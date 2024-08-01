using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.DTO;

namespace Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos
{
    public partial class Fo_Visualiza_Transferencia : Form
    {
        private readonly C2LancamentoController _c2LancamentoController;
        private readonly C6ContaController _c6ContaController = new C6ContaController();
        public int _usuariologado;
        public int _id_lancamento;
        public bool _editar = false;
        public int _tipo_lancamento;
        public int _id_status_lancamento;
        public int _id_moeda;
        public Fo_Visualiza_Transferencia(C6ContaController c6ContaController, int usuariologado, int id_lancamento, bool editar, int tipo_lancamento, C2LancamentoController c2LancamentoController)
        {
            _c6ContaController = c6ContaController;
            _usuariologado = usuariologado;
            _id_lancamento = id_lancamento;
            _editar = editar;
            _tipo_lancamento = tipo_lancamento;
            _c2LancamentoController = c2LancamentoController;
            InitializeComponent();
        }
        private void Fo_Visualiza_Transferencia_Load(object sender, EventArgs e)
        {
            PreencheCamposEditaLancamento(_id_lancamento);
        }
        private async void PreencheCamposEditaLancamento(int id)
        {
            C2LancamentoDTO? _c2lancamentodto = await _c2LancamentoController.ObterC2Lancamento(id);
            txt_titulo.Text = _c2lancamentodto.C2LancamentoNome;
            Rtxt_observacao.Text = _c2lancamentodto.C2Observacao;
            txt_valor.Text = _c2lancamentodto.C2LancamentoValor.ToString();
            txt_data_lanc.Text = _c2lancamentodto.C2DataLancamento.ToString();
            txt_prev_pag.Text = _c2lancamentodto.C2Data_Prev_Pag.ToString();
            txt_data_pag.Text = _c2lancamentodto.C2Data_Pag.ToString();
            txt_conta_origem.Text = _c2lancamentodto.C2FKC6Nome_Conta;
            txt_conta_destino.Text = _c2lancamentodto.C2FKC6Nome_Conta_Transferencia;
            _tipo_lancamento = _c2lancamentodto.C2Tipo_Lancamento;
            _id_status_lancamento = _c2lancamentodto.C2FKC3Id_Status_Lancamento;
            _id_moeda = _c2lancamentodto.C2FKC4Id_Moeda;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private async void btn_realiza_Click(object sender, EventArgs e)
        {
            if (_id_status_lancamento == 2)
            {
                MessageBox.Show("Lançamento já pago!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            await _c2LancamentoController.RealizarC2Lancamento(_id_lancamento, _id_moeda);

            this.Hide();
            DialogResult = DialogResult.OK;
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (_id_status_lancamento == 2)
            {
                MessageBox.Show("Lançamento já pago!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _editar = true;
            this.Hide();
            Fo_Transferencia fo_transferencia = new Fo_Transferencia(_tipo_lancamento, _usuariologado, _c6ContaController, _c2LancamentoController, _editar, _id_lancamento);
            DialogResult result = fo_transferencia.ShowDialog();
            if (result == DialogResult.OK)
            {
                _editar = false;
                DialogResult = DialogResult.OK;
            }
        }
        private async void btn_estornar_Click(object sender, EventArgs e)
        {
            if (_id_status_lancamento == 1)
            {
                MessageBox.Show("Não é possível estornar este lançamento, pois ele ainda não foi pago!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Deseja realmente estornar este lançamento?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await _c2LancamentoController.EstornarC2Lancamento(_id_lancamento);
                this.Hide();
                MessageBox.Show("Lançamento estornado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                return;
            }
        }
    }
}
