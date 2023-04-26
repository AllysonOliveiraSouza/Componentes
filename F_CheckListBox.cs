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
    public partial class F_CheckListBox : Form
    {
        public F_CheckListBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_selecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            
            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ",";               
            }

            if (txt!="")
            {
                MessageBox.Show(txt);
            }
            else
            {
                MessageBox.Show("Selecione algum item !!!");
            }
            
        }

        private void btn_limpar_lista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetar_lista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();

            //  clb_transportes.Items.Add("Carro", false);
            // clb_transportes.Items.Add("Avião", false);
            // clb_transportes.Items.Add("Navio", false);
            // clb_transportes.Items.Add("Ônibus", false);
            // clb_transportes.Items.Add("Trem", false);
            // Dá pra fazer do jeito acima tbm

            List<string> Items = new List<string>();
            Items.Add("Carro");
            Items.Add("Avião");
            Items.Add("Navio");
            Items.Add("Ônibus");
            Items.Add("Trem");

            clb_transportes.Items.AddRange(Items.ToArray());




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_add_novo_transp.Text!="")
            {
                clb_transportes.Items.Add(txt_add_novo_transp.Text);
                txt_add_novo_transp.Clear();
                txt_add_novo_transp.Focus();
            }
            else
            {
                MessageBox.Show("Não adicionou nada por que você não colocou nada !!!");
            }
        }
    }
}
