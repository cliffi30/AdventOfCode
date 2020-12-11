using System;
using System.Collections;
using System.Collections.Generic;

namespace PuzzleDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            var passports = new List<Dictionary<string, string>>();
            var rawPorts = System.IO.File.ReadAllLines(@"../Puzzle4Input.txt");

            var dic = new Dictionary<string, string>();

            foreach (var x in rawPorts)
            {
                if (x == "")
                { 
                    passports.Add(dic);
                    dic = new Dictionary<string, string>();
                    continue; }

                var properties = x.Split(' ');

                foreach (var prop in properties)
                {
                    var item = prop.Split(':');
                    dic.Add(item[0], item[1]);
                }
            }

            int validPassports = 0;

            foreach (var passport in passports)
            {
                if (passport.Count == 8)
                {
                    validPassports++;
                }

                if (passport.Count == 7 && !passport.ContainsKey("cid"))
                {
                    validPassports++;
                }
            }

            System.Console.WriteLine($"There are {validPassports} valid passports in the list.");
            Console.ReadLine();
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
