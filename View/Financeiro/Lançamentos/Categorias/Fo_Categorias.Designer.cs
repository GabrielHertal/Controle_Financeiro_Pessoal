namespace Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos
{
    partial class Fo_Categorias
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
            grid_categorias = new DataGridView();
            c7IdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7NomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7TipoCategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7FKC1IDUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1UsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c7CategoriaBindingSource = new BindingSource(components);
            btn_adicionar = new Button();
            btn_excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)grid_categorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c7CategoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grid_categorias
            // 
            grid_categorias.AllowUserToAddRows = false;
            grid_categorias.AllowUserToDeleteRows = false;
            grid_categorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_categorias.AutoGenerateColumns = false;
            grid_categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid_categorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_categorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_categorias.Columns.AddRange(new DataGridViewColumn[] { c7IdDataGridViewTextBoxColumn, c7NomeDataGridViewTextBoxColumn, c7TipoCategoriaDataGridViewTextBoxColumn, c7FKC1IDUsuarioDataGridViewTextBoxColumn, c1UsuarioDataGridViewTextBoxColumn });
            grid_categorias.DataSource = c7CategoriaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grid_categorias.DefaultCellStyle = dataGridViewCellStyle2;
            grid_categorias.Location = new Point(12, 74);
            grid_categorias.Name = "grid_categorias";
            grid_categorias.ReadOnly = true;
            grid_categorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_categorias.Size = new Size(565, 195);
            grid_categorias.TabIndex = 0;
            // 
            // c7IdDataGridViewTextBoxColumn
            // 
            c7IdDataGridViewTextBoxColumn.DataPropertyName = "C7Id";
            c7IdDataGridViewTextBoxColumn.FillWeight = 40F;
            c7IdDataGridViewTextBoxColumn.HeaderText = "ID";
            c7IdDataGridViewTextBoxColumn.Name = "c7IdDataGridViewTextBoxColumn";
            c7IdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c7NomeDataGridViewTextBoxColumn
            // 
            c7NomeDataGridViewTextBoxColumn.DataPropertyName = "C7Nome";
            c7NomeDataGridViewTextBoxColumn.FillWeight = 150F;
            c7NomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            c7NomeDataGridViewTextBoxColumn.Name = "c7NomeDataGridViewTextBoxColumn";
            c7NomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c7TipoCategoriaDataGridViewTextBoxColumn
            // 
            c7TipoCategoriaDataGridViewTextBoxColumn.DataPropertyName = "C7Tipo_Categoria";
            c7TipoCategoriaDataGridViewTextBoxColumn.FillWeight = 80F;
            c7TipoCategoriaDataGridViewTextBoxColumn.HeaderText = "TIPO";
            c7TipoCategoriaDataGridViewTextBoxColumn.Name = "c7TipoCategoriaDataGridViewTextBoxColumn";
            c7TipoCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c7FKC1IDUsuarioDataGridViewTextBoxColumn
            // 
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.DataPropertyName = "C7FKC1ID_Usuario";
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.HeaderText = "C7FKC1ID_Usuario";
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.Name = "c7FKC1IDUsuarioDataGridViewTextBoxColumn";
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            c7FKC1IDUsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // c1UsuarioDataGridViewTextBoxColumn
            // 
            c1UsuarioDataGridViewTextBoxColumn.DataPropertyName = "C1Usuario";
            c1UsuarioDataGridViewTextBoxColumn.HeaderText = "C1Usuario";
            c1UsuarioDataGridViewTextBoxColumn.Name = "c1UsuarioDataGridViewTextBoxColumn";
            c1UsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            c1UsuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // c7CategoriaBindingSource
            // 
            c7CategoriaBindingSource.DataSource = typeof(Model.C7Categoria);
            // 
            // btn_adicionar
            // 
            btn_adicionar.Image = Properties.Resources.mais;
            btn_adicionar.Location = new Point(12, 9);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(70, 60);
            btn_adicionar.TabIndex = 1;
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_excluir.Image = Properties.Resources.lixo;
            btn_excluir.Location = new Point(502, 9);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(70, 60);
            btn_excluir.TabIndex = 2;
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // Fo_Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 281);
            Controls.Add(btn_excluir);
            Controls.Add(btn_adicionar);
            Controls.Add(grid_categorias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fo_Categorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            FormClosed += Fo_Categorias_FormClosed;
            Load += Fo_Categorias_Load;
            ((System.ComponentModel.ISupportInitialize)grid_categorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)c7CategoriaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid_categorias;
        private Button btn_adicionar;
        private Button btn_excluir;
        private BindingSource c7CategoriaBindingSource;
        private DataGridViewTextBoxColumn c7IdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c7NomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c7TipoCategoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c7FKC1IDUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1UsuarioDataGridViewTextBoxColumn;
    }
}