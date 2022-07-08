using System;

namespace CodeToGo.MutableNaive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date1 = new Date(2022, 01, 01);

            date1.Day = 40; // Mutable

            Console.WriteLine($"{date1}");

            var date2 = new Date(2022, 01, 01); 
             
            date1.AddDays(10); // Mutable

            Console.WriteLine($"{date2}"); 

            Console.ReadKey();
        }
    }
}
