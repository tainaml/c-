using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailingLabelProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {           
            string msg;

            

            msg = ("Dados digitados: \n\n" );
            msg = msg + ("Nome:" + txtNome.Text + "\n");
            msg = msg + ("Endereço:" + txtEndereco.Text + "\n");
            msg = msg + ("Cidade: " + txtCidade.Text + "\n");
            msg = msg + ("Estado: " + txtEstado.Text + "\n");
            msg = msg + ("CEP: " + txtCep.Text + "\n");
           
            txtGrande.Text = msg;
        


    }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {                   
                    ((TextBox)item).Clear();
                }

                if (item is RichTextBox)
                {
                    ((RichTextBox)item).Clear();
                }

                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }

                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
