using System;

namespace Ex_15
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y;
                 
            Console.WriteLine("Digite um numero: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o outro numero: ");
            y = double.Parse(Console.ReadLine());


            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Ponto na origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Ponto no eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Ponto no eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Ponto no Q1");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Ponto no Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Ponto no Q3");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Ponto no Q4");
            }
        }
    }
}
