using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstantOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Membership = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.Membership, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Customer Name";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Surname";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "House Number, Street name, City, Post-Code";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void MobileNumberPropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 0116253595;
            //assign the data to the property
            AnCustomer.MobileNumber = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.MobileNumber, TestData);
        }

        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = Convert.ToDateTime("15/06/1990");
            //assign the data to the property
            AnCustomer.Date = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.Date, TestData);
        }
     }
}
