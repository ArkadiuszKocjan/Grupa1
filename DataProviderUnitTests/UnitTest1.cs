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
        string correctUrl = "https://wordpress.org/plugins/about/readme.txt";
        string wrongUrl = "aaaaa.html/test.txt";

        [TestInitialize]
        public void Initialize()
        {
            Downloader = new Downloader();
        }

        [TestMethod]
        [ExpectedException(typeof(WebException), "Wrong URL specified - WebException should have been thrown")]
        public void ShouldThrowWebException_WrongUrlIsSpecified()
        {
            Downloader.DownloadWebpageAsText(wrongUrl);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "No URL specified - ArgumentNullException should have been thrown")]
        public void ShouldThrowArgumentNullException_AddressIsNull()
        {
            Downloader.DownloadWebpageAsText(null);
        }

        [TestMethod]
        public void ShouldDownloadFile_EverythingIsValid()
        {
            try
            {
                Downloader.DownloadWebpageAsText(correctUrl);
            } catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
