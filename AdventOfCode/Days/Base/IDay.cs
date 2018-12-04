namespace AdventOfCode.Days.Base
{
    public interface IDay
    {
        string Name { get; }

        void RunBothParts();
        string RunPart1();
        string RunPart2();
    }
}