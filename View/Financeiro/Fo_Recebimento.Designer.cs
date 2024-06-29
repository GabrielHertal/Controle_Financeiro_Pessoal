namespace Controle_Financeiro_Pessoal.View.Recebimento
{
    partial class Fo_Recebimento
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
            panel_recebimentos = new Panel();
            btn_adicionar = new Button();
            btn_excluir = new Button();
            grid_recebimentos = new DataGridView();
            c7IDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7TituloRecebimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7ValorRecebimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7FKC1IDUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7FKC6IDContaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7RecebimentoBindingSource = new BindingSource(components);
            panel_recebimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_recebimentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c7RecebimentoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_recebimentos
            // 
            panel_recebimentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_recebimentos.BackColor = SystemColors.ControlDarkDark;
            panel_recebimentos.Controls.Add(btn_adicionar);
            panel_recebimentos.Controls.Add(btn_excluir);
            panel_recebimentos.Controls.Add(grid_recebimentos);
            panel_recebimentos.Location = new Point(0, -2);
            panel_recebimentos.Name = "panel_recebimentos";
            panel_recebimentos.Size = new Size(1416, 811);
            panel_recebimentos.TabIndex = 0;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Image = Properties.Resources.mais;
            btn_adicionar.Location = new Point(12, 15);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(70, 60);
            btn_adicionar.TabIndex = 2;
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_excluir.Image = Properties.Resources.lixo;
            btn_excluir.Location = new Point(1322, 15);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(70, 60);
            btn_excluir.TabIndex = 1;
            btn_excluir.UseVisualStyleBackColor = true;
            // 
            // grid_recebimentos
            // 
            grid_recebimentos.AllowUserToAddRows = false;
            grid_recebimentos.AllowUserToDeleteRows = false;
            grid_recebimentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_recebimentos.AutoGenerateColumns = false;
            grid_recebimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid_recebimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_recebimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_recebimentos.Columns.AddRange(new DataGridViewColumn[] { c7IDDataGridViewTextBoxColumn, c7TituloRecebimentoDataGridViewTextBoxColumn, c7ValorRecebimentoDataGridViewTextBoxColumn, c7FKC1IDUsuarioDataGridViewTextBoxColumn, c7FKC6IDContaDataGridViewTextBoxColumn });
            grid_recebimentos.DataSource = c7RecebimentoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grid_recebimentos.DefaultCellStyle = dataGridViewCellStyle2;
            grid_recebimentos.Location = new Point(12, 81);
            grid_recebimentos.MultiSelect = false;
            grid_recebimentos.Name = "grid_recebimentos";
            grid_recebimentos.ReadOnly = true;
            grid_recebimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_recebimentos.Size = new Size(1380, 710);
            grid_recebimentos.TabIndex = 0;
            // 
            // c7IDDataGridViewTextBoxColumn
            // 
            c7IDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            c7IDDataGridViewTextBoxColumn.DataPropertyName = "C7ID";
            c7IDDataGridViewTextBoxColumn.FillWeight = 30F;
            c7IDDataGridViewTextBoxColumn.Frozen = true;
            c7IDDataGridViewTextBoxColumn.HeaderText = "ID";
            c7IDDataGridViewTextBoxColumn.Name = "c7IDDataGridViewTextBoxColumn";
            c7IDDataGridViewTextBoxColumn.ReadOnly = true;
            c7IDDataGridViewTextBoxColumn.Width = 122;
            // 
            // c7TituloRecebimentoDataGridViewTextBoxColumn
            // 
            c7TituloRecebimentoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            c7TituloRecebimentoDataGridViewTextBoxColumn.DataPropertyName = "C7Titulo_Recebimento";
            c7TituloRecebimentoDataGridViewTextBoxColumn.FillWeight = 200F;
            c7TituloRecebimentoDataGridViewTextBoxColumn.Frozen = true;
            c7TituloRecebimentoDataGridViewTextBoxColumn.HeaderText = "TITULO LANÇAMENTO";
            c7TituloRecebimentoDataGridViewTextBoxColumn.Name = "c7TituloRecebimentoDataGridViewTextBoxColumn";
            c7TituloRecebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            c7TituloRecebimentoDataGridViewTextBoxColumn.Width = 305;
            // 
            // c7ValorRecebimentoDataGridViewTextBoxColumn
            // 
            c7ValorRecebimentoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            c7ValorRecebimentoDataGridViewTextBoxColumn.DataPropertyName = "C7Valor_Recebimento";
            c7ValorRecebimentoDataGridViewTextBoxColumn.FillWeight = 80F;
            c7ValorRecebimentoDataGridViewTextBoxColumn.Frozen = true;
            c7ValorRecebimentoDataGridViewTextBoxColumn.HeaderText = "VALOR RECEBIMENTO";
            c7ValorRecebimentoDataGridViewTextBoxColumn.Name = "c7ValorRecebimentoDataGridViewTextBoxColumn";
            c7ValorRecebimentoDataGridViewTextBoxColumn.ReadOnly = true;
            c7ValorRecebimentoDataGridViewTextBoxColumn.Width = 305;
            // 
            // c7FKC1IDUsuarioDataGridViewTextBoxColumn
            // 
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "C7FKC1ID_Usuario";
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.HeaderText = "USUARIO ";
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.Name = "c7FKC1IDUsuarioDataGridViewTextBoxColumn";
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.Width = 305;
            // 
            // c7FKC6IDContaDataGridViewTextBoxColumn
            // 
            c7FKC6IDContaDataGridViewTextBoxColumn.DataPropertyName = "C7FKC6ID_Conta";
            c7FKC6IDContaDataGridViewTextBoxColumn.HeaderText = "CONTA DESTINO";
            c7FKC6IDContaDataGridViewTextBoxColumn.Name = "c7FKC6IDContaDataGridViewTextBoxColumn";
            c7FKC6IDContaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c7RecebimentoBindingSource
            // 
            c7RecebimentoBindingSource.DataSource = typeof(Model.C7Recebimento);
            // 
            // Fo_Recebimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 801);
            Controls.Add(panel_recebimentos);
            Name = "Fo_Recebimento";
            Text = "Fo_Recebimento";
            WindowState = FormWindowState.Maximized;
            Load += Fo_Recebimento_Load;
            panel_recebimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_recebimentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)c7RecebimentoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_recebimentos;
        private DataGridView grid_recebimentos;
        private BindingSource c7RecebimentoBindingSource;
        private Button btn_excluir;
        private Button btn_adicionar;
        private DataGridViewTextBoxColumn c7IDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c7TituloRecebimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c7ValorRecebimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c7FKC1IDUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c7FKC6IDContaDataGridViewTextBoxColumn;
    }
}