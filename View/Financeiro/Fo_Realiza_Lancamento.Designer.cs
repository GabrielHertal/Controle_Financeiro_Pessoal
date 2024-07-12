namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Realiza_Lancamento
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
            panel_lancamento = new Panel();
            btn_pago = new Button();
            label8 = new Label();
            cbx_parcelas = new ComboBox();
            label7 = new Label();
            Rtx_observacao = new RichTextBox();
            btn_confirmar = new Button();
            btn_cancelar = new Button();
            cbx_moeda = new ComboBox();
            c4MoedaBindingSource = new BindingSource(components);
            label6 = new Label();
            label5 = new Label();
            cbx_conta = new ComboBox();
            c6ContaBindingSource = new BindingSource(components);
            label4 = new Label();
            label3 = new Label();
            dtp_prev_pagamento = new DateTimePicker();
            dtp_pagamento = new DateTimePicker();
            txt_valor = new TextBox();
            label2 = new Label();
            txt_titulo_lancamento = new TextBox();
            label1 = new Label();
            panel_lancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c4MoedaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c6ContaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_lancamento
            // 
            panel_lancamento.BackColor = SystemColors.ControlDark;
            panel_lancamento.Controls.Add(btn_pago);
            panel_lancamento.Controls.Add(label8);
            panel_lancamento.Controls.Add(cbx_parcelas);
            panel_lancamento.Controls.Add(label7);
            panel_lancamento.Controls.Add(Rtx_observacao);
            panel_lancamento.Controls.Add(btn_confirmar);
            panel_lancamento.Controls.Add(btn_cancelar);
            panel_lancamento.Controls.Add(cbx_moeda);
            panel_lancamento.Controls.Add(label6);
            panel_lancamento.Controls.Add(label5);
            panel_lancamento.Controls.Add(cbx_conta);
            panel_lancamento.Controls.Add(label4);
            panel_lancamento.Controls.Add(label3);
            panel_lancamento.Controls.Add(dtp_prev_pagamento);
            panel_lancamento.Controls.Add(dtp_pagamento);
            panel_lancamento.Controls.Add(txt_valor);
            panel_lancamento.Controls.Add(label2);
            panel_lancamento.Controls.Add(txt_titulo_lancamento);
            panel_lancamento.Controls.Add(label1);
            panel_lancamento.Location = new Point(-4, -5);
            panel_lancamento.Name = "panel_lancamento";
            panel_lancamento.Size = new Size(544, 371);
            panel_lancamento.TabIndex = 0;
            // 
            // btn_pago
            // 
            btn_pago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_pago.Location = new Point(185, 313);
            btn_pago.Name = "btn_pago";
            btn_pago.Size = new Size(171, 41);
            btn_pago.TabIndex = 18;
            btn_pago.Text = "Pago";
            btn_pago.UseVisualStyleBackColor = true;
            btn_pago.Click += btn_pago_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(362, 245);
            label8.Name = "label8";
            label8.Size = new Size(102, 19);
            label8.TabIndex = 17;
            label8.Text = "Qtd. Parcelas:";
            label8.Visible = false;
            // 
            // cbx_parcelas
            // 
            cbx_parcelas.Font = new Font("Segoe UI", 10F);
            cbx_parcelas.Items.AddRange(new object[] { "" });
            cbx_parcelas.Location = new Point(365, 267);
            cbx_parcelas.Name = "cbx_parcelas";
            cbx_parcelas.Size = new Size(165, 25);
            cbx_parcelas.TabIndex = 16;
            cbx_parcelas.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(14, 67);
            label7.Name = "label7";
            label7.Size = new Size(179, 19);
            label7.TabIndex = 15;
            label7.Text = "Observação Lançamento:";
            // 
            // Rtx_observacao
            // 
            Rtx_observacao.Location = new Point(14, 89);
            Rtx_observacao.Name = "Rtx_observacao";
            Rtx_observacao.Size = new Size(513, 96);
            Rtx_observacao.TabIndex = 14;
            Rtx_observacao.Text = "";
            // 
            // btn_confirmar
            // 
            btn_confirmar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_confirmar.Location = new Point(365, 313);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(165, 41);
            btn_confirmar.TabIndex = 13;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_cancelar.Location = new Point(12, 313);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(167, 41);
            btn_cancelar.TabIndex = 12;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cbx_moeda
            // 
            cbx_moeda.DataSource = c4MoedaBindingSource;
            cbx_moeda.DisplayMember = "C4Nome_Moeda";
            cbx_moeda.Font = new Font("Segoe UI", 10F);
            cbx_moeda.FormattingEnabled = true;
            cbx_moeda.Location = new Point(12, 267);
            cbx_moeda.Name = "cbx_moeda";
            cbx_moeda.Size = new Size(167, 25);
            cbx_moeda.TabIndex = 11;
            cbx_moeda.ValueMember = "C4ID";
            cbx_moeda.SelectedIndexChanged += cbx_moeda_SelectedIndexChanged;
            // 
            // c4MoedaBindingSource
            // 
            c4MoedaBindingSource.DataSource = typeof(Model.C4Moeda);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(14, 245);
            label6.Name = "label6";
            label6.Size = new Size(60, 19);
            label6.TabIndex = 10;
            label6.Text = "Moeda:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(362, 192);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 9;
            label5.Text = "Conta:";
            // 
            // cbx_conta
            // 
            cbx_conta.DataSource = c6ContaBindingSource;
            cbx_conta.DisplayMember = "C6Nome";
            cbx_conta.Font = new Font("Segoe UI", 10F);
            cbx_conta.FormattingEnabled = true;
            cbx_conta.Location = new Point(362, 217);
            cbx_conta.Name = "cbx_conta";
            cbx_conta.Size = new Size(168, 25);
            cbx_conta.TabIndex = 8;
            cbx_conta.ValueMember = "C6Id";
            // 
            // c6ContaBindingSource
            // 
            c6ContaBindingSource.DataSource = typeof(Model.C6Conta);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(185, 195);
            label4.Name = "label4";
            label4.Size = new Size(125, 19);
            label4.TabIndex = 7;
            label4.Text = "Data Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 6;
            label3.Text = "Data Prev. Pag:";
            // 
            // dtp_prev_pagamento
            // 
            dtp_prev_pagamento.Font = new Font("Segoe UI", 10F);
            dtp_prev_pagamento.Format = DateTimePickerFormat.Short;
            dtp_prev_pagamento.Location = new Point(14, 214);
            dtp_prev_pagamento.Name = "dtp_prev_pagamento";
            dtp_prev_pagamento.Size = new Size(165, 25);
            dtp_prev_pagamento.TabIndex = 5;
            // 
            // dtp_pagamento
            // 
            dtp_pagamento.Font = new Font("Segoe UI", 10F);
            dtp_pagamento.Format = DateTimePickerFormat.Short;
            dtp_pagamento.Location = new Point(185, 217);
            dtp_pagamento.Name = "dtp_pagamento";
            dtp_pagamento.Size = new Size(171, 25);
            dtp_pagamento.TabIndex = 4;
            // 
            // txt_valor
            // 
            txt_valor.Font = new Font("Segoe UI", 10F);
            txt_valor.Location = new Point(185, 267);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(171, 25);
            txt_valor.TabIndex = 3;
            txt_valor.TextChanged += txt_valor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(185, 245);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // txt_titulo_lancamento
            // 
            txt_titulo_lancamento.Font = new Font("Segoe UI", 10F);
            txt_titulo_lancamento.Location = new Point(14, 36);
            txt_titulo_lancamento.Name = "txt_titulo_lancamento";
            txt_titulo_lancamento.Size = new Size(513, 25);
            txt_titulo_lancamento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 0;
            label1.Text = "Titulo Lançamento:";
            // 
            // Fo_Realiza_Lancamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 361);
            Controls.Add(panel_lancamento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fo_Realiza_Lancamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lançamento - À Pagar";
            Load += Fo_Realiza_Lancamento_Load;
            panel_lancamento.ResumeLayout(false);
            panel_lancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c4MoedaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)c6ContaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_lancamento;
        private DateTimePicker dtp_pagamento;
        private TextBox txt_valor;
        private Label label2;
        private TextBox txt_titulo_lancamento;
        private Label label1;
        private ComboBox cbx_moeda;
        private Label label6;
        private Label label5;
        private ComboBox cbx_conta;
        private Label label4;
        private Label label3;
        private DateTimePicker dtp_prev_pagamento;
        private Button btn_confirmar;
        private Button btn_cancelar;
        private Label label7;
        private RichTextBox Rtx_observacao;
        private Label label8;
        private ComboBox cbx_parcelas;
        private Button btn_pago;
        private BindingSource c4MoedaBindingSource;
        private BindingSource c6ContaBindingSource;
    }
}