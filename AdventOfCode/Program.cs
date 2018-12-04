﻿namespace AdventOfCode
{
    using Base;
    using System;
    using System.Collections.Generic;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var puzzles = new List<IPuzzle>
            {
                new Puzzles.Day1.Impl()
                , new Puzzles.Day2.Impl()
                , new Puzzles.Day3.Impl()
                , new Puzzles.Day3.Impl2()
                , new Puzzles.Day4.Impl()
            };

            puzzles.ForEach(f => f.RunBothParts());

            Console.WriteLine("----- press enter to end -----");
            Console.ReadLine();
        }
    }
}
