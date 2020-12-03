using System;
using System.Linq;

namespace PuzzleDay2
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
            var path = @"C:\Temp\puzzleDay2Input.txt";

            var lines = System.IO.File.ReadAllLines(path);

            var passwords = lines.Select(line => line.Split(' '))
                .Select(temp => new Passworts
                {
                    Postion = new[]
                    {
                        Convert.ToInt32(temp[0].Split('-')[0]), Convert.ToInt32(temp[0].Split('-')[1])
                    }
                    ,
                    CheckLetter = Convert.ToChar(temp[1].Substring(0, 1))
                    ,
                    Password = temp[2]
                })
                .ToList();

            var trueCounter = 0;

            foreach (var password in passwords)
            {
                var found = false;

                foreach (var pos in password.Postion)
                {
                    if (password.Password.ToArray()[pos - 1] == password.CheckLetter)
                    {
                        if (found == false)
                        {
                            password.Valid = true;
                            found = true;
                        }
                        else
                        {
                            password.Valid = false;
                        }
                    }
                }

                if (password.Valid)
                {
                    trueCounter++;
                }
            }

            Console.WriteLine($"{trueCounter} are valid, {passwords.Count - trueCounter} are false.");
            Console.ReadLine();
        }

        private static void Puzzle2()
        {
            var path = @"C:\Temp\puzzleDay2Input.txt";

            var lines = System.IO.File.ReadAllLines(path);

            var passwords = lines.Select(line => line.Split(' '))
                .Select(temp => new Passworts
                {
                    Postion = new[]
                    {
                        Convert.ToInt32(temp[0].Split('-')[0]), Convert.ToInt32(temp[0].Split('-')[1])
                    }
                    , CheckLetter = Convert.ToChar(temp[1].Substring(0, 1))
                    , Password = temp[2]
                })
                .ToList();

            var trueCounter = 0;

            foreach (var password in passwords)
            {
                var found = false;

                foreach (var pos in password.Postion)
                {
                    if (password.Password.ToArray()[pos - 1] == password.CheckLetter)
                    {
                        if (found == false)
                        {
                            password.Valid = true;
                            found = true;
                        }
                        else
                        {
                            password.Valid = false;
                        }
                    }
                }

                if (password.Valid)
                {
                    trueCounter++;
                }
            }

            Console.WriteLine($"{trueCounter} are valid, {passwords.Count - trueCounter} are false.");
            Console.ReadLine();
        }
    }

    class Passworts
    {
        public int[] Postion { get; set; }
        public char CheckLetter { get; set; }
        public string Password { get; set; }
        public bool Valid { get; set; }
    }
}
