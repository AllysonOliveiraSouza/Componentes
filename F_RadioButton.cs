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
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
           foreach(RadioButton r in groupBox1.Controls)
            {
                if(r.Checked)
                {
                    MessageBox.Show("Radio button selecionado : "+r.Text);
                }
            }
        }

        private void F_RadioButton_FormClosed(object sender, FormClosedEventArgs e)
        {       
            Application.Exit();

            //Fechando toda a aplicação ao fechar o formulário
        }
    }
}
