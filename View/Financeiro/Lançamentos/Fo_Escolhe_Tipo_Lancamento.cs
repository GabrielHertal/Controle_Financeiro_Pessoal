using Controle_Financeiro_Pessoal.Controller;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Escolhe_Tipo_Lancamento : Form
    {
        public int _tipo_lancamento = 0;
        public int _usuariologado;
        private readonly C2LancamentoController _c2LancamentoController;
        private readonly C6ContaController _c6ContaController;
        private readonly C7CategoriaController _c7categoriaconotroller;
        public Fo_Escolhe_Tipo_Lancamento(int usuariologado, C2LancamentoController c2lancamentocontroller, C6ContaController c6contacontroller, C7CategoriaController c7CategoriaController)
        {
            InitializeComponent();
            _c2LancamentoController = c2lancamentocontroller;
            _c6ContaController = c6contacontroller;
            _usuariologado = usuariologado;
            _c7categoriaconotroller = c7CategoriaController;
            rdb_pagar.Checked = false;
            rdb_Receber.Checked = false;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rdb_pagar_CheckedChanged(object sender, EventArgs e)
        {
            //À PAGAR
            _tipo_lancamento = 1;
            Fo_Realiza_Lancamento fo_Realiza_Lancamento = new Fo_Realiza_Lancamento(_usuariologado, _tipo_lancamento, _c2LancamentoController, _c6ContaController, false, 0
                , _c7categoriaconotroller);
            DialogResult result = fo_Realiza_Lancamento.ShowDialog();
            this.Hide();
        }
        private void rdb_Receber_CheckedChanged(object sender, EventArgs e)
        {
            //À RECEBER
            _tipo_lancamento = 2;
            Fo_Realiza_Lancamento fo_Realiza_Lancamento = new Fo_Realiza_Lancamento(_usuariologado, _tipo_lancamento, _c2LancamentoController, _c6ContaController, false, 0
                , _c7categoriaconotroller);
            fo_Realiza_Lancamento.Text = "Lançamento - À Receber";
            DialogResult result = fo_Realiza_Lancamento.ShowDialog();
            this.Hide();
        }
        private void rdb_transferencia_CheckedChanged(object sender, EventArgs e)
        {
            //TRANSFERENCIA
            _tipo_lancamento = 3;
            Fo_Transferencia fo_fransferencia = new Fo_Transferencia(_tipo_lancamento, _usuariologado, _c6ContaController, _c2LancamentoController, false, 0);
            DialogResult result = fo_fransferencia.ShowDialog();
            this.Hide();
        }
    }
}
