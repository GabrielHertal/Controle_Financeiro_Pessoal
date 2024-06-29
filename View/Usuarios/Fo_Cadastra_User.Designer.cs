namespace Controle_Financeiro_Pessoal.View
{
    partial class Fo_Cadastra_User
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
            txt_nome = new TextBox();
            label1 = new Label();
            btn_Cadastrar = new Button();
            label2 = new Label();
            txt_email = new TextBox();
            panel_cadastro_user = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txt_renda = new TextBox();
            label6 = new Label();
            txt_senha = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_confirm_senha = new TextBox();
            label3 = new Label();
            mastxt_cpf = new MaskedTextBox();
            panel_cadastro_user.SuspendLayout();
            SuspendLayout();
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_nome.Location = new Point(139, 34);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(228, 25);
            txt_nome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 1;
            label1.Text = "Nome - ";
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Cadastrar.Location = new Point(21, 228);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(346, 39);
            btn_Cadastrar.TabIndex = 6;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(21, 71);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 4;
            label2.Text = "E-Mail -";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_email.Location = new Point(139, 68);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(228, 25);
            txt_email.TabIndex = 1;
            // 
            // panel_cadastro_user
            // 
            panel_cadastro_user.BackColor = SystemColors.ActiveBorder;
            panel_cadastro_user.Controls.Add(label11);
            panel_cadastro_user.Controls.Add(label10);
            panel_cadastro_user.Controls.Add(label9);
            panel_cadastro_user.Controls.Add(label8);
            panel_cadastro_user.Controls.Add(label7);
            panel_cadastro_user.Controls.Add(txt_renda);
            panel_cadastro_user.Controls.Add(label6);
            panel_cadastro_user.Controls.Add(txt_senha);
            panel_cadastro_user.Controls.Add(label4);
            panel_cadastro_user.Controls.Add(label5);
            panel_cadastro_user.Controls.Add(txt_confirm_senha);
            panel_cadastro_user.Controls.Add(label3);
            panel_cadastro_user.Controls.Add(mastxt_cpf);
            panel_cadastro_user.Controls.Add(txt_nome);
            panel_cadastro_user.Controls.Add(label2);
            panel_cadastro_user.Controls.Add(label1);
            panel_cadastro_user.Controls.Add(txt_email);
            panel_cadastro_user.Controls.Add(btn_Cadastrar);
            panel_cadastro_user.Location = new Point(-4, -3);
            panel_cadastro_user.Name = "panel_cadastro_user";
            panel_cadastro_user.Size = new Size(403, 281);
            panel_cadastro_user.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ControlLightLight;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(355, 175);
            label11.Name = "label11";
            label11.Size = new Size(12, 15);
            label11.TabIndex = 16;
            label11.Text = "*";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ControlLightLight;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(355, 204);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 16;
            label10.Text = "*";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ControlLightLight;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(355, 143);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 15;
            label9.Text = "*";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlLightLight;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(355, 73);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 14;
            label8.Text = "*";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ControlLightLight;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(355, 39);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 13;
            label7.Text = "*";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_renda
            // 
            txt_renda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_renda.Location = new Point(139, 137);
            txt_renda.Name = "txt_renda";
            txt_renda.Size = new Size(228, 25);
            txt_renda.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(21, 141);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 12;
            label6.Text = "Renda Mensal -";
            // 
            // txt_senha
            // 
            txt_senha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_senha.Location = new Point(139, 169);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(228, 25);
            txt_senha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(21, 202);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 10;
            label4.Text = "Conf. Senha -";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(21, 173);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 8;
            label5.Text = "Senha - ";
            // 
            // txt_confirm_senha
            // 
            txt_confirm_senha.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txt_confirm_senha.Location = new Point(139, 198);
            txt_confirm_senha.Name = "txt_confirm_senha";
            txt_confirm_senha.PasswordChar = '*';
            txt_confirm_senha.Size = new Size(228, 25);
            txt_confirm_senha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(21, 105);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 6;
            label3.Text = "CPF -";
            // 
            // mastxt_cpf
            // 
            mastxt_cpf.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            mastxt_cpf.Location = new Point(139, 104);
            mastxt_cpf.Mask = "000,000,000-00";
            mastxt_cpf.Name = "mastxt_cpf";
            mastxt_cpf.Size = new Size(228, 25);
            mastxt_cpf.TabIndex = 2;
            // 
            // Fo_Cadastra_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 276);
            Controls.Add(panel_cadastro_user);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MaximizeBox = false;
            Name = "Fo_Cadastra_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuário";
            FormClosed += Fo_Cadastra_User_FormClosed;
            panel_cadastro_user.ResumeLayout(false);
            panel_cadastro_user.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_nome;
        private Label label1;
        private Button btn_Cadastrar;
        private Label label2;
        private TextBox txt_email;
        private Panel panel_cadastro_user;
        private TextBox txt_senha;
        private Label label4;
        private Label label5;
        private TextBox txt_confirm_senha;
        private Label label3;
        private MaskedTextBox mastxt_cpf;
        private TextBox txt_renda;
        private Label label6;
        private Label label7;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}