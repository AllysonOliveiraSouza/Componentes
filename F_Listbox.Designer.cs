namespace Componentes
{
    partial class F_Listbox
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
            this.lst_carro = new System.Windows.Forms.ListBox();
            this.txt_carro = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_carro
            // 
            this.lst_carro.FormattingEnabled = true;
            this.lst_carro.Location = new System.Drawing.Point(35, 29);
            this.lst_carro.Name = "lst_carro";
            this.lst_carro.Size = new System.Drawing.Size(120, 160);
            this.lst_carro.TabIndex = 0;
            // 
            // txt_carro
            // 
            this.txt_carro.Location = new System.Drawing.Point(208, 39);
            this.txt_carro.Name = "txt_carro";
            this.txt_carro.Size = new System.Drawing.Size(100, 20);
            this.txt_carro.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(208, 78);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(100, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(208, 117);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 23);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(208, 159);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(100, 23);
            this.btn_obter.TabIndex = 4;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(208, 203);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(100, 23);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_Listbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 379);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_carro);
            this.Controls.Add(this.lst_carro);
            this.Name = "F_Listbox";
            this.Text = "F_Listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_carro;
        private System.Windows.Forms.TextBox txt_carro;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Button btn_limpar;
    }
}