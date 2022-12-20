
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ornum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 292);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ornum
            // 
            this.ornum.AutoSize = true;
            this.ornum.Location = new System.Drawing.Point(21, 19);
            this.ornum.Name = "ornum";
            this.ornum.Size = new System.Drawing.Size(66, 13);
            this.ornum.TabIndex = 1;
            this.ornum.Text = "OR Number:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(24, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(24, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GrandTotal Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Price:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(243, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(243, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(461, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(461, 87);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cash:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Change:";
            // 
            // pointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 473);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ornum);
            this.Controls.Add(this.listView1);
            this.Name = "pointOfSale";
            this.Text = "Point Of Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label ornum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}