using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest_SmartPhone
    {
        SmartPhone testPhone;

        [TestInitialize]
        public void TestPhoneInitialize()
        {
            testPhone = new SmartPhone("Sprint", "iPhone", "iPhone 8", 2016);
        }

        [TestMethod]
        public void TestPhone()
        {
            Assert.AreEqual("Sprint", testPhone.Carrier);
        }

        [TestMethod]
        public void TestPhone1()
        {
            testPhone.Call();
            Assert.IsTrue(testPhone.OnCall);
        }

        [TestMethod]
        public void TestPhone2()
        {
            testPhone.OnCall = true;
            testPhone.HangUp();
            Assert.IsFalse(testPhone.OnCall);
        }

    }
}
