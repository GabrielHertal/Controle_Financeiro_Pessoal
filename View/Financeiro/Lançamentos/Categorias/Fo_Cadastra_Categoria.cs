using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Model;

namespace Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos.Categorias
{
    public partial class Fo_Cadastra_Categoria : Form
    {
        public int _usuariologado;
        private readonly C7CategoriaController _c7CategoriaController;
        public Fo_Cadastra_Categoria(int usuariologado, C7CategoriaController c7CategoriaController)
        {
            _usuariologado = usuariologado;
            _c7CategoriaController = c7CategoriaController;
            InitializeComponent();
        }
        private async void btn_salvar_Click(object sender, EventArgs e)
        {
            string _nome_categoria = txt_nomecategoria.Text;
            int _tipo_categoria = (int)cbx_tipocategoria.SelectedIndex + 1;
            var novacategoria = new C7Categoria
            {
                C7Nome = _nome_categoria,
                C7Tipo_Categoria = _tipo_categoria,
                C7FKC1ID_Usuario = _usuariologado
            };
            await _c7CategoriaController.AdicionarC7Categoria(novacategoria);
            MessageBox.Show("Categoria cadastrada com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
