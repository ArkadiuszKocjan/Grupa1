using System;
using System.Collections.Generic;
using System.Linq;

namespace GrepEngine
{
    public class Grep : IGrep
    {
        private readonly ILogger _logger;
        public IEnumerable<string> InputData { get; private set; }

        public Grep(IEnumerable<string> inputData, ILogger logger = null)
        {
            if(logger == null) logger = new Logger();

            _logger = logger;
            InputData = inputData;
        }

        public IEnumerable<string> GetLinesContainingSpecifiedToken(string token)
        {
            _logger.Log("GetLinesContainingSpecifiedToken invoked");
            return InputData.Where(line => line.Contains(token));
        }

        public int CountTokenOccurancesInAllLines(string token)
        {
            _logger.Log("CountTokenOccurancesInAllLines invoked");
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

    public class Logger : ILogger
    {
        public void Log(string toLog)
        {
            global::Logger.Logger.Log(toLog);
        }
    }
}
