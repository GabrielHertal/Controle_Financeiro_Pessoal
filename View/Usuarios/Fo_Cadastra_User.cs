using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Function;
using Controle_Financeiro_Pessoal.Model;

namespace Controle_Financeiro_Pessoal.View
{
    public partial class Fo_Cadastra_User : Form
    {
        private readonly C1UsuarioController _c1usuariocontroller;
        Fo_Login _fo_login = new(new C1UsuarioController());
        private int _id;
        private bool _editar = false;
        DateTime _dataatual = DateTime.UtcNow;
        FormatarValor _formatarvalor = new FormatarValor();
        public Fo_Cadastra_User(C1UsuarioController _c1usuariocontroller, int _id = 0, bool _editar = false)
        {
            this._c1usuariocontroller = _c1usuariocontroller;
            this._editar = _editar;
            this._id = _id;
            InitializeComponent();
            if (_editar == true)
            {
                btn_Cadastrar.Text = "Atualizar";
                PreencheCamposEditaUser(_id);
            }
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
        private async void btn_Cadastrar_Click(object sender, EventArgs e)
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
            float _renda_mensal = float.Parse(txt_renda.Text.Replace("R$ ", ""));
            int _existe_email = await _c1usuariocontroller.VerificarExistenciaEmailC1Usuario(_email);
            int _existe_cpf = await _c1usuariocontroller.VerificarExistenciaCPFC1Usuario(_cpf);

            if (_existe_email > 0)
            {
                MessageBox.Show("Email ja existente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Text = null;
                return;
            }
            if (!string.IsNullOrEmpty(_cpf))
            {
                if (_existe_cpf > 0)
                {
                    MessageBox.Show("Cpf já existente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mastxt_cpf.Text = null;
                    return;
                }
            }
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
                _fo_login.Show();
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
        }
        #region Tratamento do campo Renda Mensal
        private void txt_renda_KeyPress(object sender, KeyPressEventArgs e)
        {
            _formatarvalor.TratarKeyPress(sender, e);
        }

        private void txt_renda_Leave(object sender, EventArgs e)
        {
            _formatarvalor.TratarLeave(sender, e);
        }

        private void txt_renda_KeyUp(object sender, KeyEventArgs e)
        {
            _formatarvalor.TratarKeyUp(sender, e);
        }
        #endregion
    }
}