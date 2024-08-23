using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.View.Financeiro;
using Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos;
using System.Collections.Immutable;
using System.Runtime.InteropServices;

namespace Controle_Financeiro_Pessoal.View.Lancamentos
{
    public partial class Fo_Lancamentos : Form
    {
        private int _usuariologado;
        public bool _editar = false;
        private readonly C2LancamentoController _c2LancamentoController;
        private readonly C6ContaController _c6ContaController;
        private readonly C7CategoriaController _c7CategoriaController;
        public Fo_Lancamentos(int usuariologado, C2LancamentoController c2lancamentocontroller, C6ContaController c6contacontroller, C7CategoriaController c7CategoriaController)
        {
            _c2LancamentoController = c2lancamentocontroller;
            _c6ContaController = c6contacontroller;
            _usuariologado = usuariologado;
            _c7CategoriaController = c7CategoriaController;
            InitializeComponent();
        }
        private async Task LoadGridLancamentos()
        {
            grid_lancamentos.DataSource = await _c2LancamentoController.ListarC2Lancamento(_usuariologado);
            foreach (DataGridViewRow cell in grid_lancamentos.Rows)
            {
                #region Colorir Celulas GRID
                #region Colorir campo STATUS
                if (Convert.ToString(cell.Cells[6].Value) == "Pago")
                {
                    cell.Cells[6].Style.BackColor = Color.LightGreen;
                    cell.Cells[6].Style.Font = new Font(cell.Cells[6].InheritedStyle.Font, FontStyle.Bold);
                }
                else
                {
                    cell.Cells[6].Style.BackColor = Color.IndianRed;
                    cell.Cells[6].Style.Font = new Font(cell.Cells[6].InheritedStyle.Font, FontStyle.Bold);
                }
                #endregion
                #region Colorir campo TIPO
                if (Convert.ToString(cell.Cells[8].Value) == "À Receber")
                {
                    cell.Cells[8].Style.BackColor = Color.LightGreen;
                    cell.Cells[8].Style.Font = new Font(cell.Cells[8].InheritedStyle.Font, FontStyle.Bold);
                }
                else
                {
                    cell.Cells[8].Style.BackColor = Color.IndianRed;
                    cell.Cells[8].Style.Font = new Font(cell.Cells[8].InheritedStyle.Font, FontStyle.Bold);
                }
                #endregion
                #endregion
            }
        }
        private async void Fo_Lancamentos_Load(object sender, EventArgs e)
        {
            await LoadGridLancamentos();
        }
        private async void btm_novo_lancamento_Click(object sender, EventArgs e)
        {
            Fo_Escolhe_Tipo_Lancamento fo_Escolhe_Tipo_Lancamento = new Fo_Escolhe_Tipo_Lancamento(_usuariologado, _c2LancamentoController, _c6ContaController, _c7CategoriaController);
            DialogResult result = fo_Escolhe_Tipo_Lancamento.ShowDialog();
            if (result == DialogResult.OK)
            {
                await LoadGridLancamentos();
            }
        }
        private async void grid_lancamentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid_lancamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Lançamento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _editar = true;
            int _linha = grid_lancamentos.SelectedCells[0].RowIndex;
            int _id_lancamento = (int)grid_lancamentos.Rows[_linha].Cells[0].Value;
            int _tipo_lancamento = (int)grid_lancamentos.Rows[_linha].Cells[10].Value;
            if (_tipo_lancamento == 3) //CASO SEJA UMA TRANSFERENCIA
            {
                var _fo_visualiza_transf = new Fo_Visualiza_Transferencia(_c6ContaController, _usuariologado, _id_lancamento, _editar, _tipo_lancamento, _c2LancamentoController);
                DialogResult result = _fo_visualiza_transf.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _editar = false;
                    this.Show();
                    await LoadGridLancamentos();
                }
            }
            else //CASO SEJA UM LANCAMENTO NORMAL
            {
                var _fo_confirm_pag = new Fo_Visualiza_Lancamento(_editar, _c2LancamentoController, _id_lancamento, _usuariologado, _c6ContaController, _c7CategoriaController);
                DialogResult result = _fo_confirm_pag.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _editar = false;
                    this.Show();
                    await LoadGridLancamentos();
                }
            }
        }
        private async void btn_excluir_Click(object sender, EventArgs e)
        {
            int _linha = grid_lancamentos.SelectedCells[0].RowIndex;
            int _id_lancamento = (int)grid_lancamentos.Rows[_linha].Cells[0].Value;
            int _id_moeda_lancamento = (int)grid_lancamentos.Rows[_linha].Cells[11].Value;
            int _id_status_lancamento = (int)grid_lancamentos.Rows[_linha].Cells[12].Value;
            int _id_tipo_lancamento = (int)grid_lancamentos.Rows[_linha].Cells[10].Value;
            int? _id_lancamento_pai = (int?)grid_lancamentos.Rows[_linha].Cells[13].Value;

            if ((_id_tipo_lancamento == 3 || _id_tipo_lancamento == 2) && _id_status_lancamento == 2)
            {
                MessageBox.Show("Para poder excluir esta parcela, é preciso realizar o estorno!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (_id_moeda_lancamento == 5 && _id_status_lancamento == 1 && _id_lancamento_pai != null) //se for uma parcela e estiver pendente de pagameto
            {
                MessageBox.Show("Se deseja excluir uma parcela para reajustar as parcelas, é preciso edita-lo clicando 2x sobre o lançamento Pai", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (_id_moeda_lancamento == 5 && _id_status_lancamento == 2) //se for uma parcela e estiver pago
            {
                MessageBox.Show("Para poder excluir esta parcela, é preciso realizar o estorno!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (_id_moeda_lancamento == 2 || _id_moeda_lancamento == 6) //se for um lancamento PAI parcelado
            {
                int _qtd_lancamentos_pagos = await _c2LancamentoController.VerificaC2LancamentosPagos(_id_lancamento);
                if (_qtd_lancamentos_pagos > 0) //se existir uma parcela paga
                {
                    MessageBox.Show("Existem parcelas já pagas, para poder excluir é necessário realizar o estorno!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult result = MessageBox.Show("Deseja realmente excluir este lançamento?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await _c2LancamentoController.DeletarC2LancamentosFilhos(_id_lancamento);
                    await _c2LancamentoController.DeletarC2Lancamento(_id_lancamento);
                    MessageBox.Show("Lancamento excluido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadGridLancamentos();
                }
                else
                {
                    return;
                }
            }
            else if (_id_status_lancamento == 2)//Apenas exclui o lançamento selecionado
            {
                MessageBox.Show("Para excluir este lançamento, é preciso realizar o estorno!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                await _c2LancamentoController.DeletarC2Lancamento(_id_lancamento);
                MessageBox.Show("Lancamento excluido com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadGridLancamentos();
            }
        }
        private void btn_filtros_Click(object sender, EventArgs e)
        {
            // FAZER METODO DE FILTROS DA GRID DE LANCAMENTOS AQUI//
        }
    }
}
