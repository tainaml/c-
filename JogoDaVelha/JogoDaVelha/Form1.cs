using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {


            if ((txt1.Text.ToUpper() == "X" && txt2.Text.ToUpper() == "X" && txt3.Text.ToUpper() == "X") ||
                (txt4.Text.ToUpper() == "X" && txt5.Text.ToUpper() == "X" && txt6.Text.ToUpper() == "X") ||
                (txt7.Text.ToUpper() == "X" && txt8.Text.ToUpper() == "X" && txt9.Text.ToUpper() == "X") ||
                (txt1.Text.ToUpper() == "X" && txt5.Text.ToUpper() == "X" && txt9.Text.ToUpper() == "X") ||
                (txt3.Text.ToUpper() == "X" && txt5.Text.ToUpper() == "X" && txt7.Text.ToUpper() == "X") ||
                (txt1.Text.ToUpper() == "X" && txt4.Text.ToUpper() == "X" && txt7.Text.ToUpper() == "X") ||
                (txt2.Text.ToUpper() == "X" && txt5.Text.ToUpper() == "X" && txt8.Text.ToUpper() == "X") ||
                (txt3.Text.ToUpper() == "X" && txt6.Text.ToUpper() == "X" && txt9.Text.ToUpper() == "X"))
            {
                txtPlacar1.Text = txtPlacar1.Text == "" ? "1" : Convert.ToString(Convert.ToInt16(txtPlacar1.Text) + 1);
                MessageBox.Show("Parabéns, você ganhou!!!");

            }
            else
            {
                ((TextBox)sender).ReadOnly = true;

                string id = ((TextBox)sender).Name;
                int numeroSelecionado = Convert.ToInt16(id.Substring(id.Length - 1, 1));

                int random = numeroSelecionado;

                while (random == numeroSelecionado || ((TextBox)panel1.Controls.Find("txt" + random.ToString(), false)[0]).ReadOnly == true)
                {
                    random = new Random().Next(1, 9);

                    if (txt1.Text != string.Empty &&
                        txt2.Text != string.Empty &&
                        txt3.Text != string.Empty &&
                        txt4.Text != string.Empty &&
                        txt5.Text != string.Empty &&
                        txt6.Text != string.Empty &&
                        txt7.Text != string.Empty &&
                        txt8.Text != string.Empty &&
                        txt9.Text != string.Empty)
                    {
                        break;
                    }
                }

            ((TextBox)panel1.Controls.Find("txt" + random.ToString(), false)[0]).TextChanged -= txt_TextChanged;
                ((TextBox)panel1.Controls.Find("txt" + random.ToString(), false)[0]).Text = "O";
                ((TextBox)panel1.Controls.Find("txt" + random.ToString(), false)[0]).ReadOnly = true;
                ((TextBox)panel1.Controls.Find("txt" + random.ToString(), false)[0]).TextChanged += txt_TextChanged;

                if ((txt1.Text.ToUpper() == "O" && txt2.Text.ToUpper() == "O" && txt3.Text.ToUpper() == "O") ||
                (txt4.Text.ToUpper() == "O" && txt5.Text.ToUpper() == "O" && txt6.Text.ToUpper() == "O") ||
                (txt7.Text.ToUpper() == "O" && txt8.Text.ToUpper() == "O" && txt9.Text.ToUpper() == "O") ||
                (txt1.Text.ToUpper() == "O" && txt5.Text.ToUpper() == "O" && txt9.Text.ToUpper() == "O") ||
                (txt3.Text.ToUpper() == "O" && txt5.Text.ToUpper() == "O" && txt7.Text.ToUpper() == "O") ||
                (txt1.Text.ToUpper() == "O" && txt4.Text.ToUpper() == "O" && txt7.Text.ToUpper() == "O") ||
                (txt2.Text.ToUpper() == "O" && txt5.Text.ToUpper() == "O" && txt8.Text.ToUpper() == "O") ||
                (txt3.Text.ToUpper() == "O" && txt6.Text.ToUpper() == "O" && txt9.Text.ToUpper() == "O"))
                {
                    txtPlacar2.Text = txtPlacar2.Text == "" ? "1" : Convert.ToString(Convert.ToInt16(txtPlacar2.Text) + 1);
                   

                    MessageBox.Show("Uma pena, você perdeu :~");
                }

                if (txt1.Text != string.Empty &&
                        txt2.Text != string.Empty &&
                        txt3.Text != string.Empty &&
                        txt4.Text != string.Empty &&
                        txt5.Text != string.Empty &&
                        txt6.Text != string.Empty &&
                        txt7.Text != string.Empty &&
                        txt8.Text != string.Empty &&
                        txt9.Text != string.Empty)
                {
                    MessageBox.Show("Empate!!!");
                }
            }
        }

        private void BloquearCampos()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).ReadOnly = true;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).TextChanged -= txt_TextChanged;
                    ((TextBox)item).Clear();
                    ((TextBox)item).ReadOnly = false;
                    ((TextBox)item).TextChanged += txt_TextChanged;
                }
            }
        }
    }
}
