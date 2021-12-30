using Aula2Pratica2.Entities;
using Aula2Pratica2.Inputs;
using Aula2Pratica2.Repositories;
using System;
using System.Collections.Generic;
namespace Aula2Pratica2
{
    class Program //Program é a classe criada para executar projeto 
    {
        static void Main(string[] args) //Método onde execução é feita
        {
            Console.WriteLine("\n *** EXPORTADOR DE DADOS  ***\n");
            Console.WriteLine("\nEntre com os dados :\n");
            var venda = new Venda();
            venda.IdVenda = Guid.NewGuid();
            venda.Total = VendaInput.LerTotal();
            venda.Data = VendaInput.LerData();

            Random rad = new Random();
            venda.Cliente = new Cliente();
            venda.Cliente.IdCliente = rad.Next(100);
            venda.Cliente.Nome = ClienteInput.LerNome();
            venda.Cliente.Cpf = ClienteInput.LerCpf();

            venda.Cliente.Endereco = new Endereco();
            venda.Cliente.Endereco.IdEndereco = Guid.NewGuid();
            venda.Cliente.Endereco.Logradouro = EnderecoInput.LerLogradouro();
            venda.Cliente.Endereco.Bairro = EnderecoInput.LerBairro();
            venda.Cliente.Endereco.Cidade = EnderecoInput.LerCidade();
            venda.Cliente.Endereco.Estado = EnderecoInput.LerEstado();
            venda.Cliente.Endereco.CEP = EnderecoInput.LerCEP();

            ///Recebedo os dados digitados pelo usuário

            venda.ItensVenda = new List <ItensVenda>();
            Console.Write("Informe a quantidade de itens vendidos: ");
            var qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                try
                {
                    Console.WriteLine($"\nInforme o {i}º iten vendido:\n");
                    var itensVenda = new ItensVenda();
                    itensVenda.IdItemVenda = Guid.NewGuid();
                    itensVenda.Nome = ItensVendaInput.LerNome();
                    itensVenda.Preco = ItensVendaInput.LerPreco();

                    itensVenda.Categoria = new Categoria();  /// ver o motivo que não entrou categoria
                    itensVenda.Categoria.IdCateg = Guid.NewGuid();
                    itensVenda.Categoria.Descrição = CategoriaInput.LerDescricao();




                    
                    venda.ItensVenda.Add(itensVenda);
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine($"\nErro: {e.Message}");
                }
            }

            try
            {
                var vendaRepository = new VendaRepository();
                vendaRepository.ExportarDados(venda);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nErro ao exportar dados: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}




