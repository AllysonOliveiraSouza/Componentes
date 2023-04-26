namespace Componentes
{
    partial class F_Checkbox
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
            this.chk_carro = new System.Windows.Forms.CheckBox();
            this.chk_aviao = new System.Windows.Forms.CheckBox();
            this.chk_moto = new System.Windows.Forms.CheckBox();
            this.chk_bicicleta = new System.Windows.Forms.CheckBox();
            this.btn_transportes_marcados = new System.Windows.Forms.Button();
            this.chk_patinete = new System.Windows.Forms.CheckBox();
            this.btn_abff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_carro
            // 
            this.chk_carro.AutoSize = true;
            this.chk_carro.Location = new System.Drawing.Point(12, 12);
            this.chk_carro.Name = "chk_carro";
            this.chk_carro.Size = new System.Drawing.Size(51, 17);
            this.chk_carro.TabIndex = 0;
            this.chk_carro.Text = "Carro";
            this.chk_carro.UseVisualStyleBackColor = true;
            // 
            // chk_aviao
            // 
            this.chk_aviao.AutoSize = true;
            this.chk_aviao.Location = new System.Drawing.Point(12, 35);
            this.chk_aviao.Name = "chk_aviao";
            this.chk_aviao.Size = new System.Drawing.Size(53, 17);
            this.chk_aviao.TabIndex = 1;
            this.chk_aviao.Text = "Avião";
            this.chk_aviao.UseVisualStyleBackColor = true;
            // 
            // chk_moto
            // 
            this.chk_moto.AutoSize = true;
            this.chk_moto.Location = new System.Drawing.Point(12, 58);
            this.chk_moto.Name = "chk_moto";
            this.chk_moto.Size = new System.Drawing.Size(50, 17);
            this.chk_moto.TabIndex = 2;
            this.chk_moto.Text = "Moto";
            this.chk_moto.UseVisualStyleBackColor = true;
            // 
            // chk_bicicleta
            // 
            this.chk_bicicleta.AutoSize = true;
            this.chk_bicicleta.Location = new System.Drawing.Point(12, 81);
            this.chk_bicicleta.Name = "chk_bicicleta";
            this.chk_bicicleta.Size = new System.Drawing.Size(66, 17);
            this.chk_bicicleta.TabIndex = 3;
            this.chk_bicicleta.Text = "Bicicleta";
            this.chk_bicicleta.UseVisualStyleBackColor = true;
            // 
            // btn_transportes_marcados
            // 
            this.btn_transportes_marcados.Location = new System.Drawing.Point(12, 115);
            this.btn_transportes_marcados.Name = "btn_transportes_marcados";
            this.btn_transportes_marcados.Size = new System.Drawing.Size(135, 21);
            this.btn_transportes_marcados.TabIndex = 4;
            this.btn_transportes_marcados.Text = "Transportes Marcados";
            this.btn_transportes_marcados.UseVisualStyleBackColor = true;
            this.btn_transportes_marcados.Click += new System.EventHandler(this.btn_transportes_marcados_Click);
            // 
            // chk_patinete
            // 
            this.chk_patinete.AutoSize = true;
            this.chk_patinete.Location = new System.Drawing.Point(13, 199);
            this.chk_patinete.Name = "chk_patinete";
            this.chk_patinete.Size = new System.Drawing.Size(65, 17);
            this.chk_patinete.TabIndex = 5;
            this.chk_patinete.Text = "Patinete";
            this.chk_patinete.UseVisualStyleBackColor = true;
            this.chk_patinete.CheckedChanged += new System.EventHandler(this.chk_patinete_CheckedChanged);
            // 
            // btn_abff
            // 
            this.btn_abff.Location = new System.Drawing.Point(12, 153);
            this.btn_abff.Name = "btn_abff";
            this.btn_abff.Size = new System.Drawing.Size(135, 21);
            this.btn_abff.TabIndex = 6;
            this.btn_abff.Text = "Abrir form filho";
            this.btn_abff.UseVisualStyleBackColor = true;
            this.btn_abff.Click += new System.EventHandler(this.btn_abff_Click);
            // 
            // F_Checkbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 282);
            this.Controls.Add(this.btn_abff);
            this.Controls.Add(this.chk_patinete);
            this.Controls.Add(this.btn_transportes_marcados);
            this.Controls.Add(this.chk_bicicleta);
            this.Controls.Add(this.chk_moto);
            this.Controls.Add(this.chk_aviao);
            this.Controls.Add(this.chk_carro);
            this.Name = "F_Checkbox";
            this.Text = "F_Checkbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_transportes_marcados;
        private System.Windows.Forms.CheckBox chk_patinete;
        public System.Windows.Forms.CheckBox chk_carro;
        public System.Windows.Forms.CheckBox chk_aviao;
        public System.Windows.Forms.CheckBox chk_moto;
        public System.Windows.Forms.CheckBox chk_bicicleta;
        private System.Windows.Forms.Button btn_abff;
    }
}