namespace AdventOfCode.Days.Base
{
    using System;
    using System.Diagnostics;
    using System.IO;
    public abstract class BaseDay : IDay
    {
        private readonly string _inputFile;

        private readonly Stopwatch _stopWatch;

        protected string[] Inputs;

        protected BaseDay(string name, string inputFile)
        {
            Name = name;
            _inputFile = inputFile;
            _stopWatch = new Stopwatch();
        }

        private void ResetInputs()
        {
            _stopWatch.Reset();
            _stopWatch.Start();
            Inputs = File.ReadAllLines(_inputFile);
        }

        public string Name { get; }

        public void RunBothParts()
        {
            //Part 1
            ResetInputs();
            _stopWatch.Reset();
            _stopWatch.Start();
            var p1Result = RunPart1();
            _stopWatch.Stop();

            Console.WriteLine($"{Name} Part 1 | Exec: {_stopWatch.Elapsed:c} | {p1Result}");

            //Part 2
            ResetInputs();
            _stopWatch.Reset();
            _stopWatch.Start();
            var p2Result = RunPart2();
            _stopWatch.Stop();

            Console.WriteLine($"{Name} Part 2 | Exec: {_stopWatch.Elapsed:c} | {p2Result}");
        }


        public abstract string RunPart1();
        public abstract string RunPart2();
    }
}
