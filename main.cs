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
