using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Contas : Form
    {
        private readonly C6ContaController _c6ContaController;
        public readonly int _usuariologado;
        public bool _editar = false;
        public Fo_Contas(C6ContaController c6contacontroller, int usuariologado)
        {
            _usuariologado = usuariologado;
            _c6ContaController = c6contacontroller;
            InitializeComponent();
        }
        private async void Fo_Contas_Load(object sender, EventArgs e)
        {
            grid_contas.DataSource = await _c6ContaController.ListarC6Contas(_usuariologado);
        }
        private async void btn_adicionar_Click(object sender, EventArgs e)
        {
            Fo_Cadastra_Conta _fo_cadastrar_conta = new Fo_Cadastra_Conta(_c6ContaController, _usuariologado, 0, false);
            DialogResult result = _fo_cadastrar_conta.ShowDialog();
            if (result == DialogResult.OK)
            {
                grid_contas.DataSource = await _c6ContaController.ListarC6Contas(_usuariologado);
            }
        }
        private async void grid_recebimentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid_contas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma conta!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _editar = true;
            int _linha = grid_contas.SelectedCells[0].RowIndex;
            int _id = (int)grid_contas.Rows[_linha].Cells[0].Value;
            var fo_cadastrar_conta = new Fo_Cadastra_Conta(_c6ContaController, _usuariologado, _id, _editar);
            DialogResult result = fo_cadastrar_conta.ShowDialog();
            if (result == DialogResult.OK)
            {
                grid_contas.DataSource = await _c6ContaController.ListarC6Contas(_usuariologado);
            }
        }
        private async void btn_excluir_Click(object sender, EventArgs e)
        {
            if (grid_contas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um recebimento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int _linha = grid_contas.SelectedCells[0].RowIndex;
            int _id = (int)grid_contas.Rows[_linha].Cells[0].Value;
            await _c6ContaController.DeletarC6Conta(_id);
            MessageBox.Show("Conta excluida com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grid_contas.DataSource = await _c6ContaController.ListarC6Contas(_usuariologado);
        }
    }
}