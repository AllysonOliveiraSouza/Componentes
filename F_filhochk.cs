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
    public partial class F_filhochk : Form
    {
        public F_Checkbox fcb;

        public F_filhochk()
        {
            InitializeComponent();
        
                fcb = Application.OpenForms["F_Checkbox"] as F_Checkbox;

            // Application.OpenForms, conforme sintaxe acima, verifica se tem um form aberto, F_Checkbox

                chk_carro.Checked = fcb.chk_carro.Checked;
                chk_aviao.Checked = fcb.chk_aviao.Checked;
                chk_moto.Checked= fcb.chk_moto.Checked;
                chk_bicicleta.Checked=fcb.chk_bicicleta.Checked;            

        }

        private void chk_carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chk_carro.Checked=chk_carro.Checked;

        }

        private void chk_aviao_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chk_aviao.Checked=chk_carro.Checked;
        }

        private void chk_moto_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chk_moto.Checked=chk_moto.Checked;
        }

        private void chk_bicicleta_CheckedChanged(object sender, EventArgs e)
        {
            fcb.chk_bicicleta.Checked= chk_bicicleta.Checked;
        }
    }
}
