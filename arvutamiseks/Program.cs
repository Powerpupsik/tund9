using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvutamiseks
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear;
            Console.WriteLine("Enter your year of birth");
            birthYear = int.Parse(Console.ReadLine());
            CalculateAge(birthYear);

            Console.ReadLine();
        }

        public static void CalculateAge(int birthYear)
        {
            Console.WriteLine($"You are {2019 - birthYear}");
        }
    }
}
