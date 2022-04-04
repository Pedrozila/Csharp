using System;

namespace Ex_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ponto X: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ponto y: ");
            double y = double.Parse(Console.ReadLine());

            while(x != 0.0 && y != 0.0)
            {
                if(x >= 0.1 && y >= 0.1)
                {
                    Console.WriteLine("ponto no quadrante 1");

                    Console.WriteLine("Digite x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite y: ");
                    y = double.Parse(Console.ReadLine());
                }
                else if(x <= -0.1 && y >= 0.1)
                {
                    Console.WriteLine("ponto no quadrante 2");

                    Console.WriteLine("Digite x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite y: ");
                    y = double.Parse(Console.ReadLine());
                }
                else if(x <= -0.1 && y <= -0.1)
                {
                    Console.WriteLine("ponto no quadrante 3");

                    Console.WriteLine("Digite x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite y: ");
                    y = double.Parse(Console.ReadLine());
                 }
                else if(x >= 0.1 && y <= -0.1)
                {
                    Console.WriteLine("ponto no quadrante 4");

                    Console.WriteLine("Digite x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite y: ");
                    y = double.Parse(Console.ReadLine());                }
            }
        }
    }
}
