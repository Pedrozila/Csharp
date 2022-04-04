using System;

namespace EX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos ha em sua casa?: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu ultimo nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);


            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString("F"));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
        }
    }
}
