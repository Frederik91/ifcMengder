using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IfcExtractor;

namespace IfcExtractorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadIfcTest()
        {
            var X = new Class1();

            X.readIfcFile();
        }
    }
}
