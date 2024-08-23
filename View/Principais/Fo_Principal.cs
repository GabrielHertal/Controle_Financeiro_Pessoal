using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.View;
using Controle_Financeiro_Pessoal.View.Financeiro;
using Controle_Financeiro_Pessoal.View.Lancamentos;

namespace Controle_Financeiro_Pessoal
{
    public partial class Fo_Principal : Form
    {
        private readonly C1UsuarioController _c1usuariocontroller;
        public Fo_Principal(C1UsuarioController c1UsuarioController)
        {
            _c1usuariocontroller = c1UsuarioController;
            InitializeComponent();
        }
        #region Função que faz um formulário abrir dentro de outro
        public Form currentForm;
        public void OpenChildForm(Form oldForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = oldForm;
            oldForm.TopLevel = false;
            oldForm.FormBorderStyle = FormBorderStyle.None;
            oldForm.Dock = DockStyle.Fill;
            panel_principal.Controls.Add(currentForm);
            panel_principal.Tag = currentForm;
            currentForm.BringToFront();
            currentForm.Show();
        }
        #endregion
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            C1UsuarioController c1usuariocontroller = new C1UsuarioController();
            OpenChildForm(new Fo_Usuarios(c1usuariocontroller));
        }
        private void btn_contas_Click(object sender, EventArgs e)
        {
            C6ContaController c6ContaController = new C6ContaController();
            OpenChildForm(new Fo_Contas(c6ContaController, _c1usuariocontroller.usuariologado));
        }
        private void btn_lancamentos_Click(object sender, EventArgs e)
        {
            C2LancamentoController c2lancamentocontroller = new C2LancamentoController();
            C6ContaController c6Contacontroller = new C6ContaController();
            C7CategoriaController c7categoriacontroller = new C7CategoriaController();
            OpenChildForm(new Fo_Lancamentos(_c1usuariocontroller.usuariologado, c2lancamentocontroller, c6Contacontroller, c7categoriacontroller));
        }
        private void Fo_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}