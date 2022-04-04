using System;

namespace Ex_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Entre com os dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Mais velho: " + pessoa1);
            }
            else
            {
                Console.WriteLine("Mais velho: " + pessoa2);
            }
            
        }
    }
}
