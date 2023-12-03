using System;

public class Ex30
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex30");
        // Código do Ex30...
        // Solicita ao usuário que insira o número para a tabuada
        Console.Write("Digite um número para a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        // Chama a função para imprimir a tabuada
        ImprimirTabuada(numero);

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para imprimir a tabuada de um número
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
