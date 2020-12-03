using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Puzzle1();
            Puzzle2();
        }

        private static void Puzzle1()
        {
            var input = System.IO.File.ReadAllLines(@"..\..\..\Input.txt");
            var numbers = input.Select(i => Convert.ToInt16(i)).ToList();

            var pos1 = 0;
            var pos2 = 0;

            for (var x = 0; x < numbers.Count; x++)
            {
                for (var y = x + 1; y < numbers.Count; y++)
                {
                    if (numbers[x] + numbers[y] != 2020) continue;
                    pos1 = x;
                    pos2 = y;

                    break;
                }
            }

            Console.WriteLine($"The numbers adding up to 2020 are {input[pos1]} and {input[pos2]}");
            Console.WriteLine($"Puzzle1 result = {numbers[pos1] * numbers[pos2]}");
            Console.ReadLine();
        }

        private static void Puzzle2()
        {
            var input = System.IO.File.ReadAllLines(@"..\..\..\Input.txt");
            var numbers = input.Select(i => Convert.ToInt16(i)).ToList();

            var pos1 = 0;
            var pos2 = 0;
            var pos3 = 0;

            for (var x = 0; x < numbers.Count; x++)
            {
                for (var y = x + 1; y < numbers.Count; y++)
                {
                    for (int z = y + 1; z < numbers.Count; z++)
                    {
                        if (numbers[x] + numbers[y] + numbers[z] != 2020) continue;
                        pos1 = x;
                        pos2 = y;
                        pos3 = z;
                        break;
                    }
                }
            }

            Console.WriteLine($"The numbers adding up to 2020 are {input[pos1]} and {input[pos2]} and {input[pos3]}");
            Console.WriteLine($"Puzzle1 result = {numbers[pos1] * numbers[pos2] * numbers[pos3]}");
            Console.ReadLine();
        }
    }
}
