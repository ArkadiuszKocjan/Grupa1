using System.Net;

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
