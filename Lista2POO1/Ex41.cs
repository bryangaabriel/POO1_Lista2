using System;

public class Ex41
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex41");
        // Código do Ex41...
        char resposta;

        do
        {
            // Solicita ao usuário que insira a idade do nadador
            Console.Write("Digite a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            // Classifica o nadador em uma das categorias
            ClassificarNadador(idade);

            // Pergunta ao usuário se deseja encerrar o programa
            Console.Write("Deseja encerrar o programa? (S/n): ");
            resposta = char.Parse(Console.ReadLine());

        } while (resposta != 'S' && resposta != 's');
    }

    // Função para classificar o nadador em uma das categorias
    static void ClassificarNadador(int idade)
    {
        if (idade >= 5 && idade <= 7)
        {
            Console.WriteLine("Categoria: Infantil A");
        }
        else if (idade >= 8 && idade <= 11)
        {
            Console.WriteLine("Categoria: Infantil B");
        }
        else if (idade >= 12 && idade <= 13)
        {
            Console.WriteLine("Categoria: Juvenil A");
        }
        else if (idade >= 14 && idade <= 17)
        {
            Console.WriteLine("Categoria: Juvenil B");
        }
        else if (idade >= 18)
        {
            Console.WriteLine("Categoria: Adultos");
        }
        else
        {
            Console.WriteLine("Idade fora das faixas de categorias especificadas.");
        }
    }
}
