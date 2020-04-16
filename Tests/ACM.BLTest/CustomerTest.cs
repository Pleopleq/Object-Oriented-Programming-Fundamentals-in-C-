using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arange
            Customer customer = new Customer
            {
                FirstName = "Felix",
                LastName = "Anducho"
            };
            string expected = "Anducho, Felix";


            //Act
            string actual = customer.FullName;

            //Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arange
            Customer customer = new Customer
            {
                LastName = "Anducho"
            };
            string expected = "Anducho";


            //Act
            string actual = customer.FullName;

            //Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arange
            Customer customer = new Customer
            {
                FirstName = "Felix"
            };
            string expected = "Felix";


            //Act
            string actual = customer.FullName;

            //Assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //Arange
            var c1 = new Customer();
            c1.FirstName = "Felix";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Argel";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Luis";
            Customer.InstanceCount += 1;

            //Act

            //Assert

            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
