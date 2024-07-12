using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.Model;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.VisualBasic;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Cadastra_Conta : Form
    {
        private readonly C6ContaController _c6ContaController;
        public readonly int _usuariologado;
        public int _id;
        public bool _editar = false;
        public Fo_Cadastra_Conta(C6ContaController c6ContaController, int usuariologado, int id, bool editar)
        {
            _usuariologado = usuariologado;
            _c6ContaController = c6ContaController;
            _id = id;
            _editar = editar;
            InitializeComponent();
            if(_editar == true)
            {
                btn_confirmar.Text = "Atualizar";
                PreencheCamposC6Conta(_id);
            }
        }
        private async void btn_confirmar_Click(object sender, EventArgs e)
        {
            string _nome_conta = txt_conta.Text;
            int _tipo_conta = cbx_tipo_conta.SelectedIndex;
            var conta = new C6Conta
            {
                C6Nome = _nome_conta,
                C6Tipo_Conta = _tipo_conta,
                C6Ativo = true,
                C6FKC1ID_User = _usuariologado,
                C6Data_Criacao = DateTime.UtcNow
            };
            if (_editar == false)
            {
                await _c6ContaController.AdicionarC6Conta(conta);
                MessageBox.Show("Conta criada com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                _c6ContaController.AtualizarC6Conta(_id, conta);
                MessageBox.Show("Conta editada com sucesso", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
        private async void PreencheCamposC6Conta(int id)
        {
            C6Conta? c6conta = await _c6ContaController.ObtemC6Recebimento(id);
            txt_conta.Text = c6conta.C6Nome;
            cbx_tipo_conta.SelectedIndex = c6conta.C6Tipo_Conta;
            c6conta.C6FKC1ID_User = c6conta.C6FKC1ID_User;
            c6conta.C6Data_Criacao = c6conta.C6Data_Criacao;
        }
    }
}
