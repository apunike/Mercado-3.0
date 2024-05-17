using System;

namespace teste111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = { "arroz", "sorvete", "feijão", "cerveja Artesanal", "amendoim", "Bonnatti 1l chocolate", "Bacalhau da Maria" };
            double[] preços = { 10.5, 5.0, 9.0, 15.0, 4.0, 22.0, 75.0 };

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {produtos[i]}  R$ {preços[i]}");
            }
            Console.WriteLine(">>>> Faça uma escolha <<<");

            int escolha = int.Parse(Console.ReadLine());
            while (escolha < 0 || escolha > produtos.Length)
            {
                Console.WriteLine("Faça uma escolha válida");
                escolha = int.Parse(Console.ReadLine());

            }
            double total = preços[escolha - 1];
            Console.WriteLine($"Sua escolha foi {escolha} e o valor foi de R$ {total} total");

            Console.WriteLine("Deseja adicionar mais item?");
            string resposta = Console.ReadLine();
            total = preços[escolha - 1];

            while (resposta.Equals("sim"))
            {
                Console.WriteLine("Qual sua escolha");
                escolha = int.Parse(Console.ReadLine());
                total += preços[escolha - 1];
                Console.WriteLine("Deseja continuar?");
                resposta = Console.ReadLine();
            }

            Console.WriteLine($"Valor total da compra foi de ${total}");


        }
    }
}
