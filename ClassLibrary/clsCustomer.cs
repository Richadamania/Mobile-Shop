using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //Membership private member variable
        private Boolean mMembership;
        //Membership public property
        public Boolean Membership
        {
            get
            {
                //this line of code sends data out of the property
                return mMembership;
            }
            set
            {
                //this line of code allows data into the property
                mMembership = value;
            }
        }

        //CustomerID private member variable
        private Int32 mCustomerID;
        //CustomerID public property
        public Int32 CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        //FirstName private member variable
        private String mFirstName;
        //FirstName public property
        public String FirstName
        {
            get
            {
                //this line of code sends data out of the property
                return mFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mFirstName = value;
            }
        }

        //LastName private member variable
        private String mLastName;
        //LastName public property
        public String LastName
        {
            get
            {
                //this line of code sends data out of the property
                return mLastName;
            }
            set
            {
                //this line of code allows data into the property
                mLastName = value;
            }
        }

        //Address private member variable
        private String mAddress;
        //Address public property
        public String Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        //MobileNumber private member variable
        private Int32 mMobileNumber;
        //MobileNumber public property
        public Int32 MobileNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mMobileNumber;
            }
            set
            {
                //this line of code allows data into the property
                mMobileNumber = value;
            }
        }

        //Date private member variable
        private DateTime mDate;
        //Date public property
        public DateTime Date
        {
            get
            {
                //this line of code sends data out of the property
                return mDate;
            }
            set
            {
                //this line of code allows data into the property
                mDate = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]); 
                mMobileNumber = Convert.ToInt32(DB.DataTable.Rows[0]["MobileNumber"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mMembership = Convert.ToBoolean(DB.DataTable.Rows[0]["Membership"]);
                //return that everything worked ok 
                return true;
            }
            // if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }
    }
}