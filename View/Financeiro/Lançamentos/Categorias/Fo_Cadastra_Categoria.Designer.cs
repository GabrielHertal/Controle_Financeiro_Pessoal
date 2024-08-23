namespace Controle_Financeiro_Pessoal.View.Financeiro.Lançamentos.Categorias
{
    partial class Fo_Cadastra_Categoria
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
            txt_nomecategoria = new TextBox();
            label1 = new Label();
            cbx_tipocategoria = new ComboBox();
            btn_salvar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_nomecategoria
            // 
            txt_nomecategoria.Font = new Font("Segoe UI", 10F);
            txt_nomecategoria.Location = new Point(10, 29);
            txt_nomecategoria.Name = "txt_nomecategoria";
            txt_nomecategoria.Size = new Size(260, 25);
            txt_nomecategoria.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 1;
            label1.Text = "Nome Categoria:";
            // 
            // cbx_tipocategoria
            // 
            cbx_tipocategoria.Font = new Font("Segoe UI", 10F);
            cbx_tipocategoria.FormattingEnabled = true;
            cbx_tipocategoria.Items.AddRange(new object[] { "1 - Mensal", "2 - Anual", "3 - Normal" });
            cbx_tipocategoria.Location = new Point(10, 79);
            cbx_tipocategoria.Name = "cbx_tipocategoria";
            cbx_tipocategoria.Size = new Size(260, 25);
            cbx_tipocategoria.TabIndex = 2;
            // 
            // btn_salvar
            // 
            btn_salvar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_salvar.Location = new Point(10, 122);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(260, 45);
            btn_salvar.TabIndex = 3;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nomecategoria);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbx_tipocategoria);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 192);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(10, 59);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 4;
            label2.Text = "Tipo Categoria:";
            // 
            // Fo_Cadastra_Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 182);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fo_Cadastra_Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar categoria";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_nomecategoria;
        private Label label1;
        private ComboBox cbx_tipocategoria;
        private Button btn_salvar;
        private Panel panel1;
        private Label label2;
    }
}