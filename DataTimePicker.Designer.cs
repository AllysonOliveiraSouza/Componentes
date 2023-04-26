namespace Componentes
{
    partial class DataTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.txt_obterData = new System.Windows.Forms.TextBox();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_obterData = new System.Windows.Forms.Button();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(39, 24);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(263, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // txt_obterData
            // 
            this.txt_obterData.Location = new System.Drawing.Point(39, 65);
            this.txt_obterData.Name = "txt_obterData";
            this.txt_obterData.Size = new System.Drawing.Size(263, 20);
            this.txt_obterData.TabIndex = 1;
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(39, 116);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(70, 20);
            this.txt_dia.TabIndex = 2;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(131, 116);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(70, 20);
            this.txt_mes.TabIndex = 3;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(223, 116);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(79, 20);
            this.txt_ano.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ano";
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(340, 24);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(75, 23);
            this.btn_obterData.TabIndex = 8;
            this.btn_obterData.Text = "Obter data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(340, 113);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(75, 23);
            this.btn_setarData.TabIndex = 9;
            this.btn_setarData.Text = "Setar Data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(340, 164);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(75, 23);
            this.btn_hoje.TabIndex = 10;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // DataTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.btn_obterData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.txt_obterData);
            this.Controls.Add(this.dtp_data);
            this.Name = "DataTimePicker";
            this.Text = "DataTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.TextBox txt_obterData;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_obterData;
        private System.Windows.Forms.Button btn_setarData;
        private System.Windows.Forms.Button btn_hoje;
    }
}