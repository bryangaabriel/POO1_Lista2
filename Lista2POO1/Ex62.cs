using System;

public class Ex62
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex62");
        // C�digo do Ex62...
        Console.Write("Digite o valor da base do tri�ngulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor da altura do tri�ngulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);

        Console.WriteLine($"\nO valor da hipotenusa �: {hipotenusa:F2}");
    }

    static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
    {
        // Calcula o quadrado da hipotenusa
        double quadradoHipotenusa = Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2);

        // Calcula a hipotenusa
        double hipotenusa = Math.Sqrt(quadradoHipotenusa);

        return hipotenusa;
    }
}
