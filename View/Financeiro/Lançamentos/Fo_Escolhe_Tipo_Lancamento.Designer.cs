namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Escolhe_Tipo_Lancamento
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
            rdb_transferencia = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            label1 = new Label();
            btn_cancelar = new Button();
            rdb_pagar = new RadioButton();
            rdb_Receber = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(rdb_transferencia);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(rdb_pagar);
            panel1.Controls.Add(rdb_Receber);
            panel1.Location = new Point(-3, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 223);
            panel1.TabIndex = 0;
            // 
            // rdb_transferencia
            // 
            rdb_transferencia.AutoSize = true;
            rdb_transferencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdb_transferencia.Location = new Point(73, 127);
            rdb_transferencia.Name = "rdb_transferencia";
            rdb_transferencia.Size = new Size(130, 25);
            rdb_transferencia.TabIndex = 5;
            rdb_transferencia.TabStop = true;
            rdb_transferencia.Text = "Transferência";
            rdb_transferencia.UseVisualStyleBackColor = true;
            rdb_transferencia.CheckedChanged += rdb_transferencia_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(15, 96);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 50);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(28, 11);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Lançamento";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_cancelar.Location = new Point(15, 158);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(220, 47);
            btn_cancelar.TabIndex = 2;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // rdb_pagar
            // 
            rdb_pagar.AutoSize = true;
            rdb_pagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdb_pagar.Location = new Point(73, 96);
            rdb_pagar.Name = "rdb_pagar";
            rdb_pagar.Size = new Size(87, 25);
            rdb_pagar.TabIndex = 1;
            rdb_pagar.Text = "À Pagar";
            rdb_pagar.UseVisualStyleBackColor = true;
            rdb_pagar.CheckedChanged += rdb_pagar_CheckedChanged;
            // 
            // rdb_Receber
            // 
            rdb_Receber.AutoSize = true;
            rdb_Receber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdb_Receber.Location = new Point(73, 65);
            rdb_Receber.Name = "rdb_Receber";
            rdb_Receber.Size = new Size(104, 25);
            rdb_Receber.TabIndex = 0;
            rdb_Receber.Text = "À Receber";
            rdb_Receber.UseVisualStyleBackColor = true;
            rdb_Receber.CheckedChanged += rdb_Receber_CheckedChanged;
            // 
            // Fo_Escolhe_Tipo_Lancamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 220);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Fo_Escolhe_Tipo_Lancamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fo_Escolhe_Tipo_Lancamento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton rdb_pagar;
        private RadioButton rdb_Receber;
        private Button btn_cancelar;
        private Panel panel2;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton rdb_transferencia;
    }
}