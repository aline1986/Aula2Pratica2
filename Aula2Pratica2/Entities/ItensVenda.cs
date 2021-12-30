using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Pratica2.Entities
{
    public class ItensVenda
    {
        public Guid IdItemVenda { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Categoria Categoria { get; set; } //Associação 1 para 1 (Entre ItensVenda e Categoria)


    }
}
