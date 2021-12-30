using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Aula2Pratica2.Entities
{
    public class Cliente
    {
        public int IdCliente = new int ();
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Endereco Endereco { get; set; } //Associação 1 para 1 ( um cliente tem um endereço)





    }
}
