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
            panel1 = new Panel();
            btn_usuarios = new Button();
            panel_principal = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(btn_usuarios);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 816);
            panel1.TabIndex = 0;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_usuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_usuarios.Location = new Point(15, 52);
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
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Fo_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            FormClosed += Fo_Principal_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_usuarios;
        public Panel panel_principal;
    }
}
