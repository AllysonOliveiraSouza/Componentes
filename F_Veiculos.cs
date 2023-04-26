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
    public partial class F_Veiculos : Form
    {
        Frm_Principal Fp; // Criando um objeto, mas não instanciando ele
        public F_Veiculos(string v, Frm_Principal f) // criou um parâmetro frmprincipal, tipo instanciar
        {
            InitializeComponent();
            Txt_Veiculos.Text = v;
            Fp = f; // Atribuiiu o objeto da outra classe nessa variável
            f.num = 20; // acessou o num da outra classe

        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fp.Txt_ListaVeiculos.Text = Txt_Veiculos.Text;
            // Para que isso fosse possível, foi necessário alterar o modifier de txtListaVeiculos


        }
    }
}
