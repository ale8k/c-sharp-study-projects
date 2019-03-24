using System;
using Testability;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException (typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            OrderProcessor x = new OrderProcessor(new FakeShippingCalc());
            Order y = new Order();
            y.Shipment = new Shipment();
            x.Process(y);
        }
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            OrderProcessor x = new OrderProcessor(new FakeShippingCalc());
            Order y = new Order();
            x.Process(y);
            Assert.IsTrue(y.IsShipped);
            Assert.AreEqual(1, y.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), y.Shipment.ShippingDate);
           
        }
    }

    public class FakeShippingCalc : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }

}
