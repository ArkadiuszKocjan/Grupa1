using System.Collections;
using System.Collections.Generic;

namespace GrepEngine
{
    public interface IGrep
    {
        GrepResult FindLinesContainingSpecifiedString();
    }

    public class GrepResult
    {
        public int OccurancesCount { get; private set; }
        public IEnumerable<string> LinesContaining { get; private set; }
    }
}
