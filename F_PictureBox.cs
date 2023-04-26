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
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.Vai;
            label2.Text = Properties.Resources.Coringao;
        }

        private void rad_simboloTimao_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.corinthians;
        }

        private void rad_fagner_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.corinthians_fagner;
        }
    }
}
