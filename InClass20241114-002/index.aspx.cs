using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass20241114_002
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Only run this is it's not a post back
            {
                // How can we run this only one time?
                // This method runs when the page is loaded into a browser window.
                // Add a pizza company to the list box
                lbPizzaCompanies.Items.Add("LaRosa's");
                // Add a few more items to the list box
                lbPizzaCompanies.Items.Add("Pizza Hut");
                lbPizzaCompanies.Items.Add("Dominos");

                cblIngredients.Items.Add("Sauce");
                cblIngredients.Items.Add("Peperoni");
                cblIngredients.Items.Add("Cheese");
            }

        }

        protected void cmdSelectPizzaCompany_Click(object sender, EventArgs e)
        {
            // We call this an "event handler"
            // This code runs when the cmdSelectPizzaCompany button is clicked
            // Write the currently selected pizza company in the list box into the label
            // We need to get the item from the list box
            lblSelectPizzaCompany.Text = lbPizzaCompanies.Text;
        }
    }
}