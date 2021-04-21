using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) { }
 
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instace of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the first name
        string Fi rstName = txtFirstName.Text;
        //capture the last name
        string LastName = txtLastName.Text;
        //capture the address
        string Address = txtAddress.Text;
        //capture mobile number
        string MobileNumber =txtMobileNumber.Text;
        //capture the date
        string Date = txtDOB.Text;
        // variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(FirstName, LastName, Address, MobileNumber, Date);
        if (Error == "")
        {
            //capture the first name
            AnCustomer.FirstName = FirstName;
            //capture the last name
            AnCustomer.LastName = LastName;
            //capture the address
            AnCustomer.Address = Address;
            //capture the mobile number
            AnCustomer.MobileNumber = Convert.ToInt64(MobileNumber);
            //capture the date
            AnCustomer.Date = Convert.ToDateTime(Date);
            //store the customer in the session object
            Session["AnCustomer"] = AnCustomer;
            //redirect to the viewer page
            Response.Write("AnCustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        }
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instace of customer class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result to find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = Convert.ToString(AnCustomer.CustomerID);
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtAddress.Text = AnCustomer.Address;
            txtMobileNumber.Text = Convert.ToString(AnCustomer.MobileNumber);
            txtDOB.Text = Convert.ToString(AnCustomer.Date);
        }



    }
}