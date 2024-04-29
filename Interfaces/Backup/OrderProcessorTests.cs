using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testability.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            var prderProcessor = new OrderProcessor();
        }
    }
}
