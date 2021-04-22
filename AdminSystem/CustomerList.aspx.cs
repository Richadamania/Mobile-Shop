using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box 
                DisplayCustomer();
            }

        }

        void DisplayCustomer()
        {
            //create instance of the County Collection
            clsCustomerCollection Customer = new clsCustomerCollection();
            //set the data source to the list of counties in the collection
            lstCustomerList.DataSource = Customer.CustomerList;
            //set the name of the primary key
            lstCustomerList.DataValueField = "CustomerID";
            //set the dat field to display
            lstCustomerList.DataTextField = "FirstName";
            //bind the data to the list
            lstCustomerList.DataBind();
        }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

     }
}