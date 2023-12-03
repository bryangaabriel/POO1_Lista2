using System;

public class Ex61
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex61");
        // C�digo do Ex61...
        Console.Write("Digite o sal�rio atual: ");
        double salarioAtual = double.Parse(Console.ReadLine());

        Console.Write("Digite o �ndice de reajuste (em porcentagem): ");
        double indiceReajuste = double.Parse(Console.ReadLine());

        double salarioAtualizado = Reajuste(salarioAtual, indiceReajuste);

        Console.WriteLine($"\nO sal�rio atualizado �: {salarioAtualizado:C}");
    }

    static double Reajuste(double salario, double indiceReajuste)
    {
        // Calcula o valor do reajuste
        double valorReajuste = salario * (indiceReajuste / 100);

        // Calcula o sal�rio atualizado
        double salarioAtualizado = salario + valorReajuste;

        return salarioAtualizado;
    }
}
