using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Data;
using Controle_Financeiro_Pessoal.View;
using Controle_Financeiro_Pessoal.View.Recebimento;
using System.DirectoryServices.ActiveDirectory;

namespace Controle_Financeiro_Pessoal
{
    public partial class Fo_Principal : Form
    {
        public Fo_Principal()
        {
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
        private readonly ApplicationDbContext context;
        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            C1UsuarioController c1usuariocontroller = new C1UsuarioController();
            OpenChildForm(new Fo_Usuarios(c1usuariocontroller));
        }
        private void Fo_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_recebimentos_Click(object sender, EventArgs e)
        {
            C7RecebimentoController c7recebimentocontroller = new C7RecebimentoController();
            OpenChildForm(new Fo_Recebimento(c7recebimentocontroller));
        }
    }
}