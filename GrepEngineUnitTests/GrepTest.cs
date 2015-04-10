using GrepEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GrepEngineUnitTests
{
    [TestClass]
    public class GrepTest
    {
        [TestMethod]
        public void ShouldCountTokenOccurancesInSingleLine()
        {
            //Assign

            var grep = new Grep(new[]
            {
                "marxk", "szymon"
            });

            const string token = "x";

            //Act

            int result = grep.CountTokenOccurancesInAllLines(token);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
