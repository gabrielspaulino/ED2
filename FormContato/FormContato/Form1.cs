using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormContato
{
    public partial class Form1 : Form
    {
        Contatos contatos = new Contatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            textBoxNome.Clear();
            textBoxFone.Clear();
            textBoxDia.Clear();
            textBoxMes.Clear();
            textBoxAno.Clear();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            string email = Convert.ToString(textBoxEmail.Text);
            string nome = Convert.ToString(textBoxNome.Text);
            string telefone = Convert.ToString(textBoxFone.Text);
            int dia = Convert.ToInt32(textBoxDia.Text);
            int mes = Convert.ToInt32(textBoxMes.Text);
            int ano = Convert.ToInt32(textBoxAno.Text);
            Data dtNasc = new Data(dia, mes, ano);
            Contato contato = new Contato(email, nome, telefone, dtNasc);
            contatos.adicionar(contato);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string email = Convert.ToString(textBoxEmail.Text);
            string nome = Convert.ToString(textBoxNome.Text);
            string telefone = Convert.ToString(textBoxFone.Text);
            int dia = Convert.ToInt32(textBoxDia.Text);
            int mes = Convert.ToInt32(textBoxMes.Text);
            int ano = Convert.ToInt32(textBoxAno.Text);
            Data dtNasc = new Data(dia, mes, ano);
            Contato contato = new Contato(email, nome, telefone, dtNasc);
            listBox1.Items.Add(contatos.remover(contato) ? "Removido" : "Não encontrado");
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string email = Convert.ToString(textBoxEmail.Text);
            string nome = Convert.ToString(textBoxNome.Text);
            string telefone = Convert.ToString(textBoxFone.Text);
            int dia = Convert.ToInt32(textBoxDia.Text);
            int mes = Convert.ToInt32(textBoxMes.Text);
            int ano = Convert.ToInt32(textBoxAno.Text);
            Data dtNasc = new Data(dia, mes, ano);
            Contato contato = new Contato(email, nome, telefone, dtNasc);
            Contato encontrado = contatos.pesquisar(contato);
            if (encontrado == null)
            {
                listBox1.Items.Add("Contato não encontrado");
            }
            else
            {
                listBox1.Items.Add(encontrado.ToString());
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            foreach (Contato c in contatos.Agenda)
            {
                listBox1.Items.Add(c.ToString());
            }
        }
    }
}