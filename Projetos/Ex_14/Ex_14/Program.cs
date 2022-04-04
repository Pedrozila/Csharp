using System;

namespace Ex_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double num = double.Parse(Console.ReadLine());

            if(num < 0.0 || num > 100.0)
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if(num == 0 || num <= 25)
            {
                Console.WriteLine("dentro do intervalo de 00 a 25");
            }
            else if(num == 25 || num <= 50)
            {
                Console.WriteLine("dentro do intervalo de 25 a 50");
            }
            else if(num == 50 || num <= 75)
            {
                Console.WriteLine("dentro do intervalo de 50 a 75");
            }
            else if(num == 75 || num <= 100)
            {
                Console.WriteLine("dentro do intervalo de 75 a 100");
            }
        }
    }
}
