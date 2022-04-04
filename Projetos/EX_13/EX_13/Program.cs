using System;

namespace EX_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double preco, res;

            Console.WriteLine("Digite o codigo do seu produto: 1- hotdog, 2- Xsalada, 3- Xbacon, 4- TorradaSimples, 5- Refri");
            cod = int.Parse(Console.ReadLine());

            if(cod == 1)
            {
                Console.WriteLine("Digite a quantidade: ");
                qtd = int.Parse(Console.ReadLine());

                res = qtd * 4.00;

                Console.WriteLine("Tudo deu: " + res);
            }
            if(cod == 2)
            {
                Console.WriteLine("Digite a quantidade: ");
                qtd = int.Parse(Console.ReadLine());

                res = qtd * 4.50;

                Console.WriteLine("Tudo deu: " + res);
            }
            if(cod == 3)
            {
                Console.WriteLine("Digite a quantidade: ");
                qtd = int.Parse(Console.ReadLine());

                res = qtd * 5.00;

                Console.WriteLine("Tudo deu: " + res);
            }
            if(cod == 4)
            {
                Console.WriteLine("Digite a quantidade: ");
                qtd = int.Parse(Console.ReadLine());

                res = qtd * 2.00;

                Console.WriteLine("Tudo deu: " + res);
            }
            if(cod == 5)
            {
                Console.WriteLine("Digite a quantidade: ");
                qtd = int.Parse(Console.ReadLine());

                res = qtd * 1.50;

                Console.WriteLine("Tudo deu: " + res);
            }

        }
    }
}
