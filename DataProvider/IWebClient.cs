using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    interface IWebClient
    {
        void DownloadFile(string address, string fileName);
    }
}
