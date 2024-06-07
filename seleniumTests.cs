using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing_Final
{
    [TestClass]
    public class UnitTest1
    {


        public bool CanDrive(int age)
        {

            const int drivingAge = 16; 
            return age >= drivingAge;

        }


        //TEST BOUNDARIES OF 16
        [TestMethod]
        public void TestMethod15()
        {
            Assert.AreEqual(false, CanDrive(15));
        }

        [TestMethod]
        public void TestMethod16()
        {
            Assert.AreEqual(true, CanDrive(16));
        }

        [TestMethod]
        public void TestMethod17()
        {
            Assert.AreEqual(true, CanDrive(17));
        }



        //TEST ZERO, PLUS 1 AND MINUS 1
        [TestMethod]
        public void TestMethodNeg1()
        {
            Assert.AreEqual(false, CanDrive(-1));
        }

        [TestMethod]
        public void TestMethod0()
        {
            Assert.AreEqual(false, CanDrive(0));
        }

        [TestMethod]
        public void TestMethodPos1()
        {
            Assert.AreEqual(false, CanDrive(1));
        }


        //TEST MAX AND MIN, ALONG WITH MAX AND MIN OFFSET BY 1
        [TestMethod]
        public void TestMethodMax()
        {
            Assert.AreEqual(true, CanDrive(int.MaxValue));
        }

        [TestMethod]
        public void TestMethodMaxMinus1()
        {
            Assert.AreEqual(true, CanDrive(int.MaxValue-1));
        }

        [TestMethod]
        public void TestMethodMin()
        {
            Assert.AreEqual(false, CanDrive(int.MinValue));
        }

        [TestMethod]
        public void TestMethodMinPlus1()
        {
            Assert.AreEqual(false, CanDrive(int.MinValue+1));
        }

        //TESTING FOR OUT OF RANGE RESULTS. LOOKS LIKE NOT APPLICABLE FOR THE PASSED FUNCTION
        //Test that fails (True/False test)
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        // public void TestMethodIntMax()
        //{
        //    CanDrive(int.MaxValue);
        // }



    }
}
