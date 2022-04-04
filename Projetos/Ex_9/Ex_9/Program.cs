using System;

namespace Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            
            if(x > 0)
            {
                Console.WriteLine("não negativo!!!");
            }
            else
            {
                Console.WriteLine("negativo!!!");
            }
        }
       
    }
}
