using System;

public class Ex30
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex30");
        // C�digo do Ex30...
        // Solicita ao usu�rio que insira o n�mero para a tabuada
        Console.Write("Digite um n�mero para a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        // Chama a fun��o para imprimir a tabuada
        ImprimirTabuada(numero);

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para imprimir a tabuada de um n�mero
    static void ImprimirTabuada(int numero)
    {
        Console.WriteLine($"Tabuada do {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
