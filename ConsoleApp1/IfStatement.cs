using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IfStatement
    {
        public static void Main()
        {
            Console.WriteLine("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You Adult");

            }
            else
            {
                Console.WriteLine("You Child");

            }
        }

    }
}