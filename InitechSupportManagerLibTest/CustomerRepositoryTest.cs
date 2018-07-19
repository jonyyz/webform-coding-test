using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using InitechSupportManagement.Entity;
using InitechSupportManagement.Repository;

namespace InitechSupportManagerLib.UnitTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        IRepository<Customer> _repository;

        [TestInitialize]
        public void SetUp()
        {
            _repository = new CustomerRepository(
                new Customer[] {
                    new Customer
                    {
                        Id = 42,
                        CompanyName = "ACME Roadrunner Catching Supplies",
                        SoftwarePurchaseDate = new DateTime(2017, 3, 28),
                        Address = new Address {
                            StreetAddressOne = "123 Coyote St",
                            StreetAddressTwo = "Suite 400",
                            City = "Indianapolis",
                            State = "IN",
                            Zip = "46202"
                        }
                    },
                    new Customer
                    {
                        Id = 2112,
                        CompanyName = "RUSH Industries",
                        SoftwarePurchaseDate = new DateTime(2016, 2, 12),
                        Address = new Address {
                            StreetAddressOne = "2112 Limelight St",
                            StreetAddressTwo = "Suite 200",
                            City = "Indianapolis",
                            State = "IN",
                            Zip = "46202"
                        }
                    }

                }
            );
        }

        [TestCleanup]
        public void TearDown()
        {
        }

        [TestMethod]
        public void TestGetAll()
        {
            var customers = _repository.GetAll();

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(2, customers.Count());

            var customer = customers.Where(c => c.Id == 42).First();

            Assert.IsNotNull(customer);
            Assert.AreEqual<string>("ACME Roadrunner Catching Supplies", customer.CompanyName);
        }

        [TestMethod]
        public void TestGetNoResults()
        {
            var customers = _repository.Get(c => c.Id == 43);

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(0, customers.Count());
        }

        [TestMethod]
        public void TestGetSingleResult()
        {
            var customers = _repository.Get(c => c.Id == 42);

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(1, customers.Count());
        }

        [TestMethod]
        public void TestGetMultipleResult()
        {
            var customers = _repository.Get(c => c.Address.City == "Indianapolis");

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(2, customers.Count());
        }

        [TestMethod]
        public void TestUpdate()
        {
            var customers = _repository.Get(c => c.Address.City == "Indianapolis");

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(2, customers.Count());

            customers.Where(c => c.Id == 42).First().CompanyName = "I updated you";

            customers = _repository.Get(c => c.CompanyName == "I updated you");

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(1, customers.Count());
        }

        [TestMethod]
        public void TestAddExplicitId()
        {
            var customers = _repository.GetAll();

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(2, customers.Count());

            _repository.Add(
                new Customer
                {
                    Id = 123,
                    CompanyName = "Spatula City",
                    SoftwarePurchaseDate = new DateTime(2015, 3, 28),
                    Address = new Address
                    {
                        StreetAddressOne = "123 Spatula St",
                        StreetAddressTwo = "Suite 800",
                        City = "Indianapolis",
                        State = "IN",
                        Zip = "46202"
                    }
                }
            );

            customers = _repository.GetAll();

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(3, customers.Count());

            customers = _repository.Get(c => c.Id == 123);

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(1, customers.Count());
        }

        [TestMethod]
        public void TestAddAutoId()
        {
            var customers = _repository.GetAll();

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(2, customers.Count());

            _repository.Add(
                new Customer
                {
                    CompanyName = "S-Mart",
                    SoftwarePurchaseDate = new DateTime(2015, 3, 28),
                    Address = new Address
                    {
                        StreetAddressOne = "123 Boomstick St",
                        StreetAddressTwo = "Suite 1200",
                        City = "Indianapolis",
                        State = "IN",
                        Zip = "46202"
                    }
                }
            );

            customers = _repository.GetAll();

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(3, customers.Count());

            customers = _repository.Get(c => c.Id == 2113);

            Assert.IsNotNull(customers);
            Assert.AreEqual<int>(1, customers.Count());
            Assert.AreEqual<string>("S-Mart", customers.First().CompanyName);
        }
    }
}
