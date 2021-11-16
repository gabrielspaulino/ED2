using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxGuiches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void buttonListarSenhas_Click(object sender, EventArgs e)
        {
            listBoxSenhas.Items.Clear();
            foreach(Senha senha in senhas.FilaSenhas)
            {
                listBoxSenhas.Items.Add(senha.dadosParciais());
            }
        }

        private void buttonListarAtend_Click(object sender, EventArgs e)
        {
            listBoxGuiche.Items.Clear();
            foreach (Guiche guiche in guiches.ListaGuiches)
            {
                if (Convert.ToString(guiche.Id) == textBoxGuiche.Text)
                {
                    foreach (Senha atend in guiche.Atendimentos)
                    {
                        listBoxGuiche.Items.Add(atend.dadosCompletos());
                    }
                }
            }
        }

        private void buttonChamar_Click(object sender, EventArgs e)
        {
            foreach (Guiche guiche in guiches.ListaGuiches)
            {
                if (Convert.ToString(guiche.Id) == textBoxGuiche.Text)
                {
                    guiche.chamar(senhas.FilaSenhas);
                }
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche(guiches.ListaGuiches.Count + 1));
            labelNGuiches.Text = Convert.ToString(Convert.ToInt32(labelNGuiches.Text) + 1);
        }
    }
}
