using System.Collections;
using System.Collections.Generic;

namespace GrepEngine
{
    public interface IGrep
    {
        IEnumerable<string> GetLinesContainingSpecifiedToken(string token);
        int CountTokenOccurancesInAllLines(string token);
    }
}
