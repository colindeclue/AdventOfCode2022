using System.Linq;

namespace AdventOfCode.Day01;

public class Solution : BaseSolution
{
    public Solution() : base(1, "")
    {
    }

    public override string GetPart1Answer()
    {
        var rawCalories = GetResourceString()
            .Split(Environment.NewLine, StringSplitOptions.None);
        List<List<int>> caloriesLists = new();
        List<int> current = new();

        foreach(var calorie in rawCalories)
        {
            if (string.IsNullOrWhiteSpace(calorie))
            {
                caloriesLists.Add(current);
                current = new();
            }
            else
            {
                current.Add(int.Parse(calorie));
            }
        }

        caloriesLists.Add(current);

        return $"{caloriesLists.Max(i => i.Sum())}";
    }

    public override string GetPart2Answer()
    {
        var rawCalories = GetResourceString()
            .Split(Environment.NewLine, StringSplitOptions.None);
        List<List<int>> caloriesLists = new();
        List<int> current = new();

        foreach (var calorie in rawCalories)
        {
            if (string.IsNullOrWhiteSpace(calorie))
            {
                caloriesLists.Add(current);
                current = new();
            }
            else
            {
                current.Add(int.Parse(calorie));
            }
        }

        caloriesLists.Add(current);

        return $"{caloriesLists.OrderByDescending(i => i.Sum()).Take(3).Sum(i => i.Sum())}";
    }
}