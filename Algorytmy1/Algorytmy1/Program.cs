using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textLines = System.IO.File.ReadAllLines("C:\\Users\\Paweł\\source\\repos\\Algorytmy1\\Algorytmy1\\TextFile1.txt");
            Console.WriteLine(Max(textLines));
            Console.ReadKey();
        }

        public static double Max(string[] lines)
        {
            List<double> numbers = new List<double>();
            foreach (string i in lines)
            {
                numbers.Add(Convert.ToDouble(i));
            }
            double max = numbers[0];
            foreach (double i in numbers)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
