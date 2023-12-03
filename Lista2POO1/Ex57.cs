using System;

public class Ex57
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex57");
        // Código do Ex57...
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        // Imprime as vogais da frase
        string vogais = ExtrairVogais(frase);
        Console.WriteLine($"\nVogais na frase: {vogais}");
    }

    static string ExtrairVogais(string texto)
    {
        // Filtra as vogais do texto
        string vogais = "";
        foreach (char c in texto)
        {
            if (EhVogal(c))
            {
                vogais += c;
            }
        }
        return vogais;
    }

    static bool EhVogal(char letra)
    {
        // Verifica se a letra é uma vogal
        char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        return Array.IndexOf(vogais, letra) != -1;
    }
}
