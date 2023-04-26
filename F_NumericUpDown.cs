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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_definirValor_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txt_valor.Text)<10)
            {
                MessageBox.Show("Valor menor que o permitido !!!");
            }
            else if (decimal.Parse(txt_valor.Text)>500)
            {
                MessageBox.Show("Valor maior que o permitido !!!");
            }
            else
            {
                numericUpDown1.Value = decimal.Parse(txt_valor.Text);
            }
                        
        }
    }
}
