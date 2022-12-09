
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
            this.cancelbtncat = new System.Windows.Forms.Button();
            this.delcat = new System.Windows.Forms.Button();
            this.addcat = new System.Windows.Forms.Button();
            this.catnametxtbx = new System.Windows.Forms.TextBox();
            this.catidtxtbx = new System.Windows.Forms.TextBox();
            this.catnamelbl = new System.Windows.Forms.Label();
            this.catidlbl = new System.Windows.Forms.Label();
            this.lvcateg = new System.Windows.Forms.ListView();
            this.prodmaintenancelbl = new System.Windows.Forms.Label();
            this.catmaintenancelbl = new System.Windows.Forms.Label();
            this.fcatcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scatcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvprod = new System.Windows.Forms.ListView();
            this.fprodcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sprodcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tprodcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frtprodcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // prodidlbl
            // 
            this.prodidlbl.AutoSize = true;
            this.prodidlbl.BackColor = System.Drawing.Color.Transparent;
            this.prodidlbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prodidlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodidlbl.Location = new System.Drawing.Point(12, 34);
            this.prodidlbl.Name = "prodidlbl";
            this.prodidlbl.Size = new System.Drawing.Size(95, 14);
            this.prodidlbl.TabIndex = 0;
            this.prodidlbl.Text = "PRODUCT ID:";
            // 
            // prodnamelbl
            // 
            this.prodnamelbl.AutoSize = true;
            this.prodnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.prodnamelbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prodnamelbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodnamelbl.Location = new System.Drawing.Point(12, 82);
            this.prodnamelbl.Name = "prodnamelbl";
            this.prodnamelbl.Size = new System.Drawing.Size(111, 14);
            this.prodnamelbl.TabIndex = 1;
            this.prodnamelbl.Text = "PRODUCT NAME:";
            // 
            // qttylbl
            // 
            this.qttylbl.AutoSize = true;
            this.qttylbl.BackColor = System.Drawing.Color.Transparent;
            this.qttylbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.qttylbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.qttylbl.Location = new System.Drawing.Point(12, 137);
            this.qttylbl.Name = "qttylbl";
            this.qttylbl.Size = new System.Drawing.Size(79, 14);
            this.qttylbl.TabIndex = 2;
            this.qttylbl.Text = "QUANTITY:";
            // 
            // catidprodlbl
            // 
            this.catidprodlbl.AutoSize = true;
            this.catidprodlbl.BackColor = System.Drawing.Color.Transparent;
            this.catidprodlbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.catidprodlbl.ForeColor = System.Drawing.Color.Transparent;
            this.catidprodlbl.Location = new System.Drawing.Point(12, 190);
            this.catidprodlbl.Name = "catidprodlbl";
            this.catidprodlbl.Size = new System.Drawing.Size(103, 14);
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
            this.addprod.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.editprod.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editprod.Location = new System.Drawing.Point(315, 100);
            this.editprod.Name = "editprod";
            this.editprod.Size = new System.Drawing.Size(123, 39);
            this.editprod.TabIndex = 9;
            this.editprod.Text = "EDIT";
            this.editprod.UseVisualStyleBackColor = true;
            // 
            // delprod
            // 
            this.delprod.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delprod.Location = new System.Drawing.Point(315, 145);
            this.delprod.Name = "delprod";
            this.delprod.Size = new System.Drawing.Size(123, 39);
            this.delprod.TabIndex = 10;
            this.delprod.Text = "DELETE";
            this.delprod.UseVisualStyleBackColor = true;
            // 
            // cancelbtnprod
            // 
            this.cancelbtnprod.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelbtnprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelbtnprod.Location = new System.Drawing.Point(315, 190);
            this.cancelbtnprod.Name = "cancelbtnprod";
            this.cancelbtnprod.Size = new System.Drawing.Size(123, 39);
            this.cancelbtnprod.TabIndex = 11;
            this.cancelbtnprod.Text = "CANCEL";
            this.cancelbtnprod.UseVisualStyleBackColor = true;
            this.cancelbtnprod.Click += new System.EventHandler(this.cnclbtn_Click);
            // 
            // cancelbtncat
            // 
            this.cancelbtncat.Font = new System.Drawing.Font("JetBrains Mono Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelbtncat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelbtncat.Location = new System.Drawing.Point(986, 186);
            this.cancelbtncat.Name = "cancelbtncat";
            this.cancelbtncat.Size = new System.Drawing.Size(123, 39);
            this.cancelbtncat.TabIndex = 16;
            this.cancelbtncat.Text = "CANCEL";
            this.cancelbtncat.UseVisualStyleBackColor = true;
            this.cancelbtncat.Click += new System.EventHandler(this.cancelbtncat_Click);
            // 
            // delcat
            // 
            this.delcat.Font = new System.Drawing.Font("JetBrains Mono Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delcat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delcat.Location = new System.Drawing.Point(847, 186);
            this.delcat.Name = "delcat";
            this.delcat.Size = new System.Drawing.Size(123, 39);
            this.delcat.TabIndex = 15;
            this.delcat.Text = "DELETE";
            this.delcat.UseVisualStyleBackColor = true;
            // 
            // addcat
            // 
            this.addcat.Font = new System.Drawing.Font("JetBrains Mono Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addcat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addcat.Location = new System.Drawing.Point(713, 186);
            this.addcat.Name = "addcat";
            this.addcat.Size = new System.Drawing.Size(123, 39);
            this.addcat.TabIndex = 13;
            this.addcat.Text = "ADD";
            this.addcat.UseVisualStyleBackColor = true;
            this.addcat.Click += new System.EventHandler(this.addcat_Click);
            // 
            // catnametxtbx
            // 
            this.catnametxtbx.Location = new System.Drawing.Point(727, 138);
            this.catnametxtbx.Name = "catnametxtbx";
            this.catnametxtbx.Size = new System.Drawing.Size(361, 20);
            this.catnametxtbx.TabIndex = 17;
            // 
            // catidtxtbx
            // 
            this.catidtxtbx.Location = new System.Drawing.Point(727, 86);
            this.catidtxtbx.Name = "catidtxtbx";
            this.catidtxtbx.Size = new System.Drawing.Size(361, 20);
            this.catidtxtbx.TabIndex = 18;
            // 
            // catnamelbl
            // 
            this.catnamelbl.AutoSize = true;
            this.catnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.catnamelbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.catnamelbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.catnamelbl.Location = new System.Drawing.Point(724, 114);
            this.catnamelbl.Name = "catnamelbl";
            this.catnamelbl.Size = new System.Drawing.Size(119, 14);
            this.catnamelbl.TabIndex = 19;
            this.catnamelbl.Text = "CATEGORY NAME:";
            // 
            // catidlbl
            // 
            this.catidlbl.AutoSize = true;
            this.catidlbl.BackColor = System.Drawing.Color.Transparent;
            this.catidlbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.catidlbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.catidlbl.Location = new System.Drawing.Point(724, 64);
            this.catidlbl.Name = "catidlbl";
            this.catidlbl.Size = new System.Drawing.Size(103, 14);
            this.catidlbl.TabIndex = 20;
            this.catidlbl.Text = "CATEGORY ID:";
            // 
            // lvcateg
            // 
            this.lvcateg.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvcateg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fcatcol,
            this.scatcol});
            this.lvcateg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvcateg.FullRowSelect = true;
            this.lvcateg.GridLines = true;
            this.lvcateg.HideSelection = false;
            this.lvcateg.Location = new System.Drawing.Point(713, 248);
            this.lvcateg.Name = "lvcateg";
            this.lvcateg.Size = new System.Drawing.Size(396, 289);
            this.lvcateg.TabIndex = 21;
            this.lvcateg.UseCompatibleStateImageBehavior = false;
            this.lvcateg.View = System.Windows.Forms.View.Details;
            this.lvcateg.SelectedIndexChanged += new System.EventHandler(this.lvcateg_SelectedIndexChanged);
            // 
            // prodmaintenancelbl
            // 
            this.prodmaintenancelbl.AutoSize = true;
            this.prodmaintenancelbl.BackColor = System.Drawing.Color.Transparent;
            this.prodmaintenancelbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prodmaintenancelbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodmaintenancelbl.Location = new System.Drawing.Point(139, 9);
            this.prodmaintenancelbl.Name = "prodmaintenancelbl";
            this.prodmaintenancelbl.Size = new System.Drawing.Size(159, 14);
            this.prodmaintenancelbl.TabIndex = 22;
            this.prodmaintenancelbl.Text = "Product Maintenance";
            // 
            // catmaintenancelbl
            // 
            this.catmaintenancelbl.AutoSize = true;
            this.catmaintenancelbl.BackColor = System.Drawing.Color.Transparent;
            this.catmaintenancelbl.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.catmaintenancelbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.catmaintenancelbl.Location = new System.Drawing.Point(728, 9);
            this.catmaintenancelbl.Name = "catmaintenancelbl";
            this.catmaintenancelbl.Size = new System.Drawing.Size(167, 14);
            this.catmaintenancelbl.TabIndex = 23;
            this.catmaintenancelbl.Text = "Category Maintenance";
            // 
            // fcatcol
            // 
            this.fcatcol.Text = "Category ID";
            this.fcatcol.Width = 183;
            // 
            // scatcol
            // 
            this.scatcol.Text = "Category Name";
            this.scatcol.Width = 208;
            // 
            // lvprod
            // 
            this.lvprod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvprod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fprodcol,
            this.sprodcol,
            this.tprodcol,
            this.frtprodcol});
            this.lvprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvprod.FullRowSelect = true;
            this.lvprod.GridLines = true;
            this.lvprod.HideSelection = false;
            this.lvprod.Location = new System.Drawing.Point(15, 248);
            this.lvprod.Name = "lvprod";
            this.lvprod.Size = new System.Drawing.Size(601, 289);
            this.lvprod.TabIndex = 24;
            this.lvprod.UseCompatibleStateImageBehavior = false;
            this.lvprod.View = System.Windows.Forms.View.Details;
            this.lvprod.SelectedIndexChanged += new System.EventHandler(this.lvprod_SelectedIndexChanged);
            // 
            // fprodcol
            // 
            this.fprodcol.Text = "Product ID";
            this.fprodcol.Width = 106;
            // 
            // sprodcol
            // 
            this.sprodcol.Text = "Product Name";
            this.sprodcol.Width = 254;
            // 
            // tprodcol
            // 
            this.tprodcol.Text = "Quantity";
            this.tprodcol.Width = 85;
            // 
            // frtprodcol
            // 
            this.frtprodcol.Text = "Category ID";
            this.frtprodcol.Width = 151;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::records_database.Properties.Resources._318304089_551224579767443_5089812890261992367_n;
            this.ClientSize = new System.Drawing.Size(1121, 549);
            this.Controls.Add(this.lvprod);
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
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "mainform";
            this.Text = "Product & Category Maintenance";
            this.Load += new System.EventHandler(this.mainform_Load);
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
        private System.Windows.Forms.Button cancelbtncat;
        private System.Windows.Forms.Button delcat;
        private System.Windows.Forms.Button addcat;
        private System.Windows.Forms.TextBox catnametxtbx;
        private System.Windows.Forms.TextBox catidtxtbx;
        private System.Windows.Forms.Label catnamelbl;
        private System.Windows.Forms.Label catidlbl;
        private System.Windows.Forms.ListView lvcateg;
        private System.Windows.Forms.Label prodmaintenancelbl;
        private System.Windows.Forms.Label catmaintenancelbl;
        private System.Windows.Forms.ColumnHeader fcatcol;
        private System.Windows.Forms.ColumnHeader scatcol;
        private System.Windows.Forms.ListView lvprod;
        private System.Windows.Forms.ColumnHeader fprodcol;
        private System.Windows.Forms.ColumnHeader sprodcol;
        private System.Windows.Forms.ColumnHeader tprodcol;
        private System.Windows.Forms.ColumnHeader frtprodcol;
    }
}

