using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Pratica2.Inputs
{
    public class ClienteInput
    {
        public static string LerNome()
        {
            Console.Write("Informe nome:");
            return Console.ReadLine();
        }

        public static string LerCpf()
        {
            Console.Write("Informe CPF de cliente:");
            return Console.ReadLine();
        }

    }
}
