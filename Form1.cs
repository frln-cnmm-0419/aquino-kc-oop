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
        string match;

        public mainform()
        {
            InitializeComponent();
            Global.stringCon = "SERVER=localhost;" + "DATABASE=proddb;" + "UID=root;" + "PASSWORD=2003;";
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            ldrec();
            ldreccat();
            disableFieldsForProd();
            editprod.Enabled = false;
            cancelbtncat.Enabled = false;
            cancelbtnprod.Enabled = false;
            delprod.Enabled = false;
            disableFieldsForCateg();
        }

        public void ldrec()
        {
            String data = "Select * from producttbl";
            query query = new query();
            query.dispRec(data);

            lvprod.Items.Clear();
            for(int ctrs = 0; ctrs < query.dtst.Tables[0].Rows.Count; ctrs++)
            {
                lvprod.Items.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(0).ToString());
                lvprod.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(1).ToString());
                lvprod.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(2).ToString());
                lvprod.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(3).ToString());
            }
        }

        public void ldreccat()
        {
            String data = "Select * from categorytbl";
            query query = new query();
            query.dispRec(data);

            lvcateg.Items.Clear();
            for (int ctrs = 0; ctrs < query.dtst.Tables[0].Rows.Count; ctrs++)
            {
                lvcateg.Items.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(0).ToString());
                lvcateg.Items[ctrs].SubItems.Add(query.dtst.Tables[0].Rows[ctrs].ItemArray.GetValue(1).ToString());
            }
        }

        public void disableFieldsForProd()
        {
            prodidtxtbx.Enabled = false;
            categidtxtbx.Enabled = false;
            prodnametxtbx.Enabled = false;
            qttytxtbx.Enabled = false;
        }

        public void disableFieldsForCateg()
        {
            catidtxtbx.Enabled = false;
            catnametxtbx.Enabled = false;
        }

        public void enableFieldsForProd()
        {
            prodidtxtbx.Enabled = true;
            categidtxtbx.Enabled = true;
            prodnametxtbx.Enabled = true;
            qttytxtbx.Enabled = true;
        }

        public void enableFieldsForCateg()
        {
            catnametxtbx.Enabled = true;
            catidtxtbx.Enabled = true;
        }

        private void clearFieldsForProd()
        {
            categidtxtbx.Clear();
            prodidtxtbx.Clear();
            prodnametxtbx.Clear();
            qttytxtbx.Clear();
        }

        private void clearFieldsForCateg()
        {
            catnametxtbx.Clear();
            catidtxtbx.Clear();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            enableFieldsForProd();
            ldrec();

            editprod.Enabled = false;
            delprod.Enabled = false;
            cancelbtnprod.Enabled = true;
            addprod.Text = "CONFIRM";
            bool ispresent = false;

            if (prodidtxtbx.Text != "" && prodnametxtbx.Text != "" && qttytxtbx.Text != "" && categidtxtbx.Text != "")
            {
                String data = "Select * from producttbl";
                query query = new query();
                query.dispRec(data);

                for (int i = 0; i < query.dtst.Tables[0].Rows.Count; i++)
                {
                    if (prodidtxtbx.Text == query.dtst.Tables[0].Rows[i].ItemArray.GetValue(0).ToString())
                    {
                        ispresent = true;
                        break;
                    }
                    else
                    {
                        ispresent = false;
                    }
                }

                if (ispresent)
                {
                    MessageBox.Show("Product ID was already exist in the database", "NOTICE");
                    prodidtxtbx.Clear();
                    prodidtxtbx.Focus();
                }
                else if (ispresent != true)
                {
                    bool notdeclared = false;
                    String datafrmtbl = "Select * from categorytbl";
                    query querytotbl = new query();
                    querytotbl.dispRec(datafrmtbl);
                    for (int i = 0; i < querytotbl.dtst.Tables[0].Rows.Count; i++)
                    {
                        match = querytotbl.dtst.Tables[0].Rows[i].ItemArray.GetValue(1).ToString();

                        if (categidtxtbx.Text == querytotbl.dtst.Tables[0].Rows[i].ItemArray.GetValue(0).ToString())
                        {
                            notdeclared = false;
                            break;
                        }

                    }

                    if(notdeclared)
                    {
                        MessageBox.Show("Category ID doesn't exist, consider adding it.", "NOTICE");
                    }
                    else
                    {
                        String concat = categidtxtbx.Text + " - " + match;
                        String str = "INSERT INTO producttbl(ProductID,ProductName,Quantity,CategoryID) values('" + prodidtxtbx.Text + "', '" + prodnametxtbx.Text + "', '" + qttytxtbx.Text + "', '" + concat + "')";
                        query qury = new query();
                        qury.maintRec(str);
                        ldrec();
                        MessageBox.Show("SUCCESS!", "Notice");
                        clearFieldsForProd();
                        cancelbtnprod.Enabled = false;
                        addprod.Text = "ADD";
                        disableFieldsForProd();
                    }
                }
            }
            else if (addprod.Text == "CONFIRM")
            {
                MessageBox.Show("Heads Up, Fill all the fields.", "Notice");
            }
        }

        private void cnclbtn_Click(object sender, EventArgs e)
        {
            clearFieldsForProd();
            disableFieldsForProd();
            addprod.Text = "ADD";
            lvprod.SelectedItems.Clear();
            addprod.Enabled = true;
            editprod.Enabled = false;
            delprod.Enabled = false;
            cancelbtnprod.Enabled = false;
        }


        private void addcat_Click(object sender, EventArgs e)
        {
            enableFieldsForCateg();
            addcat.Enabled = true;
            addcat.Text = "CONFIRM";
            cancelbtncat.Enabled = true;
            bool isduplicate = false;
            if (catnametxtbx.Text != "" && catidtxtbx.Text != "")
            {
                String data = "Select * from categorytbl";
                query query = new query();
                query.dispRec(data);
                for (int i = 0; i < query.dtst.Tables[0].Rows.Count; i++)
                {

                    if (catidtxtbx.Text == query.dtst.Tables[0].Rows[i].ItemArray.GetValue(0).ToString())
                    {
                        isduplicate = true;
                        break;
                    }
                    
                }

                if (isduplicate)
                {
                    MessageBox.Show("The Category ID already existed.", "WARNING");
                }
                else
                {
                    string addcattodb = "INSERT INTO categorytbl(categoryID, categoryName) values('" + catidtxtbx.Text + "', '" + catnametxtbx.Text + "')";
                    query queryaddcat = new query();
                    queryaddcat.maintRec(addcattodb);
                    ldreccat();
                    cancelbtncat.Enabled = false;
                    clearFieldsForCateg();
                    disableFieldsForCateg();
                    addcat.Text = "ADD";
                    MessageBox.Show("SUCCESS!", "Notice");
                    cancelbtncat.Enabled = false;
                }
            }
            else
            {           
                MessageBox.Show("Heads Up, Fill all the fields.", "Notice");
            }
        }

        private void cancelbtncat_Click(object sender, EventArgs e)
        {
            disableFieldsForCateg();
            clearFieldsForCateg();
            lvcateg.SelectedItems.Clear();
            addcat.Text = "ADD";
            addcat.Enabled = true;
            cancelbtncat.Enabled = false;
        }

        private void lvcateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cancelbtncat.Enabled = true;
            addcat.Enabled = false;
        }

        private void lvprod_SelectedIndexChanged(object sender, EventArgs e)
        {
            delprod.Enabled = true;
            addprod.Enabled = false;
            editprod.Enabled = true;
            cancelbtnprod.Enabled = true;
        }

        private void lvprod_Click(object sender, EventArgs e)
        {
            cancelbtnprod.Enabled = true;
            prodidtxtbx.Text = lvprod.SelectedItems[0].Text;
            prodnametxtbx.Text = lvprod.SelectedItems[0].SubItems[1].Text;
            qttytxtbx.Text = lvprod.SelectedItems[0].SubItems[2].Text;
            categidtxtbx.Text = lvprod.SelectedItems[0].SubItems[3].Text;
        }

        private void editprod_Click(object sender, EventArgs e)
        {
            if (editprod.Text == "EDIT")
            {
                editprod.Text = "SAVE";
                enableFieldsForProd();
                prodidtxtbx.Enabled = false;
            }
            else
            {
                String upd = "UPDATE producttbl SET ProductName='"+ prodnametxtbx.Text +"', Quantity='"+ qttytxtbx.Text +"', CategoryID='"+ categidtxtbx.Text +"' where ProductID='"+ prodidtxtbx.Text +"'";
                query qry = new query();
                qry.maintRec(upd);
                ldrec();
                MessageBox.Show("Successfully Updated!", "Message");
                clearFieldsForProd();
                disableFieldsForProd();
                editprod.Text = "EDIT";
                editprod.Enabled = false;
                delprod.Enabled = false;
                addprod.Enabled = true;
                cancelbtnprod.Enabled = false;
            }
        }

        private void delprod_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to continue this operation?", "WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String del = "DELETE FROM producttbl where ProductID='"+ prodidtxtbx.Text +"'";
                query qrdel = new query();
                qrdel.maintRec(del);
                MessageBox.Show("Successfully Deleted", "Notice");
                ldrec();
                clearFieldsForProd();
                cancelbtnprod.Enabled = false;
                delprod.Enabled = false;
                editprod.Enabled = false;
                addprod.Enabled = true;
            }
        }
    }
}
