using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class Fo_Usuarios : Form
    {
        private readonly C1UsuarioController _c1usuariocontroller;
        public bool _editar;
        public Fo_Usuarios(C1UsuarioController c1usuariocontroller)
        {
            _c1usuariocontroller = c1usuariocontroller;
            InitializeComponent();
        }
        private async void Fo_Usuarios_Load(object sender, EventArgs e)
        {
            grid_usuarios.DataSource = await _c1usuariocontroller.ListarC1Usuario();
        }
        private async void grid_usuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid_usuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _editar = true;
            int _linha = grid_usuarios.SelectedCells[0].RowIndex;
            int _id = (int)grid_usuarios.Rows[_linha].Cells[0].Value;
            var fo_Cadastra_User = new Fo_Cadastra_User(_c1usuariocontroller, _id, _editar);
            this.Hide();
            DialogResult result = fo_Cadastra_User.ShowDialog();
            if (result == DialogResult.OK)
            {
                _editar = false;
                this.Show();
                grid_usuarios.DataSource = await _c1usuariocontroller.ListarC1Usuario();
            }
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int _linha = grid_usuarios.SelectedCells[0].RowIndex;
            int _id = (int)grid_usuarios.Rows[_linha].Cells[0].Value;
            _c1usuariocontroller.DeletarC1Usuario(_id);
            MessageBox.Show("Usuário inativado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            grid_usuarios.DataSource = _c1usuariocontroller.ListarC1Usuario();
        }
    }
}