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
            btn_recebimentos = new Button();
            btn_usuarios = new Button();
            panel_principal = new Panel();
            panel_menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_menu.BackColor = SystemColors.AppWorkspace;
            panel_menu.Controls.Add(btn_recebimentos);
            panel_menu.Controls.Add(btn_usuarios);
            panel_menu.Location = new Point(-3, 0);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(355, 816);
            panel_menu.TabIndex = 0;
            // 
            // btn_recebimentos
            // 
            btn_recebimentos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_recebimentos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_recebimentos.Location = new Point(15, 191);
            btn_recebimentos.Name = "btn_recebimentos";
            btn_recebimentos.Size = new Size(331, 72);
            btn_recebimentos.TabIndex = 1;
            btn_recebimentos.Text = "Recebimentos";
            btn_recebimentos.UseVisualStyleBackColor = true;
            btn_recebimentos.Click += btn_recebimentos_Click;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_usuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_usuarios.Location = new Point(15, 92);
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
            MaximizeBox = false;
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
        private Button btn_recebimentos;
    }
}
