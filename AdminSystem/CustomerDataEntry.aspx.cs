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
        AnCustomer.CustomerID = txtCustomerID.Text;
        AnCustomer.FirstName = txtFirstName.Text;
        AnCustomer.LastName = txtLastName.Text;
        AnCustomer.Address = txtAddress.Text;
        AnCustomer.MobileNumber = Convert.ToInt32(txtMobileNumber.Text);
        AnCustomer.Date = Convert.ToDateTime(txtCustomerDOB.Text);
        // store the customer in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }
}