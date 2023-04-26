namespace Componentes
{
    partial class F_Veiculos
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
            this.Txt_Veiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Veiculos
            // 
            this.Txt_Veiculos.Location = new System.Drawing.Point(12, 12);
            this.Txt_Veiculos.Multiline = true;
            this.Txt_Veiculos.Name = "Txt_Veiculos";
            this.Txt_Veiculos.Size = new System.Drawing.Size(624, 327);
            this.Txt_Veiculos.TabIndex = 0;
            // 
            // F_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.Txt_Veiculos);
            this.Name = "F_Veiculos";
            this.Text = "Lista de veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Veiculos;
    }
}