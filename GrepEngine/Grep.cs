using System.Collections.Generic;

namespace GrepEngine
{
    public class Grep : IGrep
    {
        public IEnumerable<string> InputData { get; private set; }

        public Grep(IEnumerable<string> inputData)
        {
            InputData = inputData;
        }

        public GrepResult FindLinesContainingSpecifiedString()
        {
            throw new System.NotImplementedException();
        }
    }
}
