using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutlookMiner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMinerCleanService_UnitTest.Services
{
    [TestClass()]
    public class ConvertServiceTests
    {
        [TestMethod()]
        [DataRow("test")]
        public void ConvertTest(string expectedResult)
        {
            // arrange
            IConvertService converter = new ConvertServicePDF();

            // act


            // assert
        }
    }
}
