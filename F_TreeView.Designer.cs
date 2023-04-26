namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Civic");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hrv");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Gol");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Fusca");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Volkswagen", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(40, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Civic";
            treeNode1.Tag = "https://youtu.be/Dtzf60_XaOg";
            treeNode1.Text = "Civic";
            treeNode2.Name = "Hrv";
            treeNode2.Text = "Hrv";
            treeNode3.Name = "Honda";
            treeNode3.Text = "Honda";
            treeNode4.Name = "Gol";
            treeNode4.Text = "Gol";
            treeNode5.Name = "Fusca";
            treeNode5.Text = "Fusca";
            treeNode6.Name = "Volkswagen";
            treeNode6.Text = "Volkswagen";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(121, 216);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(189, 12);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(228, 23);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(189, 41);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(228, 23);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 4;
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}