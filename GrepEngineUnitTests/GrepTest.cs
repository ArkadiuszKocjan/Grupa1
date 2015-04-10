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

            var Grep = new Grep(new[]
            {
                "marxk", "szymon"
            });

            string token = "x";

            //Act

            int amount = Grep.CountTokenOccurancesInAllLines(token);

            //Assert
            Assert.AreEqual(1, amount);
        }
    }
}
