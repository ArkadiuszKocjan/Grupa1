using System;
using System.Collections.Generic;
using System.Linq;

namespace GrepEngine
{
    public class Grep : IGrep
    {
        public IEnumerable<string> InputData { get; private set; }

        public Grep(IEnumerable<string> inputData)
        {
            InputData = inputData;
        }

        public IEnumerable<string> GetLinesContainingSpecifiedToken(string token)
        {
            return InputData.Where(line => line.Contains(token));
        }

        public int CountTokenOccurancesInAllLines(string token)
        {
            return InputData.Sum(x => CountTokenOccurancesInSingleLine(x, token));
        }

        private int CountTokenOccurancesInSingleLine(string line, string token)
        {
            var currentStartIndex = 0;
            var occurancesCount = 0;

            while (true)
            {
                var foundIndex = line.IndexOf(token, currentStartIndex, StringComparison.Ordinal);
                if (foundIndex == -1)
                    break;

                currentStartIndex = foundIndex + token.Length;
                occurancesCount++;
            }

            return occurancesCount;
        }
    }
}
