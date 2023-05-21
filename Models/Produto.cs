using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeWhileVsWhere.Models
{
    public class Produto
    {

        public Produto (int id, string nomme, decimal custo, decimal preco)
        {
            Id = id;
            Nome = Nome;
            Custo = custo;
            Preco = preco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Custo { get; set; }
        public decimal Preco { get; set; }
    }
}