using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest_Computer
    {
        Computer testComputer;

        [TestInitialize]
        public void TestComputerInitialize()
        {
            testComputer = new Computer("Dell", "Unknown", 2018);
        }

        [TestMethod]
        public void TestComputer()
        {
            testComputer.UpdateSoftware();
            Assert.IsTrue(testComputer.IsSoftwareUpToDate);
        }

        [TestMethod]
        public void TestComputer1()
        {
            Assert.AreEqual(2018, testComputer.ManufacturedYear);
        }

        [TestMethod]
        public void TestComputer2()
        {
            testComputer.SwitchOn();
            Assert.IsTrue(testComputer.IsDeviceOn);
        }

        [TestMethod]
        public void TestComputer3()
        {
            testComputer.IsDeviceOn = true;
            testComputer.SwitchOff();
            Assert.IsFalse(testComputer.IsDeviceOn);
        }


    }
}
