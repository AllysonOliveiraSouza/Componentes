namespace Componentes
{
    partial class F_PictureBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rad_simboloTimao = new System.Windows.Forms.RadioButton();
            this.rad_fagner = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Componentes.Properties.Resources.corinthians;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rad_simboloTimao
            // 
            this.rad_simboloTimao.AutoSize = true;
            this.rad_simboloTimao.Location = new System.Drawing.Point(393, 130);
            this.rad_simboloTimao.Name = "rad_simboloTimao";
            this.rad_simboloTimao.Size = new System.Drawing.Size(105, 17);
            this.rad_simboloTimao.TabIndex = 3;
            this.rad_simboloTimao.TabStop = true;
            this.rad_simboloTimao.Text = "Simbolo do timão";
            this.rad_simboloTimao.UseVisualStyleBackColor = true;
            this.rad_simboloTimao.CheckedChanged += new System.EventHandler(this.rad_simboloTimao_CheckedChanged);
            // 
            // rad_fagner
            // 
            this.rad_fagner.AutoSize = true;
            this.rad_fagner.Location = new System.Drawing.Point(393, 166);
            this.rad_fagner.Name = "rad_fagner";
            this.rad_fagner.Size = new System.Drawing.Size(73, 17);
            this.rad_fagner.TabIndex = 4;
            this.rad_fagner.TabStop = true;
            this.rad_fagner.Text = "Fagner kk";
            this.rad_fagner.UseVisualStyleBackColor = true;
            this.rad_fagner.CheckedChanged += new System.EventHandler(this.rad_fagner_CheckedChanged);
            // 
            // F_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rad_fagner);
            this.Controls.Add(this.rad_simboloTimao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_PictureBox";
            this.Text = "F_PictureBox";
            this.Load += new System.EventHandler(this.F_PictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rad_simboloTimao;
        private System.Windows.Forms.RadioButton rad_fagner;
    }
}