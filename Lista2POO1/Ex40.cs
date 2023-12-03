using System;

public class Ex40
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex40");
        // C�digo do Ex40...
        char resposta;

        do
        {
            // Solicita ao usu�rio que insira o �ndice de polui��o medido
            Console.Write("Digite o �ndice de polui��o medido: ");
            double indicePoluicao = double.Parse(Console.ReadLine());

            // Emite a notifica��o adequada aos diferentes grupos de empresas
            EmitirNotificacao(indicePoluicao);

            // Pergunta ao usu�rio se deseja encerrar o programa
            Console.Write("Deseja encerrar o programa? (S/n): ");
            resposta = char.Parse(Console.ReadLine());

        } while (resposta != 'S' && resposta != 's');
    }

    // Fun��o para emitir a notifica��o adequada aos diferentes grupos de empresas
    static void EmitirNotificacao(double indicePoluicao)
    {
        if (indicePoluicao >= 0.5)
        {
            Console.WriteLine("Todos os grupos de empresas devem paralisar suas atividades.");
        }
        else if (indicePoluicao >= 0.4)
        {
            Console.WriteLine("Ind�strias do 1� e 2� grupo devem suspender suas atividades.");
        }
        else if (indicePoluicao >= 0.3)
        {
            Console.WriteLine("Ind�strias do 1� grupo devem suspender suas atividades.");
        }
        else if (indicePoluicao >= 0.25)
        {
            Console.WriteLine("�ndice de polui��o dentro do limite aceit�vel.");
        }
        else
        {
            Console.WriteLine("�ndice de polui��o abaixo do limite aceit�vel.");
        }
    }
}
