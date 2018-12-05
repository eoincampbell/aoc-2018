namespace AdventOfCode.Puzzles.Day5
{
    using Base;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Impl : BasePuzzle
    {
        public Impl() : base("Day 5 ", ".\\Puzzles\\Day5\\Input.txt") { }

        public override string RunPart1()
        {
            var chars = Inputs.First().ToCharArray().ToList();

            var result = RecursiveReduction(chars);
                
            return $"Len: {result.Count}";
        }

        public override string RunPart2()
        {
            var bestShortLength = int.MaxValue;
            var removed = "";
            for (int i = 'A'; i <= 'Z'; i++)
            {
                var j = i;
                var chars = Inputs.First().Where(f => f != (char)j && f != (char)(j+32)).ToList();
                var result = RecursiveReduction(chars);
                if (result.Count >= bestShortLength)
                    continue;

                bestShortLength = result.Count;
                removed = $"{(char) i}/{(char) (i + 32)}";
            }

            return $"Removed: {removed} | Len: {bestShortLength}";
        }

        private bool CharCompare(char a, char b)
        {
            return (a+32 == b || a-32 == b);
        }

        private List<char> RecursiveReduction(List<char> chars)
        {
            var removed = false;
            for (var i = 0; i < chars.Count - 1; i++)
            {
                if (!CharCompare(chars[i], chars[i + 1]))
                    continue;

                removed = true;
                chars.RemoveAt(i + 1);
                chars.RemoveAt(i);
            }

            if (removed)
                chars = RecursiveReduction(chars);
            

            return chars;
        }
    }
}