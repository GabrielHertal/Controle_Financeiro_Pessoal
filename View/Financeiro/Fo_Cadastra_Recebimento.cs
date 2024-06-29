using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Cadastra_Recebimento : Form
    {
        private readonly C7RecebimentoController _c7RecebimentoController;
        private bool _cadastrarecebimento;
        public Fo_Cadastra_Recebimento(C7RecebimentoController c7RecebimentoController, bool cadastraRecebimento)
        {
            this._c7RecebimentoController = c7RecebimentoController;
            this._cadastrarecebimento = cadastraRecebimento;
            InitializeComponent();
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}