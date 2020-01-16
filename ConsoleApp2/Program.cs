using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int komputery = 24;
            int studenci;
            double wynik;
            Console.WriteLine("How many studends are there?");
            studenci = Convert.ToInt32(Console.ReadLine());
            wynik = (double) studenci / komputery;
            Console.WriteLine($"There is {wynik} computers per student.");
            Console.ReadKey();
        }
    }
}
