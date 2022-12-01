global using AdventOfCode;
global using AdventOfCode.Properties;
global using System;
global using System.Collections.Generic;

const bool withStats = true;

var solution = SolutionRepository.GetSolutionByDay(1);
if (!string.IsNullOrWhiteSpace(solution.Title))
{        
    solution.ConsoleDump(withStats);
}

Console.ReadLine();