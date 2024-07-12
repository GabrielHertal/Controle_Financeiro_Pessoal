using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.View.Financeiro;

namespace Controle_Financeiro_Pessoal.View.Lancamentos
{
    public partial class Fo_Lancamentos : Form
    {
        private int _usuariologado;
        public bool _editar = false;
        private readonly C2LancamentoController _c2LancamentoController;
        private readonly C6ContaController _c6ContaController;
        public Fo_Lancamentos(int usuariologado, C2LancamentoController c2lancamentocontroller, C6ContaController c6contacontroller)
        {
            _c2LancamentoController = c2lancamentocontroller;
            _c6ContaController = c6contacontroller;
            _usuariologado = usuariologado;
            InitializeComponent();
        }
        private async void Fo_Lancamentos_Load(object sender, EventArgs e)
        {
            grid_lancamentos.DataSource = await _c2LancamentoController.ListaC2Lancamento(_usuariologado);
        }
        private void btm_novo_lancamento_Click(object sender, EventArgs e)
        {
            Fo_Escolhe_Tipo_Lancamento fo_Escolhe_Tipo_Lancamento = new Fo_Escolhe_Tipo_Lancamento(_usuariologado, _c2LancamentoController, _c6ContaController);
            DialogResult result = fo_Escolhe_Tipo_Lancamento.ShowDialog();
            if (result == DialogResult.OK)
            {
                grid_lancamentos.DataSource = _c2LancamentoController.ListaC2Lancamento(_usuariologado);
            }
        }
        private void grid_lancamentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid_lancamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _editar = true;
            int _linha = grid_lancamentos.SelectedCells[0].RowIndex;
            int _id = (int)grid_lancamentos.Rows[_linha].Cells[0].Value;
            var fo_Cadastra_User = new Fo_Cadastra_User(_c1usuariocontroller, _id, _editar);
            DialogResult result = fo_Cadastra_User.ShowDialog();
            if (result == DialogResult.OK)
            {
                _editar = false;
                this.Show();
                grid_usuarios.DataSource = await _c1usuariocontroller.ListarC1Usuario();
            }
        }
    }
}
