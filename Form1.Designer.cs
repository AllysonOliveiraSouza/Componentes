namespace Componentes
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Lbl_Veiculo = new System.Windows.Forms.Label();
            this.Txt_Veiculo = new System.Windows.Forms.TextBox();
            this.Btn_Adicionar = new System.Windows.Forms.Button();
            this.Txt_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_mostrar = new System.Windows.Forms.Button();
            this.Btn_Num = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cts_menuIcone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.treeviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.cts_menuIcone.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Veiculo
            // 
            this.Lbl_Veiculo.AutoSize = true;
            this.Lbl_Veiculo.Location = new System.Drawing.Point(26, 65);
            this.Lbl_Veiculo.Name = "Lbl_Veiculo";
            this.Lbl_Veiculo.Size = new System.Drawing.Size(96, 13);
            this.Lbl_Veiculo.TabIndex = 0;
            this.Lbl_Veiculo.Text = "Digite um veículo :";
            // 
            // Txt_Veiculo
            // 
            this.Txt_Veiculo.Location = new System.Drawing.Point(138, 65);
            this.Txt_Veiculo.Name = "Txt_Veiculo";
            this.Txt_Veiculo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Veiculo.TabIndex = 1;
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.Location = new System.Drawing.Point(253, 63);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Adicionar.TabIndex = 2;
            this.Btn_Adicionar.Text = "Adicionar";
            this.Btn_Adicionar.UseVisualStyleBackColor = true;
            this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
            // 
            // Txt_ListaVeiculos
            // 
            this.Txt_ListaVeiculos.Location = new System.Drawing.Point(29, 104);
            this.Txt_ListaVeiculos.Multiline = true;
            this.Txt_ListaVeiculos.Name = "Txt_ListaVeiculos";
            this.Txt_ListaVeiculos.ReadOnly = true;
            this.Txt_ListaVeiculos.Size = new System.Drawing.Size(243, 263);
            this.Txt_ListaVeiculos.TabIndex = 3;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(107, 373);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(122, 23);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_mostrar
            // 
            this.Btn_mostrar.Location = new System.Drawing.Point(107, 409);
            this.Btn_mostrar.Name = "Btn_mostrar";
            this.Btn_mostrar.Size = new System.Drawing.Size(122, 23);
            this.Btn_mostrar.TabIndex = 5;
            this.Btn_mostrar.Text = "Mostrar veiculos";
            this.Btn_mostrar.UseVisualStyleBackColor = true;
            this.Btn_mostrar.Click += new System.EventHandler(this.Btn_mostrar_Click);
            // 
            // Btn_Num
            // 
            this.Btn_Num.Location = new System.Drawing.Point(107, 438);
            this.Btn_Num.Name = "Btn_Num";
            this.Btn_Num.Size = new System.Drawing.Size(122, 23);
            this.Btn_Num.TabIndex = 6;
            this.Btn_Num.Text = "Mostrar valor de Num";
            this.Btn_Num.UseVisualStyleBackColor = true;
            this.Btn_Num.Click += new System.EventHandler(this.Btn_Num_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dataTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listboxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedTextBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.pictureBoxToolStripMenuItem,
            this.progressbarToolStripMenuItem,
            this.radioButtonToolStripMenuItem,
            this.trackbarToolStripMenuItem,
            this.treeviewToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkListBoxToolStripMenuItem
            // 
            this.checkListBoxToolStripMenuItem.Name = "checkListBoxToolStripMenuItem";
            this.checkListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dataTimePickerToolStripMenuItem
            // 
            this.dataTimePickerToolStripMenuItem.Name = "dataTimePickerToolStripMenuItem";
            this.dataTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataTimePickerToolStripMenuItem.Text = "DataTimePicker";
            this.dataTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dataTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listboxToolStripMenuItem
            // 
            this.listboxToolStripMenuItem.Name = "listboxToolStripMenuItem";
            this.listboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listboxToolStripMenuItem.Text = "Listbox";
            this.listboxToolStripMenuItem.Click += new System.EventHandler(this.listboxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            this.maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            this.maskedTextBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            this.maskedTextBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedTextBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // pictureBoxToolStripMenuItem
            // 
            this.pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            this.pictureBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pictureBoxToolStripMenuItem.Text = "PictureBox";
            this.pictureBoxToolStripMenuItem.Click += new System.EventHandler(this.pictureBoxToolStripMenuItem_Click);
            // 
            // progressbarToolStripMenuItem
            // 
            this.progressbarToolStripMenuItem.Name = "progressbarToolStripMenuItem";
            this.progressbarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.progressbarToolStripMenuItem.Text = "Progressbar";
            this.progressbarToolStripMenuItem.Click += new System.EventHandler(this.progressbarToolStripMenuItem_Click);
            // 
            // radioButtonToolStripMenuItem
            // 
            this.radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            this.radioButtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.radioButtonToolStripMenuItem.Text = "RadioButton";
            this.radioButtonToolStripMenuItem.Click += new System.EventHandler(this.radioButtonToolStripMenuItem_Click);
            // 
            // trackbarToolStripMenuItem
            // 
            this.trackbarToolStripMenuItem.Name = "trackbarToolStripMenuItem";
            this.trackbarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trackbarToolStripMenuItem.Text = "Trackbar";
            this.trackbarToolStripMenuItem.Click += new System.EventHandler(this.trackbarToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cts_menuIcone;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // cts_menuIcone
            // 
            this.cts_menuIcone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_restaurar,
            this.tsmi_mensagem,
            this.tsmi_fechar});
            this.cts_menuIcone.Name = "cts_menuIcone";
            this.cts_menuIcone.Size = new System.Drawing.Size(134, 70);
            this.cts_menuIcone.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cts_menuIcone_ItemClicked);
            // 
            // tsmi_restaurar
            // 
            this.tsmi_restaurar.Name = "tsmi_restaurar";
            this.tsmi_restaurar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_restaurar.Text = "Restaurar";
            // 
            // tsmi_mensagem
            // 
            this.tsmi_mensagem.Name = "tsmi_mensagem";
            this.tsmi_mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmi_mensagem.Text = "Mensagem";
            // 
            // tsmi_fechar
            // 
            this.tsmi_fechar.Name = "tsmi_fechar";
            this.tsmi_fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmi_fechar.Text = "Fechar";
            // 
            // treeviewToolStripMenuItem
            // 
            this.treeviewToolStripMenuItem.Name = "treeviewToolStripMenuItem";
            this.treeviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.treeviewToolStripMenuItem.Text = "Treeview";
            this.treeviewToolStripMenuItem.Click += new System.EventHandler(this.treeviewToolStripMenuItem_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 473);
            this.Controls.Add(this.Btn_Num);
            this.Controls.Add(this.Btn_mostrar);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Txt_ListaVeiculos);
            this.Controls.Add(this.Btn_Adicionar);
            this.Controls.Add(this.Txt_Veiculo);
            this.Controls.Add(this.Lbl_Veiculo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cts_menuIcone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Veiculo;
        private System.Windows.Forms.TextBox Txt_Veiculo;
        private System.Windows.Forms.Button Btn_Adicionar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_mostrar;
        private System.Windows.Forms.Button Btn_Num;
        public System.Windows.Forms.TextBox Txt_ListaVeiculos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cts_menuIcone;
        private System.Windows.Forms.ToolStripMenuItem tsmi_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_fechar;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeviewToolStripMenuItem;
    }
}

