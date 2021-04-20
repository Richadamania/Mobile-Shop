using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //hjh
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instace of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //Capture the Customer ID
        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnCustomer.FirstName = txtFirstName.Text;
        AnCustomer.LastName = txtLastName.Text;
        AnCustomer.Address = txtAddress.Text;
        AnCustomer.MobileNumber = Convert.ToInt32(txtMobileNumber.Text);
        AnCustomer.Date = Convert.ToDateTime(txtDOB.Text);
        // store the customer in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

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