using System;

namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)

        {
            int res;


            Console.WriteLine("Numero da matricula: ");
            int mat = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero de horas trabalhadas: ");
            int hor = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor da hora: ");
            int val = int.Parse(Console.ReadLine());

            res = hor * val;

            Console.WriteLine("O funcionario: " + mat + " Recebe: " + res);
        }
    }
}
