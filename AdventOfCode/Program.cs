namespace AdventOfCode
{
    using Days;
    using Days.Base;
    using System;
    using System.Collections.Generic;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var days = new List<IDay>
            {
                new Day1()
                , new Day2()
                , new Day3()
                , new Day4()
            };

            foreach (var d in days)
            {
                d.RunBothParts();
            }

            Console.WriteLine("----- press enter to end -----");
            Console.ReadLine();
        }
    }
}
