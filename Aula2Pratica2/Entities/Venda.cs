using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Pratica2.Entities
{
    public class Venda
    {
        public  Guid IdVenda { get; set; }
        public double Total { get; set; }
        public DateTime Data { get; set; }

        public Cliente Cliente { get; set; } //Associação 1 para 1 (Entre venda e Cliente)
        public List<ItensVenda> ItensVenda { get; set; } //Associação 1 para N
       

    }
}
