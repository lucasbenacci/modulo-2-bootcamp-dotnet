using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo2BootcampDotnet.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime datavenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = datavenda;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}