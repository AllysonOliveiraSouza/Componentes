namespace Componentes
{
    partial class ComboBox
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
            this.cmb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_add_transp = new System.Windows.Forms.Button();
            this.txt_mostrar_e_add = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_transportes
            // 
            this.cmb_transportes.FormattingEnabled = true;
            this.cmb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cmb_transportes.Location = new System.Drawing.Point(34, 24);
            this.cmb_transportes.Name = "cmb_transportes";
            this.cmb_transportes.Size = new System.Drawing.Size(148, 21);
            this.cmb_transportes.TabIndex = 0;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(219, 24);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(172, 23);
            this.btn_mostrar.TabIndex = 1;
            this.btn_mostrar.Text = "Mostrar selecionado";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(219, 63);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(172, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar elementos";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(219, 103);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(172, 23);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar elementos";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_add_transp
            // 
            this.btn_add_transp.Location = new System.Drawing.Point(219, 181);
            this.btn_add_transp.Name = "btn_add_transp";
            this.btn_add_transp.Size = new System.Drawing.Size(172, 23);
            this.btn_add_transp.TabIndex = 4;
            this.btn_add_transp.Text = "Adicionar novo transporte";
            this.btn_add_transp.UseVisualStyleBackColor = true;
            this.btn_add_transp.Click += new System.EventHandler(this.btn_add_transp_Click);
            // 
            // txt_mostrar_e_add
            // 
            this.txt_mostrar_e_add.Location = new System.Drawing.Point(219, 143);
            this.txt_mostrar_e_add.Name = "txt_mostrar_e_add";
            this.txt_mostrar_e_add.Size = new System.Drawing.Size(172, 20);
            this.txt_mostrar_e_add.TabIndex = 5;
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_mostrar_e_add);
            this.Controls.Add(this.btn_add_transp);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.cmb_transportes);
            this.Name = "ComboBox";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.ComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_transportes;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_add_transp;
        private System.Windows.Forms.TextBox txt_mostrar_e_add;
    }
}