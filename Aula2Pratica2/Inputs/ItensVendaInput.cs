using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Pratica2.Inputs
{
    public class ItensVendaInput
    {
        public static string LerNome()
        {
            Console.Write("Informe o nome do iten ..: ");
            return Console.ReadLine();
        }
        public static double LerPreco()
        {
            Console.Write("Informe o preço do iten..: ");
            return double.Parse(Console.ReadLine());
        }

     
    }
}
