using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class Downloader : IDownloader
    {
        WebClient client;

        public Downloader() {
            client = new WebClient();
        }

        public IEnumerable<string> DownloadWebpageAsText(string url)
        {
            string file = client.DownloadString(url);

            if (String.IsNullOrEmpty(file))
            {
                throw new FileEmptyException();
            }

            List<string> result = file.Split(new char[] { '\n' }).ToList();

            return result;
        }

        private IEnumerable<String> ReadFileToNewList(string filePath)
        {
            string line;
            List<String> lines = new List<string>();

            StreamReader file = new StreamReader(filePath);

            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines;
        }
    }
}
