using System.Linq;

namespace AdventOfCode.Day02;

public class Solution : BaseSolution
{
    public Solution() : base(2, "Rock Paper Scissors")
    {
    }

    public override string GetPart1Answer()
    {
        var answers = GetResourceString().Split(Environment.NewLine, StringSplitOptions.None)
            .Select(line => line.Split(" "));
        var score = 0;
        foreach(var answer in answers)
        {
            var _ = (answer[0], answer[1]) switch
            {
                ("A", "X") => score += 1 + 3,
                ("A", "Y") => score += 2 + 6,
                ("A", "Z") => score += 3 + 0,
                ("B", "X") => score += 1 + 0,
                ("B", "Y") => score += 2 + 3,
                ("B", "Z") => score += 3 + 6,
                ("C", "X") => score += 1 + 6,
                ("C", "Y") => score += 2 + 0,
                ("C", "Z") => score += 3 + 3,
                _ => throw new NotImplementedException()
            };
        }
        return $"{score}";
    }

    public override string GetPart2Answer()
    {
        var answers = GetResourceString().Split(Environment.NewLine, StringSplitOptions.None)
           .Select(line => line.Split(" "));
        var score = 0;
        foreach (var answer in answers)
        {
            var _ = (answer[0], answer[1]) switch
            {
                ("A", "X") => score += 3 + 0,
                ("A", "Y") => score += 1 + 3,
                ("A", "Z") => score += 2 + 6,
                ("B", "X") => score += 1 + 0,
                ("B", "Y") => score += 2 + 3,
                ("B", "Z") => score += 3 + 6,
                ("C", "X") => score += 2 + 0,
                ("C", "Y") => score += 3 + 3,
                ("C", "Z") => score += 1 + 6,
                _ => throw new NotImplementedException()
            };
        }
        return $"{score}";
    }
}
