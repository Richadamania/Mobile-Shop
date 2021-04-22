using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {

        [TestMethod]
        public void InstanceOk()
        {
            //create an insatnce of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see its exists 
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Membership = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Customer Name";
            TestItem.LastName = "Surname";
            TestItem.Address = "House Number, Street name, City, Post-Code";
            TestItem.MobileNumber = Convert.ToInt64("0116253595");
            TestItem.Date = Convert.ToDateTime("15/06/1990");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
           clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Membership = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Customer Name";
            TestCustomer.LastName = "Surname";
            TestCustomer.Address = "House Number, Street name, City, Post-Code";
            TestCustomer.MobileNumber = Convert.ToInt64("0116253595");
            TestCustomer.Date = Convert.ToDateTime("15/06/1990");
            //assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties 
            TestItem.Membership = true;
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Customer Name";
            TestItem.LastName = "Surname";
            TestItem.Address = "House Number, Street name, City, Post-Code";
            TestItem.MobileNumber = Convert.ToInt64("0116253595");
            TestItem.Date = Convert.ToDateTime("15/06/1990");
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

    }
}
