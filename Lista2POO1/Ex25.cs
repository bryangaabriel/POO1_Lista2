using System;

public class Ex25
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex25");
        // Código do Ex25...
        // Solicita ao usuário que insira a altura e o sexo
        Console.Write("Digite a altura (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M para masculino, F para feminino): ");
        char sexo = char.Parse(Console.ReadLine());

        // Calcula o peso ideal com base na fórmula correspondente ao sexo
        double pesoIdeal = CalcularPesoIdeal(altura, sexo);

        // Exibe o resultado
        Console.WriteLine($"O peso ideal é: {pesoIdeal} kg");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para calcular o peso ideal com base na altura e no sexo
    static double CalcularPesoIdeal(double altura, char sexo)
    {
        if (sexo == 'M' || sexo == 'm')
        {
            // Fórmula para homens
            return (72.7 * altura) - 58;
        }
        else if (sexo == 'F' || sexo == 'f')
        {
            // Fórmula para mulheres
            return (62.1 * altura) - 44.7;
        }
        else
        {
            // Sexo inválido
            Console.WriteLine("Sexo inválido. Não foi possível calcular o peso ideal.");
            return 0;
        }
    }
}
