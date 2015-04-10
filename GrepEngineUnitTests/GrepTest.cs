using GrepEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GrepEngineUnitTests
{
    [TestClass]
    public class GrepTest
    {
        [TestMethod]
        public void ShouldCountTokenOccurancesInSingleLine()
        {
            //Assign

            var mock = new Mock<ILogger>();

            var grep = new Grep(new[]
            {
                "marxk", 
                "szymoxkn",
                "szyxmon",
                "sxkzyxmon",
                "sxkzyxmo nx xk xk",
                "",
                " ",
                "\\n",
            }, mock.Object);

            const string token = "xk";

            //Act

            int result = grep.CountTokenOccurancesInAllLines(token);

            //Assert
            Assert.AreEqual(6, result);
        }
    }
}
