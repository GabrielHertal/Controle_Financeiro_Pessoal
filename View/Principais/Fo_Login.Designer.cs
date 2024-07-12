namespace Controle_Financeiro_Pessoal.View
{
    partial class Fo_Login
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
            txt_email = new TextBox();
            txt_senha = new TextBox();
            label1 = new Label();
            btn_entrar = new Button();
            linklbl_cadastrar = new LinkLabel();
            label2 = new Label();
            panel_login = new Panel();
            panel_login.SuspendLayout();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.Location = new Point(94, 29);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(284, 23);
            txt_email.TabIndex = 0;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(94, 74);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(284, 23);
            txt_senha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 2;
            label1.Text = "E-mail -";
            // 
            // btn_entrar
            // 
            btn_entrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_entrar.Location = new Point(265, 103);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(113, 30);
            btn_entrar.TabIndex = 2;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // linklbl_cadastrar
            // 
            linklbl_cadastrar.AutoSize = true;
            linklbl_cadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            linklbl_cadastrar.Location = new Point(94, 103);
            linklbl_cadastrar.Name = "linklbl_cadastrar";
            linklbl_cadastrar.Size = new Size(165, 19);
            linklbl_cadastrar.TabIndex = 3;
            linklbl_cadastrar.TabStop = true;
            linklbl_cadastrar.Text = "Cadastrar novo usuário";
            linklbl_cadastrar.LinkClicked += linklbl_cadastrar_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(27, 75);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 5;
            label2.Text = "Senha - ";
            // 
            // panel_login
            // 
            panel_login.BackColor = SystemColors.ControlDark;
            panel_login.Controls.Add(txt_senha);
            panel_login.Controls.Add(label2);
            panel_login.Controls.Add(txt_email);
            panel_login.Controls.Add(linklbl_cadastrar);
            panel_login.Controls.Add(label1);
            panel_login.Controls.Add(btn_entrar);
            panel_login.Location = new Point(-3, -2);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(411, 156);
            panel_login.TabIndex = 6;
            // 
            // Fo_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 153);
            Controls.Add(panel_login);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Fo_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Fo_Login_FormClosed;
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_email;
        private TextBox txt_senha;
        private Label label1;
        private Button btn_entrar;
        private LinkLabel linklbl_cadastrar;
        private Label label2;
        private Panel panel_login;
    }
}