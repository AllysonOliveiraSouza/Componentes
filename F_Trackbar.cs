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
    public partial class F_Trackbar : Form
    {
        public F_Trackbar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txt_definir.Text = trackBar1.Value.ToString();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if(int.Parse(txt_definir.Text) < trackBar1.Minimum || int.Parse(txt_definir.Text)>trackBar1.Maximum){
                MessageBox.Show("Não é possível definir esse valor !");
                return; // Para o programa daqui,caso a condição seja verdadeira
            }

            trackBar1.Value = int.Parse(txt_definir.Text);
        }

        private void F_Trackbar_Load(object sender, EventArgs e)
        {
            txt_definir.Text = trackBar1.Value.ToString();
        }
    }
}
