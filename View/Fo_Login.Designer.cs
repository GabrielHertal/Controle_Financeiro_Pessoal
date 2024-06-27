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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.Location = new Point(96, 32);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(252, 23);
            txt_email.TabIndex = 0;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(96, 73);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(252, 23);
            txt_senha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 35);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "E-mail";
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(235, 102);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(113, 23);
            btn_entrar.TabIndex = 2;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // linklbl_cadastrar
            // 
            linklbl_cadastrar.AutoSize = true;
            linklbl_cadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            linklbl_cadastrar.Location = new Point(96, 102);
            linklbl_cadastrar.Name = "linklbl_cadastrar";
            linklbl_cadastrar.Size = new Size(133, 15);
            linklbl_cadastrar.TabIndex = 3;
            linklbl_cadastrar.TabStop = true;
            linklbl_cadastrar.Text = "Cadastrar novo usuário";
            linklbl_cadastrar.LinkClicked += linklbl_cadastrar_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 76);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(txt_senha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(linklbl_cadastrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_entrar);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 156);
            panel1.TabIndex = 6;
            // 
            // Fo_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 153);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Fo_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Fo_Login_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_email;
        private TextBox txt_senha;
        private Label label1;
        private Button btn_entrar;
        private LinkLabel linklbl_cadastrar;
        private Label label2;
        private Panel panel1;
    }
}