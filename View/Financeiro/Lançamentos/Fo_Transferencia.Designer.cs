namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Transferencia
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
            panel1 = new Panel();
            label7 = new Label();
            Rtxt_observacao = new RichTextBox();
            label6 = new Label();
            txt_titulo = new TextBox();
            label5 = new Label();
            dtp_pag = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_confirma = new Button();
            btn_pago = new Button();
            btn_cancelar = new Button();
            label1 = new Label();
            dtp_prev_pag = new DateTimePicker();
            txt_valor = new TextBox();
            cbx_destino = new ComboBox();
            c6ContaBindingSource = new BindingSource(components);
            cbx_conta_origem = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c6ContaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Rtxt_observacao);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_titulo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtp_pag);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_confirma);
            panel1.Controls.Add(btn_pago);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtp_prev_pag);
            panel1.Controls.Add(txt_valor);
            panel1.Controls.Add(cbx_destino);
            panel1.Controls.Add(cbx_conta_origem);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 402);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(15, 121);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 16;
            label7.Text = "Observação";
            // 
            // Rtxt_observacao
            // 
            Rtxt_observacao.Location = new Point(12, 143);
            Rtxt_observacao.Name = "Rtxt_observacao";
            Rtxt_observacao.Size = new Size(378, 78);
            Rtxt_observacao.TabIndex = 15;
            Rtxt_observacao.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(12, 62);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 13;
            label6.Text = "Título";
            // 
            // txt_titulo
            // 
            txt_titulo.Font = new Font("Segoe UI", 10F);
            txt_titulo.Location = new Point(13, 84);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(377, 25);
            txt_titulo.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(276, 234);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 11;
            label5.Text = "Data Pag.";
            // 
            // dtp_pag
            // 
            dtp_pag.Font = new Font("Segoe UI", 10F);
            dtp_pag.Format = DateTimePickerFormat.Short;
            dtp_pag.Location = new Point(276, 256);
            dtp_pag.Name = "dtp_pag";
            dtp_pag.Size = new Size(114, 25);
            dtp_pag.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(12, 290);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 9;
            label4.Text = "Conta Destino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(158, 234);
            label3.Name = "label3";
            label3.Size = new Size(112, 19);
            label3.TabIndex = 8;
            label3.Text = "Data Prev. Pag.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(13, 234);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 7;
            label2.Text = "Valor:";
            // 
            // btn_confirma
            // 
            btn_confirma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_confirma.Location = new Point(278, 351);
            btn_confirma.Name = "btn_confirma";
            btn_confirma.Size = new Size(112, 40);
            btn_confirma.TabIndex = 6;
            btn_confirma.Text = "Confirmar";
            btn_confirma.UseVisualStyleBackColor = true;
            btn_confirma.Click += btn_confirma_Click;
            // 
            // btn_pago
            // 
            btn_pago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_pago.Location = new Point(159, 351);
            btn_pago.Name = "btn_pago";
            btn_pago.Size = new Size(113, 40);
            btn_pago.TabIndex = 5;
            btn_pago.Text = "Pago";
            btn_pago.UseVisualStyleBackColor = true;
            btn_pago.Click += btn_pago_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_cancelar.Location = new Point(13, 351);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(110, 40);
            btn_cancelar.TabIndex = 4;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(13, 6);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 1;
            label1.Text = "Conta Origem:";
            // 
            // dtp_prev_pag
            // 
            dtp_prev_pag.Font = new Font("Segoe UI", 10F);
            dtp_prev_pag.Format = DateTimePickerFormat.Short;
            dtp_prev_pag.Location = new Point(158, 256);
            dtp_prev_pag.Name = "dtp_prev_pag";
            dtp_prev_pag.Size = new Size(114, 25);
            dtp_prev_pag.TabIndex = 3;
            // 
            // txt_valor
            // 
            txt_valor.Font = new Font("Segoe UI", 10F);
            txt_valor.Location = new Point(13, 256);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(129, 25);
            txt_valor.TabIndex = 2;
            // 
            // cbx_destino
            // 
            cbx_destino.DataSource = c6ContaBindingSource;
            cbx_destino.DisplayMember = "C6Nome";
            cbx_destino.Font = new Font("Segoe UI", 10F);
            cbx_destino.FormattingEnabled = true;
            cbx_destino.Location = new Point(12, 312);
            cbx_destino.Name = "cbx_destino";
            cbx_destino.Size = new Size(377, 25);
            cbx_destino.TabIndex = 1;
            cbx_destino.ValueMember = "C6Id";
            // 
            // c6ContaBindingSource
            // 
            c6ContaBindingSource.DataSource = typeof(Model.C6Conta);
            // 
            // cbx_conta_origem
            // 
            cbx_conta_origem.DataSource = c6ContaBindingSource;
            cbx_conta_origem.DisplayMember = "C6Nome";
            cbx_conta_origem.Font = new Font("Segoe UI", 10F);
            cbx_conta_origem.FormattingEnabled = true;
            cbx_conta_origem.Location = new Point(13, 28);
            cbx_conta_origem.Name = "cbx_conta_origem";
            cbx_conta_origem.Size = new Size(377, 25);
            cbx_conta_origem.TabIndex = 0;
            cbx_conta_origem.ValueMember = "C6Id";
            // 
            // Fo_Transferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 397);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fo_Transferencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transferência";
            Load += Fo_Transferencia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c6ContaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_confirma;
        private Button btn_pago;
        private Button btn_cancelar;
        private Label label1;
        private DateTimePicker dtp_prev_pag;
        private TextBox txt_valor;
        private ComboBox cbx_destino;
        private ComboBox cbx_conta_origem;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker dtp_pag;
        private BindingSource c6ContaBindingSource;
        private Label label6;
        private TextBox txt_titulo;
        private RichTextBox Rtxt_observacao;
        private Label label7;
    }
}