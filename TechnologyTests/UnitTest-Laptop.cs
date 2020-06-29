using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;


namespace TechnologyTests
{
    [TestClass]
    public class UnitTest_Laptop
    {
        Laptop testLaptop;

        [TestInitialize]
        public void TestLaptopInitialize()
        {
            testLaptop = new Laptop(5, "Sony", "IDK", 2015);
        }

        [TestMethod]
        public void TestLaptop()
        {
            testLaptop.InsertUsb();
            Assert.IsTrue(testLaptop.UsbLoaded);
        }

        [TestMethod]
        public void TestLaptop1()
        {
            testLaptop.EjectUsb();
            Assert.IsFalse(testLaptop.UsbLoaded);
        }

        [TestMethod]
        public void TestLaptop2()
        {
            Assert.AreEqual(5, testLaptop.TouchPadSize);
        }

    }
}
