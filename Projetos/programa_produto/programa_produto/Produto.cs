using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_produto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotEstoque()
        {
            return Preco * Quantidade;

            
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }


        public override string ToString()
        {
            return Nome
                + ", $" + Preco
                + Preco
                + ", "
                + Quantidade
                + " unidades, total: $"
                + ValorTotEstoque();
        }







    }   
}
