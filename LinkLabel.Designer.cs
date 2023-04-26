namespace Componentes
{
    partial class LinkLabel
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
            this.lkn_calculadora = new System.Windows.Forms.LinkLabel();
            this.lkn_linkedin = new System.Windows.Forms.LinkLabel();
            this.btn_abrirYT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lkn_calculadora
            // 
            this.lkn_calculadora.AutoSize = true;
            this.lkn_calculadora.Location = new System.Drawing.Point(140, 89);
            this.lkn_calculadora.Name = "lkn_calculadora";
            this.lkn_calculadora.Size = new System.Drawing.Size(87, 13);
            this.lkn_calculadora.TabIndex = 0;
            this.lkn_calculadora.TabStop = true;
            this.lkn_calculadora.Text = "Abrir Calculadora";
            this.lkn_calculadora.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.lkn_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkn_calculadora_LinkClicked);
            // 
            // lkn_linkedin
            // 
            this.lkn_linkedin.AutoSize = true;
            this.lkn_linkedin.Location = new System.Drawing.Point(336, 89);
            this.lkn_linkedin.Name = "lkn_linkedin";
            this.lkn_linkedin.Size = new System.Drawing.Size(67, 13);
            this.lkn_linkedin.TabIndex = 1;
            this.lkn_linkedin.TabStop = true;
            this.lkn_linkedin.Text = "Abrir linkedin";
            this.lkn_linkedin.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.lkn_linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkn_linkedin_LinkClicked);
            // 
            // btn_abrirYT
            // 
            this.btn_abrirYT.Location = new System.Drawing.Point(214, 154);
            this.btn_abrirYT.Name = "btn_abrirYT";
            this.btn_abrirYT.Size = new System.Drawing.Size(121, 23);
            this.btn_abrirYT.TabIndex = 2;
            this.btn_abrirYT.Text = "Abrir youtube";
            this.btn_abrirYT.UseVisualStyleBackColor = true;
            this.btn_abrirYT.Click += new System.EventHandler(this.btn_abrirYT_Click);
            // 
            // LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 264);
            this.Controls.Add(this.btn_abrirYT);
            this.Controls.Add(this.lkn_linkedin);
            this.Controls.Add(this.lkn_calculadora);
            this.Name = "LinkLabel";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkn_calculadora;
        private System.Windows.Forms.LinkLabel lkn_linkedin;
        private System.Windows.Forms.Button btn_abrirYT;
    }
}