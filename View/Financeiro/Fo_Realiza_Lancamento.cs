using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Realiza_Lancamento : Form
    {
        public int _usuariologado;
        public int _tipo_lancamento;
        private readonly C2LancamentoController _c2LancamentoController;
        private readonly C6ContaController _c6ContaController;
        public Fo_Realiza_Lancamento(int usuariologado, int tipo_lancamento, C2LancamentoController c2lancamentocontroller, C6ContaController c6contacontroller)
        {
            _c2LancamentoController = c2lancamentocontroller;
            _c6ContaController = c6contacontroller;
            _tipo_lancamento = tipo_lancamento;
            _usuariologado = usuariologado;
            InitializeComponent();
        }
        private async void Fo_Realiza_Lancamento_Load(object sender, EventArgs e)
        {
            cbx_conta.DataSource = await _c6ContaController.PreencheComboBoxC6Conta(_usuariologado);
            cbx_moeda.DataSource = await _c6ContaController.ListarC4Moeda();
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
            DateTime _dtp_prev_pag = dtp_prev_pagamento.Value;
            int _id_conta = (int)cbx_conta.SelectedValue;
            int _id_moeda = (int)cbx_moeda.SelectedValue;
            int _qtd_parcelas = cbx_parcelas.SelectedIndex;
            DateTime _data_lancamento = DateTime.Now;

            if ((int)cbx_moeda.SelectedValue == 2) //se for parcelado
            {
                decimal _valor_parcela = _valor_lancamento / _qtd_parcelas;
                foreach (int i in Enumerable.Range(1, _qtd_parcelas))
                {
                    _dtp_prev_pag = _dtp_prev_pag.AddMonths(1);
                    var lancamentoparcelado = new C2Lancamento
                    {
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = DateTime.FromFileTimeUtc(_data_lancamento.Ticks),
                        C2Data_Previa_Pagamento = DateTime.FromFileTimeUtc(_dtp_prev_pag.Ticks),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento + $"Parcela ({i}/{_qtd_parcelas})",
                        C2FKC3ID_Status = 1, //Pendente Pagamento
                        C2Valor = _valor_parcela,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento
                    };
                    await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelado);
                    this.Hide();
                }
            }
            else //se for dinheiro ou outra que não seja parcelado
            {
                var lancamento = new C2Lancamento
                {
                    C2FKC6ID_Conta = _id_conta,
                    C2FKC4ID_Moeda = _id_moeda,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.FromFileTimeUtc(_data_lancamento.Ticks),
                    C2Data_Previa_Pagamento = DateTime.FromFileTimeUtc(_dtp_prev_pag.Ticks),
                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                    C2Observacao = _observacao_lancamento,
                    C2Titulo_Lancamento = _titulo_lancamento,
                    C2FKC3ID_Status = 1, //Pendente Pagamento
                    C2Valor = _valor_lancamento,
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento
                };
                await _c2LancamentoController.AdicionarC2Lancamento(lancamento);
                this.Hide();
                DialogResult = DialogResult.OK;
            }
        }
        private void cbx_moeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbx_moeda.SelectedValue == 2)
            {
                label8.Visible = true;
                cbx_parcelas.Visible = true;
                btn_pago.Enabled = false;
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
            DateTime _dtp_prev_pag = dtp_prev_pagamento.Value;
            DateTime _dtp_pagamento = dtp_pagamento.Value;
            int _id_conta = (int)cbx_conta.SelectedValue;
            int _id_moeda = (int)cbx_moeda.SelectedValue;

            var lancamento = new C2Lancamento
            {
                C2FKC6ID_Conta = _id_conta,
                C2FKC4ID_Moeda = _id_moeda,
                C2FKC1ID_User = _usuariologado,
                C2Data_Lancamento = DateTime.UtcNow,
                C2Data_Previa_Pagamento = DateTime.FromFileTimeUtc(_dtp_prev_pag.Ticks),
                C2Data_Pagamento = DateTime.FromFileTimeUtc(_dtp_pagamento.Ticks),
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
        private void AtualizaValoresParcelas()
        {
            if (decimal.TryParse(txt_valor.Text, out decimal _valor_lancamento))
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
    }
}