using System;
using System.Globalization;

namespace Ex_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite as informações do 1 funcionario: ");
            Console.WriteLine("Nome: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Salario :");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite as informaçoes do 2 funcionario: ");
            Console.WriteLine("Nome: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Salario: ");
            f2.salario = double.Parse(Console.ReadLine());

            double media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("Salario médio: " + media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
