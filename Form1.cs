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
    public partial class mainform : Form
    {
        string match, matchedEdit; // global variable for matching the category id and name

        public mainform()
        {
            InitializeComponent(); // initializing all components
            Global.stringCon = "SERVER=localhost;" + "DATABASE=proddb;" + "UID=root;" + "PASSWORD=2003;"; // setting the attribute foor connection details
        }

        // function when the form load
        private void mainform_Load(object sender, EventArgs e)
        {
            ldrec(); // load the record for products
            ldreccat(); // load the record for category
            disableFieldsForProd(); // disable the field during initial run
            editprod.Enabled = false; // disable the edit product during initial run
            cancelbtncat.Enabled = false; // disable the cancel button for category during initial run
            cancelbtnprod.Enabled = false; // disable the cancel button for product during initial run
            delprod.Enabled = false; // disable the delete button
            disableFieldsForCateg(); // disable th fields for category
        }

        // function for loading the the records from product table
        public void ldrec()
        {
            String data = "Select * from producttbl"; // for requesting the data from the producttbl
            query query = new query(); // creating the query cs instance
            query.dispRec(data); // using the query instance to access the function display record and passing the request string

            lvprod.Items.Clear(); // clearing the listview for products
            for(int ctrs = 0; ctrs < query.dtst.Tables[0].Rows.Count; ctrs++) // iterate over the row of the product table
            {
                lvprod.Items.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(0).ToString()); // accessing the first column
                lvprod.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(1).ToString()); //  accessing the second column
                lvprod.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(2).ToString()); //  accessing the third column
                lvprod.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(3).ToString()); //  accessing the fourth column
            }
        }

        // function for loading the category table records
        public void ldreccat()
        {
            String data = "Select * from categorytbl"; // creating a string to request the all content of the table
            query query = new query(); // creating the instance of query cs for further usage
            query.dispRec(data); // using the query cs variable to access tthe display record function and passing the data string

            lvcateg.Items.Clear(); // clearing the listview of category
            for (int ctrs = 0; ctrs < query.dtst.Tables[0].Rows.Count; ctrs++) // iterate over the table rows
            {
                lvcateg.Items.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(0).ToString()); // accessing the first
                lvcateg.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(1).ToString()); // accessig the subitems
            }
        }

        // disable function for products field
        public void disableFieldsForProd()
        {
            prodidtxtbx.Enabled = false; // disabling the product id textbox
            categidtxtbx.Enabled = false; // disabling the category id textbox
            prodnametxtbx.Enabled = false; // disabling the product name textbox
            qttytxtbx.Enabled = false; // disabling the quantity textbox
        }

        // disabing the fields function for category
        public void disableFieldsForCateg()
        {
            catidtxtbx.Enabled = false; // disabling the category id textbox
            catnametxtbx.Enabled = false; // disabling the category name textbox
        }

        // enabling fields function for product
        public void enableFieldsForProd()
        {
            prodidtxtbx.Enabled = true; // enabling the product id textbox
            categidtxtbx.Enabled = true; // enabling the category id textbox
            prodnametxtbx.Enabled = true; // enabling the product name textbox
            qttytxtbx.Enabled = true; // enabling the quantity text box
        }

        // enable fields function for category
        public void enableFieldsForCateg()
        {
            catnametxtbx.Enabled = true; // enabling the category name txtbx
            catidtxtbx.Enabled = true; // enabling the category id txtbx
        }

        // disable fields function for product
        private void clearFieldsForProd()
        {
            categidtxtbx.Clear(); // clearing the category id txtbx
            prodidtxtbx.Clear(); // clearing the product id txtbx
            prodnametxtbx.Clear(); // clearing the product name txtbx
            qttytxtbx.Clear(); // clearing the quantity txtbx
        }

        // clear fields for category maintenance function
        private void clearFieldsForCateg()
        {
            catnametxtbx.Clear(); // clearing the category name txtbx
            catidtxtbx.Clear(); // clearing the category id txtbx
        }

        // function for clicking the add product
        private void addbtn_Click(object sender, EventArgs e)
        {
            enableFieldsForProd(); // enabling the fields for product
            ldrec(); // reloading the listview

            editprod.Enabled = false; // disabling the edit product button 
            delprod.Enabled = false; // disabling te delete product button
            cancelbtnprod.Enabled = true; // enabling the cancel button
            addprod.Text = "CONFIRM"; // chahnging the text from add to confirm
            bool ispresent = false; // creating a variable ispresent for validation

            if (prodidtxtbx.Text != "" && prodnametxtbx.Text != "" && qttytxtbx.Text != "" && categidtxtbx.Text != "") // validation if the fields are empty
            {
                String data = "Select * from producttbl"; // command to be executed asterisk means everything
                query query = new query(); // creating an instace of query cs
                query.dispRec(data); // passing the command to thee displayrec funcction

                for (int i = 0; i < query.dtst.Tables[0].Rows.Count; i++) // iterate over the product table
                {
                    if (prodidtxtbx.Text == query.dtst.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()) // if the current text of product id is same with the curret iteration in the loop
                    {
                        ispresent = true; // if is present is true it will go to the query
                        break; // breaking out of the loop
                    }
                    else
                    {
                        ispresent = false; // this is false if the product id isnt present in the current list
                    }
                }

                if (ispresent) // if the ipresent is true
                {
                    MessageBox.Show("Product ID was already exist in the database", "NOTICE"); // note for user if the id doesnt exist
                    prodidtxtbx.Clear(); // clearing hte product id textbox
                    prodidtxtbx.Focus(); // focusing the cursor to the product id
                }
                else if (ispresent != true) // checking if the is present variale is not true
                {
                    bool notdeclared = false; // creating a not declared variable for validation
                    String datafrmtbl = "Select * from categorytbl"; // command to be executed
                    query querytotbl = new query(); // creating an instance of query cs
                    querytotbl.dispRec(datafrmtbl); // executing the command to the maintain record
                    for (int i = 0; i < querytotbl.dtst.Tables[0].Rows.Count; i++) // loop to iterate over the category table
                    {
                        match = querytotbl.dtst.Tables[0].Rows[i].ItemArray.GetValue(1).ToString(); // keeping the track of the iteration

                        if (categidtxtbx.Text == querytotbl.dtst.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()) // if the current text of te catgory id text box is match with any of the column of catgory id in the other table
                        {
                            notdeclared = false; // changing the variable of notdelcared to true because the id is already declared
                            break; // escaping out of  the loop
                        }

                    }

                    if(notdeclared) // if not decalred is truee
                    {
                        MessageBox.Show("Category ID doesn't exist, consider adding it.", "NOTICE"); // if the category id doesn't in the category tbl
                    }
                    else
                    {
                        String concat = categidtxtbx.Text + " - " + match; // creating an hyphenated category id
                        String str = "INSERT INTO producttbl(ProductID,ProductName,Quantity,CategoryID) values('" + prodidtxtbx.Text + "', '" + prodnametxtbx.Text + "', '" + qttytxtbx.Text + "', '" + concat + "')"; // creating a command to be executed
                        query qury = new query(); // creating an instance of query cs
                        qury.maintRec(str); // passing the comman we've created to the function maintain record
                        ldrec(); // reloading the records of listview
                        MessageBox.Show("SUCCESS!", "Notice"); // message box for confirmation
                        clearFieldsForProd(); // cleaaring the fields for product
                        cancelbtnprod.Enabled = false; // disabling the cancel button for product
                        addprod.Text = "ADD"; // changing the text from confirm to add
                        disableFieldsForProd(); // disabling the fields for product
                        match = "";
                    }
                }
            }
            else if (addprod.Text == "CONFIRM")
            {
                MessageBox.Show("Heads Up, Fill all the fields.", "Notice"); // a heads up note for user
            }
        }

        // cancel button function if click
        private void cnclbtn_Click(object sender, EventArgs e)
        {
            clearFieldsForProd(); // clearing the fields for products
            disableFieldsForProd(); // disabling the fields for product
            addprod.Text = "ADD"; // changing the text from confirm to add
            lvprod.SelectedItems.Clear(); // unselect the selected index from listview
            addprod.Enabled = true; // enabling the add product button
            editprod.Enabled = false; // disabling the edit product button
            delprod.Enabled = false; // disabling the delete button
            cancelbtnprod.Enabled = false; // disabling the cancel button
            editprod.Text = "EDIT"; // changing the text of the edit products to edit
        }

        // add category events on click
        private void addcat_Click(object sender, EventArgs e)
        {
            enableFieldsForCateg(); // enabling all the fields for category
            addcat.Enabled = true; // enabling theadd category button
            addcat.Text = "CONFIRM"; // changing the button text fom add to confirm
            cancelbtncat.Enabled = true; // enabling the cancel button
            bool isduplicate = false; // creating the is duplicate for validation with initial value of false
            if (catnametxtbx.Text != "" && catidtxtbx.Text != "") // check if the field is empty validation
            {
                String data = "Select * from categorytbl"; // command to be executed
                query query = new query(); // creating an instance of query cs
                query.dispRec(data); // executing the command we've created
                for (int i = 0; i < query.dtst.Tables[0].Rows.Count; i++) // looping to check if duplicate
                {
                    // checking if the current iteration is already existed if no the loop will continue to run
                    if (catidtxtbx.Text == query.dtst.Tables[0].Rows[i].ItemArray.GetValue(0).ToString())
                    {
                        isduplicate = true; // changing the variable value of isduplicate to true because nageexist na siya
                        break; // escaping from the loop
                    }
                    
                }

                // if isduplicate is true
                if (isduplicate)
                {
                    MessageBox.Show("The Category ID already existed.", "WARNING"); // if the category id already exist
                }
                // else if isduplicate  is false
                else
                {
                    string addcattodb = "INSERT INTO categorytbl(categoryID, categoryName) values('" + catidtxtbx.Text + "', '" + catnametxtbx.Text + "')"; // command to be executed
                    query queryaddcat = new query(); // creating an instance of query cs
                    queryaddcat.maintRec(addcattodb); // executing the command to the query function member maintain record
                    ldreccat(); // reloading the listview iwht updated database
                    cancelbtncat.Enabled = false; // disabling the cancel button for category
                    clearFieldsForCateg(); // clearing the fields of category maintenance
                    disableFieldsForCateg(); // disabling the fields for ategory maintenance
                    addcat.Text = "ADD"; // changing the text of button from confirm to add
                    MessageBox.Show("SUCCESS!", "Notice"); // messagebox for confirmation
                    cancelbtncat.Enabled = false; // disabling the cancel button for category maintenance
                }
            }
            else
            {           
                MessageBox.Show("Heads Up, Fill all the fields.", "Notice"); // heads up notice to the user
            }
        }

        // cancel btton function for category maintenance
        private void cancelbtncat_Click(object sender, EventArgs e)
        {
            disableFieldsForCateg(); // disabling the fields of category
            clearFieldsForCateg(); // clearing the fields for category
            lvcateg.SelectedItems.Clear(); // unselecting the index
            addcat.Text = "ADD"; // changing the text from confirm to add
            addcat.Enabled = true; // enabling the add category button
            cancelbtncat.Enabled = false; // disabling the cancel button of category maintenance
        }

        // running this function when the selected index has change in listview of category
        private void lvcateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cancelbtncat.Enabled = true; // enabling the cancel button
            addcat.Enabled = false; // disabling the add category button
        }

        // sleected index change for listview of product function
        private void lvprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            delprod.Enabled = true; // enabling delete button
            addprod.Enabled = false; // disbling the add product button
            editprod.Enabled = true; // enabling edit button
            cancelbtnprod.Enabled = true; // enabling cancel button
        }

        // function when clicking the list view of product
        private void lvprod_Click(object sender, EventArgs e)
        {
            cancelbtnprod.Enabled = true; // enabling the cancel button to cancel if accidental clicked was happened
            prodidtxtbx.Text = lvprod.SelectedItems[0].Text; // getting the product id from selected index and displaying it to the corresponding textbox
            prodnametxtbx.Text = lvprod.SelectedItems[0].SubItems[1].Text; // getting the product name of the selected index and displaying it to the corresponding textbox
            qttytxtbx.Text = lvprod.SelectedItems[0].SubItems[2].Text; // getting the quantity of the selected index and displaying it to the corresponding textbox
            categidtxtbx.Text = lvprod.SelectedItems[0].SubItems[3].Text; // getting the category id of the selected index and displaying it to the corresponding textbox
        }

        // edit product button function
        private void editprod_Click(object sender, EventArgs e)
        {
            if (editprod.Text == "EDIT") // if block to change the text of edit
            {
                editprod.Text = "SAVE"; // changing the texxt  from edit to save
                enableFieldsForProd(); // enabling all the fields of product
                prodidtxtbx.Enabled = false; //disabling the product id to prevent editing the product id
            }
            else
            {
                bool notdeclared = true; // creating a not declared variable for validation
                string datafrmtbl = "Select * from categorytbl"; // command to be executed
                query querytotble = new query(); // creating an instance of query cs
                querytotble.dispRec(datafrmtbl); // executing the command to the maintain record
                for (int i = 0; i < querytotble.dtst.Tables[0].Rows.Count; i++) // loop to iterate over the category table
                {
                    matchedEdit = querytotble.dtst.Tables[0].Rows[i].ItemArray.GetValue(1).ToString(); // keeping the track of the iteration

                    if (categidtxtbx.Text == querytotble.dtst.Tables[0].Rows[i].ItemArray.GetValue(0).ToString()) // if the current text of te catgory id text box is match with any of the column of catgory id in the other table
                    {
                        notdeclared = false; // changing the variable of notdelcared to true because the id is already declared
                        break; // escaping out of  the loop
                    }

                }

                if (notdeclared) // if not decalred is truee
                {
                    MessageBox.Show("Category ID doesn't exist, consider adding it.", "NOTICE"); // if the category id doesn't in the category tbl
                }
                else if (notdeclared != true)
                {
                    string concat = categidtxtbx.Text + " - " + matchedEdit; // creating an hyphenated category id

                    string upd = "UPDATE producttbl SET ProductName='"+ prodnametxtbx.Text +"', Quantity='"+ qttytxtbx.Text +"', CategoryID='"+ concat +"' where ProductID='"+ prodidtxtbx.Text +"'"; // the command to be executed
                    query qry = new query(); // creating an instance of query cs
                    qry.maintRec(upd); // requessting the function from the query cs
                    ldrec(); // reloading the listview
                    MessageBox.Show("Successfully Updated!", "Message"); // confirmation box
                    clearFieldsForProd(); // clearing the fields
                    disableFieldsForProd(); // disabling all the fields
                    editprod.Text = "EDIT"; //changing the text from save to edit
                    editprod.Enabled = false; // disabling the edit button
                    delprod.Enabled = false; // disabling the delete product button
                    addprod.Enabled = true; // enabling the add product button
                    cancelbtnprod.Enabled = false; // disabling the cancel button
                    matchedEdit = "";
                }

            }
        }

        // delete product button event
        private void delprod_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to continue this operation?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes) // confirmation
            {
                String del = "DELETE FROM producttbl where ProductID='"+ prodidtxtbx.Text +"'"; // query to delete the target row
                query qrdel = new query(); // creating an instance of query cs
                qrdel.maintRec(del); // accessing the function from the querycs and passing the del query to execute delete
                MessageBox.Show("Successfully Deleted", "Notice"); // confirmation that the selected item was deleted
                ldrec(); // reloading the listview
                clearFieldsForProd(); // clearing the fields
                cancelbtnprod.Enabled = false; // disabling the cancel button
                delprod.Enabled = false; // disabling delete button after deletion
                editprod.Enabled = false; // disabling the edit button
                addprod.Enabled = true; // enabling the add product button
            }
        }
    }
}
