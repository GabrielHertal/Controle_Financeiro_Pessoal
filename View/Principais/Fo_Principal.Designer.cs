namespace Controle_Financeiro_Pessoal
{
    partial class Fo_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_menu = new Panel();
            btn_lancamentos = new Button();
            btn_contas = new Button();
            btn_usuarios = new Button();
            panel_principal = new Panel();
            panel_menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_menu.BackColor = SystemColors.AppWorkspace;
            panel_menu.Controls.Add(btn_lancamentos);
            panel_menu.Controls.Add(btn_contas);
            panel_menu.Controls.Add(btn_usuarios);
            panel_menu.Location = new Point(-3, 0);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(355, 816);
            panel_menu.TabIndex = 0;
            // 
            // btn_lancamentos
            // 
            btn_lancamentos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_lancamentos.Location = new Point(15, 124);
            btn_lancamentos.Name = "btn_lancamentos";
            btn_lancamentos.Size = new Size(331, 72);
            btn_lancamentos.TabIndex = 3;
            btn_lancamentos.Text = "Lançamentos";
            btn_lancamentos.UseVisualStyleBackColor = true;
            btn_lancamentos.Click += btn_lancamentos_Click;
            // 
            // btn_contas
            // 
            btn_contas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_contas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_contas.Location = new Point(15, 280);
            btn_contas.Name = "btn_contas";
            btn_contas.Size = new Size(331, 72);
            btn_contas.TabIndex = 2;
            btn_contas.Text = "Contas";
            btn_contas.UseVisualStyleBackColor = true;
            btn_contas.Click += btn_contas_Click;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_usuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_usuarios.Location = new Point(15, 202);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Size = new Size(331, 72);
            btn_usuarios.TabIndex = 0;
            btn_usuarios.Text = "Usuários";
            btn_usuarios.UseVisualStyleBackColor = true;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // panel_principal
            // 
            panel_principal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_principal.BackColor = SystemColors.ActiveCaption;
            panel_principal.Location = new Point(349, 0);
            panel_principal.Name = "panel_principal";
            panel_principal.Size = new Size(1045, 816);
            panel_principal.TabIndex = 1;
            // 
            // Fo_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1393, 813);
            Controls.Add(panel_principal);
            Controls.Add(panel_menu);
            Name = "Fo_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            FormClosed += Fo_Principal_FormClosed;
            panel_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_menu;
        private Button btn_usuarios;
        public Panel panel_principal;
        private Button btn_contas;
        private Button btn_lancamentos;
    }
}
