using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Puzzle1();
            Puzzle2();
        }

        private static void Puzzle1()
        {
            var lines = System.IO.File.ReadAllLines(@"PuzzleDay3Input.txt");

            foreach (var line in lines)
            {
                Console.WriteLine($"{line}");
            }

            var currentX = 0;
            var treeCounter = 0;

            foreach (var line in lines)
            {
                var positions = line.ToArray();

                if (positions[currentX] == Convert.ToChar('#'))
                {
                    treeCounter++;
                }

                currentX += 3;
                currentX %= positions.Length;
            }

            Console.WriteLine($"Treehits from puzzle no1 are {treeCounter}");
            //Console.ReadLine();
        }

        private static void Puzzle2()
        {
            var lines = System.IO.File.ReadAllLines(@"PuzzleDay3Input.txt");

            /* foreach (var line in lines)
            {
                Console.WriteLine($"{line}");
            } */

            var rightSteps = new int[5,2] {{1,1},{3,1},{5,1},{7,1},{1,2}};
            var list = new List<int>();

            for (var x = 0; x < rightSteps.GetLength(0); x++)
            {
                var lineJumps = rightSteps[x, 1];
                var lineCounter = 1;
                var currentX = 0;
                var treeCounter = 0;
                var firstLine = true;

                foreach (var line in lines)
                {
                    if (lineCounter == lineJumps || firstLine)
                    { 
                        firstLine = false;

                        var positions = line.ToArray();

                        if (positions[currentX] == Convert.ToChar('#'))
                        {
                            treeCounter++;
                        }

                        currentX += rightSteps[x, 0];
                        currentX %= positions.Length;
                        lineCounter = 1;
                        continue;
                    }
                    lineCounter++;
                }

                list.Add(treeCounter);
            }
            foreach (var singleResult in list)
            {
                System.Console.WriteLine($"Result {singleResult}");
            }
            
            var resultManual = Convert.ToInt64(list[0])
            * Convert.ToInt64(list[1])
            * Convert.ToInt64(list[2])
            * Convert.ToInt64(list[3])
            * Convert.ToInt64(list[4]);

            Console.WriteLine($"Treehits from puzzle no.2 are {resultManual}");
            Console.ReadLine();
        }
    }
}
