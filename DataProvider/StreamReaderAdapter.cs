using System.IO;

namespace DataProvider 
{
    class StreamReaderAdapter : IStreamReader
    {
        private readonly StreamReader _streamReader;
        StreamReaderAdapter(StreamReader streamReader)
        {
            _streamReader = streamReader;
        }

        public string ReadLine()
        {
            return _streamReader.ReadLine();
        }
    }
}
