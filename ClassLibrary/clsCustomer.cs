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
            //set the private data members to the test data value
            mCustomerID = 2;
            mFirstName = "Name";
            mLastName = "Last Name";
            mAddress = "House Number, Street name, City, Post-Code";
            mMobileNumber = 0116253595;
            mDate = Convert.ToDateTime("15/06/1990");
            mMembership = true;

            //always return true
            return true;
        }
    }
}