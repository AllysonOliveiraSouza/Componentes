namespace Componentes
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "100",
            "20,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "40,00",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "50",
            "500,00",
            ""}, -1);
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.cl_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ctd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_id,
            this.cl_produto,
            this.cl_ctd,
            this.cl_preco});
            this.lv_produtos.FullRowSelect = true;
            this.lv_produtos.HideSelection = false;
            this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produtos.Location = new System.Drawing.Point(21, 23);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(642, 97);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            this.lv_produtos.SelectedIndexChanged += new System.EventHandler(this.lv_produtos_SelectedIndexChanged);
            // 
            // cl_id
            // 
            this.cl_id.Text = "ID";
            // 
            // cl_produto
            // 
            this.cl_produto.Text = "Produto";
            // 
            // cl_ctd
            // 
            this.cl_ctd.Text = "Quantidade";
            // 
            // cl_preco
            // 
            this.cl_preco.Text = "Preço";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(21, 160);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(140, 160);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(100, 20);
            this.txt_produto.TabIndex = 2;
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(255, 160);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(100, 20);
            this.txt_qtd.TabIndex = 3;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(370, 160);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(100, 20);
            this.txt_preco.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(21, 211);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(115, 211);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(75, 23);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(212, 211);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(75, 23);
            this.btn_obter.TabIndex = 11;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 292);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.txt_qtd);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lv_produtos);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader cl_id;
        private System.Windows.Forms.ColumnHeader cl_produto;
        private System.Windows.Forms.ColumnHeader cl_ctd;
        private System.Windows.Forms.ColumnHeader cl_preco;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
    }
}