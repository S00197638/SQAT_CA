using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InsurancePremiums;

namespace InsurancePremiums.Tests
{
    [TestFixture]
    public class InsuranceServiceTests
    {
        static int myExpectedResult;
        static InsuranceService myService;

        [SetUp] // code here is executed before tests are executed
        public static void Init()
        {
            myService = new InsuranceService(); // create an object of class InsuranceService
        }

        [Test]
        public static void getPremium_NotImplement_ExceptionThrown()
        {
            Assert.AreEqual("not implemented", "not implemented");
        }

        #region Female
        [Test]
        public static void getPremium_SimpleValues1_Female()
        {
            Assert.AreEqual(5.0, myService.CalcPremium(20, "female"));
        }

        [Test]
        public static void getPremium_SimpleValues2_Female()
        {
            Assert.AreEqual(0.375, myService.CalcPremium(55, "female"));
        }

        [Test]
        public static void getPremium_SimpleValues3_Female()
        {
            Assert.AreEqual(0.0, myService.CalcPremium(16, "female"));
        }
        #endregion

        #region Male
        [Test]
        public static void getPremium_SimpleValues1_Male()
        {
            Assert.AreEqual(6.0, myService.CalcPremium(30, "male"));
        }

        [Test]
        public static void getPremium_SimpleValues2_Male()
        {
            Assert.AreEqual(0.75, myService.CalcPremium(65, "male"));
        }

        [Test]
        public static void getPremium_SimpleValues3_Male()
        {
            Assert.AreEqual(0.0, myService.CalcPremium(13, "male"));
        }
        #endregion

        #region Unknown
        [Test]
        public static void getPremium_SimpleValues1_Unknown()
        {
            Assert.AreEqual(0.0, myService.CalcPremium(30, "unknown"));
        }
        #endregion
    }
}
