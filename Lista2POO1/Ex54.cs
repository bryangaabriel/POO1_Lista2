using System;

public class Ex54
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex54");
        // Código do Ex54...
        // Vetores A e B
        int[] vetorA = { 1, 2, 3, 4, 5 };
        int[] vetorB = { 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Elementos comuns aos dois vetores:");

        // Verifica e imprime os elementos comuns
        foreach (int elementoA in vetorA)
        {
            foreach (int elementoB in vetorB)
            {
                if (elementoA == elementoB)
                {
                    Console.WriteLine(elementoA);
                    break; // Se encontrou um elemento comum, não é necessário continuar procurando
                }
            }
        }
    }
}
