using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    class WebClientAdapter : IWebClient
    {
        readonly WebClient _webClient;  
        WebClientAdapter(WebClient webClient)
        {
            this._webClient = webClient;
        }

        public void DownloadFile(string address, string fileName)
        {
            _webClient.DownloadFile(address,fileName);
        }


        public string DownloadString(string url)
        {
            return _webClient.DownloadString(url);
        }
    }
}
