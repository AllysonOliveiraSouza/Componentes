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
    public partial class F_ListView : Form
    {
        private void Limpar()
        {
            txt_id.Clear();
            txt_preco.Clear();
            txt_produto.Clear();
            txt_qtd.Clear();
        }

        private void VerificarConteudo(string id, string produto, string qtd, string preco)
        {
            if ((id=="") || (produto=="") || (qtd=="") || (preco==""))
            {
                MessageBox.Show("Verifique os campos, algum está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return; 
            }

        }



        public F_ListView()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            VerificarConteudo(txt_id.Text,txt_produto.Text,txt_qtd.Text,txt_preco.Text);

            string[] pr = new string[4];
            pr[0] = txt_id.Text;
            pr[1] = txt_produto.Text;
            pr[2] = txt_qtd.Text;
            pr[3] = txt_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_produtos.Items.Add(l);
            Limpar();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            txt_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            txt_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            txt_qtd.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            txt_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;

        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_produtos.SelectedItems.Count > 0)
            {
                txt_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
                txt_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
                txt_qtd.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
                txt_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
