using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            ListBox:lst_1.Items.Add(txt_Nome.Text);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            
                if (lst_1.Items.Contains(txt_Nome.Text) == true)
                {
                    int p;
                    p = lst_1.Items.IndexOf(txt_Nome.Text);

                DialogResult variavel = MessageBox.Show("\n" + "O Nome" + " " + txt_Nome.Text + " " + "encontra-se na Posição n.º " + (Convert.ToString(p + 1)) + "\n" + "" + "\n" + "Tem a certeza que o deseja Eliminar? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (variavel == DialogResult.Yes) lst_1.Items.Remove(txt_Nome.Text); 

                if (variavel == DialogResult.Yes) MessageBox.Show("O Nome " + txt_Nome.Text + " foi corretamente Removido da ListBox", "Mensagem de Confirmação");
            }
                else
                {
                    MessageBox.Show("O nome que digitou, não existe na ListBox, \nCompre uns Óculos e depois tente novamente.");
                }
            
        }
    }
}
