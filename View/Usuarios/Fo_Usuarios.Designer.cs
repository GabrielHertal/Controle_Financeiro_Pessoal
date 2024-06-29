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
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panel_usuarios = new Panel();
            btn_excluir = new Button();
            grid_usuarios = new DataGridView();
            c1UsuarioBindingSource = new BindingSource(components);
            c1IDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1NomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1CpfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1EmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            c1RendaMensalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btn_adicionar = new Button();
            panel_usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1UsuarioBindingSource).BeginInit();
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
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            grid_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            grid_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_usuarios.Columns.AddRange(new DataGridViewColumn[] { c1IDDataGridViewTextBoxColumn, c1NomeDataGridViewTextBoxColumn, c1CpfDataGridViewTextBoxColumn, c1EmailDataGridViewTextBoxColumn, c1RendaMensalDataGridViewTextBoxColumn });
            grid_usuarios.DataSource = c1UsuarioBindingSource;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            grid_usuarios.DefaultCellStyle = dataGridViewCellStyle16;
            grid_usuarios.Location = new Point(14, 83);
            grid_usuarios.MultiSelect = false;
            grid_usuarios.Name = "grid_usuarios";
            grid_usuarios.ReadOnly = true;
            grid_usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_usuarios.Size = new Size(1380, 710);
            grid_usuarios.TabIndex = 1;
            grid_usuarios.CellMouseDoubleClick += grid_usuarios_CellMouseDoubleClick;
            // 
            // c1UsuarioBindingSource
            // 
            c1UsuarioBindingSource.DataSource = typeof(Model.C1Usuario);
            // 
            // c1IDDataGridViewTextBoxColumn
            // 
            c1IDDataGridViewTextBoxColumn.DataPropertyName = "C1ID";
            c1IDDataGridViewTextBoxColumn.FillWeight = 2.5F;
            c1IDDataGridViewTextBoxColumn.HeaderText = "ID";
            c1IDDataGridViewTextBoxColumn.Name = "c1IDDataGridViewTextBoxColumn";
            c1IDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1NomeDataGridViewTextBoxColumn
            // 
            c1NomeDataGridViewTextBoxColumn.DataPropertyName = "C1Nome";
            c1NomeDataGridViewTextBoxColumn.FillWeight = 15.6903543F;
            c1NomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            c1NomeDataGridViewTextBoxColumn.Name = "c1NomeDataGridViewTextBoxColumn";
            c1NomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1CpfDataGridViewTextBoxColumn
            // 
            c1CpfDataGridViewTextBoxColumn.DataPropertyName = "C1Cpf";
            c1CpfDataGridViewTextBoxColumn.FillWeight = 7.690354F;
            c1CpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            c1CpfDataGridViewTextBoxColumn.Name = "c1CpfDataGridViewTextBoxColumn";
            c1CpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1EmailDataGridViewTextBoxColumn
            // 
            c1EmailDataGridViewTextBoxColumn.DataPropertyName = "C1Email";
            c1EmailDataGridViewTextBoxColumn.FillWeight = 12.6903543F;
            c1EmailDataGridViewTextBoxColumn.HeaderText = "E-MAIL";
            c1EmailDataGridViewTextBoxColumn.Name = "c1EmailDataGridViewTextBoxColumn";
            c1EmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c1RendaMensalDataGridViewTextBoxColumn
            // 
            c1RendaMensalDataGridViewTextBoxColumn.DataPropertyName = "C1Renda_Mensal";
            c1RendaMensalDataGridViewTextBoxColumn.FillWeight = 5.690354F;
            c1RendaMensalDataGridViewTextBoxColumn.HeaderText = "RENDA MENSAL";
            c1RendaMensalDataGridViewTextBoxColumn.Name = "c1RendaMensalDataGridViewTextBoxColumn";
            c1RendaMensalDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)c1UsuarioBindingSource).EndInit();
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
        private BindingSource c1UsuarioBindingSource;
        private Button btn_excluir;
        private DataGridViewTextBoxColumn c1IDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1NomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1CpfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1EmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn c1RendaMensalDataGridViewTextBoxColumn;
        private Button btn_adicionar;
    }
}