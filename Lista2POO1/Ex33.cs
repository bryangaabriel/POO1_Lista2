using System;

public class Ex33
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex33");
        // C�digo do Ex33...
        int numeroMatricula;
        double nota;
        int quantidadeAlunos = 0;
        double somaNotas = 0;

        // Loop para receber dados dos alunos at� que um n�mero de matr�cula negativo seja inserido
        do
        {
            Console.Write("Digite o n�mero de matr�cula do aluno (ou um n�mero negativo para encerrar): ");
            numeroMatricula = int.Parse(Console.ReadLine());

            if (numeroMatricula >= 0)
            {
                Console.Write("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());

                // Adiciona a nota � soma total
                somaNotas += nota;
                quantidadeAlunos++;
            }

        } while (numeroMatricula >= 0);

        // Verifica se pelo menos um aluno foi inserido antes de calcular a m�dia
        if (quantidadeAlunos > 0)
        {
            // Calcula a m�dia das notas
            double mediaNotas = somaNotas / quantidadeAlunos;

            // Exibe a m�dia das notas
            Console.WriteLine($"A m�dia das notas dos {quantidadeAlunos} alunos �: {mediaNotas}");
        }
        else
        {
            Console.WriteLine("Nenhum aluno foi inserido. N�o � poss�vel calcular a m�dia.");
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
