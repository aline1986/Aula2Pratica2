using Newtonsoft.Json;
using Aula2Pratica2.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Pratica2.Repositories
{
    public class VendaRepository
    {
        /// <summary>
        /// Método para exportar dados de venda para arquivo JSON
        /// </summary>
        /// <param name="venda">Objeto da classe de entidade Venda</param>
        public void ExportarDados(Venda venda) //Colocando parametro da entidade venda
        {
            var json = JsonConvert.SerializeObject(venda, Formatting.Indented);//tranformando códico c# para JSON

            //abrindo arquivo mode de escrita
            var streamWriter = new StreamWriter($"c:\\temp\\venda_{venda.IdVenda}.json");
            streamWriter.WriteLine(json);//escrevendo dados do arquivo Json
            streamWriter.Flush(); //salvando
            streamWriter.Close();//fechando
        }

    }
}
