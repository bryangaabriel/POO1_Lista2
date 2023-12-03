using System;

public class Ex59
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex59");
        // C�digo do Ex59...
        Console.Write("Digite o primeiro caractere (A-Z): ");
        char caractere1 = char.ToUpper(Console.ReadKey().KeyChar);

        Console.Write("\nDigite o segundo caractere (A-Z): ");
        char caractere2 = char.ToUpper(Console.ReadKey().KeyChar);

        if (caractere1 >= 'A' && caractere1 <= 'Z' && caractere2 >= 'A' && caractere2 <= 'Z')
        {
            // Calcula o n�mero de caracteres entre os dois caracteres
            int numeroCaracteres = Math.Abs(caractere2 - caractere1) - 1;

            Console.WriteLine($"\nO n�mero de caracteres entre {caractere1} e {caractere2} �: {numeroCaracteres}");
        }
        else
        {
            Console.WriteLine("\nErro: Certifique-se de que os caracteres est�o no intervalo de A a Z e em ordem alfab�tica.");
        }
    }
}
