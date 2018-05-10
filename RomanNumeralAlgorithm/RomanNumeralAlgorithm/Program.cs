using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeralLogic Problem = new RomanNumeralLogic();
            //input and print to screen
            Console.WriteLine(Problem.RomanToInt("IV"));
            Console.ReadLine();
        }
    }
}

