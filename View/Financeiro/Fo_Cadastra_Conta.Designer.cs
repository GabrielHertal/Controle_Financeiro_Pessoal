namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Cadastra_Conta
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
            panel1 = new Panel();
            btn_confirmar = new Button();
            cbx_tipo_conta = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txt_conta = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btn_confirmar);
            panel1.Controls.Add(cbx_tipo_conta);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_conta);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 218);
            panel1.TabIndex = 0;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_confirmar.Location = new Point(25, 137);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(312, 49);
            btn_confirmar.TabIndex = 5;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // cbx_tipo_conta
            // 
            cbx_tipo_conta.Font = new Font("Segoe UI", 10F);
            cbx_tipo_conta.FormattingEnabled = true;
            cbx_tipo_conta.Items.AddRange(new object[] { "Saldo Físico", "Saldo em Banco" });
            cbx_tipo_conta.Location = new Point(127, 94);
            cbx_tipo_conta.Name = "cbx_tipo_conta";
            cbx_tipo_conta.Size = new Size(210, 25);
            cbx_tipo_conta.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(25, 97);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 3;
            label3.Text = "Tipo Conta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 2;
            // 
            // txt_conta
            // 
            txt_conta.Font = new Font("Segoe UI", 10F);
            txt_conta.Location = new Point(127, 54);
            txt_conta.Name = "txt_conta";
            txt_conta.Size = new Size(210, 25);
            txt_conta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome Conta:";
            // 
            // Fo_Cadastra_Conta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 211);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Fo_Cadastra_Conta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Nova Conta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txt_conta;
        private Label label2;
        private Button btn_confirmar;
        private ComboBox cbx_tipo_conta;
        private Label label3;
    }
}