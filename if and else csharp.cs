using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCsharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coloque um numero inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) 
            {
                Console.WriteLine("par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }
    }
}
