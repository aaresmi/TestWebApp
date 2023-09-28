using Car.DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Car.Entities;
using System.Collections.Generic;
using Car.Entities;

namespace Car.UnitTestLayer
{
    
    
    /// <summary>
    ///This is a test class for CarDAOTest and is intended
    ///to contain all CarDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CarDAOTest
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
        ///A test for AddACar
        ///</summary>
        [TestMethod()]
        public void AddACarTest()
        {
            CarDAO target = new CarDAO(); // TODO: Initialize to an appropriate value
            Car.Entities.Car car = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.AddACar(car);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConvertCarEntityToCarTable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Car.DataAccessLayer.dll")]
        public void ConvertCarEntityToCarTableTest()
        {
            CarDAO_Accessor target = new CarDAO_Accessor(); // TODO: Initialize to an appropriate value
            Car.Entities.Car car = null; // TODO: Initialize to an appropriate value
            tblCar carTable = null; // TODO: Initialize to an appropriate value
            tblCar expected = null; // TODO: Initialize to an appropriate value
            tblCar actual;
            actual = target.ConvertCarEntityToCarTable(car, carTable);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConvertCarTableToCarEntity
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Car.DataAccessLayer.dll")]
        public void ConvertCarTableToCarEntityTest()
        {
            CarDAO_Accessor target = new CarDAO_Accessor(); // TODO: Initialize to an appropriate value
            tblCar carTable = null; // TODO: Initialize to an appropriate value
            Car.Entities.Car car = null; // TODO: Initialize to an appropriate value
            Car.Entities.Car expected = null; // TODO: Initialize to an appropriate value
            Car.Entities.Car actual;
            actual = target.ConvertCarTableToCarEntity(carTable, car);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RetrieveAllCars
        ///</summary>
        [TestMethod()]
        public void RetrieveAllCarsTest()
        {
            CarDAO target = new CarDAO(); // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> expected = null; // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> actual;
            actual = target.RetrieveAllCars();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RetrieveAllCarsDetails
        ///</summary>
        [TestMethod()]
        public void RetrieveAllCarsDetailsTest()
        {
            CarDAO target = new CarDAO(); // TODO: Initialize to an appropriate value
            int CarId = 0; // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> expected = null; // TODO: Initialize to an appropriate value
            List<Car.Entities.Car> actual;
            actual = target.RetrieveAllCarsDetails(CarId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
