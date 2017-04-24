using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaEconomia
{
    public partial class Form1 : Form
    {
        private List<Object> Lista;

        public Form1()
        {
            InitializeComponent();

            PreencherComboDebito();
            PreencherComboCredito();

        }

        private void PreencherComboDebito()
        {
            List<ComboBoxItem> ListaItens = new List<ComboBoxItem>();
            ListaItens.Add(new ComboBoxItem { Text = "Selecione", Value = -1 });
            ListaItens.Add(new ComboBoxItem { Text = "Cinema", Value = 1 });
            ListaItens.Add(new ComboBoxItem { Text = "Combustível", Value = 2 });
            ListaItens.Add(new ComboBoxItem { Text = "Viagem", Value = 3 });

            cbbTipoDebito.DataSource = ListaItens;

        }

        private void PreencherComboCredito()
        {
            List<ComboBoxItem> ListaItens = new List<ComboBoxItem>();
            ListaItens.Add(new ComboBoxItem { Text = "Selecione", Value = -1 });
            ListaItens.Add(new ComboBoxItem { Text = "Salário", Value = 1 });
            ListaItens.Add(new ComboBoxItem { Text = "Mesada", Value = 2 });
            ListaItens.Add(new ComboBoxItem { Text = "Emprestimo", Value = 3 });

            cbbTipoCredito.DataSource = ListaItens;

        }

        private void btnSalvarDebito_Click(object sender, EventArgs e)
        {
            Debito debito = new Debito();

            debito.Descricao = txtDescricao.Text;

            string dataInserida = mskData.Text;
            
            if (string.IsNullOrEmpty(dataInserida)) 
            {
                debito.data = DateTime.Now;
            }
            else
            {
                DateTime data;

                if (DateTime.TryParse(dataInserida, out data))
                {
                    if (data.Date > DateTime.Now.Date)
                    {
                        MessageBox.Show("Data informada é superior à data atual!");
                    }
                    else
                    {
                        debito.data = data;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Data inválida!");
                }
            }
            

            if (cbbTipoDebito.SelectedIndex != -1)
            {
                debito.Tipo = ((ComboBoxItem)cbbTipoDebito.SelectedValue).Text;
            }
            else
            {
                MessageBox.Show("Selecione um tipo de débito!");
            }

            double valor = 0;

            if (Double.TryParse(txtValorDebito.Text.Trim(), out valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("O valor tem que ser superior a zero!");
                }
                else
                {
                    debito.Valor = valor;
                }

            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }

            if (debito.Tipo != null && debito.Valor > 0)
            {
                if (Lista == null)
                {
                    Lista = new List<Object>();
                }

                            

                Lista.Add(debito);

                AtualizarGridView();

                txtValorDebito.Text = String.Empty;
                txtDescricao.Text = String.Empty;
                cbbTipoDebito.SelectedIndex = 0;
            }
        }

        

        private void btnSalvarCredito_Click(object sender, EventArgs e)
        {
            Credito credito = new Credito();

            credito.Descricao = txtDescricao.Text;

            if (cbbTipoCredito.SelectedIndex != -1)
            {
                credito.Tipo = ((ComboBoxItem)cbbTipoCredito.SelectedValue).Text;
            }
            else
            {
                MessageBox.Show("Selecione um tipo de Crédito!");
            }

            double valor = 0;

            if (Double.TryParse(txtValorCredito.Text.Trim(), out valor))
            {
                if (valor <= 0)
                {
                    MessageBox.Show("O valor tem que ser superior a zero!");
                }
                else
                {
                    credito.Valor = valor;
                }

            }
            else
            {
                MessageBox.Show("Valor inválido!");
            }

            if (credito.Tipo != null && credito.Valor > 0)
            {
                if (Lista == null)
                {
                    Lista = new List<Object>();
                }

                credito.data = DateTime.Now;

                Lista.Add(credito);   //parei aqui   

                AtualizarGridView();

                txtValorCredito.Text = String.Empty;
                txtDescricao.Text = String.Empty;
                cbbTipoCredito.SelectedIndex = 0;
            }
        }

        private void AtualizarGridView()
        {
            dttDebitos.Rows.Clear();

            double valorTotal = 0;

            foreach (object item in Lista)
            {
                if (item is Debito)
                {
                    DataGridViewRow row = (DataGridViewRow)dttDebitos.Rows[0].Clone();
                    row.Cells[0].Value = ((Debito)item).data.ToShortDateString();
                    row.Cells[1].Value = "Débito";
                    row.Cells[2].Value = ((Debito)item).Tipo;
                    row.Cells[3].Value = ((Debito)item).Descricao;
                    row.Cells[4].Value = ((Debito)item).Valor;
                    row.Cells[4].Style.BackColor = Color.Red;
                    dttDebitos.Rows.Add(row);

                    valorTotal -= ((Debito)item).Valor;
                }
                else if (item is Credito )
                {
                    DataGridViewRow row = (DataGridViewRow)dttDebitos.Rows[0].Clone();
                    row.Cells[0].Value = ((Credito)item).data.ToShortDateString();
                    row.Cells[1].Value = "Crédito";
                    row.Cells[2].Value = ((Credito)item).Tipo;
                    row.Cells[3].Value = ((Credito)item).Descricao;
                    row.Cells[4].Value = ((Credito)item).Valor;
                    row.Cells[4].Style.BackColor = Color.LightBlue;
                    dttDebitos.Rows.Add(row);

                    valorTotal += ((Credito)item).Valor;
                }
            }

            DataGridViewRow rowfinal = (DataGridViewRow)dttDebitos.Rows[0].Clone();
            rowfinal.Cells[3].Value = "Saldo";
            rowfinal.Cells[4].Value = valorTotal;
            
            if(valorTotal >= 0)
            {
                rowfinal.Cells[4].Style.BackColor = Color.LightBlue;
            }
            else
            {
                rowfinal.Cells[4].Style.BackColor = Color.Red;
            }

            dttDebitos.Rows.Add(rowfinal);
        }

     
      
    }
}
