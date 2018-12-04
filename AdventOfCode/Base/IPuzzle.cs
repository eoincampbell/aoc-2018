namespace AdventOfCode.Base
{
    public interface IPuzzle
    {
        string Name { get; }
        void RunBothParts();
        string RunPart1();
        string RunPart2();
    }
}