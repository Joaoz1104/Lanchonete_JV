using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lanchonete_JV
{
    public partial class formCliente : Form
    {
        Freques freques = new Freques();
        List<Freques> listarClientes = new List<Freques>();
        public formCliente()
        {
            InitializeComponent();
            ExibirDados();
        }
        private void CarregarDados()
        {
            var MaxId = 0;
            MaxId = listarClientes.Max(x => x.IdCliente);
            freques.IdCliente = MaxId + 1;
            freques.Nome = txtNomeCliente;
            freques.Telefone = txtTelCliente.Text;
            listarClientes.Add(freques);

            dataGridDadosCliente.DataSource = null;
            dataGridDadosCliente.DataSource = listarClientes;
        }

        private void ExibirDados()
        {
            listarClientes = Freques.CarregarCliente(@"C:\Bd\BdFreques.json");
            dataGridDadosCliente.DataSource = listarClientes;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CarregarDados();

            if (freques.SalvarDados(listarClientes, @"C:\Bd\BdFreques.json"))
            {
                MessageBox.Show("Dados Cadastrados com sucesso!");
            }
            txtNomeCliente.Text = "";
            txtTelCliente.Text = "";
        }

        private void Editar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridDadosCliente.Rows[e.RowIndex];
                txtIdCliente.Text = gridViewRow.Cells[0].Value.ToString();
                txtNomeCliente.Text = gridViewRow.Cells[1].Value.ToString();
                txtTelCliente.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdCliente.Text);
            var elem = listarClientes.Where<Freques>(x => x.IdCliente == id).FirstOrDefault();
            int index = listarClientes.IndexOf(elem);

            listarClientes[index].Nome = txtNomeCliente.Text;
            listarClientes[index].Telefone = txtTelCliente.Text;
            if (freques.SalvarDados(listarClientes, @"C:\Bd\BdFreques.json"))
            {
                MessageBox.Show("Dados Salvos");
            }
            ExibirDados();
            txtNomeCliente.Text = "";
            txtTelCliente.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdCliente.Text);
            var elem = listarClientes.Where<Freques>(x => x.IdCliente == id).FirstOrDefault();
            int index = listarClientes.IndexOf(elem);

            listarClientes[index].Nome = txtNomeCliente.Text;
            listarClientes[index].Telefone = txtTelCliente.Text;
            if (freques.SalvarDados(listarClientes, @"C:\Bd\BdFreques.json"))
            {
                MessageBox.Show("Dados Salvos");
            }
            ExibirDados();
        }
    }
}
