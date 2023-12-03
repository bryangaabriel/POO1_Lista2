using System;

public class Ex63
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex63");
        // C�digo do Ex63...
        Console.Write("Digite um n�mero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        string resultado = VerificaParImpar(numero);

        Console.WriteLine($"\nO n�mero {numero} � {resultado}.");
    }

    static string VerificaParImpar(int n)
    {
        if (n % 2 == 0)
        {
            return "PAR";
        }
        else
        {
            return "�MPAR";
        }
    }
}
