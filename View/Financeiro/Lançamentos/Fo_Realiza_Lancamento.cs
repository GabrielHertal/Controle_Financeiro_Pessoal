using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;
using Controle_Financeiro_Pessoal.View.Lancamentos;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Realiza_Lancamento : Form
    {
        public int _usuariologado;
        public int _tipo_lancamento;
        private readonly C2LancamentoController _c2LancamentoController;
        private readonly C6ContaController _c6ContaController;
        public bool _editar;
        public int _id_lancamento;
        public int? _status_lancamento;
        public int? _id_lancamento_pai;
        public int _usuario_lancamento;
        public int qtd_parcelas;
        public Fo_Realiza_Lancamento(int usuariologado, int tipo_lancamento, C2LancamentoController c2lancamentocontroller, C6ContaController c6contacontroller, bool editar, int id)
        {
            _c2LancamentoController = c2lancamentocontroller;
            _c6ContaController = c6contacontroller;
            _tipo_lancamento = tipo_lancamento;
            _usuariologado = usuariologado;
            _editar = editar;
            _id_lancamento = id;
            InitializeComponent();
        }
        private async void PreencheCamposEditaLancamento(int id_lancamento)
        {
            C2LancamentoDTO? _c2lancamentodto = await _c2LancamentoController.ObterC2Lancamento(id_lancamento);
            txt_titulo_lancamento.Text = _c2lancamentodto.C2LancamentoNome;
            Rtx_observacao.Text = _c2lancamentodto.C2Observacao;
            txt_valor.Text = _c2lancamentodto.C2LancamentoValor.ToString();
            dtp_prev_pagamento.Text = _c2lancamentodto.C2Data_Prev_Pag.ToString();
            dtp_pagamento.Text = _c2lancamentodto.C2Data_Pag.ToString();
            cbx_conta.SelectedValue = _c2lancamentodto.C2FKC6Id_Conta;
            cbx_moeda.SelectedValue = _c2lancamentodto.C2FKC4Id_Moeda;
            _tipo_lancamento = _c2lancamentodto.C2Tipo_Lancamento;
            _status_lancamento = _c2lancamentodto.C2FKC3Id_Status_Lancamento;
            _id_lancamento_pai = _c2lancamentodto.C2FKC6ID_Conta_Transferencia;
            _usuario_lancamento = _c2lancamentodto.C2FKC1Id_Usuario;
        }
        private async void Fo_Realiza_Lancamento_Load(object sender, EventArgs e)
        {
            cbx_conta.DataSource = await _c6ContaController.PreencheComboBoxC6Conta(_usuariologado);
            cbx_moeda.DataSource = await _c6ContaController.ListarC4Moeda();
            if (_editar == true)
            {
                PreencheCamposEditaLancamento(_id_lancamento);
            }
            AtualizaValoresParcelas();
            System.Threading.Thread.Sleep(300);
            qtd_parcelas = await _c2LancamentoController.QtdParcelasC2Lancamentos_Filho(_id_lancamento);
            cbx_parcelas.SelectedIndex = qtd_parcelas;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private async void btn_confirmar_Click(object sender, EventArgs e)
        {
            string _titulo_lancamento = txt_titulo_lancamento.Text;
            string _observacao_lancamento = Rtx_observacao.Text;
            decimal _valor_lancamento = decimal.Parse(txt_valor.Text);
            DateTime _dtp_prev_pag = dtp_prev_pagamento.Value.Kind == DateTimeKind.Utc ? dtp_prev_pagamento.Value : dtp_prev_pagamento.Value.ToUniversalTime();
            int _id_conta = (int)cbx_conta.SelectedValue;
            int _id_moeda = (int)cbx_moeda.SelectedValue;
            int _qtd_parcelas = cbx_parcelas.SelectedIndex;
            DateTime _data_lancamento = DateTime.UtcNow.ToUniversalTime();

            if (_editar == false)
            { //Caso seja um novo lancamento
                if ((int)cbx_moeda.SelectedValue == 2 || (int)cbx_moeda.SelectedValue == 6) //se for parcelado
                {
                    decimal _valor_parcela = _valor_lancamento / _qtd_parcelas;
                    var lancamentopai = new C2Lancamento
                    {
                        C2Data_Lancamento = _data_lancamento.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 1, //Pendente Pagamento
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado
                    };
                    await _c2LancamentoController.AdicionarC2Lancamento(lancamentopai);
                    //Criação das parcelas
                    foreach (int i in Enumerable.Range(1, _qtd_parcelas))
                    {
                        _dtp_prev_pag = _dtp_prev_pag.AddMonths(1);
                        var lancamentoparcelado = new C2Lancamento
                        {
                            C2FKC6ID_Conta = _id_conta,
                            C2FKC4ID_Moeda = 5, //Parcela
                            C2FKC1ID_User = _usuariologado,
                            C2Data_Lancamento = _data_lancamento.AddHours(-3),
                            C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                            C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                            C2Observacao = _observacao_lancamento,
                            C2Titulo_Lancamento = _titulo_lancamento + $" Parcela ({i}/{_qtd_parcelas})",
                            C2FKC3ID_Status = 1, //Pendente Pagamento
                            C2Valor = _valor_parcela,
                            C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                            C2FKC2ID_Lancamento_Pai = lancamentopai.C2ID
                        };
                        await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelado);
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else //se for dinheiro ou outra que não seja parcelado
                {
                    var lancamento = new C2Lancamento
                    {
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = _data_lancamento.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 1, //Pendente Pagamento
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento
                    };
                    await _c2LancamentoController.AdicionarC2Lancamento(lancamento);
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {//Caso seja um lançamento existente 
                if (_id_lancamento_pai == null && _id_moeda == 2 || _id_moeda == 6)
                {//Caso seja um lancamento PAi e for parcelado
                    var atualizalancamento_pai = new C2Lancamento
                    {
                        C2ID = _id_lancamento,
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = _data_lancamento.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 1, //Pendente Pagamento
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento
                    };
                    await _c2LancamentoController.AtualizarC2Lancamento(atualizalancamento_pai);
                    DialogResult result = MessageBox.Show("Deseja recalcular as Parcelas já criadas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        decimal _valor_parcela = _valor_lancamento / _qtd_parcelas;
                        if (_qtd_parcelas != qtd_parcelas)
                        {
                            var id = await _c2LancamentoController.ListarC2Lancamento_Filhos(_id_lancamento);   
                            foreach (var item in id)
                            {
                                await _c2LancamentoController.DeletarC2LancamentosFilhos(_id_lancamento);
                            }
                            foreach (int i in Enumerable.Range(1, _qtd_parcelas))
                            {
                                _dtp_prev_pag = _dtp_prev_pag.AddMonths(1);
                                var lancamentoparcelado = new C2Lancamento
                                {
                                    C2FKC6ID_Conta = _id_conta,
                                    C2FKC4ID_Moeda = 5, //Parcela
                                    C2FKC1ID_User = _usuariologado,
                                    C2Data_Lancamento = _data_lancamento.AddHours(-3),
                                    C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                    C2Observacao = _observacao_lancamento,
                                    C2Titulo_Lancamento = _titulo_lancamento + $" Parcela ({i}/{_qtd_parcelas})",
                                    C2FKC3ID_Status = 1, //Pendente Pagamento
                                    C2Valor = _valor_parcela,
                                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                                    C2FKC2ID_Lancamento_Pai = atualizalancamento_pai.C2ID
                                };
                                await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelado);
                            }
                            this.Hide();
                            MessageBox.Show("Parcelas recalculadas com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            foreach (var parcela in await _c2LancamentoController.ListarC2Lancamento_Filhos(_id_lancamento))
                            {
                                var ajusteparcela = new C2Lancamento
                                {
                                    C2ID = parcela.C2ID,
                                    C2FKC6ID_Conta = _id_conta,
                                    C2FKC4ID_Moeda = 5, //Parcela
                                    C2FKC1ID_User = _usuariologado,
                                    C2Data_Lancamento = parcela.C2Data_Lancamento,
                                    C2Data_Previa_Pagamento = parcela.C2Data_Previa_Pagamento,
                                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                    C2Observacao = _observacao_lancamento,
                                    C2Titulo_Lancamento = parcela.C2Titulo_Lancamento,
                                    C2FKC3ID_Status = 1, //Pendente Pagamento
                                    C2Valor = _valor_parcela,
                                    C2FKC5ID_Tipo_Lancamento = parcela.C2FKC5ID_Tipo_Lancamento,
                                    C2FKC2ID_Lancamento_Pai = atualizalancamento_pai.C2ID
                                };
                                await _c2LancamentoController.AtualizarC2LancamentoFilho(ajusteparcela);
                            }   
                            this.Hide();
                            MessageBox.Show("Parcelas recalculadas com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lançamento atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    //Lancamento à vista ou parcela
                    var atualizalancamento = new C2Lancamento
                    {
                        C2ID = _id_lancamento,
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = _data_lancamento.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 1, //Pendente Pagamento
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento
                    };
                    await _c2LancamentoController.AtualizarC2Lancamento(atualizalancamento);
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void cbx_moeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbx_moeda.SelectedValue is 2 or 6)
            {
                label8.Visible = true;
                cbx_parcelas.Visible = true;
                btn_pago.Enabled = false;
                label3.Text = "Data 1º Parcela";
            }
            else
            {
                label8.Visible = false;
                cbx_parcelas.Visible = false;
                btn_pago.Enabled = true;
            }
        }
        private async void btn_pago_Click(object sender, EventArgs e)
        {
            string _titulo_lancamento = txt_titulo_lancamento.Text;
            string _observacao_lancamento = Rtx_observacao.Text;
            decimal _valor_lancamento = decimal.Parse(txt_valor.Text);
            DateTime _dtp_prev_pag = dtp_prev_pagamento.Value.Kind == DateTimeKind.Utc ? dtp_prev_pagamento.Value : dtp_prev_pagamento.Value.ToUniversalTime();
            DateTime _dtp_pagamento = dtp_pagamento.Value.Kind == DateTimeKind.Utc ? dtp_pagamento.Value : dtp_pagamento.Value.ToUniversalTime();
            int _id_conta = (int)cbx_conta.SelectedValue;
            int _id_moeda = (int)cbx_moeda.SelectedValue;

            if (_editar == true)
            {
                var pagarlancamento = new C2Lancamento
                {
                    C2ID = _id_lancamento,
                    C2FKC6ID_Conta = _id_conta,
                    C2FKC4ID_Moeda = _id_moeda,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                    C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                    C2Data_Pagamento = _dtp_pagamento.AddHours(-3),
                    C2Observacao = _observacao_lancamento,
                    C2Titulo_Lancamento = _titulo_lancamento,
                    C2FKC3ID_Status = 2, //Pago
                    C2Valor = _valor_lancamento,
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento
                };
                await _c2LancamentoController.AtualizarC2Lancamento(pagarlancamento);
                this.Hide();
                DialogResult = DialogResult.OK;
            }
            else
            {
                var lancamento = new C2Lancamento
                {
                    C2FKC6ID_Conta = _id_conta,
                    C2FKC4ID_Moeda = _id_moeda,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                    C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                    C2Data_Pagamento = _dtp_pagamento.AddHours(-3),
                    C2Observacao = _observacao_lancamento,
                    C2Titulo_Lancamento = _titulo_lancamento,
                    C2FKC3ID_Status = 2, //Pago
                    C2Valor = _valor_lancamento,
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento
                };
                await _c2LancamentoController.AdicionarC2Lancamento(lancamento);
                this.Hide();
                DialogResult = DialogResult.OK;
            }
        }
        #region Validação e Atualização de Valores
        private void AtualizaValoresParcelas()
        {
            string valor = txt_valor.Text;
            if (_editar == true)
            {
                valor.Replace("R$ ", "");
            }
            if (decimal.TryParse(valor, out decimal _valor_lancamento))
            {
                cbx_parcelas.Items.Clear();
                // Adiciona o item em branco no início
                cbx_parcelas.Items.Add("Parcelas:");
                //AItera de 1 a 12 para adicionar as parcelas com os valores calculados
                for (int i = 1; i <= 12; i++)
                {
                    decimal valor_parcela = _valor_lancamento / i;
                    cbx_parcelas.Items.Add($"{i} parcela(s): {valor_parcela:C2}");
                }
                cbx_parcelas.SelectedIndex = 0;
            }
            else
            {
                cbx_parcelas.Items.Clear();
                cbx_parcelas.Items.Add("");
                cbx_parcelas.SelectedIndex = 0;
            }
        }
        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            AtualizaValoresParcelas();
        }
        #endregion
    }
}