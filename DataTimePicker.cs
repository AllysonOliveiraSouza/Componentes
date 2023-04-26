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
    public partial class DataTimePicker : Form
    {
        public DataTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            txt_obterData.Text = dtp_data.Text;
            txt_dia.Text = dtp_data.Value.Day.ToString();
            txt_mes.Text = dtp_data.Value.Month.ToString();
            txt_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;
            dia = int.Parse(txt_dia.Text);
            mes = int.Parse(txt_mes.Text);
            ano = int.Parse(txt_ano.Text);

            DateTime dt = new DateTime(ano,mes,dia);

            dtp_data.Value = dt;

          //  MessageBox.Show("hello word", "ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }
    }
}
