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
    public partial class pointOfSale : Form
    {
        double grandTotal;
        int totalQtty = 0;
        int orNumber;
        public pointOfSale()
        {
            InitializeComponent();
            Global.stringCon = "SERVER=localhost;" + "DATABASE=proddb;" + "UID=root;" + "PASSWORD=2003;"; // setting the attribute foor connection details
        }

        private void getDataFromOtherTable()
        {
            totalQtty = 0;
            String data = "Select * from producttbl"; // for requesting the data from the producttbl
            query query = new query(); // creating the query cs instance
            query.dispRec(data); // using the query instance to access the function display record and passing the request string
            grandTotal = 0;
            posLv.Items.Clear(); // clearing the listview for products
            for (int ctrs = 0; ctrs < query.dtst.Tables[0].Rows.Count; ctrs++) // iterate over the row of the product table
            {
                posLv.Items.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(1).ToString()); // accessing the first column
                posLv.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(2).ToString()); //  accessing the second column
                posLv.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(4).ToString()); //  accessing the third column
                posLv.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(5).ToString()); //  accessing the fourth column
                totalQtty += Convert.ToInt32(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(2).ToString());
                grandTotal += Convert.ToDouble(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(5).ToString());
                grndTotalTxtBox.Text = Convert.ToString(grandTotal);

            }
        }

        private void pointOfSale_Load(object sender, EventArgs e)
        {
            Random OR = new Random();
            orNumber = OR.Next(500000, 10000000);
            ornumtxtbx.Text = Convert.ToString(orNumber);
            getDataFromOtherTable();
        }

        private void confbtn_Click(object sender, EventArgs e)
        {
            if (custName.Text != "")
            {
                if (cashTxtBox.Text != "")
                {
                    if (Convert.ToInt32(cashTxtBox.Text) >= Convert.ToDouble(grndTotalTxtBox.Text))
                    {
                        double due = Convert.ToDouble(Convert.ToString(grndTotalTxtBox.Text));
                        double cash = Convert.ToDouble(Convert.ToString(cashTxtBox.Text));
                        changetxtbox.Text = Convert.ToString(cash - due);
                        if (MessageBox.Show("Warning", "Are You Sure You Want to Proceed?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            MessageBox.Show("SUCCESSFULLY PURCHASE", "NOTE!");
                            cashTxtBox.Clear();
                            string deleteRecords = "DELETE from producttbl";
                            query delete = new query();
                            delete.maintRec(deleteRecords);
                            this.Dispose();
                        }
                    }
                    else if ((Convert.ToInt32(cashTxtBox.Text)) <= (Convert.ToDouble(grndTotalTxtBox.Text)))
                    {
                        MessageBox.Show("please increase your cash higher than the amount due.", "WARNING!");
                        cashTxtBox.Clear();
                        cashTxtBox.Focus();
                    }
                }
                else if (cashTxtBox.Text == "")
                {
                    MessageBox.Show("please type your cash amount.", "WARNING!");
                    cashTxtBox.Focus();
                }
            }
            else if (custName.Text == "")
            {
                MessageBox.Show("please type your name.", "WARNING!");
                custName.Focus();
            }
        }

        private void cashTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
