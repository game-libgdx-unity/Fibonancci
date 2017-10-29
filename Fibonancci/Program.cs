using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonancci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum: {0}", Fibonancci());
            Console.ReadLine();
        }
        static ulong Fibonancci()
        {
            ulong result = 0, n1 = 0, n2 = 1;
            ulong sum = 0;

            while (result <= 4000000)
            {
                result = n1 + n2;

                if (result > 4000000)
                {
                    break;
                }

                if (result % 2 == 0 && result < 4000000)
                {
                    sum += result;
                }

                n1 = n2;
                n2 = result;

            }
            return sum;
        }
    }
}
