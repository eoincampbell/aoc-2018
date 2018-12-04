namespace AdventOfCode.Days
{
    using Base;
    using System.Collections.Generic;
    using System.Linq;

    public class Day1 : BaseDay
    {
        public Day1() : base("Day 1", ".\\Inputs\\Day1.txt") { }

        public override string RunPart1()
        {
            return Inputs.Sum(int.Parse).ToString();
        }

        public override string RunPart2()
        {
            int counter = 0, i = 0;
            var inputs = Inputs.Select(int.Parse).ToList();
            var occurenceTracker = new Dictionary<int, int> {{0, 1}};
            
            while (true)
            {
                counter += inputs[i];

                if (occurenceTracker.ContainsKey(counter)) return $"{counter} was received twice.";
                
                occurenceTracker.Add(counter, 1);
                
                if (inputs.Count == ++i) i = 0;
            }
        }
    }
}