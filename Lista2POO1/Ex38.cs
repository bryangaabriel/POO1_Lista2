using System;

public class Ex38
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex38");
        // C�digo do Ex38...
        char resposta;

        do
        {
            // Solicita ao usu�rio que insira o c�digo e o n�mero de horas trabalhadas
            Console.Write("Digite o c�digo do oper�rio: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o n�mero de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            // Calcula o sal�rio
            double salario = CalcularSalario(horasTrabalhadas);

            // Exibe o sal�rio total e o sal�rio excedente, se houver
            Console.WriteLine($"Sal�rio total do oper�rio (C�digo {codigo}): R$ {salario}");

            // Pergunta ao usu�rio se deseja encerrar o programa
            Console.Write("Deseja encerrar o programa? (S/n): ");
            resposta = char.Parse(Console.ReadLine());

        } while (resposta != 'S' && resposta != 's');
    }

    // Fun��o para calcular o sal�rio com base no n�mero de horas trabalhadas
    static double CalcularSalario(int horasTrabalhadas)
    {
        double valorHoraNormal = 10.00;
        double valorHoraExtra = 20.00;
        int horasNormais = Math.Min(horasTrabalhadas, 50);
        int horasExtras = Math.Max(horasTrabalhadas - 50, 0);

        // Calcula o sal�rio total
        double salarioTotal = (horasNormais * valorHoraNormal) + (horasExtras * valorHoraExtra);

        // Calcula o sal�rio excedente, se houver
        double salarioExcedente = horasExtras > 0 ? (horasExtras * (valorHoraExtra - valorHoraNormal)) : 0;

        // Exibe o sal�rio excedente, se houver
        Console.WriteLine($"Sal�rio excedente: R$ {salarioExcedente}");

        return salarioTotal;
    }
}
