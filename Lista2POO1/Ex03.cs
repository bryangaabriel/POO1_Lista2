using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ex03
    {
        public static void Executar()
        {

            // Solicita ao usuário que insira a identificação do vendedor
            Console.Write("Digite a identificação do vendedor: ");
            string identificacaoVendedor = Console.ReadLine();

            // Solicita ao usuário que insira o código da peça
            Console.Write("Digite o código da peça: ");
            string codigoPeca = Console.ReadLine();

            // Solicita ao usuário que insira o preço unitário da peça
            Console.Write("Digite o preço unitário da peça: ");
            double precoUnitario = double.Parse(Console.ReadLine());

            // Solicita ao usuário que insira a quantidade vendida
            Console.Write("Digite a quantidade vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine());

            // Calcula o total da venda
            double totalVenda = precoUnitario * quantidadeVendida;

            // Calcula a comissão (5% do total da venda)
            double comissao = CalcularComissao(totalVenda);

            // Exibe o resultado
            Console.WriteLine($"Vendedor: {identificacaoVendedor}");
            Console.WriteLine($"Código da Peça: {codigoPeca}");
            Console.WriteLine($"Preço Unitário: {precoUnitario:C}");
            Console.WriteLine($"Quantidade Vendida: {quantidadeVendida}");
            Console.WriteLine($"Total da Venda: {totalVenda:C}");
            Console.WriteLine($"Comissão (5%): {comissao:C}");

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();

        }

        // Função para calcular a comissão (5% do total da venda)
        static double CalcularComissao(double totalVenda)
        {
            return 0.05 * totalVenda;
        }

    }