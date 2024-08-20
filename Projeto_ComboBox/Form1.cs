using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboLista.Items.Add(txtTexto.Text);

            lblQtde.Text = cboLista.Items.Count.ToString();

            txtTexto.Clear();

            txtTexto.Select();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdenar(object sender, EventArgs e)
        {
            //Ativa a propriedade para ordenar a lista no combo:
            cboLista.Sorted = true;
        }

        private void btnRemover(object sender, EventArgs e)
        {
            if(cboLista.SelectedIndex != -1)
            {
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);

                lblQtde.Text = cboLista.Items.Count.ToString();

                cboLista.ResetText();
            }
        }

        private void btnExibir(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
