namespace Componentes
{
    partial class F_filhochk
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
            this.chk_bicicleta = new System.Windows.Forms.CheckBox();
            this.chk_moto = new System.Windows.Forms.CheckBox();
            this.chk_aviao = new System.Windows.Forms.CheckBox();
            this.chk_carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chk_bicicleta
            // 
            this.chk_bicicleta.AutoSize = true;
            this.chk_bicicleta.Location = new System.Drawing.Point(24, 81);
            this.chk_bicicleta.Name = "chk_bicicleta";
            this.chk_bicicleta.Size = new System.Drawing.Size(66, 17);
            this.chk_bicicleta.TabIndex = 7;
            this.chk_bicicleta.Text = "Bicicleta";
            this.chk_bicicleta.UseVisualStyleBackColor = true;
            this.chk_bicicleta.CheckedChanged += new System.EventHandler(this.chk_bicicleta_CheckedChanged);
            // 
            // chk_moto
            // 
            this.chk_moto.AutoSize = true;
            this.chk_moto.Location = new System.Drawing.Point(24, 58);
            this.chk_moto.Name = "chk_moto";
            this.chk_moto.Size = new System.Drawing.Size(50, 17);
            this.chk_moto.TabIndex = 6;
            this.chk_moto.Text = "Moto";
            this.chk_moto.UseVisualStyleBackColor = true;
            this.chk_moto.CheckedChanged += new System.EventHandler(this.chk_moto_CheckedChanged);
            // 
            // chk_aviao
            // 
            this.chk_aviao.AutoSize = true;
            this.chk_aviao.Location = new System.Drawing.Point(24, 35);
            this.chk_aviao.Name = "chk_aviao";
            this.chk_aviao.Size = new System.Drawing.Size(53, 17);
            this.chk_aviao.TabIndex = 5;
            this.chk_aviao.Text = "Avião";
            this.chk_aviao.UseVisualStyleBackColor = true;
            this.chk_aviao.CheckedChanged += new System.EventHandler(this.chk_aviao_CheckedChanged);
            // 
            // chk_carro
            // 
            this.chk_carro.AutoSize = true;
            this.chk_carro.Location = new System.Drawing.Point(24, 12);
            this.chk_carro.Name = "chk_carro";
            this.chk_carro.Size = new System.Drawing.Size(51, 17);
            this.chk_carro.TabIndex = 4;
            this.chk_carro.Text = "Carro";
            this.chk_carro.UseVisualStyleBackColor = true;
            this.chk_carro.CheckedChanged += new System.EventHandler(this.chk_carro_CheckedChanged);
            // 
            // F_filhochk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_bicicleta);
            this.Controls.Add(this.chk_moto);
            this.Controls.Add(this.chk_aviao);
            this.Controls.Add(this.chk_carro);
            this.Name = "F_filhochk";
            this.Text = "F_filhochk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_bicicleta;
        private System.Windows.Forms.CheckBox chk_moto;
        private System.Windows.Forms.CheckBox chk_aviao;
        private System.Windows.Forms.CheckBox chk_carro;
    }
}