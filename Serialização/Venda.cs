using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serialização
{
    public class Venda
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda){

            this.Id = id;
            this.Produto = produto;
            this.Preco = preco;
            this.DataVenda = dataVenda;
        }
    }
}