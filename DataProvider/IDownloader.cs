using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    interface IDownloader
    {
        IEnumerable<string> DownloadWebpageAsText(string url);
        void CancelRequest();
    }
}
