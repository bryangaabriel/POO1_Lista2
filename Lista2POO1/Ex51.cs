using System;

public class Ex51
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex51");
        // Código do Ex51...
        // Solicita ao usuário a quantidade de alunos
        Console.Write("Digite a quantidade de alunos: ");
        int quantidadeAlunos = int.Parse(Console.ReadLine());

        // Variáveis para armazenar as notas e a soma das notas
        double nota;
        double somaNotas = 0;

        // Contador de alunos com nota acima de 7.0
        int alunosAcimaDeSete = 0;

        // Loop para ler as notas e calcular a média
        for (int i = 1; i <= quantidadeAlunos; i++)
        {
            Console.Write($"Digite a nota do aluno {i}: ");
            nota = double.Parse(Console.ReadLine());

            // Soma a nota ao total
            somaNotas += nota;

            // Verifica se a nota é maior que 7.0 e incrementa o contador
            if (nota > 7.0)
            {
                alunosAcimaDeSete++;
            }
        }

        // Calcula a média aritmética
        double media = quantidadeAlunos > 0 ? somaNotas / quantidadeAlunos : 0;

        // Exibe a média e a quantidade de alunos com nota acima de 7.0
        Console.WriteLine($"\nMédia aritmética das notas: {media:F2}");

        if (alunosAcimaDeSete > 0)
        {
            Console.WriteLine($"Quantidade de alunos com nota acima de 7.0: {alunosAcimaDeSete}");
        }
        else
        {
            Console.WriteLine("Não há nenhum aluno com nota acima de 7.0.");
        }
    }
}
