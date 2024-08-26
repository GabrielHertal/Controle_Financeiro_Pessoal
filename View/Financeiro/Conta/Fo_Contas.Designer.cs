namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Contas
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
            panel_contas = new Panel();
            btn_adicionar = new Button();
            btn_excluir = new Button();
            grid_contas = new DataGridView();
            c6ContaDTOBindingSource = new BindingSource(components);
            c6IDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c6NomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c6SaldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel_contas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_contas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c6ContaDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_contas
            // 
            panel_contas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_contas.BackColor = SystemColors.ControlDarkDark;
            panel_contas.Controls.Add(btn_adicionar);
            panel_contas.Controls.Add(btn_excluir);
            panel_contas.Controls.Add(grid_contas);
            panel_contas.Location = new Point(-4, -4);
            panel_contas.Name = "panel_contas";
            panel_contas.Size = new Size(1413, 809);
            panel_contas.TabIndex = 0;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Image = Properties.Resources.mais;
            btn_adicionar.Location = new Point(16, 16);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(70, 60);
            btn_adicionar.TabIndex = 5;
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_excluir.Image = Properties.Resources.lixo;
            btn_excluir.Location = new Point(1326, 16);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(70, 60);
            btn_excluir.TabIndex = 4;
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // grid_contas
            // 
            grid_contas.AllowUserToAddRows = false;
            grid_contas.AllowUserToDeleteRows = false;
            grid_contas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_contas.AutoGenerateColumns = false;
            grid_contas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid_contas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_contas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_contas.Columns.AddRange(new DataGridViewColumn[] { c6IDDataGridViewTextBoxColumn, c6NomeDataGridViewTextBoxColumn, c6SaldoDataGridViewTextBoxColumn });
            grid_contas.DataSource = c6ContaDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grid_contas.DefaultCellStyle = dataGridViewCellStyle2;
            grid_contas.Location = new Point(16, 82);
            grid_contas.MultiSelect = false;
            grid_contas.Name = "grid_contas";
            grid_contas.ReadOnly = true;
            grid_contas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_contas.Size = new Size(1380, 710);
            grid_contas.TabIndex = 3;
            grid_contas.CellMouseDoubleClick += grid_recebimentos_CellMouseDoubleClick;
            // 
            // c6ContaDTOBindingSource
            // 
            c6ContaDTOBindingSource.DataSource = typeof(DTO.C6ContaDTO);
            // 
            // c6IDDataGridViewTextBoxColumn
            // 
            c6IDDataGridViewTextBoxColumn.DataPropertyName = "C6ID";
            c6IDDataGridViewTextBoxColumn.HeaderText = "ID";
            c6IDDataGridViewTextBoxColumn.Name = "c6IDDataGridViewTextBoxColumn";
            c6IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c6NomeDataGridViewTextBoxColumn
            // 
            c6NomeDataGridViewTextBoxColumn.DataPropertyName = "C6Nome";
            c6NomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            c6NomeDataGridViewTextBoxColumn.Name = "c6NomeDataGridViewTextBoxColumn";
            c6NomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c6SaldoDataGridViewTextBoxColumn
            // 
            c6SaldoDataGridViewTextBoxColumn.DataPropertyName = "C6Saldo";
            c6SaldoDataGridViewTextBoxColumn.HeaderText = "SALDO";
            c6SaldoDataGridViewTextBoxColumn.Name = "c6SaldoDataGridViewTextBoxColumn";
            c6SaldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Fo_Contas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 801);
            Controls.Add(panel_contas);
            Name = "Fo_Contas";
            Text = "Fo_Contas";
            WindowState = FormWindowState.Maximized;
            Load += Fo_Contas_Load;
            panel_contas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_contas).EndInit();
            ((System.ComponentModel.ISupportInitialize)c6ContaDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_contas;
        private Button btn_adicionar;
        private Button btn_excluir;
        private DataGridView grid_contas;
        private BindingSource c6ContaDTOBindingSource;
        private DataGridViewTextBoxColumn c6IDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c6NomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c6SaldoDataGridViewTextBoxColumn;
    }
}