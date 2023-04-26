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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (cmb_transportes.SelectedIndex>=0) {
                txt_mostrar_e_add.Text = cmb_transportes.Text;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cmb_transportes.Items.Clear();
            txt_mostrar_e_add.Clear();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            cmb_transportes.Items.Clear();
            cmb_transportes.Items.Add("Carro");
            cmb_transportes.Items.Add("Avião");
            cmb_transportes.Items.Add("Navio");
            cmb_transportes.Items.Add("Ônibus");
            cmb_transportes.Items.Add("Trem");

        }

        private void btn_add_transp_Click(object sender, EventArgs e)
        {
            if ((txt_mostrar_e_add.Text!="") && (cmb_transportes.FindString(txt_mostrar_e_add.Text)<0))
            {              

                    cmb_transportes.Items.Add(txt_mostrar_e_add.Text);
                
            }
            else
            {
                MessageBox.Show("O item já existe, ou não foi digitado nada, favor verificar !!!");
            }
        }
    }
}
