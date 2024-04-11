namespace Assessment_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAmountOwed = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDisplayQueue = new System.Windows.Forms.Button();
            this.btnHighestAmountOwed = new System.Windows.Forms.Button();
            this.btnTotalAmountOwed = new System.Windows.Forms.Button();
            this.btnGetCustomerByIndex = new System.Windows.Forms.Button();
            this.lblQueue = new System.Windows.Forms.ListBox();
            this.lblHighestAmountOwed = new System.Windows.Forms.ListBox();
            this.lblTotalAmountOwed = new System.Windows.Forms.ListBox();
            this.txtCustomerIndex = new System.Windows.Forms.TextBox();
            this.lblCustomerAtIndex = new System.Windows.Forms.ListBox();
            this.btnTotalCustomer = new System.Windows.Forms.Button();
            this.lbDequeue = new System.Windows.Forms.ListBox();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.lblTotalCustomers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 26);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount Owed:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(120, 68);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(180, 26);
            this.txtAge.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 111);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 26);
            this.txtAddress.TabIndex = 6;
            // 
            // txtAmountOwed
            // 
            this.txtAmountOwed.Location = new System.Drawing.Point(120, 153);
            this.txtAmountOwed.Name = "txtAmountOwed";
            this.txtAmountOwed.Size = new System.Drawing.Size(180, 26);
            this.txtAmountOwed.TabIndex = 7;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(323, 94);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(174, 37);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDisplayQueue
            // 
            this.btnDisplayQueue.Location = new System.Drawing.Point(477, 310);
            this.btnDisplayQueue.Name = "btnDisplayQueue";
            this.btnDisplayQueue.Size = new System.Drawing.Size(185, 31);
            this.btnDisplayQueue.TabIndex = 9;
            this.btnDisplayQueue.Text = "Display Queue";
            this.btnDisplayQueue.UseVisualStyleBackColor = true;
            this.btnDisplayQueue.Click += new System.EventHandler(this.btnDisplayQueue_Click);
            // 
            // btnHighestAmountOwed
            // 
            this.btnHighestAmountOwed.Location = new System.Drawing.Point(82, 425);
            this.btnHighestAmountOwed.Name = "btnHighestAmountOwed";
            this.btnHighestAmountOwed.Size = new System.Drawing.Size(185, 35);
            this.btnHighestAmountOwed.TabIndex = 10;
            this.btnHighestAmountOwed.Text = "Highest Amount Owed";
            this.btnHighestAmountOwed.UseVisualStyleBackColor = true;
            this.btnHighestAmountOwed.Click += new System.EventHandler(this.btnHighestAmountOwed_Click);
            // 
            // btnTotalAmountOwed
            // 
            this.btnTotalAmountOwed.Location = new System.Drawing.Point(82, 577);
            this.btnTotalAmountOwed.Name = "btnTotalAmountOwed";
            this.btnTotalAmountOwed.Size = new System.Drawing.Size(185, 36);
            this.btnTotalAmountOwed.TabIndex = 11;
            this.btnTotalAmountOwed.Text = "Total Amount Owed";
            this.btnTotalAmountOwed.UseVisualStyleBackColor = true;
            this.btnTotalAmountOwed.Click += new System.EventHandler(this.btnTotalAmountOwed_Click);
            // 
            // btnGetCustomerByIndex
            // 
            this.btnGetCustomerByIndex.Location = new System.Drawing.Point(142, 732);
            this.btnGetCustomerByIndex.Name = "btnGetCustomerByIndex";
            this.btnGetCustomerByIndex.Size = new System.Drawing.Size(185, 33);
            this.btnGetCustomerByIndex.TabIndex = 12;
            this.btnGetCustomerByIndex.Text = "Get Customer By Index";
            this.btnGetCustomerByIndex.UseVisualStyleBackColor = true;
            this.btnGetCustomerByIndex.Click += new System.EventHandler(this.btnGetCustomerByIndex_Click);
            // 
            // lblQueue
            // 
            this.lblQueue.FormattingEnabled = true;
            this.lblQueue.ItemHeight = 20;
            this.lblQueue.Location = new System.Drawing.Point(345, 347);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(438, 564);
            this.lblQueue.TabIndex = 13;
            this.lblQueue.SelectedIndexChanged += new System.EventHandler(this.lblQueue_SelectedIndexChanged);
            // 
            // lblHighestAmountOwed
            // 
            this.lblHighestAmountOwed.FormattingEnabled = true;
            this.lblHighestAmountOwed.ItemHeight = 20;
            this.lblHighestAmountOwed.Location = new System.Drawing.Point(30, 466);
            this.lblHighestAmountOwed.Name = "lblHighestAmountOwed";
            this.lblHighestAmountOwed.Size = new System.Drawing.Size(297, 84);
            this.lblHighestAmountOwed.TabIndex = 14;
            this.lblHighestAmountOwed.SelectedIndexChanged += new System.EventHandler(this.btnHighestAmountOwed_Click);
            // 
            // lblTotalAmountOwed
            // 
            this.lblTotalAmountOwed.FormattingEnabled = true;
            this.lblTotalAmountOwed.ItemHeight = 20;
            this.lblTotalAmountOwed.Location = new System.Drawing.Point(30, 619);
            this.lblTotalAmountOwed.Name = "lblTotalAmountOwed";
            this.lblTotalAmountOwed.Size = new System.Drawing.Size(297, 84);
            this.lblTotalAmountOwed.TabIndex = 15;
            // 
            // txtCustomerIndex
            // 
            this.txtCustomerIndex.Location = new System.Drawing.Point(30, 735);
            this.txtCustomerIndex.Name = "txtCustomerIndex";
            this.txtCustomerIndex.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerIndex.TabIndex = 16;
            this.txtCustomerIndex.TextChanged += new System.EventHandler(this.btnGetCustomerByIndex_Click);
            // 
            // lblCustomerAtIndex
            // 
            this.lblCustomerAtIndex.FormattingEnabled = true;
            this.lblCustomerAtIndex.ItemHeight = 20;
            this.lblCustomerAtIndex.Location = new System.Drawing.Point(30, 771);
            this.lblCustomerAtIndex.Name = "lblCustomerAtIndex";
            this.lblCustomerAtIndex.Size = new System.Drawing.Size(297, 104);
            this.lblCustomerAtIndex.TabIndex = 17;
            // 
            // btnTotalCustomer
            // 
            this.btnTotalCustomer.Location = new System.Drawing.Point(30, 200);
            this.btnTotalCustomer.Name = "btnTotalCustomer";
            this.btnTotalCustomer.Size = new System.Drawing.Size(156, 30);
            this.btnTotalCustomer.TabIndex = 18;
            this.btnTotalCustomer.Text = "Total Customers";
            this.btnTotalCustomer.UseVisualStyleBackColor = true;
            this.btnTotalCustomer.Click += new System.EventHandler(this.btnDisplayTotalCustomers_Click);
            // 
            // lbDequeue
            // 
            this.lbDequeue.FormattingEnabled = true;
            this.lbDequeue.ItemHeight = 20;
            this.lbDequeue.Location = new System.Drawing.Point(30, 317);
            this.lbDequeue.Name = "lbDequeue";
            this.lbDequeue.Size = new System.Drawing.Size(297, 84);
            this.lbDequeue.TabIndex = 21;
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(82, 276);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(185, 35);
            this.btnDequeue.TabIndex = 20;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeueCustomer_Click);
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.HideSelection = false;
            this.lblTotalCustomers.Location = new System.Drawing.Point(206, 200);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(456, 57);
            this.lblTotalCustomers.TabIndex = 22;
            this.lblTotalCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 977);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.lbDequeue);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnTotalCustomer);
            this.Controls.Add(this.lblCustomerAtIndex);
            this.Controls.Add(this.txtCustomerIndex);
            this.Controls.Add(this.lblTotalAmountOwed);
            this.Controls.Add(this.lblHighestAmountOwed);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.btnGetCustomerByIndex);
            this.Controls.Add(this.btnTotalAmountOwed);
            this.Controls.Add(this.btnHighestAmountOwed);
            this.Controls.Add(this.btnDisplayQueue);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtAmountOwed);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAmountOwed;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDisplayQueue;
        private System.Windows.Forms.Button btnHighestAmountOwed;
        private System.Windows.Forms.Button btnTotalAmountOwed;
        private System.Windows.Forms.Button btnGetCustomerByIndex;
        private System.Windows.Forms.ListBox lblQueue;
        private System.Windows.Forms.ListBox lblHighestAmountOwed;
        private System.Windows.Forms.ListBox lblTotalAmountOwed;
        private System.Windows.Forms.TextBox txtCustomerIndex;
        private System.Windows.Forms.ListBox lblCustomerAtIndex;
        private System.Windows.Forms.Button btnTotalCustomer;
        private System.Windows.Forms.ListBox lbDequeue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.ListView lblTotalCustomers;
    }
}

