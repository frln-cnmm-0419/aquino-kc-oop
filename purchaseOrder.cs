using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace records_database
{
    public partial class purchaseOrder : Form
    {
        int base_price, quantityCount, availQtty;
        double totalPrice, grandTotalPrice;
        String textForProductName, textForProductID, updatedQuantity;
        public purchaseOrder()
        {
            InitializeComponent();
            Global.stringCon = "SERVER=localhost;" + "DATABASE=proddb;" + "UID=root;" + "PASSWORD=2003;"; // setting the attribute foor connection details
        }

        private void purchaseOrder_Load(object sender, EventArgs e)
        {
            loadInventory();
            qttyPurchOrd.Enabled = false;
        }
        public void loadInventory()
        {
            String requestData = "Select * from purchaseorder"; // for requesting the data from the producttbl
            query query = new query(); // creating the query cs instance
            query.dispRec(requestData); // using the query instance to access the function display record and passing the request string
            lvPurchOrd.Items.Clear(); // clearing the listview for products
            for (int ctrs = 0; ctrs < query.dtst.Tables[0].Rows.Count; ctrs++) // iterate over the row of the product table
            {
                lvPurchOrd.Items.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(0).ToString()); // accessing the first column
                lvPurchOrd.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(1).ToString()); //  accessing the second column
                lvPurchOrd.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(2).ToString()); //  accessing the third column
                lvPurchOrd.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(3).ToString()); //  accessing the fourth column
                lvPurchOrd.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(4).ToString()); //  accessing the fourth column
                lvPurchOrd.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(5).ToString()); //  accessing the fourth column
                lvPurchOrd.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(6).ToString()); //  accessing the fourth column
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clearFieldsForPurchaseOrder()
        {
            suppAddTxtBx.Clear(); // clearing the supplier add txtbx
            suppNameTxtBx.Clear(); // clearing the supplier name txtbx
        }

        private void lvPurchOrd_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearFieldsForPurchaseOrder();
            qttyPurchOrd.Enabled = true;
            qttyPurchOrd.Clear();
            totalPriceTxtBox.Clear();
            if (lvPurchOrd.SelectedItems.Count > 0)
            {
                ListViewItem item = lvPurchOrd.SelectedItems[0];
                suppNameTxtBx.Text = item.SubItems[0].Text;
                suppAddTxtBx.Text = item.SubItems[1].Text;
                base_price = Convert.ToInt32(item.SubItems[4].Text);
            }
            else
            {
                suppNameTxtBx.Text = string.Empty;
                suppAddTxtBx.Text = string.Empty;
                base_price = 0;
            }
        }

        private void addToPurchbtn_Click(object sender, EventArgs e)
        {
            quantityCount = 0;
            base_price = 0;
            ListViewItem item = lvPurchOrd.SelectedItems[0];
            availQtty = Convert.ToInt32(item.SubItems[5].Text);
            try
            {
                quantityCount = Convert.ToInt32(qttyPurchOrd.Text);
                if (quantityCount < availQtty)
                {
                    textForProductID = item.SubItems[2].Text;
                    textForProductName = item.SubItems[3].Text;
                    base_price = Convert.ToInt32(item.SubItems[4].Text);
                    totalPrice = ((base_price * 0.20) + base_price) * quantityCount;
                    totalPriceTxtBox.Text = Convert.ToString(totalPrice);
                    grandTotalPrice += totalPrice;
                    grndTotalPriceTxtbx.Text = Convert.ToString(grandTotalPrice);
                    String queryToProductTable = "INSERT INTO producttbl(ProductID, ProductName, Quantity, CategoryID, Price, TotalPrice) values('" + textForProductID + "', '" + textForProductName + "', '" + qttyPurchOrd.Text + "', '" + item.SubItems[6].Text + "', '" + Convert.ToString((base_price * 0.20) + base_price) + "', '" + Convert.ToString(totalPrice) + "')";
                    query qry = new query();
                    qry.maintRec(queryToProductTable);
                    updatedQuantity = Convert.ToString(availQtty - quantityCount);
                    String queryToUpdatedAvailQtty = "UPDATE purchaseorder SET quantityStock='" + updatedQuantity + "' where supplierName='" + suppNameTxtBx.Text + "'";
                    qry.maintRec(queryToUpdatedAvailQtty);
                    MessageBox.Show("The Selected Item is being added to your purchase and the available stocks will be updated.", "SUCCESS");
                    loadInventory();
                    totalPriceTxtBox.Text = "";
                    qttyPurchOrd.Text = "";
                    base_price = 0;
                    quantityCount = 0;
                }
                else if (quantityCount > availQtty)
                {
                    MessageBox.Show("Please Reduce Your Quantity.", "WARNING");
                }
            }
            catch
            {

            }
        }

        private void cancelSelectionbtn_Click(object sender, EventArgs e)
        {
            quantityCount = 0;
            base_price = 0;
            qttyPurchOrd.Text = "";
            qttyPurchOrd.Enabled = false;
            totalPriceTxtBox.Text = "";
            lvPurchOrd.SelectedItems.Clear();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvPurchOrd.SelectedItems[0];
            try
            {
                quantityCount = 0;
                base_price = 0;
                base_price = Convert.ToInt32(item.SubItems[4].Text);
                quantityCount = Convert.ToInt32(qttyPurchOrd.Text);
                totalPrice = base_price * quantityCount;
                totalPriceTxtBox.Text = Convert.ToString(totalPrice);
            }
            catch
            {
                MessageBox.Show("Something Went Wrong", "WARNING");
            }
        }
    }
}
