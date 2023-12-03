using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex09
{
    public static void Executar()
    {
        // Solicita ao usuário que insira a idade em anos, meses e dias
        Console.Write("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em dias: ");
        int dias = int.Parse(Console.ReadLine());

        // Calcula a idade em dias
        int idadeEmDias = CalcularIdadeEmDias(anos, meses, dias);

        // Exibe o resultado
        Console.WriteLine($"A idade expressa em dias é: {idadeEmDias} dias");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
    // Função para calcular a idade em dias
    static int CalcularIdadeEmDias(int anos, int meses, int dias)
    {
        // Considerando 365 dias por ano e 30 dias por mês
        return anos * 365 + meses * 30 + dias;
    }
}

