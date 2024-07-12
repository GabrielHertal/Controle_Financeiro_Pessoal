namespace Controle_Financeiro_Pessoal.View.Lancamentos
{
    partial class Fo_Lancamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel_lancamentos = new Panel();
            btn_excluir = new Button();
            btn_novo_lancamento = new Button();
            grid_lancamentos = new DataGridView();
            c2LancamentoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2LancamentoNomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2LancamentoValorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2DataLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2DataPrevPagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2DataPagDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2FKC3StatusLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2FKC4NomeMoedaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2FKC5TipoLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2FKC6NomeContaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c2LancamentoDTOBindingSource = new BindingSource(components);
            panel_lancamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lancamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c2LancamentoDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_lancamentos
            // 
            panel_lancamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_lancamentos.BackColor = SystemColors.ControlDarkDark;
            panel_lancamentos.Controls.Add(btn_excluir);
            panel_lancamentos.Controls.Add(btn_novo_lancamento);
            panel_lancamentos.Controls.Add(grid_lancamentos);
            panel_lancamentos.Location = new Point(-2, -2);
            panel_lancamentos.Name = "panel_lancamentos";
            panel_lancamentos.Size = new Size(1411, 806);
            panel_lancamentos.TabIndex = 0;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_excluir.Image = Properties.Resources.lixo;
            btn_excluir.Location = new Point(1324, 15);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(70, 60);
            btn_excluir.TabIndex = 2;
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_novo_lancamento
            // 
            btn_novo_lancamento.Image = Properties.Resources.mais;
            btn_novo_lancamento.Location = new Point(14, 15);
            btn_novo_lancamento.Name = "btn_novo_lancamento";
            btn_novo_lancamento.Size = new Size(70, 60);
            btn_novo_lancamento.TabIndex = 1;
            btn_novo_lancamento.UseVisualStyleBackColor = true;
            btn_novo_lancamento.Click += btm_novo_lancamento_Click;
            // 
            // grid_lancamentos
            // 
            grid_lancamentos.AllowUserToAddRows = false;
            grid_lancamentos.AllowUserToDeleteRows = false;
            grid_lancamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_lancamentos.AutoGenerateColumns = false;
            grid_lancamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid_lancamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_lancamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_lancamentos.Columns.AddRange(new DataGridViewColumn[] { c2LancamentoIdDataGridViewTextBoxColumn, c2LancamentoNomeDataGridViewTextBoxColumn, c2LancamentoValorDataGridViewTextBoxColumn, c2DataLancamentoDataGridViewTextBoxColumn, c2DataPrevPagDataGridViewTextBoxColumn, c2DataPagDataGridViewTextBoxColumn, c2FKC3StatusLancamentoDataGridViewTextBoxColumn, c2FKC4NomeMoedaDataGridViewTextBoxColumn, c2FKC5TipoLancamentoDataGridViewTextBoxColumn, c2FKC6NomeContaDataGridViewTextBoxColumn });
            grid_lancamentos.DataSource = c2LancamentoDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grid_lancamentos.DefaultCellStyle = dataGridViewCellStyle2;
            grid_lancamentos.Location = new Point(14, 81);
            grid_lancamentos.Name = "grid_lancamentos";
            grid_lancamentos.ReadOnly = true;
            grid_lancamentos.Size = new Size(1380, 710);
            grid_lancamentos.TabIndex = 0;
            grid_lancamentos.CellMouseDoubleClick += grid_lancamentos_CellMouseDoubleClick;
            // 
            // c2LancamentoIdDataGridViewTextBoxColumn
            // 
            c2LancamentoIdDataGridViewTextBoxColumn.DataPropertyName = "C2LancamentoId";
            c2LancamentoIdDataGridViewTextBoxColumn.FillWeight = 35F;
            c2LancamentoIdDataGridViewTextBoxColumn.HeaderText = "ID";
            c2LancamentoIdDataGridViewTextBoxColumn.Name = "c2LancamentoIdDataGridViewTextBoxColumn";
            c2LancamentoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2LancamentoNomeDataGridViewTextBoxColumn
            // 
            c2LancamentoNomeDataGridViewTextBoxColumn.DataPropertyName = "C2LancamentoNome";
            c2LancamentoNomeDataGridViewTextBoxColumn.HeaderText = "TITULO LANCAMENTO";
            c2LancamentoNomeDataGridViewTextBoxColumn.Name = "c2LancamentoNomeDataGridViewTextBoxColumn";
            c2LancamentoNomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2LancamentoValorDataGridViewTextBoxColumn
            // 
            c2LancamentoValorDataGridViewTextBoxColumn.DataPropertyName = "C2LancamentoValor";
            c2LancamentoValorDataGridViewTextBoxColumn.FillWeight = 70F;
            c2LancamentoValorDataGridViewTextBoxColumn.HeaderText = "VALOR";
            c2LancamentoValorDataGridViewTextBoxColumn.Name = "c2LancamentoValorDataGridViewTextBoxColumn";
            c2LancamentoValorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2DataLancamentoDataGridViewTextBoxColumn
            // 
            c2DataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "C2DataLancamento";
            c2DataLancamentoDataGridViewTextBoxColumn.HeaderText = "C2DataLancamento";
            c2DataLancamentoDataGridViewTextBoxColumn.Name = "c2DataLancamentoDataGridViewTextBoxColumn";
            c2DataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            c2DataLancamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // c2DataPrevPagDataGridViewTextBoxColumn
            // 
            c2DataPrevPagDataGridViewTextBoxColumn.DataPropertyName = "C2Data_Prev_Pag";
            c2DataPrevPagDataGridViewTextBoxColumn.FillWeight = 70F;
            c2DataPrevPagDataGridViewTextBoxColumn.HeaderText = "DATA PREV. PAG.";
            c2DataPrevPagDataGridViewTextBoxColumn.Name = "c2DataPrevPagDataGridViewTextBoxColumn";
            c2DataPrevPagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2DataPagDataGridViewTextBoxColumn
            // 
            c2DataPagDataGridViewTextBoxColumn.DataPropertyName = "C2Data_Pag";
            c2DataPagDataGridViewTextBoxColumn.FillWeight = 70F;
            c2DataPagDataGridViewTextBoxColumn.HeaderText = "DATA PAGAMENTO";
            c2DataPagDataGridViewTextBoxColumn.Name = "c2DataPagDataGridViewTextBoxColumn";
            c2DataPagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2FKC3StatusLancamentoDataGridViewTextBoxColumn
            // 
            c2FKC3StatusLancamentoDataGridViewTextBoxColumn.DataPropertyName = "C2FKC3Status_Lancamento";
            c2FKC3StatusLancamentoDataGridViewTextBoxColumn.FillWeight = 65F;
            c2FKC3StatusLancamentoDataGridViewTextBoxColumn.HeaderText = "STATUS ";
            c2FKC3StatusLancamentoDataGridViewTextBoxColumn.Name = "c2FKC3StatusLancamentoDataGridViewTextBoxColumn";
            c2FKC3StatusLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2FKC4NomeMoedaDataGridViewTextBoxColumn
            // 
            c2FKC4NomeMoedaDataGridViewTextBoxColumn.DataPropertyName = "C2FKC4Nome_Moeda";
            c2FKC4NomeMoedaDataGridViewTextBoxColumn.FillWeight = 55F;
            c2FKC4NomeMoedaDataGridViewTextBoxColumn.HeaderText = "MOEDA";
            c2FKC4NomeMoedaDataGridViewTextBoxColumn.Name = "c2FKC4NomeMoedaDataGridViewTextBoxColumn";
            c2FKC4NomeMoedaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2FKC5TipoLancamentoDataGridViewTextBoxColumn
            // 
            c2FKC5TipoLancamentoDataGridViewTextBoxColumn.DataPropertyName = "C2FKC5Tipo_Lancamento";
            c2FKC5TipoLancamentoDataGridViewTextBoxColumn.FillWeight = 45F;
            c2FKC5TipoLancamentoDataGridViewTextBoxColumn.HeaderText = "TIPO ";
            c2FKC5TipoLancamentoDataGridViewTextBoxColumn.Name = "c2FKC5TipoLancamentoDataGridViewTextBoxColumn";
            c2FKC5TipoLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2FKC6NomeContaDataGridViewTextBoxColumn
            // 
            c2FKC6NomeContaDataGridViewTextBoxColumn.DataPropertyName = "C2FKC6Nome_Conta";
            c2FKC6NomeContaDataGridViewTextBoxColumn.FillWeight = 78.23604F;
            c2FKC6NomeContaDataGridViewTextBoxColumn.HeaderText = "CONTA";
            c2FKC6NomeContaDataGridViewTextBoxColumn.Name = "c2FKC6NomeContaDataGridViewTextBoxColumn";
            c2FKC6NomeContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2LancamentoDTOBindingSource
            // 
            c2LancamentoDTOBindingSource.DataSource = typeof(DTO.C2LancamentoDTO);
            // 
            // Fo_Lancamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 801);
            Controls.Add(panel_lancamentos);
            Name = "Fo_Lancamentos";
            Text = "Fo_Lancamentos";
            WindowState = FormWindowState.Maximized;
            Load += Fo_Lancamentos_Load;
            panel_lancamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_lancamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)c2LancamentoDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_lancamentos;
        private DataGridView grid_lancamentos;
        private Button btn_excluir;
        private Button btn_novo_lancamento;
        private DataGridViewTextBoxColumn c2FKC3IDStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2FKC4IDMoedaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2FKC5IDTipoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2FKC6IDContaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BindingSource c2LancamentoDTOBindingSource;
        private DataGridViewTextBoxColumn c2LancamentoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2LancamentoNomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2LancamentoValorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2DataLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2DataPrevPagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2DataPagDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2FKC3StatusLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2FKC4NomeMoedaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2FKC5TipoLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c2FKC6NomeContaDataGridViewTextBoxColumn;
    }
}