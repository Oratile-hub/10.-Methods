using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call for the SayHi METHOD
            SayHi();

            AddNumbers();

            //freeze console
            Console.ReadLine();
        }
        static void SayHi()
        {
            Console.WriteLine("Your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);           
        }
        static void AddNumbers()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
}
