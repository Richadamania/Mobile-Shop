using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsCustomerCollection
    {
       
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
               
            }
        }
        public clsCustomer ThisCustomer { get; set; }


        //constructor for the class
        public clsCustomerCollection()
        {

            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.Membership = Convert.ToBoolean(DB.DataTable.Rows[Index]["Membership"]);
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.MobileNumber = Convert.ToInt64(DB.DataTable.Rows[Index]["MobileNumber"]); 
                AnCustomer.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                //add the record to the privare data member
                //point at the next record
                Index++;

            }
        }
    }

}