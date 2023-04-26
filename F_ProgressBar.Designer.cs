namespace Componentes
{
    partial class F_ProgressBar
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
            this.pgb_1 = new System.Windows.Forms.ProgressBar();
            this.btn_definirValor = new System.Windows.Forms.Button();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.txt_definirValor = new System.Windows.Forms.TextBox();
            this.txt_valorContador = new System.Windows.Forms.TextBox();
            this.chk_usarSleep = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pgb_1
            // 
            this.pgb_1.BackColor = System.Drawing.SystemColors.Control;
            this.pgb_1.Location = new System.Drawing.Point(29, 133);
            this.pgb_1.Name = "pgb_1";
            this.pgb_1.Size = new System.Drawing.Size(742, 23);
            this.pgb_1.TabIndex = 0;
            // 
            // btn_definirValor
            // 
            this.btn_definirValor.Location = new System.Drawing.Point(29, 74);
            this.btn_definirValor.Name = "btn_definirValor";
            this.btn_definirValor.Size = new System.Drawing.Size(75, 23);
            this.btn_definirValor.TabIndex = 1;
            this.btn_definirValor.Text = "Definir valor";
            this.btn_definirValor.UseVisualStyleBackColor = true;
            this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(29, 193);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(75, 23);
            this.btn_preencher.TabIndex = 2;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
            // 
            // txt_definirValor
            // 
            this.txt_definirValor.Location = new System.Drawing.Point(29, 34);
            this.txt_definirValor.Name = "txt_definirValor";
            this.txt_definirValor.Size = new System.Drawing.Size(201, 20);
            this.txt_definirValor.TabIndex = 3;
            // 
            // txt_valorContador
            // 
            this.txt_valorContador.Location = new System.Drawing.Point(338, 34);
            this.txt_valorContador.Name = "txt_valorContador";
            this.txt_valorContador.Size = new System.Drawing.Size(201, 20);
            this.txt_valorContador.TabIndex = 4;
            this.txt_valorContador.Text = "0";
            // 
            // chk_usarSleep
            // 
            this.chk_usarSleep.AutoSize = true;
            this.chk_usarSleep.Location = new System.Drawing.Point(310, 199);
            this.chk_usarSleep.Name = "chk_usarSleep";
            this.chk_usarSleep.Size = new System.Drawing.Size(80, 17);
            this.chk_usarSleep.TabIndex = 6;
            this.chk_usarSleep.Text = "usar sleep?";
            this.chk_usarSleep.UseVisualStyleBackColor = true;
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_usarSleep);
            this.Controls.Add(this.txt_valorContador);
            this.Controls.Add(this.txt_definirValor);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.btn_definirValor);
            this.Controls.Add(this.pgb_1);
            this.Name = "F_ProgressBar";
            this.Text = "F_ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_1;
        private System.Windows.Forms.Button btn_definirValor;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.TextBox txt_definirValor;
        private System.Windows.Forms.TextBox txt_valorContador;
        private System.Windows.Forms.CheckBox chk_usarSleep;
    }
}