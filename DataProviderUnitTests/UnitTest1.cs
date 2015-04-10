using DataProvider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataProviderUnitTests
{

    [TestClass]
    public class UnitTest1
    {
        Downloader Downloader;
        string url;
        string wrongUrl = "aaaaa.html/test.txt";
        string targetFileName;

        [TestInitialize]
        public void Initialize()
        {
            Downloader = new Downloader();
        }

        [TestMethod]
        [ExpectedException(typeof(WebException), "Wrong URL specified - WebException should have been thrown")]
        public void ShouldThrowWebException_whenWrongUrlIsSpecified()
        {
            targetFileName = @"downloadedFile.txt";

            Downloader.DownloadWebpageAsText(wrongUrl, targetFileName);
        }
    }
}
