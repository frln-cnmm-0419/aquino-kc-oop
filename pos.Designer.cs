
namespace records_database
{
    partial class pointOfSale
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
            this.posLv = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qtty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grndtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ornum = new System.Windows.Forms.Label();
            this.ornumtxtbx = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grndTotalTxtBox = new System.Windows.Forms.TextBox();
            this.cashTxtBox = new System.Windows.Forms.TextBox();
            this.changetxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // posLv
            // 
            this.posLv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.posLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.qtty,
            this.price,
            this.grndtotal});
            this.posLv.GridLines = true;
            this.posLv.HideSelection = false;
            this.posLv.Location = new System.Drawing.Point(24, 143);
            this.posLv.Name = "posLv";
            this.posLv.Size = new System.Drawing.Size(592, 292);
            this.posLv.TabIndex = 0;
            this.posLv.UseCompatibleStateImageBehavior = false;
            this.posLv.View = System.Windows.Forms.View.Details;
            // 
            // productName
            // 
            this.productName.Text = "Product Name:";
            this.productName.Width = 303;
            // 
            // qtty
            // 
            this.qtty.Text = "Quantity";
            // 
            // price
            // 
            this.price.Text = "Price:";
            this.price.Width = 140;
            // 
            // grndtotal
            // 
            this.grndtotal.Text = "Grand Total:";
            this.grndtotal.Width = 83;
            // 
            // ornum
            // 
            this.ornum.AutoSize = true;
            this.ornum.BackColor = System.Drawing.Color.Transparent;
            this.ornum.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ornum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ornum.Location = new System.Drawing.Point(21, 19);
            this.ornum.Name = "ornum";
            this.ornum.Size = new System.Drawing.Size(87, 14);
            this.ornum.TabIndex = 1;
            this.ornum.Text = "OR Number:";
            // 
            // ornumtxtbx
            // 
            this.ornumtxtbx.Enabled = false;
            this.ornumtxtbx.Location = new System.Drawing.Point(24, 35);
            this.ornumtxtbx.Name = "ornumtxtbx";
            this.ornumtxtbx.Size = new System.Drawing.Size(195, 20);
            this.ornumtxtbx.TabIndex = 2;
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(24, 87);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(195, 20);
            this.custName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(235, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "GrandTotal Price:";
            // 
            // grndTotalTxtBox
            // 
            this.grndTotalTxtBox.Enabled = false;
            this.grndTotalTxtBox.Location = new System.Drawing.Point(238, 35);
            this.grndTotalTxtBox.Name = "grndTotalTxtBox";
            this.grndTotalTxtBox.Size = new System.Drawing.Size(195, 20);
            this.grndTotalTxtBox.TabIndex = 7;
            // 
            // cashTxtBox
            // 
            this.cashTxtBox.Location = new System.Drawing.Point(238, 87);
            this.cashTxtBox.Name = "cashTxtBox";
            this.cashTxtBox.Size = new System.Drawing.Size(195, 20);
            this.cashTxtBox.TabIndex = 12;
            this.cashTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashTxtBox_KeyPress);
            // 
            // changetxtbox
            // 
            this.changetxtbox.Enabled = false;
            this.changetxtbox.Location = new System.Drawing.Point(461, 35);
            this.changetxtbox.Name = "changetxtbox";
            this.changetxtbox.Size = new System.Drawing.Size(155, 20);
            this.changetxtbox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(235, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cash:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(458, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Change:";
            // 
            // confbtn
            // 
            this.confbtn.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confbtn.Location = new System.Drawing.Point(461, 77);
            this.confbtn.Name = "confbtn";
            this.confbtn.Size = new System.Drawing.Size(155, 38);
            this.confbtn.TabIndex = 13;
            this.confbtn.Text = "CONFIRM";
            this.confbtn.UseVisualStyleBackColor = true;
            this.confbtn.Click += new System.EventHandler(this.confbtn_Click);
            // 
            // pointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::records_database.Properties.Resources.Green;
            this.ClientSize = new System.Drawing.Size(648, 473);
            this.Controls.Add(this.confbtn);
            this.Controls.Add(this.cashTxtBox);
            this.Controls.Add(this.changetxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grndTotalTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.ornumtxtbx);
            this.Controls.Add(this.ornum);
            this.Controls.Add(this.posLv);
            this.Name = "pointOfSale";
            this.Text = "Point Of Sales";
            this.Load += new System.EventHandler(this.pointOfSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView posLv;
        private System.Windows.Forms.Label ornum;
        private System.Windows.Forms.TextBox ornumtxtbx;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grndTotalTxtBox;
        private System.Windows.Forms.TextBox cashTxtBox;
        private System.Windows.Forms.TextBox changetxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader qtty;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader grndtotal;
        private System.Windows.Forms.Button confbtn;
    }
}