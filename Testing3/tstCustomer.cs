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

        [TestMethod]
        public void FindMethodOK()
        {
           //create an instance of the class I want to create
           clsCustomer AnCustomer = new clsCustomer();
        //Bollean variable to store the results of the validation
        Boolean Found = false;
        //create some test data to use with the method
        Int32 CustomerID = 1;
        //invoke the method
        Found = AnCustomer.Find(CustomerID);
          //test to see if the result is true
          Assert.IsTrue(Found);
       }

        [TestMethod]
        public void TestCustomerIDNoFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the Customer ID
           if (AnCustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameNoFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            String FirstName = "Name";
            //invoke the method
            Found = AnCustomer.Find(AnCustomer.CustomerID);
            //check the First Name
            if (AnCustomer.FirstName != "Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameNoFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            String LastName = "Last Name";
            //invoke the method
            Found = AnCustomer.Find(AnCustomer.CustomerID);
            //check the Last Name
            if (AnCustomer.LastName != "Last Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            String Address = "House Number, Street name, City, Post-Code";
            //invoke the method
            Found = AnCustomer.Find(AnCustomer.CustomerID);
            //check the Address
            if (AnCustomer.Address != "House Number, Street name, City, Post-Code")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMobileNumberNoFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 MobileNumber = 0116253595; 
            //invoke the method
            Found = AnCustomer.Find(AnCustomer.CustomerID);
            //check the MobileNUmber
            if (AnCustomer.MobileNumber != 0116253595)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateNoFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Int32 Date = 15/06/1990; 
            //invoke the method
            Found = AnCustomer.Find(AnCustomer.CustomerID);
            //check the Date
            if (AnCustomer.Date != Convert.ToDateTime("15/06/1990"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMembershipNoFound()
        {
            //create an instance of the class I want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            // create some test data to use witht the method
            Boolean membership = true;
            //invoke the method
            Found = AnCustomer.Find(AnCustomer.CustomerID);
            //check the Membership
            if (AnCustomer.Membership != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
