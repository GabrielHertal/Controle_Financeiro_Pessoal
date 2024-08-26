using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos.Categorias;

namespace Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos
{
    public partial class Fo_Categorias : Form
    {
        public int _usuariologado;
        private readonly C7CategoriaController _c7CategoriaController;
        public Fo_Categorias(int usuariologado, C7CategoriaController c7CategoriaController)
        {
            _usuariologado = usuariologado;
            _c7CategoriaController = c7CategoriaController;
            InitializeComponent();
        }
        public async Task LoadGridCategorias()
        {
            grid_categorias.DataSource = await _c7CategoriaController.ListarC7Categorias(_usuariologado);
        }
        private async void Fo_Categorias_Load(object sender, EventArgs e)
        {
            await LoadGridCategorias();
        }
        private async void btn_adicionar_Click(object sender, EventArgs e)
        {
            Fo_Cadastra_Categoria _fo_cadastra_categoria = new Fo_Cadastra_Categoria(_usuariologado, _c7CategoriaController);
            DialogResult result = _fo_cadastra_categoria.ShowDialog();
            if (result == DialogResult.OK)
            {
                await LoadGridCategorias();
            }
        }
        private async void btn_excluir_Click(object sender, EventArgs e)
        {
            int _linha = grid_categorias.SelectedCells[0].RowIndex;
            int _id_categoria = (int)grid_categorias.Rows[_linha].Cells[0].Value;
            if (_id_categoria == 1 || _id_categoria == 2 || _id_categoria == 3)
            {
                MessageBox.Show("Esta categoria não pode ser excluida", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await _c7CategoriaController.DeletarC7Categorias(_id_categoria);
            MessageBox.Show("Categoria excluida com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadGridCategorias();
        }
        private void Fo_Categorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
