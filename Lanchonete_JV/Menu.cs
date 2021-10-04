using System;
using System.Collections.Generic;
using System.Text;

namespace Lanchonete_JV
{
    public class Menu
    {
        public int IdPedido { get; set; }
        public DateTime dataPedido { get; set; }
        public double ValorTotal { get; set; }
        public string msg { get; set; }

        public Produtos produto = new Produtos();

        public void Cardápio(int id)
        {
            if (produto.IdProduto == 1)
            {
                produto.Descricao = "Alichi";
                produto.ValorUnitario = 18.70;

            }
            else if (produto.IdProduto == 2)
            {
                produto.Descricao = "Alichi c/ Manierição";
                produto.ValorUnitario = 22.50;
            }
            else if (produto.IdProduto == 3)
            {
                produto.Descricao = "Milho c/ Bacon";
                produto.ValorUnitario = 19.20;
            }
            else if (produto.IdProduto == 4)
            {
                produto.Descricao = "Peperoni";
                produto.ValorUnitario = 24.50;
            }
            else if (produto.IdProduto == 5)
            {
                produto.Descricao = "Palmito a Bolonhesa";
                produto.ValorUnitario = 21.30;
            }
            else if (produto.IdProduto == 6)
            {
                produto.Descricao = "Palmito c/ Atum e Catupiry";
                produto.ValorUnitario = 48.70;
            }
            else if (produto.IdProduto == 7)
            {
                produto.Descricao = "Romana";
                produto.ValorUnitario = 68.30;
            }
            else if (produto.IdProduto == 8)
            {
                produto.Descricao = "Siciliana";
                produto.ValorUnitario = 5.10;
            }
            else if (produto.IdProduto == 9)
            {
                produto.Descricao = "Califórnia";
                produto.ValorUnitario = 6.30;
            }
            else if (produto.IdProduto == 10)
            {
                produto.Descricao = "Vegetariana";
                produto.ValorUnitario = 6.30;
            }
            else if (produto.IdProduto == 11)
            {
                produto.Descricao = "Atum";
                produto.ValorUnitario = 8.40;
            }
            else if (produto.IdProduto == 12)
            {
                produto.Descricao = "Atum c/ Tomate e Bacon";
                produto.ValorUnitario = 8.90;
            }
            else if (produto.IdProduto == 13)
            {
                produto.Descricao = "Lombo c/ Catupiry";
                produto.ValorUnitario = 10.90;
            }
            else if (produto.IdProduto == 14)
            {
                produto.Descricao = "Lombo c/ Tomate e Cebola";
                produto.ValorUnitario = 13.50;
            }
            else if (produto.IdProduto == 15)
            {
                produto.Descricao = "Toscana";
                produto.ValorUnitario = 20.90;
            }
            else if (produto.IdProduto == 16)
            {
                produto.Descricao = "Quatro Queijos";
                produto.ValorUnitario = 10.70;
            }
            else
            {
                msg = "Código do Produto não Encontrado";
            }
        }
    }
}
