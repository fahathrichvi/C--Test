using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AddNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Enter Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int ans = num1 + num2;

            Console.WriteLine("Total is: " + ans);

        }
    }
}
