using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lanchonete_JV
{
    public partial class formPedido : Form
    {
        Freques f = new Freques();
        Menu m = new Menu();
        double valor;
        public formPedido(Freques freques)
        {
            InitializeComponent();
            f = freques;
            ChamarCliente();
        }

        public void ChamarCliente()
        {
            txtPdoNome.Text = f.Nome;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtPIdCliente.Text);

            m.produto = new Produtos();
            m.produto.IdProduto = id;
            m.Cardápio(id);
            if (m.produto.IdProduto != 17)
            {
                dataGridPedido.Rows.Add(m.produto.Descricao, m.produto.ValorUnitario);
            }
            else
            {
                MessageBox.Show(m.msg);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            int x = dataGridPedido.Rows.Count;
            if (x > 1)
            {
                for (int i = 0; i < x; i++)
                {
                    valor += double.Parse(dataGridPedido.Rows[i].Cells[1].Value.ToString());
                }
            }
            else
            {
                valor = double.Parse(dataGridPedido.Rows[0].Cells[1].Value.ToString());
            }

            txtPIdCliente.Text = "";
            txtTotal.Text = valor.ToString("F2");
        }
    }
}
