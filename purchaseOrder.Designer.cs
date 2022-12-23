
namespace records_database
{
    partial class purchaseOrder
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
            this.suppNameTxtBx = new System.Windows.Forms.TextBox();
            this.suppAddTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qttyPurchOrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPriceTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grndTotalPriceTxtbx = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.lvPurchOrd = new System.Windows.Forms.ListView();
            this.suppliernameHidden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplieraddHidden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplierPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qttyStocks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addToPurchbtn = new System.Windows.Forms.Button();
            this.cancelSelectionbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // suppNameTxtBx
            // 
            this.suppNameTxtBx.Enabled = false;
            this.suppNameTxtBx.Location = new System.Drawing.Point(38, 35);
            this.suppNameTxtBx.Name = "suppNameTxtBx";
            this.suppNameTxtBx.Size = new System.Drawing.Size(230, 20);
            this.suppNameTxtBx.TabIndex = 1;
            // 
            // suppAddTxtBx
            // 
            this.suppAddTxtBx.Enabled = false;
            this.suppAddTxtBx.Location = new System.Drawing.Point(38, 84);
            this.suppAddTxtBx.Name = "suppAddTxtBx";
            this.suppAddTxtBx.Size = new System.Drawing.Size(230, 20);
            this.suppAddTxtBx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier Address:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(292, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // qttyPurchOrd
            // 
            this.qttyPurchOrd.Location = new System.Drawing.Point(295, 35);
            this.qttyPurchOrd.Name = "qttyPurchOrd";
            this.qttyPurchOrd.Size = new System.Drawing.Size(62, 20);
            this.qttyPurchOrd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(292, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Price:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // totalPriceTxtBox
            // 
            this.totalPriceTxtBox.Enabled = false;
            this.totalPriceTxtBox.Location = new System.Drawing.Point(295, 84);
            this.totalPriceTxtBox.Name = "totalPriceTxtBox";
            this.totalPriceTxtBox.Size = new System.Drawing.Size(62, 20);
            this.totalPriceTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(394, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grand Total Price:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // grndTotalPriceTxtbx
            // 
            this.grndTotalPriceTxtbx.Enabled = false;
            this.grndTotalPriceTxtbx.Location = new System.Drawing.Point(397, 61);
            this.grndTotalPriceTxtbx.Name = "grndTotalPriceTxtbx";
            this.grndTotalPriceTxtbx.Size = new System.Drawing.Size(90, 20);
            this.grndTotalPriceTxtbx.TabIndex = 9;
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enter.Location = new System.Drawing.Point(551, 12);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(101, 47);
            this.enter.TabIndex = 11;
            this.enter.Text = "Calculate";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // lvPurchOrd
            // 
            this.lvPurchOrd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvPurchOrd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.suppliernameHidden,
            this.supplieraddHidden,
            this.productID,
            this.productName,
            this.supplierPrice,
            this.qttyStocks,
            this.categname});
            this.lvPurchOrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPurchOrd.FullRowSelect = true;
            this.lvPurchOrd.GridLines = true;
            this.lvPurchOrd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPurchOrd.HideSelection = false;
            this.lvPurchOrd.Location = new System.Drawing.Point(38, 122);
            this.lvPurchOrd.Name = "lvPurchOrd";
            this.lvPurchOrd.Size = new System.Drawing.Size(674, 435);
            this.lvPurchOrd.TabIndex = 12;
            this.lvPurchOrd.UseCompatibleStateImageBehavior = false;
            this.lvPurchOrd.View = System.Windows.Forms.View.Details;
            this.lvPurchOrd.SelectedIndexChanged += new System.EventHandler(this.lvPurchOrd_SelectedIndexChanged);
            // 
            // suppliernameHidden
            // 
            this.suppliernameHidden.Text = "Supplier Name Hidden";
            this.suppliernameHidden.Width = 0;
            // 
            // supplieraddHidden
            // 
            this.supplieraddHidden.Text = "Supplier Add. Hidden";
            this.supplieraddHidden.Width = 0;
            // 
            // productID
            // 
            this.productID.Text = "Product ID:";
            this.productID.Width = 98;
            // 
            // productName
            // 
            this.productName.Text = "Product Name:";
            this.productName.Width = 180;
            // 
            // supplierPrice
            // 
            this.supplierPrice.Text = "Supplier Price in PHP:";
            this.supplierPrice.Width = 117;
            // 
            // qttyStocks
            // 
            this.qttyStocks.Text = "Quantity (Stocks):";
            this.qttyStocks.Width = 141;
            // 
            // categname
            // 
            this.categname.Text = "CategNameHidden";
            this.categname.Width = 0;
            // 
            // addToPurchbtn
            // 
            this.addToPurchbtn.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addToPurchbtn.Location = new System.Drawing.Point(658, 45);
            this.addToPurchbtn.Name = "addToPurchbtn";
            this.addToPurchbtn.Size = new System.Drawing.Size(101, 47);
            this.addToPurchbtn.TabIndex = 13;
            this.addToPurchbtn.Text = "ADD TO Purchase";
            this.addToPurchbtn.UseVisualStyleBackColor = true;
            this.addToPurchbtn.Click += new System.EventHandler(this.addToPurchbtn_Click);
            // 
            // cancelSelectionbtn
            // 
            this.cancelSelectionbtn.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelSelectionbtn.Location = new System.Drawing.Point(551, 68);
            this.cancelSelectionbtn.Name = "cancelSelectionbtn";
            this.cancelSelectionbtn.Size = new System.Drawing.Size(101, 47);
            this.cancelSelectionbtn.TabIndex = 14;
            this.cancelSelectionbtn.Text = "Cancel Selection";
            this.cancelSelectionbtn.UseVisualStyleBackColor = true;
            this.cancelSelectionbtn.Click += new System.EventHandler(this.cancelSelectionbtn_Click);
            // 
            // purchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::records_database.Properties.Resources.Green;
            this.ClientSize = new System.Drawing.Size(768, 601);
            this.Controls.Add(this.cancelSelectionbtn);
            this.Controls.Add(this.addToPurchbtn);
            this.Controls.Add(this.lvPurchOrd);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grndTotalPriceTxtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPriceTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qttyPurchOrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suppAddTxtBx);
            this.Controls.Add(this.suppNameTxtBx);
            this.Name = "purchaseOrder";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.purchaseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox suppNameTxtBx;
        private System.Windows.Forms.TextBox suppAddTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qttyPurchOrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalPriceTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox grndTotalPriceTxtbx;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.ListView lvPurchOrd;
        private System.Windows.Forms.ColumnHeader suppliernameHidden;
        private System.Windows.Forms.ColumnHeader supplieraddHidden;
        private System.Windows.Forms.ColumnHeader productID;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader supplierPrice;
        private System.Windows.Forms.ColumnHeader qttyStocks;
        private System.Windows.Forms.Button addToPurchbtn;
        private System.Windows.Forms.Button cancelSelectionbtn;
        private System.Windows.Forms.ColumnHeader categname;
    }
}