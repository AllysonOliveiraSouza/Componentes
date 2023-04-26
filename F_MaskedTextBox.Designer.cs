namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_somenteTexto = new System.Windows.Forms.CheckBox();
            this.btn_obterCpf = new System.Windows.Forms.Button();
            this.btn_mostrarSenha = new System.Windows.Forms.Button();
            this.btn_ocultarsenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(37, 36);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '●';
            this.mtb_senha.Size = new System.Drawing.Size(100, 20);
            this.mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha :";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(37, 95);
            this.mtb_cpf.Mask = "000.000.000.00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(100, 20);
            this.mtb_cpf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF :";
            // 
            // chk_somenteTexto
            // 
            this.chk_somenteTexto.AutoSize = true;
            this.chk_somenteTexto.Location = new System.Drawing.Point(182, 95);
            this.chk_somenteTexto.Name = "chk_somenteTexto";
            this.chk_somenteTexto.Size = new System.Drawing.Size(94, 17);
            this.chk_somenteTexto.TabIndex = 4;
            this.chk_somenteTexto.Text = "Somente texto";
            this.chk_somenteTexto.UseVisualStyleBackColor = true;
            // 
            // btn_obterCpf
            // 
            this.btn_obterCpf.Location = new System.Drawing.Point(37, 139);
            this.btn_obterCpf.Name = "btn_obterCpf";
            this.btn_obterCpf.Size = new System.Drawing.Size(75, 23);
            this.btn_obterCpf.TabIndex = 5;
            this.btn_obterCpf.Text = "Obter Cpf";
            this.btn_obterCpf.UseVisualStyleBackColor = true;
            this.btn_obterCpf.Click += new System.EventHandler(this.btn_obterCpf_Click);
            // 
            // btn_mostrarSenha
            // 
            this.btn_mostrarSenha.Location = new System.Drawing.Point(153, 34);
            this.btn_mostrarSenha.Name = "btn_mostrarSenha";
            this.btn_mostrarSenha.Size = new System.Drawing.Size(89, 23);
            this.btn_mostrarSenha.TabIndex = 6;
            this.btn_mostrarSenha.Text = "Mostrar senha";
            this.btn_mostrarSenha.UseVisualStyleBackColor = true;
            this.btn_mostrarSenha.Click += new System.EventHandler(this.btn_mostrarSenha_Click);
            // 
            // btn_ocultarsenha
            // 
            this.btn_ocultarsenha.Location = new System.Drawing.Point(153, 33);
            this.btn_ocultarsenha.Name = "btn_ocultarsenha";
            this.btn_ocultarsenha.Size = new System.Drawing.Size(89, 23);
            this.btn_ocultarsenha.TabIndex = 7;
            this.btn_ocultarsenha.Text = "Ocultar senha";
            this.btn_ocultarsenha.UseVisualStyleBackColor = true;
            this.btn_ocultarsenha.Visible = false;
            this.btn_ocultarsenha.Click += new System.EventHandler(this.btn_ocultarsenha_Click);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ocultarsenha);
            this.Controls.Add(this.btn_mostrarSenha);
            this.Controls.Add(this.btn_obterCpf);
            this.Controls.Add(this.chk_somenteTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_senha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_somenteTexto;
        private System.Windows.Forms.Button btn_obterCpf;
        private System.Windows.Forms.Button btn_mostrarSenha;
        private System.Windows.Forms.Button btn_ocultarsenha;
    }
}