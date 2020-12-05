using System;

namespace PuzzleDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawPorts = System.IO.File.ReadAllLines(@"../Puzzle4Input.txt");
            foreach (var x in rawPorts)
            System.Console.WriteLine($"{x}");
        }
    }

    class Passport 
    {
        public uint BirthYear { get; set; }
        public uint IssueYear { get; set; } 
        public uint ExpirationYear { get; set; }
        public uint Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Id { get; set; }
        public string Country { get; set; }
    }
}
