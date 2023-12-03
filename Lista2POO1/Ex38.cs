using System;

public class Ex38
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex38");
        // Código do Ex38...
        char resposta;

        do
        {
            // Solicita ao usuário que insira o código e o número de horas trabalhadas
            Console.Write("Digite o código do operário: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            // Calcula o salário
            double salario = CalcularSalario(horasTrabalhadas);

            // Exibe o salário total e o salário excedente, se houver
            Console.WriteLine($"Salário total do operário (Código {codigo}): R$ {salario}");

            // Pergunta ao usuário se deseja encerrar o programa
            Console.Write("Deseja encerrar o programa? (S/n): ");
            resposta = char.Parse(Console.ReadLine());

        } while (resposta != 'S' && resposta != 's');
    }

    // Função para calcular o salário com base no número de horas trabalhadas
    static double CalcularSalario(int horasTrabalhadas)
    {
        double valorHoraNormal = 10.00;
        double valorHoraExtra = 20.00;
        int horasNormais = Math.Min(horasTrabalhadas, 50);
        int horasExtras = Math.Max(horasTrabalhadas - 50, 0);

        // Calcula o salário total
        double salarioTotal = (horasNormais * valorHoraNormal) + (horasExtras * valorHoraExtra);

        // Calcula o salário excedente, se houver
        double salarioExcedente = horasExtras > 0 ? (horasExtras * (valorHoraExtra - valorHoraNormal)) : 0;

        // Exibe o salário excedente, se houver
        Console.WriteLine($"Salário excedente: R$ {salarioExcedente}");

        return salarioTotal;
    }
}
