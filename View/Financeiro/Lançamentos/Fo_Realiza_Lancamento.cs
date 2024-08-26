using Controle_Financeiro_Pessoal.Controller;
using Controle_Financeiro_Pessoal.DTO;
using Controle_Financeiro_Pessoal.Function;
using Controle_Financeiro_Pessoal.Model;
using Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos;

namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    public partial class Fo_Realiza_Lancamento : Form
    {
        public int _usuariologado;
        public int _tipo_lancamento;
        private readonly C2LancamentoController _c2LancamentoController;
        private readonly C6ContaController _c6ContaController;
        public bool _editar;
        public int _id_lancamento;
        public int? _status_lancamento;
        public int? _id_lancamento_pai;
        public int _usuario_lancamento;
        public int __qtd_parcelas;
        FormatarValor _formatar_valor = new FormatarValor();
        public float _valor_original;
        private readonly C7CategoriaController _c7categoriacontroller;
        public Fo_Realiza_Lancamento(int usuariologado, int tipo_lancamento, C2LancamentoController c2lancamentocontroller, C6ContaController c6contacontroller, bool editar, int id
            , C7CategoriaController c7CategoriaController)
        {
            _c2LancamentoController = c2lancamentocontroller;
            _c6ContaController = c6contacontroller;
            _tipo_lancamento = tipo_lancamento;
            _usuariologado = usuariologado;
            _editar = editar;
            _id_lancamento = id;
            _c7categoriacontroller = c7CategoriaController;
            InitializeComponent();
        }
        private async void PreencheCamposEditaLancamento(int id_lancamento)
        {
            C2LancamentoDTO? _c2lancamentodto = await _c2LancamentoController.ObterC2Lancamento(id_lancamento);
            txt_titulo_lancamento.Text = _c2lancamentodto.C2LancamentoNome;
            Rtx_observacao.Text = _c2lancamentodto.C2Observacao;
            txt_valor.Text = "R$ " + _c2lancamentodto.C2LancamentoValor.ToString().Replace(".", ",");
            dtp_prev_pagamento.Text = _c2lancamentodto.C2Data_Prev_Pag.ToString();
            cbx_conta.SelectedValue = _c2lancamentodto.C2FKC6Id_Conta;
            cbx_moeda.SelectedValue = _c2lancamentodto.C2FKC4Id_Moeda;
            _tipo_lancamento = _c2lancamentodto.C2Tipo_Lancamento;
            _status_lancamento = _c2lancamentodto.C2FKC3Id_Status_Lancamento;
            _id_lancamento_pai = _c2lancamentodto.C2FKC2ID_Lancamento_Pai;
            _usuario_lancamento = _c2lancamentodto.C2FKC1Id_Usuario;
            cbx_categorias.SelectedValue = _c2lancamentodto.C2FKC7ID_Categoria;
            _valor_original = float.Parse(_c2lancamentodto.C2LancamentoValor);
        }
        private async Task LoadLancamentos()
        {
            cbx_conta.DataSource = await _c6ContaController.PreencheComboBoxC6Conta(_usuariologado);
            cbx_moeda.DataSource = await _c6ContaController.ListarC4Moeda();
            cbx_categorias.DataSource = await _c7categoriacontroller.ListarC7Categorias(_usuariologado);
            if (_editar == true)
            {
                PreencheCamposEditaLancamento(_id_lancamento);
            }
            AtualizaValoresParcelas();
            System.Threading.Thread.Sleep(300);
            __qtd_parcelas = await _c2LancamentoController.QtdParcelasC2Lancamentos_Filho(_id_lancamento);
            cbx_parcelas.SelectedIndex = __qtd_parcelas;
        }
        private async void Fo_Realiza_Lancamento_Load(object sender, EventArgs e)
        {
            await LoadLancamentos();
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private async void btn_confirmar_Click(object sender, EventArgs e)
        {
            #region 1 - Variaveis de entrada
            string _titulo_lancamento = txt_titulo_lancamento.Text;
            string _observacao_lancamento = Rtx_observacao.Text;
            float _valor_lancamento = float.Parse(txt_valor.Text.Replace("R$ ", ""));
            DateTime _dtp_prev_pag = dtp_prev_pagamento.Value.Kind == DateTimeKind.Utc ? dtp_prev_pagamento.Value : dtp_prev_pagamento.Value.ToUniversalTime();
            int _id_conta = (int)cbx_conta.SelectedValue;
            int _id_moeda = (int)cbx_moeda.SelectedValue;
            int? _id_categoria = (int)cbx_categorias.SelectedValue;
            int _qtd_parcelas = cbx_parcelas.SelectedIndex;
            DateTime _data_lancamento = DateTime.UtcNow.ToUniversalTime();
            int? _tipo_categoria = await _c7categoriacontroller.VerificarTipoC7Categoria(_id_categoria);
            #endregion
            #region 2 - Verificacao dos campos
            if (string.IsNullOrEmpty(txt_titulo_lancamento.Text))
            {
                MessageBox.Show("É preciso informar um título para este lançamento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_valor.Text == "R$ 0,00")
            {
                MessageBox.Show("É preciso informar um valor para este Lançamento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            if (_editar == false) //Caso seja um lançamento NOVO
            {
                #region 3 - Caso seja um novo lançamento e seja Parcelado
                if ((int)cbx_moeda.SelectedValue == 2 || (int)cbx_moeda.SelectedValue == 6) //se for parcelado
                {
                    float _valor_parcela = _valor_lancamento / _qtd_parcelas;
                    var lancamentopai = new C2Lancamento
                    {
                        C2Data_Lancamento = _data_lancamento.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 1, //Pendente Pagamento
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                    };
                    await _c2LancamentoController.AdicionarC2Lancamento(lancamentopai);
                    //Criação das parcelas
                    foreach (int i in Enumerable.Range(1, _qtd_parcelas))
                    {
                        _dtp_prev_pag = _dtp_prev_pag.AddMonths(1);
                        var lancamentoparcelado = new C2Lancamento
                        {
                            C2FKC6ID_Conta = _id_conta,
                            C2FKC4ID_Moeda = 5, //Parcela
                            C2FKC1ID_User = _usuariologado,
                            C2Data_Lancamento = _data_lancamento.AddHours(-3),
                            C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                            C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                            C2Observacao = _observacao_lancamento,
                            C2Titulo_Lancamento = _titulo_lancamento + $" ({i}/{_qtd_parcelas})",
                            C2FKC3ID_Status = 1, //Pendente Pagamento
                            C2Valor = _valor_parcela,
                            C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                            C2FKC2ID_Lancamento_Pai = lancamentopai.C2ID,
                            C2FKC7ID_Categoria = lancamentopai.C2FKC7ID_Categoria
                        };
                        await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelado);
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                    }
                    #endregion
                }
                else
                {
                    #region 4 - Caso for dinheiro ou outra que não seja Parcelado
                    if (_tipo_categoria == 1) //Caso seja uma categoria de parcela fixa MENSAL
                    {
                        for (int i = 1; i <= 6; i++)
                        {
                            _dtp_prev_pag = _dtp_prev_pag.AddMonths(1);
                            var lancamentoparcelafixa = new C2Lancamento
                            {
                                C2FKC6ID_Conta = _id_conta,
                                C2FKC4ID_Moeda = _id_moeda,
                                C2FKC1ID_User = _usuariologado,
                                C2Data_Lancamento = _data_lancamento.AddHours(-3),
                                C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                                C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                C2Observacao = _observacao_lancamento,
                                C2Titulo_Lancamento = _titulo_lancamento,
                                C2FKC3ID_Status = 1, //Pendente Pagamento
                                C2Valor = _valor_lancamento,
                                C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                                C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                            };
                            await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelafixa);
                        }
                        MessageBox.Show("Lançamento criado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (_tipo_categoria == 2) //Caso seja uma categoria de parcela fixa ANUAL
                    {
                        for (int i = 1; i <= 2; i++)
                        {
                            _dtp_prev_pag = _dtp_prev_pag.AddYears(1);
                            var lancamentoparcelafixaano = new C2Lancamento
                            {
                                C2FKC6ID_Conta = _id_conta,
                                C2FKC4ID_Moeda = _id_moeda,
                                C2FKC1ID_User = _usuariologado,
                                C2Data_Lancamento = _data_lancamento.AddHours(-3),
                                C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                                C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                C2Observacao = _observacao_lancamento,
                                C2Titulo_Lancamento = _titulo_lancamento,
                                C2FKC3ID_Status = 1, //Pendente Pagamento
                                C2Valor = _valor_lancamento,
                                C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                                C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                            };
                            await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelafixaano);
                        }
                        MessageBox.Show("Lançamento criado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {

                        var lancamento = new C2Lancamento
                        {
                            C2FKC6ID_Conta = _id_conta,
                            C2FKC4ID_Moeda = _id_moeda,
                            C2FKC1ID_User = _usuariologado,
                            C2Data_Lancamento = _data_lancamento.AddHours(-3),
                            C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                            C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                            C2Observacao = _observacao_lancamento,
                            C2Titulo_Lancamento = _titulo_lancamento,
                            C2FKC3ID_Status = 1, //Pendente Pagamento
                            C2Valor = _valor_lancamento,
                            C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                            C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                        };
                        await _c2LancamentoController.AdicionarC2Lancamento(lancamento);
                    }
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    #endregion
                }
            }
            else
            { //caso seja um lancamento EXISTENTE
                #region 6 - Caso seja um Lancamento PAI e for parcelado
                if (_id_lancamento_pai == null && _id_moeda == 2 || _id_moeda == 6)
                {//Caso seja um lancamento PAi e for parcelado
                    if (await _c2LancamentoController.VerificarSeLancamentoEstaPago(_id_lancamento) == true)
                    {
                        MessageBox.Show("Existem parcelas pagas para este lançamento, realize o estorno para que possa ser possivel editar o lançamento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    var atualizalancamento_pai = new C2Lancamento
                    {
                        C2ID = _id_lancamento,
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = _data_lancamento.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 1, //Pendente Pagamento
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                        C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                    };
                    await _c2LancamentoController.AtualizarC2Lancamento(atualizalancamento_pai);
                    DialogResult result = MessageBox.Show("Deseja recalcular as Parcelas já criadas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        float _valor_parcela = _valor_lancamento / _qtd_parcelas;
                        if (_qtd_parcelas != __qtd_parcelas) //CASO A QUANTIDADE DE PARCELAS DA EDICAO FOR DIFERENTE DA QUANTIDADE QUE HAVIA SIDO CRIADA////
                        {
                            var id = await _c2LancamentoController.ListarC2Lancamento_Filhos(_id_lancamento);
                            foreach (var item in id)
                            {
                                await _c2LancamentoController.DeletarC2LancamentosFilhos(_id_lancamento);
                            }
                            foreach (int i in Enumerable.Range(1, _qtd_parcelas))
                            {
                                _dtp_prev_pag = _dtp_prev_pag.AddMonths(1);
                                var lancamentoparcelado = new C2Lancamento
                                {
                                    C2FKC6ID_Conta = _id_conta,
                                    C2FKC4ID_Moeda = 5, //Parcela
                                    C2FKC1ID_User = _usuariologado,
                                    C2Data_Lancamento = _data_lancamento.AddHours(-3),
                                    C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                    C2Observacao = _observacao_lancamento,
                                    C2Titulo_Lancamento = _titulo_lancamento + $" Parcela ({i}/{_qtd_parcelas})",
                                    C2FKC3ID_Status = 1, //Pendente Pagamento
                                    C2Valor = _valor_parcela,
                                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                                    C2FKC2ID_Lancamento_Pai = atualizalancamento_pai.C2ID,
                                    C2FKC7ID_Categoria = atualizalancamento_pai.C2FKC7ID_Categoria
                                };
                                await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelado);
                            }
                            this.Hide();
                            MessageBox.Show("Parcelas recalculadas com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        { //CASO SEJA IGUAL A QUANTIDADE DE PARCELAS ORIGINAIS, APENAS EDITA-LAS
                            foreach (var parcela in await _c2LancamentoController.ListarC2Lancamento_Filhos(_id_lancamento))
                            {
                                var ajusteparcela = new C2Lancamento
                                {
                                    C2ID = parcela.C2ID,
                                    C2FKC6ID_Conta = _id_conta,
                                    C2FKC4ID_Moeda = 5, //Parcela
                                    C2FKC1ID_User = _usuariologado,
                                    C2Data_Lancamento = parcela.C2Data_Lancamento,
                                    C2Data_Previa_Pagamento = parcela.C2Data_Previa_Pagamento,
                                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                    C2Observacao = _observacao_lancamento,
                                    C2Titulo_Lancamento = parcela.C2Titulo_Lancamento,
                                    C2FKC3ID_Status = 1, //Pendente Pagamento
                                    C2Valor = _valor_parcela,
                                    C2FKC5ID_Tipo_Lancamento = parcela.C2FKC5ID_Tipo_Lancamento,
                                    C2FKC2ID_Lancamento_Pai = atualizalancamento_pai.C2ID,
                                    C2FKC7ID_Categoria = atualizalancamento_pai.C2FKC7ID_Categoria
                                };
                                await _c2LancamentoController.AtualizarC2LancamentoFilho(ajusteparcela);
                            }
                            this.Hide();
                            MessageBox.Show("Parcelas recalculadas com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    { //CASO NÃO QUEIRA RECALCULAR AS DEMAIS PARCELAS APENAS ALTERA O LANÇAMENTO PAI
                        MessageBox.Show("Lançamento atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DialogResult = DialogResult.OK;
                    }
                }
                #endregion
                else
                {
                    #region /////////TRATAMENTO DE EDIÇÃO DAS PARCELAS FIXAS//////////////////
                    if (_tipo_categoria == 1 || _tipo_categoria == 2) //Categoria MENSAL ou ANUAL
                    {
                        DialogResult result = MessageBox.Show("Deseja atualizar as demais parcelas existentes?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            var list_lancamentosexistente = await _c2LancamentoController.VerificarC2LancamentosCategoria(_id_categoria);
                            foreach (var lancamento_existente in list_lancamentosexistente)
                            {
                                var atualizalancamentoCategoria = new C2Lancamento
                                {
                                    C2ID = lancamento_existente.C2ID,
                                    C2FKC6ID_Conta = _id_conta,
                                    C2FKC4ID_Moeda = _id_moeda,
                                    C2FKC1ID_User = _usuariologado,
                                    C2Data_Lancamento = lancamento_existente.C2Data_Lancamento,
                                    C2Data_Previa_Pagamento = lancamento_existente.C2Data_Previa_Pagamento,
                                    C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                    C2Observacao = _observacao_lancamento,
                                    C2Titulo_Lancamento = _titulo_lancamento,
                                    C2FKC3ID_Status = 1, //Pendente Pagamento
                                    C2Valor = _valor_lancamento,
                                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                                    C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                                };
                                await _c2LancamentoController.AtualizarC2Lancamento(atualizalancamentoCategoria);
                            }
                            MessageBox.Show("Lançamentos atualizados com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {//Caso não queira atualizar as demais parcelas
                            var atualizalancamentoCategoria = new C2Lancamento
                            {
                                C2ID = _id_lancamento,
                                C2FKC6ID_Conta = _id_conta,
                                C2FKC4ID_Moeda = _id_moeda,
                                C2FKC1ID_User = _usuariologado,
                                C2Data_Lancamento = _data_lancamento.AddHours(-3),
                                C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                                C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                                C2Observacao = _observacao_lancamento,
                                C2Titulo_Lancamento = _titulo_lancamento,
                                C2FKC3ID_Status = 1, //Pendente Pagamento
                                C2Valor = _valor_lancamento,
                                C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                                C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                            };
                            await _c2LancamentoController.AtualizarC2Lancamento(atualizalancamentoCategoria);
                            MessageBox.Show("Lançamento atualizado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            DialogResult = DialogResult.OK;
                        }
                    }
                    #endregion
                    else
                    {
                        #region 7 - Caso seja Lancamento À VISTA, PARCELA, CATEGORIA NORMAL
                        var parcela = await _c2LancamentoController.ListarC2Lancamento_Filhos(_id_lancamento);                        
                        var atualizalancamento = new C2Lancamento
                        {
                            C2ID = _id_lancamento,
                            C2FKC6ID_Conta = _id_conta,
                            C2FKC4ID_Moeda = _id_moeda,
                            C2FKC1ID_User = _usuariologado,
                            C2Data_Lancamento = _data_lancamento.AddHours(-3),
                            C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                            C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                            C2Observacao = _observacao_lancamento,
                            C2Titulo_Lancamento = _titulo_lancamento,
                            C2FKC3ID_Status = 1, //Pendente Pagamento
                            C2Valor = _valor_lancamento,
                            C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                            C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria,
                            C2FKC2ID_Lancamento_Pai = _id_lancamento_pai
                        };
                        await _c2LancamentoController.AtualizarC2Lancamento(atualizalancamento);
                        await _c2LancamentoController.VerificaeAtualizaValorLancamentoParcelado(_id_lancamento, _id_lancamento_pai, _valor_original, _valor_lancamento);
                        MessageBox.Show("Lançamento atualizado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                        #endregion
                    }
                }
            }
        }
        private void cbx_moeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbx_moeda.SelectedValue is 2 or 6)
            {
                label8.Visible = true;
                cbx_parcelas.Visible = true;
                btn_pago.Enabled = false;
                label3.Text = "Data 1º Parcela";
            }
            else
            {
                label8.Visible = false;
                cbx_parcelas.Visible = false;
                btn_pago.Enabled = true;
            }
        }
        private async void cbx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _id_categoria = (int)cbx_categorias.SelectedValue;
            int? _tipo_categoria = await _c7categoriacontroller.VerificarTipoC7Categoria(_id_categoria);
            if (_tipo_categoria is 1 or 2)
            {
                cbx_moeda.SelectedValue = 7;
            }
        }
        private async void btn_pago_Click(object sender, EventArgs e)
        {
            #region 1 - Variaveis de entrada
            string _titulo_lancamento = txt_titulo_lancamento.Text;
            string _observacao_lancamento = Rtx_observacao.Text;
            float _valor_lancamento = float.Parse(txt_valor.Text.Replace("R$ ", ""));
            DateTime _dtp_prev_pag = dtp_prev_pagamento.Value.Kind == DateTimeKind.Utc ? dtp_prev_pagamento.Value : dtp_prev_pagamento.Value.ToUniversalTime();
            DateTime _dtp_pagamento = DateTime.UtcNow; /*? dtp_pagamento.Value : dtp_pagamento.Value.ToUniversalTime();*/
            int _id_conta = (int)cbx_conta.SelectedValue;
            int _id_moeda = (int)cbx_moeda.SelectedValue;
            int _id_categoria = (int)cbx_categorias.SelectedValue;
            int? _tipo_categoria = await _c7categoriacontroller.VerificarTipoC7Categoria(_id_categoria);
            #endregion
            #region 2 - Verificacao dos campos
            if (string.IsNullOrEmpty(txt_titulo_lancamento.Text))
            {
                MessageBox.Show("É preciso informar um título para este lançamento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_valor.Text.Replace("R$ ", "") == "0,00")
            {
                MessageBox.Show("É preciso informar um valor para este Lançamento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            if (_editar == true)
            {
                #region 3 - Caso seja um lancamento existente
                var pagarlancamento = new C2Lancamento
                {
                    C2ID = _id_lancamento,
                    C2FKC6ID_Conta = _id_conta,
                    C2FKC4ID_Moeda = _id_moeda,
                    C2FKC1ID_User = _usuariologado,
                    C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                    C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                    C2Data_Pagamento = _dtp_pagamento.AddHours(-3),
                    C2Observacao = _observacao_lancamento,
                    C2Titulo_Lancamento = _titulo_lancamento,
                    C2FKC3ID_Status = 2, //Pago
                    C2Valor = _valor_lancamento,
                    C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                    C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                };
                await _c2LancamentoController.AtualizarC2Lancamento(pagarlancamento);
                this.Hide();
                DialogResult = DialogResult.OK;
                #endregion
            }
            else
            {

                if (_tipo_categoria == 1) //Caso seja uma categoria de parcela fixa todo mês
                {
                    #region 4 - Caso seja um novo lancamento com parcela Fixa MENSAL
                    var lancamentoparcelafixamespaga = new C2Lancamento
                    {
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 2, ////Pago
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                        C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                    };
                    await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelafixamespaga);
                    for (int i = 1; i <= 5; i++)
                    {
                        _dtp_prev_pag = _dtp_prev_pag.AddMonths(1);
                        var lancamentoparcelafixa = new C2Lancamento
                        {
                            C2FKC6ID_Conta = _id_conta,
                            C2FKC4ID_Moeda = _id_moeda,
                            C2FKC1ID_User = _usuariologado,
                            C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                            C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                            C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                            C2Observacao = _observacao_lancamento,
                            C2Titulo_Lancamento = _titulo_lancamento,
                            C2FKC3ID_Status = 1, ////Pendente Pagamento
                            C2Valor = _valor_lancamento,
                            C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                            C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                        };
                        await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelafixa);
                    }
                    MessageBox.Show("Lançamento criado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    #endregion
                }
                else if (_tipo_categoria == 2) //Caso seja uma categoria de parcela fixa todo ano
                {
                    #region 5 - Caso seja um novo lancamento com parcela Fixa ANUAL
                    var lancamentoparcelafixaanopaga = new C2Lancamento
                    {
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 2, ////Pago
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                        C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                    };
                    await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelafixaanopaga);
                    for (int i = 1; i <= 1; i++)
                    {
                        _dtp_prev_pag = _dtp_prev_pag.AddYears(1);
                        var lancamentoparcelafixaano = new C2Lancamento
                        {
                            C2FKC6ID_Conta = _id_conta,
                            C2FKC4ID_Moeda = _id_moeda,
                            C2FKC1ID_User = _usuariologado,
                            C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                            C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                            C2Data_Pagamento = null, //Como ele ainda não foi pago, ele ainda não possui uma data de pagamento
                            C2Observacao = _observacao_lancamento,
                            C2Titulo_Lancamento = _titulo_lancamento,
                            C2FKC3ID_Status = 1, ////Pendente Pagamento
                            C2Valor = _valor_lancamento,
                            C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                            C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria
                        };
                        await _c2LancamentoController.AdicionarC2Lancamento(lancamentoparcelafixaano);
                    }
                    MessageBox.Show("Lançamento criado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    #endregion
                }
                else
                {
                    #region 6 - Caso seja um lancamento de categoria Normal
                    var lancamento = new C2Lancamento
                    {
                        C2FKC6ID_Conta = _id_conta,
                        C2FKC4ID_Moeda = _id_moeda,
                        C2FKC1ID_User = _usuariologado,
                        C2Data_Lancamento = DateTime.UtcNow.AddHours(-3),
                        C2Data_Previa_Pagamento = _dtp_prev_pag.AddHours(-3),
                        C2Data_Pagamento = _dtp_pagamento.AddHours(-3),
                        C2Observacao = _observacao_lancamento,
                        C2Titulo_Lancamento = _titulo_lancamento,
                        C2FKC3ID_Status = 2, //Pago
                        C2Valor = _valor_lancamento,
                        C2FKC5ID_Tipo_Lancamento = _tipo_lancamento,
                        C2FKC7ID_Categoria = _id_categoria == 0 ? 3 : _id_categoria,
                        C2FKC2ID_Lancamento_Pai = _id_lancamento_pai
                    };
                    await _c2LancamentoController.AdicionarC2Lancamento(lancamento);
                    await _c2LancamentoController.VerificarRecriarParcelaFixas(_id_lancamento, _id_categoria, _tipo_categoria);
                    this.Hide();
                    DialogResult = DialogResult.OK;
                    #endregion
                }
            }
        }
        #region Validação e Atualização de Valores
        private void AtualizaValoresParcelas()
        {
            string valor = txt_valor.Text.Replace("R$ ", "");
            if (_editar == true)
            {
                valor.Replace("R$ ", "");
            }
            if (float.TryParse(valor, out float _valor_lancamento))
            {
                cbx_parcelas.Items.Clear();
                // Adiciona o item em branco no início
                cbx_parcelas.Items.Add("Parcelas:");
                //AItera de 1 a 12 para adicionar as parcelas com os valores calculados
                for (int i = 1; i <= 12; i++)
                {
                    float valor_parcela = _valor_lancamento / i;
                    cbx_parcelas.Items.Add($"{i} parcela(s): {valor_parcela:C2}");
                }
                cbx_parcelas.SelectedIndex = 0;
            }
            else
            {
                cbx_parcelas.Items.Clear();
                cbx_parcelas.Items.Add("");
                cbx_parcelas.SelectedIndex = 0;
            }
        }
        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            AtualizaValoresParcelas();
        }
        #endregion
        #region Tratamento do campo Valor
        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            _formatar_valor.TratarKeyPress(sender, e);
        }

        private void txt_valor_Leave(object sender, EventArgs e)
        {
            _formatar_valor.TratarLeave(sender, e);
        }

        private void txt_valor_KeyUp(object sender, KeyEventArgs e)
        {
            _formatar_valor.TratarKeyUp(sender, e);
        }
        #endregion
        private async void btn_adiciona_categoria_Click(object sender, EventArgs e)
        {
            Fo_Categorias _fo_categoria = new Fo_Categorias(_usuariologado, _c7categoriacontroller);
            DialogResult result = _fo_categoria.ShowDialog();
            if (result == DialogResult.OK)
            {
                cbx_categorias.DataSource = await _c7categoriacontroller.ListarC7Categorias(_usuariologado);
            }
        }
    }
}