using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Model;
using System.Runtime.CompilerServices;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Visualiza_Lancamento : Form
    {
        private readonly C2LancamentoController _c2LancamentoController;
        public bool _editar = false;
        public int _id_lancamento;
        private int _usuariologado;
        public int tipo_lancamento;
        public int _id_status_lancamento;
        public int? _id_lancamento_pai;
        public int _id_moeda;
        public int? _id_categoria;
        private readonly C6ContaController _c6ContaController;
        private readonly C7CategoriaController _c7categoriaController;
        public Fo_Visualiza_Lancamento(bool editar, C2LancamentoController c2LancamentoController, int id_lancamento, int usuariologado, C6ContaController c6contacontroller
            , C7CategoriaController c7categoriaconotroller)
        {
            _c2LancamentoController = c2LancamentoController;
            _editar = editar;
            _id_lancamento = id_lancamento;
            _usuariologado = usuariologado;
            _c6ContaController = c6contacontroller;
            _c7categoriaController = c7categoriaconotroller;
            InitializeComponent();
        }
        private async void PreencheCamposEditaLancamento(int id)
        {
            C2LancamentoDTO? _c2lancamentodto = await _c2LancamentoController.ObterC2Lancamento(id);
            txt_titulo_lancamento.Text = _c2lancamentodto.C2LancamentoNome;
            rtxt_observacao.Text = _c2lancamentodto.C2Observacao;
            txt_valor.Text = "R$ " + _c2lancamentodto.C2LancamentoValor.ToString();
            txt_categoria.Text = _c2lancamentodto.C2FKC7Nome_Categoria;
            txt_data_prev_pag.Text = _c2lancamentodto.C2Data_Prev_Pag.ToString();
            txt_data_pag.Text = _c2lancamentodto.C2Data_Pag.ToString();
            txt_conta.Text = _c2lancamentodto.C2FKC6Nome_Conta;
            txt_moeda.Text = _c2lancamentodto.C2FKC4Nome_Moeda;
            tipo_lancamento = _c2lancamentodto.C2Tipo_Lancamento;
            _id_status_lancamento = _c2lancamentodto.C2FKC3Id_Status_Lancamento;
            _id_lancamento_pai = _c2lancamentodto.C2FKC2ID_Lancamento_Pai;
            _id_moeda = _c2lancamentodto.C2FKC4Id_Moeda;
            _id_categoria = _c2lancamentodto.C2FKC7ID_Categoria;
        }
        private void Fo_Confirma_Pagamento_Load(object sender, EventArgs e)
        {
            PreencheCamposEditaLancamento(_id_lancamento);
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (_id_status_lancamento == 2)
            {
                MessageBox.Show("Lançamento já pago, para edita-lo é necessario excluir e criar novamente!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Hide();
            Fo_Realiza_Lancamento fo_realiza_lancamento = new Fo_Realiza_Lancamento(_usuariologado, tipo_lancamento, _c2LancamentoController, _c6ContaController, _editar = true
                , _id_lancamento, _c7categoriaController);
            DialogResult result = fo_realiza_lancamento.ShowDialog();
            this.Hide();
            if (result == DialogResult.OK)
            {
                _editar = false;
            }
        }
        private async void btn_realizar_Click(object sender, EventArgs e)
        {
            int? _tipo_categoria = await _c7categoriaController.VerificarTipoC7Categoria(_id_categoria);
            if (_id_status_lancamento == 2)
            {
                MessageBox.Show("Este lançamento já esta pago!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_id_moeda == 2 || _id_moeda == 6)
            {
                await _c2LancamentoController.RealizarC2Lancamento(_id_lancamento, _id_moeda);
                DialogResult = DialogResult.OK;
            }
            else if (_id_lancamento_pai != null)
            {
                await _c2LancamentoController.RealizarC2Lancamento(_id_lancamento, _id_moeda);
                await _c2LancamentoController.AtualizarStatusC2Lancamento(_id_lancamento_pai);
                DialogResult = DialogResult.OK;
            }
            else
            {
                await _c2LancamentoController.RealizarC2Lancamento(_id_lancamento, _id_moeda);
                await _c2LancamentoController.VerificarRecriarParcelaFixas(_id_lancamento, _id_categoria, _tipo_categoria);
                DialogResult = DialogResult.OK;
            }
            this.Hide();
            MessageBox.Show("Lançamento pago com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btn_estornar_Click(object sender, EventArgs e)
        {
            if (_id_status_lancamento == 1)
            {
                MessageBox.Show("Não é possível estornar este lançamento, pois ele ainda não foi pago!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
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
}
