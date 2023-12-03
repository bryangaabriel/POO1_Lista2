using System;

public class Ex25
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex25");
        // C�digo do Ex25...
        // Solicita ao usu�rio que insira a altura e o sexo
        Console.Write("Digite a altura (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M para masculino, F para feminino): ");
        char sexo = char.Parse(Console.ReadLine());

        // Calcula o peso ideal com base na f�rmula correspondente ao sexo
        double pesoIdeal = CalcularPesoIdeal(altura, sexo);

        // Exibe o resultado
        Console.WriteLine($"O peso ideal �: {pesoIdeal} kg");

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para calcular o peso ideal com base na altura e no sexo
    static double CalcularPesoIdeal(double altura, char sexo)
    {
        if (sexo == 'M' || sexo == 'm')
        {
            // F�rmula para homens
            return (72.7 * altura) - 58;
        }
        else if (sexo == 'F' || sexo == 'f')
        {
            // F�rmula para mulheres
            return (62.1 * altura) - 44.7;
        }
        else
        {
            // Sexo inv�lido
            Console.WriteLine("Sexo inv�lido. N�o foi poss�vel calcular o peso ideal.");
            return 0;
        }
    }
}
