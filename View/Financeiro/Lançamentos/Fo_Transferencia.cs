using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Transferencia : Form
    {
        public int _tipo_lancamento;
        public int _usuariologado;
        public bool _editar = false;
        public int _id_lancamento;
        private readonly C6ContaController _c6ContaController;
        private readonly C2LancamentoController _c2lancamentocontroller;
        public Fo_Transferencia(int tipo_lancamento, int usuariologado, C6ContaController c6contacontroller, C2LancamentoController c2lancamentocontroller, bool editar, int id_lancamento)
        {
            _c2lancamentocontroller = c2lancamentocontroller;
            _tipo_lancamento = tipo_lancamento;
            _c6ContaController = c6contacontroller;
            _usuariologado = usuariologado;
            _editar = editar;
            _id_lancamento = id_lancamento;
            InitializeComponent();
        }
        private async void PreencheCamposEditaTransferencia(int id)
        {
            C2LancamentoDTO? _c2lancamentodto = await _c2lancamentocontroller.ObterC2Lancamento(id);
            txt_titulo.Text = _c2lancamentodto.C2LancamentoNome;
            Rtxt_observacao.Text = _c2lancamentodto.C2Observacao;
            txt_valor.Text = _c2lancamentodto.C2LancamentoValor.ToString();
            dtp_prev_pag.Text = _c2lancamentodto.C2Data_Prev_Pag.ToString();
            dtp_pag.Text = _c2lancamentodto.C2Data_Pag.ToString();
            cbx_conta_origem.SelectedValue = _c2lancamentodto.C2FKC6Id_Conta;
            cbx_destino.SelectedValue = _c2lancamentodto.C2FKC6ID_Conta_Transferencia;
            _tipo_lancamento = _c2lancamentodto.C2Tipo_Lancamento;
        }
        private async void Fo_Transferencia_Load(object sender, EventArgs e)
        {
            cbx_conta_origem.DataSource = await _c6ContaController.PreencheComboBoxC6Conta(_usuariologado);
            cbx_destino.DataSource = await _c6ContaController.PreencheComboBoxC6Conta(_usuariologado);
            if (_editar == true)
            {
                PreencheCamposEditaTransferencia(_id_lancamento);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private async void btn_confirma_Click(object sender, EventArgs e)
        {
            int _id_origem = (int)cbx_conta_origem.SelectedValue;
            int _id_destino = (int)cbx_destino.SelectedValue;
            string _titulo_transferencia = txt_titulo.Text;
            decimal _valor = Convert.ToDecimal(txt_valor.Text);
            string _observacao = Rtxt_observacao.Text;
            DateTime _data_previa_pag = dtp_prev_pag.Value.Kind == DateTimeKind.Utc ? dtp_prev_pag.Value : dtp_prev_pag.Value.ToUniversalTime();
            if (_id_origem == _id_destino)
            {
                MessageBox.Show("Contas de Origem e Destino não podem ser iguais!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbx_conta_origem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma conta de origem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_destino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma conta de destino!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_editar == false)
            {
                var transferencia = new C2Lancamento
                {
                    C2Titulo_Lancamento = _titulo_transferencia,
                    C2FKC4ID_Moeda = 1,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                    C2Data_Previa_Pagamento = _data_previa_pag.AddHours(-3),
                    C2Data_Pagamento = null,
                    C2Observacao = _observacao,
                    C2Valor = _valor,
                    C2FKC3ID_Status = 1,
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                    C2FKC6ID_Conta = _id_origem,
                    C2FKC6ID_Conta_Transferencia = _id_destino
                };
                await _c2lancamentocontroller.AdicionarC2Lancamento(transferencia);
                this.Hide();
                MessageBox.Show("Transferência criada com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var atualizatransferencia = new C2Lancamento
                {
                    C2ID = _id_lancamento,
                    C2Titulo_Lancamento = _titulo_transferencia,
                    C2FKC4ID_Moeda = 1,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                    C2Data_Previa_Pagamento = _data_previa_pag.AddHours(-3),
                    C2Data_Pagamento = null,
                    C2Observacao = _observacao,
                    C2Valor = _valor,
                    C2FKC3ID_Status = 1, //Pendente pagamento
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                    C2FKC6ID_Conta = _id_origem,
                    C2FKC6ID_Conta_Transferencia = _id_destino
                };
                await _c2lancamentocontroller.AtualizarC2Lancamento(atualizatransferencia);
                this.Hide();
                MessageBox.Show("Transferência atualizada com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async void btn_pago_Click(object sender, EventArgs e)
        {
            int _id_origem = (int)cbx_conta_origem.SelectedValue;
            int _id_destino = (int)cbx_destino.SelectedValue;
            if (_id_origem == _id_destino)
            {
                MessageBox.Show("Contas de Origem e Destino não podem ser iguais", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbx_conta_origem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma conta de origem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_destino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma conta de destino!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string _titulo_transferencia = txt_titulo.Text;
            decimal _valor = Convert.ToDecimal(txt_valor.Text);
            string _observacao = Rtxt_observacao.Text;
            DateTime _data_previa_pag = dtp_prev_pag.Value.Kind == DateTimeKind.Utc ? dtp_prev_pag.Value : dtp_prev_pag.Value.ToUniversalTime();
            DateTime _dtp_pagamento = dtp_pag.Value.Kind == DateTimeKind.Utc ? dtp_pag.Value : dtp_pag.Value.ToUniversalTime();
            if (_editar == false)
            {
                var transferencia = new C2Lancamento
                {
                    C2Titulo_Lancamento = _titulo_transferencia,
                    C2FKC4ID_Moeda = 1,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                    C2Data_Previa_Pagamento = _data_previa_pag.AddHours(-3),
                    C2Data_Pagamento = _dtp_pagamento.AddHours(-3),
                    C2Observacao = _observacao,
                    C2Valor = _valor,
                    C2FKC3ID_Status = 2,
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                    C2FKC6ID_Conta = _id_origem,
                    C2FKC6ID_Conta_Transferencia = _id_destino
                };
                await _c2lancamentocontroller.AdicionarC2Lancamento(transferencia);
                this.Hide();
                MessageBox.Show("Transferência paga com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var atualizatransferencia = new C2Lancamento
                {
                    C2ID = _id_lancamento,
                    C2Titulo_Lancamento = _titulo_transferencia,
                    C2FKC4ID_Moeda = 1,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                    C2Data_Previa_Pagamento = _data_previa_pag.AddHours(-3),
                    C2Data_Pagamento = _dtp_pagamento.AddHours(-3),
                    C2Observacao = _observacao,
                    C2Valor = _valor,
                    C2FKC3ID_Status = 2, //PAGO
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                    C2FKC6ID_Conta = _id_origem,
                    C2FKC6ID_Conta_Transferencia = _id_destino
                };
                await _c2lancamentocontroller.AtualizarC2Lancamento(atualizatransferencia);
                this.Hide();
                MessageBox.Show("Transferência atualizada com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
