using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Data;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class Fo_Login : Form
    {
        public Fo_Login()
        {
            InitializeComponent();
        }
        C1UsuarioController c1usuariocontroller = new C1UsuarioController();
        private void linklbl_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fo_Cadastro = new Fo_Cadastra_User(c1usuariocontroller);
            this.Hide();
            fo_Cadastro.Show();
        }
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_senha.Text))
            {
                MessageBox.Show("Existem campos vazios verifique!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string _email = txt_email.Text;
            string _senha = txt_senha.Text;
            if (c1usuariocontroller.VerificarExistenciaCadastro(_email, _senha) <= 0)
            {
                MessageBox.Show("Usuario inexistente ou inativado, verifique!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Clear();
                txt_senha.Clear();
                return;
            }
            else
            {
                var fo_Principal = new Fo_Principal();
                this.Hide();
                fo_Principal.Show();
            }
        }
        private void Fo_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
