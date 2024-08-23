namespace Controle_Financeiro_Pessoal.View
{
    partial class Fo_Usuarios
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
            panel_usuarios = new Panel();
            btn_adicionar = new Button();
            btn_excluir = new Button();
            grid_usuarios = new DataGridView();
            c1UsuarioDTOBindingSource = new BindingSource(components);
            c1IDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1NomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1CPFDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1EmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1RendaMensalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1UsuarioDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_usuarios
            // 
            panel_usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_usuarios.AutoSize = true;
            panel_usuarios.BackColor = SystemColors.ControlDarkDark;
            panel_usuarios.Controls.Add(btn_adicionar);
            panel_usuarios.Controls.Add(btn_excluir);
            panel_usuarios.Controls.Add(grid_usuarios);
            panel_usuarios.Location = new Point(-2, -4);
            panel_usuarios.Name = "panel_usuarios";
            panel_usuarios.Size = new Size(1409, 811);
            panel_usuarios.TabIndex = 0;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Image = Properties.Resources.mais;
            btn_adicionar.Location = new Point(14, 20);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(70, 60);
            btn_adicionar.TabIndex = 3;
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_excluir.Image = Properties.Resources.lixo;
            btn_excluir.Location = new Point(1326, 20);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(70, 60);
            btn_excluir.TabIndex = 2;
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // grid_usuarios
            // 
            grid_usuarios.AllowUserToAddRows = false;
            grid_usuarios.AllowUserToDeleteRows = false;
            grid_usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_usuarios.AutoGenerateColumns = false;
            grid_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_usuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_usuarios.Columns.AddRange(new DataGridViewColumn[] { c1IDDataGridViewTextBoxColumn, c1NomeDataGridViewTextBoxColumn, c1CPFDataGridViewTextBoxColumn, c1EmailDataGridViewTextBoxColumn, c1RendaMensalDataGridViewTextBoxColumn });
            grid_usuarios.DataSource = c1UsuarioDTOBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grid_usuarios.DefaultCellStyle = dataGridViewCellStyle2;
            grid_usuarios.Location = new Point(16, 83);
            grid_usuarios.MultiSelect = false;
            grid_usuarios.Name = "grid_usuarios";
            grid_usuarios.ReadOnly = true;
            grid_usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_usuarios.Size = new Size(1380, 710);
            grid_usuarios.TabIndex = 1;
            grid_usuarios.CellMouseDoubleClick += grid_usuarios_CellMouseDoubleClick;
            // 
            // c1UsuarioDTOBindingSource
            // 
            c1UsuarioDTOBindingSource.DataSource = typeof(DTO.C1UsuarioDTO);
            // 
            // c1IDDataGridViewTextBoxColumn
            // 
            c1IDDataGridViewTextBoxColumn.DataPropertyName = "C1ID";
            c1IDDataGridViewTextBoxColumn.FillWeight = 20F;
            c1IDDataGridViewTextBoxColumn.HeaderText = "ID";
            c1IDDataGridViewTextBoxColumn.Name = "c1IDDataGridViewTextBoxColumn";
            c1IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1NomeDataGridViewTextBoxColumn
            // 
            c1NomeDataGridViewTextBoxColumn.DataPropertyName = "C1Nome";
            c1NomeDataGridViewTextBoxColumn.FillWeight = 120F;
            c1NomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            c1NomeDataGridViewTextBoxColumn.Name = "c1NomeDataGridViewTextBoxColumn";
            c1NomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1CPFDataGridViewTextBoxColumn
            // 
            c1CPFDataGridViewTextBoxColumn.DataPropertyName = "C1CPF";
            c1CPFDataGridViewTextBoxColumn.FillWeight = 60F;
            c1CPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            c1CPFDataGridViewTextBoxColumn.Name = "c1CPFDataGridViewTextBoxColumn";
            c1CPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1EmailDataGridViewTextBoxColumn
            // 
            c1EmailDataGridViewTextBoxColumn.DataPropertyName = "C1Email";
            c1EmailDataGridViewTextBoxColumn.FillWeight = 80F;
            c1EmailDataGridViewTextBoxColumn.HeaderText = "E-MAIL";
            c1EmailDataGridViewTextBoxColumn.Name = "c1EmailDataGridViewTextBoxColumn";
            c1EmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1RendaMensalDataGridViewTextBoxColumn
            // 
            c1RendaMensalDataGridViewTextBoxColumn.DataPropertyName = "C1RendaMensal";
            c1RendaMensalDataGridViewTextBoxColumn.FillWeight = 70F;
            c1RendaMensalDataGridViewTextBoxColumn.HeaderText = "RENDA MENSAL";
            c1RendaMensalDataGridViewTextBoxColumn.Name = "c1RendaMensalDataGridViewTextBoxColumn";
            c1RendaMensalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Fo_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1404, 801);
            Controls.Add(panel_usuarios);
            MaximizeBox = false;
            Name = "Fo_Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fo_Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += Fo_Usuarios_Load;
            panel_usuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1UsuarioDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Panel panel_usuarios;
        private ColumnHeader C1ID;
        private ColumnHeader C1Nome;
        private ColumnHeader C1Email;
        private ColumnHeader C1Renda_Mensal;
        public ListView lv_usuarios;
        private DataGridView grid_usuarios;
        private Button btn_excluir;
        private Button btn_adicionar;
        private BindingSource c1UsuarioDTOBindingSource;
        private DataGridViewTextBoxColumn c1IDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1NomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1CPFDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1EmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1RendaMensalDataGridViewTextBoxColumn;
    }
}