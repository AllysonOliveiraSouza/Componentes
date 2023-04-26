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
    public partial class F_Checkbox : Form
    {
        List<CheckBox> transp = new List<CheckBox>(); // criando um listbox

        public F_Checkbox()
        {
            InitializeComponent();
            transp.Add(chk_carro);
            transp.Add(chk_aviao);
            transp.Add(chk_moto);
            transp.Add(chk_bicicleta);

            // Adicionando os valores no List transp

        }

        private void btn_transportes_marcados_Click(object sender, EventArgs e)
        {
            string txt="";

            foreach(CheckBox c in transp)
            {
                if (c.Checked)
                {
                    txt += c.Text+", ";
                }
            }
            

            if (txt!="")
            {
                MessageBox.Show(txt);
            }
            else
            {
                MessageBox.Show("Não há nenhum checkbox marcado !!");
            }


        }

        private void chk_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_patinete.Checked)
            {
                MessageBox.Show("Patinete selecionado");
            }
        }

        private void btn_abff_Click(object sender, EventArgs e)
        {
            F_filhochk f = new F_filhochk();
            f.ShowDialog();
        }
    }
}
