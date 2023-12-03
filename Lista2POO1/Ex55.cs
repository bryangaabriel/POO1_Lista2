using System;

public class Ex55
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex55");
        // Código do Ex55...
        Console.Write("Digite uma frase de até 50 caracteres: ");
        string frase = Console.ReadLine();

        if (frase.Length > 50)
        {
            Console.WriteLine("A frase não pode ter mais de 50 caracteres.");
            return;
        }

        // Remove espaços em branco da frase
        string fraseSemEspacos = RemoverEspacosEmBranco(frase);

        // Imprime a frase sem espaços em branco
        Console.WriteLine($"\nFrase sem espaços em branco: {fraseSemEspacos}");

        // Imprime a quantidade de espaços em branco na frase original
        int quantidadeEspacos = ContarEspacosEmBranco(frase);
        Console.WriteLine($"Quantidade de espaços em branco na frase original: {quantidadeEspacos}");
    }

    static string RemoverEspacosEmBranco(string texto)
    {
        // Substitui espaços em branco por uma string vazia
        return texto.Replace(" ", "");
    }

    static int ContarEspacosEmBranco(string texto)
    {
        // Conta a quantidade de espaços em branco na string
        int count = 0;
        foreach (char c in texto)
        {
            if (char.IsWhiteSpace(c))
            {
                count++;
            }
        }
        return count;
    }
}
