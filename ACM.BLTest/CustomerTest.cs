using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";
            //Act

            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            
            customer.LastName = "Baggins";

            string expected = "Baggins";
            //Act

            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            

            string expected = "Bilbo";
            //Act

            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.instanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.instanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.instanceCount += 1;


            Assert.AreEqual(3, Customer.instanceCount);
        }


        [TestMethod]

        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer();
            //customer.LastName = "Baggins";
            customer.EmailAddress = "fbBaggins@hobbiton.me";

            var expected = false;
            //Act
            var actual = customer.Validate();
            //Assert
            Assert.AreEqual(expected, actual);
            
        }
        
    }
}
