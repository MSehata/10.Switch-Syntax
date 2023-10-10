using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Switch_Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number IN(1, 2, 3) : ");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("You entered 1.");
                    break;

                case 2:
                    Console.WriteLine("You entered 2.");
                    break;

                case 3:
                    Console.WriteLine("You entered 3.");
                    break;

                default:
                    Console.WriteLine("Enter the number from 1 to 3.");
                    break;
            }

            Console.Read();
        }
    }
}
