using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Model;
using System.Drawing.Text;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class Fo_Cadastra_User : Form
    {
        private readonly C1UsuarioController _c1usuariocontroller;
        Fo_Login _fo_login = new Fo_Login();
        private int _id;
        private bool _editar;
        private bool _cadastrarnovo;
        public Fo_Cadastra_User(C1UsuarioController _c1usuariocontroller, int _id = 0, bool _editar = false, bool _cadastranovo = false)
        {
            this._c1usuariocontroller = _c1usuariocontroller;
            this._editar = _editar;
            this._id = _id;
            this._cadastrarnovo = _cadastranovo;
            InitializeComponent();
            if (_editar == true)
            {
                btn_Cadastrar.Text = "Atualizar";
                PreencheCamposEditaUser(_id);
            }
        }
        DateTime _dataatual = DateTime.UtcNow;
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            string? _cpf = mastxt_cpf.Text;
            if (mastxt_cpf.Text.Length != 14)
            {
                _cpf = null;
            }
            string _nome = txt_nome.Text;
            string _email = txt_email.Text;
            string _senha = txt_senha.Text;
            string _confirm_senha = txt_confirm_senha.Text;
            float _renda_mensal = float.Parse(txt_renda.Text);
            if (txt_senha.Text != txt_confirm_senha.Text)
            {
                MessageBox.Show("Senhas informadas não coincidem!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_senha.Text)
                || string.IsNullOrEmpty(txt_confirm_senha.Text) || string.IsNullOrEmpty(txt_renda.Text))
            {
                MessageBox.Show("Existem campos vazios, verifique!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var usuario = new C1Usuario()
            {
                C1Nome = _nome,
                C1Email = _email,
                C1Senha = _senha,
                C1Cpf = _cpf,
                C1Renda_Mensal = _renda_mensal,
                C1Data_Criacao = _dataatual,
                C1Ativo = true
            };
            if (_editar == false)
            {
                _c1usuariocontroller.AdicionarUsuário(usuario);
                MessageBox.Show("Usuário criado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Hide();
                if (_cadastrarnovo == false)
                {
                    var fo_login = new Fo_Login();
                    fo_login.Show();
                }
            }
            else
            {
                _c1usuariocontroller.AtualizarC1Usuario(_id, usuario);
                MessageBox.Show("Usuário editado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
        private void Fo_Cadastra_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_editar == false)
            {
                _fo_login.Show();
            }
            else
            {
                this.Hide();
            }
;
        }
        private async void PreencheCamposEditaUser(int id)
        {
            C1Usuario _c1usuario = await _c1usuariocontroller.ObtemC1Usuario(id);
            txt_nome.Text = _c1usuario.C1Nome;
            txt_email.Text = _c1usuario.C1Email;
            txt_senha.Text = _c1usuario.C1Senha;
            txt_confirm_senha.Text = _c1usuario.C1Senha;
            txt_renda.Text = _c1usuario.C1Renda_Mensal.ToString();
            mastxt_cpf.Text = _c1usuario.C1Cpf;
            _dataatual = _c1usuario.C1Data_Criacao;
        }
    }
}