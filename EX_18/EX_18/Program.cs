using System;

namespace EX_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o PIN: ");
            int pin = int.Parse(Console.ReadLine());

            while(pin != 2002)
            {
                Console.WriteLine("Pin incorreto, tente novamente: ");
                pin = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Pin correto, acesso liberado!!");
        }
    }
}
