using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDarrays
{
      class Program
    {
        static void Main(string[] args)
        {
            int[, ,] numbers = { { {2,3}, { 4, 5 } }, { {6,7 }, { 8, 9 } }, { {6,3 } , {2, 8 } } };
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    for (int z = 0; z < 2; z++)
                    {
                        Console.Write(numbers[x, y, z]);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();    
            }
            Console.ReadLine();
        }
    }
}
