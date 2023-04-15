using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            int maximumValue = 96;
            int step = 7;

            while (value <= maximumValue)
            {
                Console.WriteLine(value);
                value += step;
            }

            Console.ReadKey();
        }
    }
}
