using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Pratica2.Inputs
{
    public class VendaInput
    {
        public static double LerTotal()
        {
            Console.Write("Informe o total da compra..: ");
            return double.Parse( Console.ReadLine());
        }

        public static DateTime LerData()
        {
            Console.Write("Informe a data da compra..........: ");
            return DateTime.Parse(Console.ReadLine());
        }
    }

}
