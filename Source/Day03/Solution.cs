using System.Linq;

namespace AdventOfCode.Day03;

public class Solution : BaseSolution
{
    public Solution() : base(3, "Rucksacks")
    {
    }


    static IEnumerable<string> WholeChunks(string str, int chunkSize)
    {
        for (int i = 0; i < str.Length; i += chunkSize)
            yield return str.Substring(i, chunkSize);
    }

    static IEnumerable<List<string>> StringChunks(string[] strings, int size)
    {
        for(int i = 0; i< strings.Count(); i += size)
        {
            yield return strings.ToList().GetRange(i, size);
        }
    }

    public override string GetPart1Answer()
    {
        var rucksacks = GetResourceString().Split(Environment.NewLine, StringSplitOptions.None);
        var score = 0;
        foreach(var part in rucksacks)
        {
            var parts = WholeChunks(part, part.Length / 2).ToList();
            var match = (char)0;
            foreach (char letter in parts[1])
            {
                if (parts[0].Contains(letter))
                {
                    match = letter;
                    break;
                }
            }

            if(match >= 'a')
            {
                var scoreValue = match - '`';
                score += scoreValue;
            }
            else
            {
                var scoreValue = match - '@' + 26;
                score += scoreValue;
            }
        }

        return $"{score}";
    }

    public override string GetPart2Answer()
    {
        var rucksacks = GetResourceString().Split(Environment.NewLine, StringSplitOptions.None);
        var score = 0;
        foreach (var part in StringChunks(rucksacks, 3))
        {
            var match = (char)0;
            foreach (char letter in part[1])
            {
                if (part[0].Contains(letter) && part[2].Contains(letter))
                {
                    match = letter;
                    break;
                }
            }

            if (match >= 'a')
            {
                var scoreValue = match - '`';
                score += scoreValue;
            }
            else
            {
                var scoreValue = match - '@' + 26;
                score += scoreValue;
            }
        }

        return $"{score}";
    }
}
