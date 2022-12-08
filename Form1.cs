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
        private bool isCatNameEmpty = true;
        private bool isCatIdEmpty = true;
        public mainform()
        {
            InitializeComponent();
            disableFieldsForProd();
            disableFieldsForCateg();
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
            editprod.Enabled = false;
            delprod.Enabled = false;

            if (addprod.Text == "CONFIRM" && prodID.Text != "" && prodnametxtbx.Text != "" && qttytxtbx.Text != "" && categidtxtbx.Text != "")
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
            editprod.Enabled = true;
            delprod.Enabled = true;
            addprod.Text = "ADD";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addcat_Click(object sender, EventArgs e)
        {
            enableFieldsForCateg();
            addcat.Enabled = true;
            delcat.Enabled = false;

            if (addcat.Text == "CONFIRM" && catnametxtbx.Text != "" && catidtxtbx.Text != "")
            {
                MessageBox.Show("SUCCESS!", "Notice");
            }
            else if (addcat.Text == "CONFIRM")
            {
                MessageBox.Show("Please don't leave any fields blank", "Notice");
            }
            addcat.Text = "CONFIRM";
        }

        private void cancelbtncat_Click(object sender, EventArgs e)
        {
            disableFieldsForCateg();
            clearFieldsForCateg();
            addcat.Text = "ADD";
            addcat.Enabled = true;
            delcat.Enabled = true;
        }

        private void lvcateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
