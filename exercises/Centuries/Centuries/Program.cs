using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries: ");
            var a = int.Parse(Console.ReadLine());

            var years = a * 100;
            var days = years * 365;
            var hours = days * 24;
            var min = hours * 60;

            Console.WriteLine(a + " centuries is equal to:");
            Console.WriteLine(years + " years.");
            Console.WriteLine(days + " days.");
            Console.WriteLine(hours + " hours.");
            Console.WriteLine(min + " minutes.");
            
            



        }
    }
}
