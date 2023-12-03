using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex15
{
    public static void Executar()
    {
        // Solicita ao usuário que insira as quatro notas escolares
        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        double nota4 = double.Parse(Console.ReadLine());

        // Calcula a média das notas
        double media = CalcularMedia(nota1, nota2, nota3, nota4);

        // Verifica se o aluno foi aprovado
        if (media >= 7)
        {
            Console.WriteLine($"Aluno aprovado! Média: {media:F2}");
        }
        else
        {
            // Solicita a nota da recuperação
            Console.Write("Digite a nota da recuperação: ");
            double notaRecuperacao = double.Parse(Console.ReadLine());

            // Calcula a nova média considerando a recuperação
            double novaMedia = CalcularMediaRecuperacao(media, notaRecuperacao);

            // Verifica se o aluno foi aprovado na recuperação
            if (novaMedia >= 7)
            {
                Console.WriteLine($"Aluno aprovado na recuperação! Nova média: {novaMedia:F2}");
            }
            else
            {
                Console.WriteLine($"Aluno não aprovado. Média final: {novaMedia:F2}");
            }
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para calcular a média das notas
    static double CalcularMedia(double nota1, double nota2, double nota3, double nota4)
    {
        return (nota1 + nota2 + nota3 + nota4) / 4;
    }

    // Função para calcular a nova média considerando a recuperação
    static double CalcularMediaRecuperacao(double mediaAnterior, double notaRecuperacao)
    {
        // Considerando que a nota da recuperação é a nota do exame final
        return (mediaAnterior + notaRecuperacao) / 2;
    }
}

