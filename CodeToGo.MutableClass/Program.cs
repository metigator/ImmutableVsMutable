using System;

namespace CodeToGo.MutableClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date1 = new Date(2022, 01, 01);

            //date1.Day = 40; // Error compile time

            Console.WriteLine($"{date1}");

             date1.AddDays(10); // Mutable

            Console.WriteLine($"{date1}"); 

            Console.ReadKey();
        }
    }
}
