using System;

public class Ex40
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex40");
        // Código do Ex40...
        char resposta;

        do
        {
            // Solicita ao usuário que insira o índice de poluição medido
            Console.Write("Digite o índice de poluição medido: ");
            double indicePoluicao = double.Parse(Console.ReadLine());

            // Emite a notificação adequada aos diferentes grupos de empresas
            EmitirNotificacao(indicePoluicao);

            // Pergunta ao usuário se deseja encerrar o programa
            Console.Write("Deseja encerrar o programa? (S/n): ");
            resposta = char.Parse(Console.ReadLine());

        } while (resposta != 'S' && resposta != 's');
    }

    // Função para emitir a notificação adequada aos diferentes grupos de empresas
    static void EmitirNotificacao(double indicePoluicao)
    {
        if (indicePoluicao >= 0.5)
        {
            Console.WriteLine("Todos os grupos de empresas devem paralisar suas atividades.");
        }
        else if (indicePoluicao >= 0.4)
        {
            Console.WriteLine("Indústrias do 1º e 2º grupo devem suspender suas atividades.");
        }
        else if (indicePoluicao >= 0.3)
        {
            Console.WriteLine("Indústrias do 1º grupo devem suspender suas atividades.");
        }
        else if (indicePoluicao >= 0.25)
        {
            Console.WriteLine("Índice de poluição dentro do limite aceitável.");
        }
        else
        {
            Console.WriteLine("Índice de poluição abaixo do limite aceitável.");
        }
    }
}
