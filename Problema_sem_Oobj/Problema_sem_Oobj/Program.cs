using System;

namespace Problema_sem_Oobj
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double xP = (x.A + x.B + x.C) / 2.0;
            double yP = (y.A + y.B + y.C) / 2.0;

            double Ax = Math.Sqrt(xP * (xP - x.A) * (xP - x.B) * (xP - x.C));
            double Ay = Math.Sqrt(yP * (yP - y.A) * (yP - y.B) * (yP - y.C));

            Console.WriteLine("Area de x = " + Ax);
            Console.WriteLine("Area de y = " + Ay);

            if (Ax > Ay)
            {
                Console.WriteLine("Maior area: x");              
            }
            else
            {
                Console.WriteLine("Maior area: y");
            }
        }
    }
}
