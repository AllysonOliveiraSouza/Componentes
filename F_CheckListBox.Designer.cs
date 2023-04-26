namespace Componentes
{
    partial class F_CheckListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrar_selecionados = new System.Windows.Forms.Button();
            this.btn_limpar_lista = new System.Windows.Forms.Button();
            this.btn_resetar_lista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_add_novo_transp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(35, 13);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(120, 214);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrar_selecionados
            // 
            this.btn_mostrar_selecionados.Location = new System.Drawing.Point(178, 13);
            this.btn_mostrar_selecionados.Name = "btn_mostrar_selecionados";
            this.btn_mostrar_selecionados.Size = new System.Drawing.Size(147, 23);
            this.btn_mostrar_selecionados.TabIndex = 1;
            this.btn_mostrar_selecionados.Text = "Mostrar selecionados";
            this.btn_mostrar_selecionados.UseVisualStyleBackColor = true;
            this.btn_mostrar_selecionados.Click += new System.EventHandler(this.btn_mostrar_selecionados_Click);
            // 
            // btn_limpar_lista
            // 
            this.btn_limpar_lista.Location = new System.Drawing.Point(178, 42);
            this.btn_limpar_lista.Name = "btn_limpar_lista";
            this.btn_limpar_lista.Size = new System.Drawing.Size(147, 23);
            this.btn_limpar_lista.TabIndex = 2;
            this.btn_limpar_lista.Text = "Limpar lista";
            this.btn_limpar_lista.UseVisualStyleBackColor = true;
            this.btn_limpar_lista.Click += new System.EventHandler(this.btn_limpar_lista_Click);
            // 
            // btn_resetar_lista
            // 
            this.btn_resetar_lista.Location = new System.Drawing.Point(178, 71);
            this.btn_resetar_lista.Name = "btn_resetar_lista";
            this.btn_resetar_lista.Size = new System.Drawing.Size(147, 23);
            this.btn_resetar_lista.TabIndex = 3;
            this.btn_resetar_lista.Text = "Resetar lista";
            this.btn_resetar_lista.UseVisualStyleBackColor = true;
            this.btn_resetar_lista.Click += new System.EventHandler(this.btn_resetar_lista_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar novo transporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_add_novo_transp
            // 
            this.txt_add_novo_transp.Location = new System.Drawing.Point(194, 140);
            this.txt_add_novo_transp.Name = "txt_add_novo_transp";
            this.txt_add_novo_transp.Size = new System.Drawing.Size(120, 20);
            this.txt_add_novo_transp.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // F_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_add_novo_transp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_resetar_lista);
            this.Controls.Add(this.btn_limpar_lista);
            this.Controls.Add(this.btn_mostrar_selecionados);
            this.Controls.Add(this.clb_transportes);
            this.Name = "F_CheckListBox";
            this.Text = "F_CheckListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrar_selecionados;
        private System.Windows.Forms.Button btn_limpar_lista;
        private System.Windows.Forms.Button btn_resetar_lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_add_novo_transp;
        private System.Windows.Forms.Label label1;
    }
}