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
    public partial class F_MaskedTextBox : Form
    {


        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_obterCpf_Click(object sender, EventArgs e)
        {
            if(chk_somenteTexto.Checked)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                // mostra só o texto sem a formatação do mask
            }
            else
            {
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;

                // mostra o texto e a formatação do mask
            }

            MessageBox.Show(mtb_cpf.Text.ToString(),"CPF",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_mostrarSenha_Click(object sender, EventArgs e)
        {
          /*  if (mtb_senha.PasswordChar=='●')
            {
                mtb_senha.PasswordChar='\0';
                btn_mostrarSenha.Text="Ocultar senha";
            }
            else
            {
                mtb_senha.PasswordChar='●';
                btn_mostrarSenha.Text="Revelar senha";
            }  Outra forma de fazer o código, até mais simples, nem precisa de dois botões */ 


             mtb_senha.PasswordChar = '\0';
             btn_mostrarSenha.Visible= false;
             btn_ocultarsenha.Visible=true;
            }

        private void btn_ocultarsenha_Click(object sender, EventArgs e)
        {
            mtb_senha.PasswordChar = '●';
            btn_mostrarSenha.Visible= true;
            btn_ocultarsenha.Visible=false;
        }

    }
    }
    

