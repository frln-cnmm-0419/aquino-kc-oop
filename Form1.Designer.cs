
namespace records_database
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prodidlbl = new System.Windows.Forms.Label();
            this.prodnamelbl = new System.Windows.Forms.Label();
            this.qttylbl = new System.Windows.Forms.Label();
            this.catidprodlbl = new System.Windows.Forms.Label();
            this.prodidtxtbx = new System.Windows.Forms.TextBox();
            this.categidtxtbx = new System.Windows.Forms.TextBox();
            this.prodnametxtbx = new System.Windows.Forms.TextBox();
            this.qttytxtbx = new System.Windows.Forms.TextBox();
            this.addprod = new System.Windows.Forms.Button();
            this.editprod = new System.Windows.Forms.Button();
            this.delprod = new System.Windows.Forms.Button();
            this.cancelbtnprod = new System.Windows.Forms.Button();
            this.lvprod = new System.Windows.Forms.ListView();
            this.prodID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cancelbtncat = new System.Windows.Forms.Button();
            this.delcat = new System.Windows.Forms.Button();
            this.addcat = new System.Windows.Forms.Button();
            this.catnametxtbx = new System.Windows.Forms.TextBox();
            this.catidtxtbx = new System.Windows.Forms.TextBox();
            this.catnamelbl = new System.Windows.Forms.Label();
            this.catidlbl = new System.Windows.Forms.Label();
            this.lvcateg = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodmaintenancelbl = new System.Windows.Forms.Label();
            this.catmaintenancelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prodidlbl
            // 
            this.prodidlbl.AutoSize = true;
            this.prodidlbl.Location = new System.Drawing.Point(12, 34);
            this.prodidlbl.Name = "prodidlbl";
            this.prodidlbl.Size = new System.Drawing.Size(77, 13);
            this.prodidlbl.TabIndex = 0;
            this.prodidlbl.Text = "PRODUCT ID:";
            // 
            // prodnamelbl
            // 
            this.prodnamelbl.AutoSize = true;
            this.prodnamelbl.Location = new System.Drawing.Point(12, 82);
            this.prodnamelbl.Name = "prodnamelbl";
            this.prodnamelbl.Size = new System.Drawing.Size(97, 13);
            this.prodnamelbl.TabIndex = 1;
            this.prodnamelbl.Text = "PRODUCT NAME:";
            // 
            // qttylbl
            // 
            this.qttylbl.AutoSize = true;
            this.qttylbl.Location = new System.Drawing.Point(12, 137);
            this.qttylbl.Name = "qttylbl";
            this.qttylbl.Size = new System.Drawing.Size(65, 13);
            this.qttylbl.TabIndex = 2;
            this.qttylbl.Text = "QUANTITY:";
            // 
            // catidprodlbl
            // 
            this.catidprodlbl.AutoSize = true;
            this.catidprodlbl.Location = new System.Drawing.Point(12, 190);
            this.catidprodlbl.Name = "catidprodlbl";
            this.catidprodlbl.Size = new System.Drawing.Size(83, 13);
            this.catidprodlbl.TabIndex = 3;
            this.catidprodlbl.Text = "CATEGORY ID:";
            // 
            // prodidtxtbx
            // 
            this.prodidtxtbx.Location = new System.Drawing.Point(15, 53);
            this.prodidtxtbx.Name = "prodidtxtbx";
            this.prodidtxtbx.Size = new System.Drawing.Size(282, 20);
            this.prodidtxtbx.TabIndex = 4;
            // 
            // categidtxtbx
            // 
            this.categidtxtbx.Location = new System.Drawing.Point(15, 215);
            this.categidtxtbx.Name = "categidtxtbx";
            this.categidtxtbx.Size = new System.Drawing.Size(282, 20);
            this.categidtxtbx.TabIndex = 5;
            // 
            // prodnametxtbx
            // 
            this.prodnametxtbx.Location = new System.Drawing.Point(15, 104);
            this.prodnametxtbx.Name = "prodnametxtbx";
            this.prodnametxtbx.Size = new System.Drawing.Size(282, 20);
            this.prodnametxtbx.TabIndex = 6;
            // 
            // qttytxtbx
            // 
            this.qttytxtbx.Location = new System.Drawing.Point(15, 162);
            this.qttytxtbx.Name = "qttytxtbx";
            this.qttytxtbx.Size = new System.Drawing.Size(282, 20);
            this.qttytxtbx.TabIndex = 7;
            // 
            // addprod
            // 
            this.addprod.Location = new System.Drawing.Point(315, 55);
            this.addprod.Name = "addprod";
            this.addprod.Size = new System.Drawing.Size(123, 39);
            this.addprod.TabIndex = 8;
            this.addprod.Text = "ADD";
            this.addprod.UseVisualStyleBackColor = true;
            this.addprod.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editprod
            // 
            this.editprod.Location = new System.Drawing.Point(315, 100);
            this.editprod.Name = "editprod";
            this.editprod.Size = new System.Drawing.Size(123, 39);
            this.editprod.TabIndex = 9;
            this.editprod.Text = "EDIT";
            this.editprod.UseVisualStyleBackColor = true;
            // 
            // delprod
            // 
            this.delprod.Location = new System.Drawing.Point(315, 145);
            this.delprod.Name = "delprod";
            this.delprod.Size = new System.Drawing.Size(123, 39);
            this.delprod.TabIndex = 10;
            this.delprod.Text = "DELETE";
            this.delprod.UseVisualStyleBackColor = true;
            // 
            // cancelbtnprod
            // 
            this.cancelbtnprod.Location = new System.Drawing.Point(315, 190);
            this.cancelbtnprod.Name = "cancelbtnprod";
            this.cancelbtnprod.Size = new System.Drawing.Size(123, 39);
            this.cancelbtnprod.TabIndex = 11;
            this.cancelbtnprod.Text = "CANCEL";
            this.cancelbtnprod.UseVisualStyleBackColor = true;
            this.cancelbtnprod.Click += new System.EventHandler(this.cnclbtn_Click);
            // 
            // lvprod
            // 
            this.lvprod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prodID,
            this.prodName,
            this.quantity,
            this.categoryID});
            this.lvprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvprod.FullRowSelect = true;
            this.lvprod.GridLines = true;
            this.lvprod.HideSelection = false;
            this.lvprod.Location = new System.Drawing.Point(15, 248);
            this.lvprod.Name = "lvprod";
            this.lvprod.Size = new System.Drawing.Size(423, 289);
            this.lvprod.TabIndex = 12;
            this.lvprod.UseCompatibleStateImageBehavior = false;
            this.lvprod.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // prodName
            // 
            this.prodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantity
            // 
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryID
            // 
            this.categoryID.Text = "";
            // 
            // cancelbtncat
            // 
            this.cancelbtncat.Location = new System.Drawing.Point(848, 186);
            this.cancelbtncat.Name = "cancelbtncat";
            this.cancelbtncat.Size = new System.Drawing.Size(123, 39);
            this.cancelbtncat.TabIndex = 16;
            this.cancelbtncat.Text = "CANCEL";
            this.cancelbtncat.UseVisualStyleBackColor = true;
            this.cancelbtncat.Click += new System.EventHandler(this.cancelbtncat_Click);
            // 
            // delcat
            // 
            this.delcat.Location = new System.Drawing.Point(709, 186);
            this.delcat.Name = "delcat";
            this.delcat.Size = new System.Drawing.Size(123, 39);
            this.delcat.TabIndex = 15;
            this.delcat.Text = "DELETE";
            this.delcat.UseVisualStyleBackColor = true;
            // 
            // addcat
            // 
            this.addcat.Location = new System.Drawing.Point(575, 186);
            this.addcat.Name = "addcat";
            this.addcat.Size = new System.Drawing.Size(123, 39);
            this.addcat.TabIndex = 13;
            this.addcat.Text = "ADD";
            this.addcat.UseVisualStyleBackColor = true;
            this.addcat.Click += new System.EventHandler(this.addcat_Click);
            // 
            // catnametxtbx
            // 
            this.catnametxtbx.Location = new System.Drawing.Point(589, 138);
            this.catnametxtbx.Name = "catnametxtbx";
            this.catnametxtbx.Size = new System.Drawing.Size(361, 20);
            this.catnametxtbx.TabIndex = 17;
            // 
            // catidtxtbx
            // 
            this.catidtxtbx.Location = new System.Drawing.Point(589, 86);
            this.catidtxtbx.Name = "catidtxtbx";
            this.catidtxtbx.Size = new System.Drawing.Size(361, 20);
            this.catidtxtbx.TabIndex = 18;
            // 
            // catnamelbl
            // 
            this.catnamelbl.AutoSize = true;
            this.catnamelbl.Location = new System.Drawing.Point(586, 114);
            this.catnamelbl.Name = "catnamelbl";
            this.catnamelbl.Size = new System.Drawing.Size(103, 13);
            this.catnamelbl.TabIndex = 19;
            this.catnamelbl.Text = "CATEGORY NAME:";
            // 
            // catidlbl
            // 
            this.catidlbl.AutoSize = true;
            this.catidlbl.Location = new System.Drawing.Point(586, 64);
            this.catidlbl.Name = "catidlbl";
            this.catidlbl.Size = new System.Drawing.Size(83, 13);
            this.catidlbl.TabIndex = 20;
            this.catidlbl.Text = "CATEGORY ID:";
            // 
            // lvcateg
            // 
            this.lvcateg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvcateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvcateg.FullRowSelect = true;
            this.lvcateg.GridLines = true;
            this.lvcateg.HideSelection = false;
            this.lvcateg.Location = new System.Drawing.Point(575, 248);
            this.lvcateg.Name = "lvcateg";
            this.lvcateg.Size = new System.Drawing.Size(396, 289);
            this.lvcateg.TabIndex = 21;
            this.lvcateg.UseCompatibleStateImageBehavior = false;
            this.lvcateg.SelectedIndexChanged += new System.EventHandler(this.lvcateg_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            // 
            // prodmaintenancelbl
            // 
            this.prodmaintenancelbl.AutoSize = true;
            this.prodmaintenancelbl.Location = new System.Drawing.Point(139, 9);
            this.prodmaintenancelbl.Name = "prodmaintenancelbl";
            this.prodmaintenancelbl.Size = new System.Drawing.Size(109, 13);
            this.prodmaintenancelbl.TabIndex = 22;
            this.prodmaintenancelbl.Text = "Product Maintenance";
            // 
            // catmaintenancelbl
            // 
            this.catmaintenancelbl.AutoSize = true;
            this.catmaintenancelbl.Location = new System.Drawing.Point(728, 9);
            this.catmaintenancelbl.Name = "catmaintenancelbl";
            this.catmaintenancelbl.Size = new System.Drawing.Size(114, 13);
            this.catmaintenancelbl.TabIndex = 23;
            this.catmaintenancelbl.Text = "Category Maintenance";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 549);
            this.Controls.Add(this.catmaintenancelbl);
            this.Controls.Add(this.prodmaintenancelbl);
            this.Controls.Add(this.lvcateg);
            this.Controls.Add(this.catidlbl);
            this.Controls.Add(this.catnamelbl);
            this.Controls.Add(this.catidtxtbx);
            this.Controls.Add(this.catnametxtbx);
            this.Controls.Add(this.cancelbtncat);
            this.Controls.Add(this.delcat);
            this.Controls.Add(this.addcat);
            this.Controls.Add(this.lvprod);
            this.Controls.Add(this.cancelbtnprod);
            this.Controls.Add(this.delprod);
            this.Controls.Add(this.editprod);
            this.Controls.Add(this.addprod);
            this.Controls.Add(this.qttytxtbx);
            this.Controls.Add(this.prodnametxtbx);
            this.Controls.Add(this.categidtxtbx);
            this.Controls.Add(this.prodidtxtbx);
            this.Controls.Add(this.catidprodlbl);
            this.Controls.Add(this.qttylbl);
            this.Controls.Add(this.prodnamelbl);
            this.Controls.Add(this.prodidlbl);
            this.Name = "mainform";
            this.Text = "Product & Category Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prodidlbl;
        private System.Windows.Forms.Label prodnamelbl;
        private System.Windows.Forms.Label qttylbl;
        private System.Windows.Forms.Label catidprodlbl;
        private System.Windows.Forms.TextBox prodidtxtbx;
        private System.Windows.Forms.TextBox categidtxtbx;
        private System.Windows.Forms.TextBox prodnametxtbx;
        private System.Windows.Forms.TextBox qttytxtbx;
        private System.Windows.Forms.Button addprod;
        private System.Windows.Forms.Button editprod;
        private System.Windows.Forms.Button delprod;
        private System.Windows.Forms.Button cancelbtnprod;
        private System.Windows.Forms.ListView lvprod;
        private System.Windows.Forms.ColumnHeader prodID;
        private System.Windows.Forms.ColumnHeader prodName;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader categoryID;
        private System.Windows.Forms.Button cancelbtncat;
        private System.Windows.Forms.Button delcat;
        private System.Windows.Forms.Button addcat;
        private System.Windows.Forms.TextBox catnametxtbx;
        private System.Windows.Forms.TextBox catidtxtbx;
        private System.Windows.Forms.Label catnamelbl;
        private System.Windows.Forms.Label catidlbl;
        private System.Windows.Forms.ListView lvcateg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label prodmaintenancelbl;
        private System.Windows.Forms.Label catmaintenancelbl;
    }
}

