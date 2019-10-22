using lab1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lab1.Controllers;
using System.Threading.Tasks;
using lab1.Data;

namespace UnitTestLab1
{
    [TestClass]
    public class UnitTest1
    {
        private static lab1Context _context;

        [ClassInitialize]
        public static void Initialize(TestContext tc)
        {
            //var options = new DbContextOptionsBuilder<lab1Context>().UseInMemoryDatabase(databaseName: "SSD_DealershipDB").Options;
            //_context = new lab1Context(options);

            //List<Dealership> dealerships =  DealershipMgr.GetDealerships();

            //Car Car1 = new Car { Id = 1, Make = "Chevy", Model = "Impala", Year = 2012, VIN = 123 };
            //Car Car2 = new Car { Id = 2, Make = "Chevy", Model = "Malibu", Year = 2010, VIN = 456 };
            //_mohawkTestContext.Car.AddRange(Car1, Car2);
            //_mohawkTestContext.SaveChanges();

        }

        [TestMethod]
        public void DealershipMgrGetById()
        {
            //Test to pass
            Dealership d = DealershipMgr.GetDealership(2);
            Assert.IsInstanceOfType(d, typeof(Dealership));
            Assert.AreEqual("dealership2", d.Name);
            Assert.AreEqual("asd@asdf.com", d.Email);

            //Test to fail
            Assert.AreNotEqual("123-123-1234", d.PhoneNumber);
            Assert.IsNull(DealershipMgr.GetDealership(20));

        }

        [TestMethod]
        public void DealershipMgrPost() {
            Dealership newDealership = new Dealership { Name = "Test2", Email = "Test@ok.com", PhoneNumber = "444-444-4444"};
            DealershipMgr.CreateDealership(newDealership);

            List<Dealership> dealerships = DealershipMgr.GetDealerships();

            Assert.IsTrue(dealerships.Count == 4);

            Dealership testDealership = DealershipMgr.GetDealership(4);
            Assert.IsInstanceOfType(testDealership, typeof(Dealership));
            Assert.AreEqual(4, testDealership.ID);

            Assert.AreNotEqual("Test1", testDealership.Name);
        }
    }
}
