using System;

public class Ex63
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex63");
        // Código do Ex63...
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        string resultado = VerificaParImpar(numero);

        Console.WriteLine($"\nO número {numero} é {resultado}.");
    }

    static string VerificaParImpar(int n)
    {
        if (n % 2 == 0)
        {
            return "PAR";
        }
        else
        {
            return "ÍMPAR";
        }
    }
}
