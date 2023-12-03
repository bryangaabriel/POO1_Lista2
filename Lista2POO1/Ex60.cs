using System;

public class Ex60
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex60");
        // Código do Ex60...
        Console.Write("Digite o valor de x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor de y: ");
        double y = double.Parse(Console.ReadLine());

        int quadrante = VerificaQuadrante(x, y);

        Console.WriteLine($"\nO ponto ({x}, {y}) está no Quadrante {quadrante}.");
    }

    static int VerificaQuadrante(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return 1;
        }
        else if (x < 0 && y > 0)
        {
            return 2;
        }
        else if (x < 0 && y < 0)
        {
            return 3;
        }
        else if (x > 0 && y < 0)
        {
            return 4;
        }
        else
        {
            // Se x ou y forem zero, retorna 0 (origem)
            return 0;
        }
    }
}
