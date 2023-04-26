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
    public partial class F_Listbox : Form
    {
        List<string> carros = new List<string>();

        public void AtualizarLT()
        {
            lst_carro.DataSource = null;
            lst_carro.DataSource=carros;

        }


        public F_Listbox()
        {
            InitializeComponent();
            carros.Add("Ford Ka");
            carros.Add("Classic");
            carros.Add("Voyage");

            lst_carro.DataSource= carros;
            // DataSource pega uma lista já existente e adiciona, pode ser um banco de dados tbm ;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_carro.Text!="")
            {
                carros.Add(txt_carro.Text);
                AtualizarLT();
                txt_carro.Clear();
                txt_carro.Focus();
            }
            else
            {
                MessageBox.Show("Campo vazio","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lst_carro.SelectedIndex);
            // Remove o elemento no indice especificado do List<>
            AtualizarLT();

        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            txt_carro.Text = carros[lst_carro.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizarLT();
        }
    }
}
