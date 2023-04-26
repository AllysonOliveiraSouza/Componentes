namespace Componentes
{
    partial class F_monthCalendar
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
            this.mtc_calendario = new System.Windows.Forms.MonthCalendar();
            this.txt_datainicial = new System.Windows.Forms.TextBox();
            this.txt_dataFinal = new System.Windows.Forms.TextBox();
            this.txt_dataAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtc_calendario
            // 
            this.mtc_calendario.Location = new System.Drawing.Point(34, 28);
            this.mtc_calendario.MaxSelectionCount = 31;
            this.mtc_calendario.Name = "mtc_calendario";
            this.mtc_calendario.TabIndex = 0;
            this.mtc_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mtc_calendario_DateChanged);
            // 
            // txt_datainicial
            // 
            this.txt_datainicial.Location = new System.Drawing.Point(300, 28);
            this.txt_datainicial.Name = "txt_datainicial";
            this.txt_datainicial.Size = new System.Drawing.Size(167, 20);
            this.txt_datainicial.TabIndex = 1;
            // 
            // txt_dataFinal
            // 
            this.txt_dataFinal.Location = new System.Drawing.Point(300, 66);
            this.txt_dataFinal.Name = "txt_dataFinal";
            this.txt_dataFinal.Size = new System.Drawing.Size(167, 20);
            this.txt_dataFinal.TabIndex = 2;
            // 
            // txt_dataAtual
            // 
            this.txt_dataAtual.Location = new System.Drawing.Point(300, 101);
            this.txt_dataAtual.Name = "txt_dataAtual";
            this.txt_dataAtual.Size = new System.Drawing.Size(167, 20);
            this.txt_dataAtual.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data inicial selecionada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data final selecionada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data atual";
            // 
            // F_monthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dataAtual);
            this.Controls.Add(this.txt_dataFinal);
            this.Controls.Add(this.txt_datainicial);
            this.Controls.Add(this.mtc_calendario);
            this.Name = "F_monthCalendar";
            this.Text = "F_monthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mtc_calendario;
        private System.Windows.Forms.TextBox txt_datainicial;
        private System.Windows.Forms.TextBox txt_dataFinal;
        private System.Windows.Forms.TextBox txt_dataAtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}