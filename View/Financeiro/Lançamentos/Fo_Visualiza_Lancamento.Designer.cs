namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Visualiza_Lancamento
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
            txt_titulo_lancamento = new TextBox();
            label1 = new Label();
            rtxt_observacao = new RichTextBox();
            btn_editar = new Button();
            btn_realizar = new Button();
            btn_cancelar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            txt_categoria = new TextBox();
            btn_estornar = new Button();
            txt_data_pag = new TextBox();
            txt_data_prev_pag = new TextBox();
            txt_valor = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txt_moeda = new TextBox();
            label2 = new Label();
            txt_conta = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_titulo_lancamento
            // 
            txt_titulo_lancamento.Enabled = false;
            txt_titulo_lancamento.Font = new Font("Segoe UI", 10F);
            txt_titulo_lancamento.Location = new Point(14, 35);
            txt_titulo_lancamento.Name = "txt_titulo_lancamento";
            txt_titulo_lancamento.Size = new Size(211, 25);
            txt_titulo_lancamento.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 1;
            label1.Text = "Título ";
            // 
            // rtxt_observacao
            // 
            rtxt_observacao.Enabled = false;
            rtxt_observacao.Location = new Point(14, 119);
            rtxt_observacao.Name = "rtxt_observacao";
            rtxt_observacao.Size = new Size(475, 96);
            rtxt_observacao.TabIndex = 2;
            rtxt_observacao.Text = "";
            // 
            // btn_editar
            // 
            btn_editar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_editar.Location = new Point(402, 221);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(87, 35);
            btn_editar.TabIndex = 3;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_realizar
            // 
            btn_realizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_realizar.Location = new Point(305, 221);
            btn_realizar.Name = "btn_realizar";
            btn_realizar.Size = new Size(91, 35);
            btn_realizar.TabIndex = 4;
            btn_realizar.Text = "Realizar";
            btn_realizar.UseVisualStyleBackColor = true;
            btn_realizar.Click += btn_realizar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_cancelar.Location = new Point(14, 221);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(91, 35);
            btn_cancelar.TabIndex = 5;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_categoria);
            panel1.Controls.Add(btn_estornar);
            panel1.Controls.Add(txt_data_pag);
            panel1.Controls.Add(txt_data_prev_pag);
            panel1.Controls.Add(txt_valor);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_moeda);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_conta);
            panel1.Controls.Add(btn_realizar);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(txt_titulo_lancamento);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(rtxt_observacao);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 270);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(375, 13);
            label4.Name = "label4";
            label4.Size = new Size(75, 19);
            label4.TabIndex = 23;
            label4.Text = "Categoria";
            // 
            // txt_categoria
            // 
            txt_categoria.Enabled = false;
            txt_categoria.Font = new Font("Segoe UI", 10F);
            txt_categoria.Location = new Point(375, 35);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(114, 25);
            txt_categoria.TabIndex = 22;
            // 
            // btn_estornar
            // 
            btn_estornar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_estornar.Location = new Point(208, 221);
            btn_estornar.Name = "btn_estornar";
            btn_estornar.Size = new Size(91, 35);
            btn_estornar.TabIndex = 21;
            btn_estornar.Text = "Estornar";
            btn_estornar.UseVisualStyleBackColor = true;
            btn_estornar.Click += btn_estornar_Click;
            // 
            // txt_data_pag
            // 
            txt_data_pag.Enabled = false;
            txt_data_pag.Font = new Font("Segoe UI", 10F);
            txt_data_pag.Location = new Point(363, 90);
            txt_data_pag.Name = "txt_data_pag";
            txt_data_pag.Size = new Size(126, 25);
            txt_data_pag.TabIndex = 20;
            // 
            // txt_data_prev_pag
            // 
            txt_data_prev_pag.Enabled = false;
            txt_data_prev_pag.Font = new Font("Segoe UI", 10F);
            txt_data_prev_pag.Location = new Point(231, 90);
            txt_data_prev_pag.Name = "txt_data_prev_pag";
            txt_data_prev_pag.Size = new Size(125, 25);
            txt_data_prev_pag.TabIndex = 19;
            // 
            // txt_valor
            // 
            txt_valor.Enabled = false;
            txt_valor.Font = new Font("Segoe UI", 10F);
            txt_valor.Location = new Point(15, 90);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(79, 25);
            txt_valor.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(14, 68);
            label7.Name = "label7";
            label7.Size = new Size(44, 19);
            label7.TabIndex = 16;
            label7.Text = "Valor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(363, 68);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 15;
            label6.Text = "Data Pagamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(231, 68);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 13;
            label5.Text = "Data Previa Pag.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(100, 68);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 9;
            label3.Text = "Moeda";
            // 
            // txt_moeda
            // 
            txt_moeda.Enabled = false;
            txt_moeda.Font = new Font("Segoe UI", 10F);
            txt_moeda.Location = new Point(100, 90);
            txt_moeda.Name = "txt_moeda";
            txt_moeda.Size = new Size(125, 25);
            txt_moeda.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(231, 13);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 7;
            label2.Text = "Conta";
            // 
            // txt_conta
            // 
            txt_conta.Enabled = false;
            txt_conta.Font = new Font("Segoe UI", 10F);
            txt_conta.Location = new Point(231, 35);
            txt_conta.Name = "txt_conta";
            txt_conta.Size = new Size(138, 25);
            txt_conta.TabIndex = 6;
            // 
            // Fo_Visualiza_Lancamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 261);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fo_Visualiza_Lancamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar Lançamento";
            Load += Fo_Confirma_Pagamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_titulo_lancamento;
        private Label label1;
        private RichTextBox rtxt_observacao;
        private Button btn_editar;
        private Button btn_realizar;
        private Button btn_cancelar;
        private Panel panel1;
        private Label label3;
        private TextBox txt_moeda;
        private Label label2;
        private TextBox txt_conta;
        private Label label6;
        private Label label5;
        private TextBox txt_valor;
        private Label label7;
        private TextBox txt_data_pag;
        private TextBox txt_data_prev_pag;
        private Button btn_estornar;
        private Label label4;
        private TextBox txt_categoria;
    }
}