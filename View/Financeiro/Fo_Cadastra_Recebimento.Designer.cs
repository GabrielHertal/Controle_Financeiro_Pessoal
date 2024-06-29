namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Cadastra_Recebimento
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
            btn_cadastrar = new Button();
            label3 = new Label();
            txt_valor_lancamento = new TextBox();
            label2 = new Label();
            dtp_lancamento = new DateTimePicker();
            txt_titulo_lancamento = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btn_cadastrar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_valor_lancamento);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtp_lancamento);
            panel1.Controls.Add(txt_titulo_lancamento);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 234);
            panel1.TabIndex = 0;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_cadastrar.Location = new Point(30, 163);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(326, 36);
            btn_cadastrar.TabIndex = 7;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(30, 123);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 6;
            label3.Text = "Data Lançamento:";
            // 
            // txt_valor_lancamento
            // 
            txt_valor_lancamento.Font = new Font("Segoe UI", 10F);
            txt_valor_lancamento.Location = new Point(172, 91);
            txt_valor_lancamento.Name = "txt_valor_lancamento";
            txt_valor_lancamento.Size = new Size(184, 25);
            txt_valor_lancamento.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 4;
            label2.Text = "Valor Lançamento:";
            // 
            // dtp_lancamento
            // 
            dtp_lancamento.Font = new Font("Segoe UI", 10F);
            dtp_lancamento.Format = DateTimePickerFormat.Short;
            dtp_lancamento.Location = new Point(172, 120);
            dtp_lancamento.Name = "dtp_lancamento";
            dtp_lancamento.Size = new Size(184, 25);
            dtp_lancamento.TabIndex = 3;
            // 
            // txt_titulo_lancamento
            // 
            txt_titulo_lancamento.Font = new Font("Segoe UI", 10F);
            txt_titulo_lancamento.Location = new Point(172, 55);
            txt_titulo_lancamento.Name = "txt_titulo_lancamento";
            txt_titulo_lancamento.Size = new Size(184, 25);
            txt_titulo_lancamento.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(30, 55);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 1;
            label1.Text = "Título Lançamento:";
            // 
            // Fo_Cadastra_Recebimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 228);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Fo_Cadastra_Recebimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Recebimento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtp_lancamento;
        private TextBox txt_titulo_lancamento;
        private Label label1;
        private Label label3;
        private TextBox txt_valor_lancamento;
        private Label label2;
        private Button btn_cadastrar;
    }
}