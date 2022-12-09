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
            delcat.Enabled = false;
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

        private void isEmpty()
        {
            if (categidtxtbx.Text != "" && prodidtxtbx.Text != "" && prodnametxtbx.Text != "" && qttytxtbx.Text != "")
            {
                addprod.Text = "CONFIRM";
            }
            else
            {
                addprod.Text = "ADD";
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            enableFieldsForProd();
            ldrec();

            editprod.Enabled = false;
            delprod.Enabled = false;
            cancelbtnprod.Enabled = true;

            if (addprod.Text == "CONFIRM" && prodidtxtbx.Text != "" && prodnametxtbx.Text != "" && qttytxtbx.Text != "" && categidtxtbx.Text != "")
            {
                MessageBox.Show("SUCCESS!", "Notice");
            }
            else if (addprod.Text == "CONFIRM")
            {
                MessageBox.Show("Please don't leave any fields blank", "Notice");
            }
            addprod.Text = "CONFIRM";
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
            delcat.Enabled = false;

            if (addcat.Text == "CONFIRM" && catnametxtbx.Text != "" && catidtxtbx.Text != "")
            {
                MessageBox.Show("SUCCESS!", "Notice");
                String str = "INSERT INTO producttbl(ProductID,ProductName,)";
            }
            else if (addcat.Text == "CONFIRM")
            {
                MessageBox.Show("Please don't leave any fields blank", "Notice");
            }
            addcat.Text = "CONFIRM";
            cancelbtncat.Enabled = true;
        }

        private void cancelbtncat_Click(object sender, EventArgs e)
        {
            disableFieldsForCateg();
            clearFieldsForCateg();
            lvcateg.SelectedItems.Clear();
            addcat.Text = "ADD";
            addcat.Enabled = true;
            delcat.Enabled = false;
            cancelbtncat.Enabled = false;
        }

        private void lvcateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            delcat.Enabled = true;
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
    }
}
