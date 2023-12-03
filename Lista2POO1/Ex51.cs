using System;

public class Ex51
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex51");
        // C�digo do Ex51...
        // Solicita ao usu�rio a quantidade de alunos
        Console.Write("Digite a quantidade de alunos: ");
        int quantidadeAlunos = int.Parse(Console.ReadLine());

        // Vari�veis para armazenar as notas e a soma das notas
        double nota;
        double somaNotas = 0;

        // Contador de alunos com nota acima de 7.0
        int alunosAcimaDeSete = 0;

        // Loop para ler as notas e calcular a m�dia
        for (int i = 1; i <= quantidadeAlunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i}: ");
            nota = double.Parse(Console.ReadLine());

            // Soma a nota ao total
            somaNotas += nota;

            // Verifica se a nota � maior que 7.0 e incrementa o contador
            if (nota > 7.0)
            {
                alunosAcimaDeSete++;
            }
        }

        // Calcula a m�dia aritm�tica
        double media = quantidadeAlunos > 0 ? somaNotas / quantidadeAlunos : 0;

        // Exibe a m�dia e a quantidade de alunos com nota acima de 7.0
        Console.WriteLine($"\nM�dia aritm�tica das notas: {media:F2}");

        if (alunosAcimaDeSete > 0)
        {
            Console.WriteLine($"Quantidade de alunos com nota acima de 7.0: {alunosAcimaDeSete}");
        }
        else
        {
            Console.WriteLine("N�o h� nenhum aluno com nota acima de 7.0.");
        }
    }
}
