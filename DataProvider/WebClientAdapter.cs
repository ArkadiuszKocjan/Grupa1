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
        WebClient webClient;  
        WebClientAdapter(WebClient webClient)
        {
            this.webClient = webClient;
        }

        public void DownloadFile(string address, string fileName)
        {
            webClient.DownloadFile(address,fileName);
        }
    }
}
