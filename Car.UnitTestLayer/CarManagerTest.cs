using Car.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Car.Entities;
using System.Collections.Generic;

namespace Car.UnitTestLayer
{
    
    
    /// <summary>
    ///This is a test class for CarManagerTest and is intended
    ///to contain all CarManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarManagerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for RetrieveAllCars
        ///</summary>
        [TestMethod()]
        public void RetrieveAllCarsTest()
        {
            CarManager target = new CarManager(); // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> expected = null; // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> actual;
            actual = target.RetrieveAllCars();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddACar
        ///</summary>
        [TestMethod()]
        public void AddACarTest()
        {
            CarManager target = new CarManager(); // TODO: Initialize to an appropriate value
            Car.Entities.Car car = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.AddACar(car);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RetrieveAllCarsDetails
        ///</summary>
        [TestMethod()]
        public void RetrieveAllCarsDetailsTest()
        {
            CarManager target = new CarManager(); // TODO: Initialize to an appropriate value
            int CarId = 2; // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> expected = null; // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> actual;
            actual = target.RetrieveAllCarsDetails(CarId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
