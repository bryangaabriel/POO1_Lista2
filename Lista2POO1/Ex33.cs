using System;

public class Ex33
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex33");
        // Código do Ex33...
        int numeroMatricula;
        double nota;
        int quantidadeAlunos = 0;
        double somaNotas = 0;

        // Loop para receber dados dos alunos até que um número de matrícula negativo seja inserido
        do
        {
            Console.Write("Digite o número de matrícula do aluno (ou um número negativo para encerrar): ");
            numeroMatricula = int.Parse(Console.ReadLine());

            if (numeroMatricula >= 0)
            {
                Console.Write("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());

                // Adiciona a nota à soma total
                somaNotas += nota;
                quantidadeAlunos++;
            }

        } while (numeroMatricula >= 0);

        // Verifica se pelo menos um aluno foi inserido antes de calcular a média
        if (quantidadeAlunos > 0)
        {
            // Calcula a média das notas
            double mediaNotas = somaNotas / quantidadeAlunos;

            // Exibe a média das notas
            Console.WriteLine($"A média das notas dos {quantidadeAlunos} alunos é: {mediaNotas}");
        }
        else
        {
            Console.WriteLine("Nenhum aluno foi inserido. Não é possível calcular a média.");
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
