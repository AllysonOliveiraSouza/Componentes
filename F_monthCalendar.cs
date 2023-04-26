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
    public partial class F_monthCalendar : Form
    {
        public F_monthCalendar()
        {
            InitializeComponent();
            txt_dataAtual.Text = mtc_calendario.TodayDate.ToShortDateString();
        }

        private void mtc_calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_datainicial.Text = mtc_calendario.SelectionRange.Start.ToShortDateString();
            txt_dataFinal.Text = mtc_calendario.SelectionRange.End.ToShortDateString();
            txt_dataAtual.Text = mtc_calendario.TodayDate.ToShortDateString();

            


        }
    }
}
