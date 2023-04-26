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
    public partial class LinkLabel : Form
    {
        public LinkLabel()
        {
            InitializeComponent();
        }

        private void lkn_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            lkn_calculadora.LinkVisited=true;
        }

        private void btn_abrirYT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
           
        }

        private void lkn_linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/allyson-oliveira-souza-77a21692/");
            lkn_linkedin.LinkVisited=true;
        }
    }
}
