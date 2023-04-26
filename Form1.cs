using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Frm_Principal : Form
    {
        public int num;

        public Frm_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (Txt_Veiculo.Text=="")
            {
                MessageBox.Show("Digite um veículo"); // Abre um message box
                Txt_Veiculo.Focus(); // Volta para o txtveiculo
                return; // fecha o método de evento
            }

            Txt_ListaVeiculos.Text += Txt_Veiculo.Text+", ";
            Txt_Veiculo.Clear(); // limpa
            Txt_Veiculo.Focus();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Veiculo.Clear();
            Txt_ListaVeiculos.Clear();
            Txt_Veiculo.Focus();

        }

        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f = new F_Veiculos(Txt_ListaVeiculos.Text,this);
            f.ShowDialog(); // ShowDialog, mostra apenas a janela atual e bloqueia a anterior
            
            
        }

        private void Btn_Num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
            
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Checkbox fcb = new F_Checkbox();
            fcb.ShowDialog();
        }

        private void checkListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckListBox fclb = new F_CheckListBox();
            fclb.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBox c = new ComboBox();
            c.ShowDialog();
        }

        private void dataTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTimePicker d = new DataTimePicker();
            d.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkLabel lb = new LinkLabel();
            lb.ShowDialog();
        }

        private void listboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Listbox lb = new F_Listbox();
            lb.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView lv = new F_ListView();
            lv.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox mtb = new F_MaskedTextBox();
            mtb.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_monthCalendar mtc = new F_monthCalendar();
            mtc.ShowDialog();
        }

        private void cts_menuIcone_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // e = evento ocorrido

            if (e.ClickedItem.Name=="tsmi_restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }else if (e.ClickedItem.Name=="tsmi_mensagem")
            {
                MessageBox.Show("Hello Word !!!");
            }else if(e.ClickedItem.Name=="tsmi_fechar"){
                this.Close();
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown fnud = new F_NumericUpDown();
            fnud.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox pb = new F_PictureBox();
            pb.ShowDialog();
        }

        private void progressbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar fpgb = new F_ProgressBar();
            fpgb.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButton f_Radio= new F_RadioButton();
            f_Radio.ShowDialog();
        }

        private void trackbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Trackbar ftb = new F_Trackbar();
            ftb.ShowDialog();
        }

        private void treeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView ftv = new F_TreeView();
            ftv.ShowDialog();
        }
    }
}
