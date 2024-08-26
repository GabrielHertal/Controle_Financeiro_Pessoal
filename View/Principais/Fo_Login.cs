using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class Fo_Login : Form
    {
        private readonly C1UsuarioController _c1usuariocontroller;
        public Fo_Login(C1UsuarioController c1UsuarioController)
        {
            _c1usuariocontroller = c1UsuarioController;
            InitializeComponent();
        }
        private void linklbl_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fo_Cadastro = new Fo_Cadastra_User(_c1usuariocontroller);
            this.Hide();
            fo_Cadastro.Show();
        }
        private async void btn_entrar_Click(object sender, EventArgs e)
        {
            btn_entrar.Enabled = false;
            if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_senha.Text))
            {
                MessageBox.Show("Existem campos vazios verifique!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_entrar.Enabled = true;
                return;
            }
            string _email = txt_email.Text;
            string _senha = txt_senha.Text;
            if (await _c1usuariocontroller.VerificarExistenciaCadastro(_email, _senha) <= 0)
            {
                MessageBox.Show("Usuario inexistente ou inativado, verifique!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Clear();
                txt_senha.Clear();
                btn_entrar.Enabled = true;
                return;
            }
            else 
            {
                await _c1usuariocontroller.SalvarUsuarioConectado(_email, _senha);
                var fo_Principal = new Fo_Principal(_c1usuariocontroller);
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
