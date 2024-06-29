namespace Controle_Financeiro_Pessoal.View.Financeiro
{
    partial class Fo_Contas
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
            panel_contas = new Panel();
            SuspendLayout();
            // 
            // panel_contas
            // 
            panel_contas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_contas.BackColor = SystemColors.ControlDarkDark;
            panel_contas.Location = new Point(-4, -4);
            panel_contas.Name = "panel_contas";
            panel_contas.Size = new Size(1413, 809);
            panel_contas.TabIndex = 0;
            // 
            // Fo_Contas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 801);
            Controls.Add(panel_contas);
            Name = "Fo_Contas";
            Text = "Fo_Contas";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_contas;
    }
}