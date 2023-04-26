using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // necessário importar para uso do sleep

namespace Componentes
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_definirValor.Text)<0)
            {
                MessageBox.Show("O valor não pode ser menor do que 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (int.Parse(txt_definirValor.Text)>100)
            {
                MessageBox.Show("O valor não pode ser maior do que 100", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pgb_1.Value = int.Parse(txt_definirValor.Text);
            }


            
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            pgb_1.Value=0;

            if (chk_usarSleep.Checked)
            {
                pgb_1.Maximum=100;
                pgb_1.Value=0;

                for (int i = 0; i<pgb_1.Maximum; i++)
                {
                    pgb_1.Value++;
                    Thread.Sleep(200);
                }

            }
            else
            {
                pgb_1.Maximum=int.Parse(txt_valorContador.Text);
                pgb_1.Value=0;
                for (int i = 0; i<int.Parse(txt_valorContador.Text); i++)
                {                      
                    pgb_1.Value=i;

                }
                
            }

        }
    }
}
