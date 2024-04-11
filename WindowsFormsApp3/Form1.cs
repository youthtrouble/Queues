using Assessment_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_1
{
    public partial class Form1 : Form
    {
        private CustomerQueue customerQueue;
        public Form1()
        {
            InitializeComponent();
            customerQueue = new CustomerQueue(10); // Assuming max 10 customers for simplicity
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Extract information from text boxes
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text); // Add validation
            string address = txtAddress.Text;
            float amountOwed = float.Parse(txtAmountOwed.Text); // Add validation

            Customer customer = new Customer(name, age, address, amountOwed);
            customerQueue.Enqueue(customer);
            DisplayQueue();
        }

        private void btnDequeueCustomer_Click(object sender, EventArgs e)
        {
            if (customerQueue.Count > 0)
            {
                Customer customer = customerQueue.Dequeue();
                lbDequeue.Items.Clear(); 
                lbDequeue.Items.Add($"Dequeued customer: {customer.GetInformation()}");
                DisplayQueue();
            }
            else
            {
                MessageBox.Show("Queue is empty.");
            }
        }

        private void DisplayQueue()
        {
            lblQueue.Items.Clear();
            lblQueue.Items.Add( "Queue: \n" );
            for (int i = 0; i < customerQueue.Count; i++)
            {
                lblQueue.Items.Add("Index [" + i + "]: " + customerQueue.GetCustomerByIndex(i).GetInformation() + "\n");
            }
        }
        // Event handler for the button to display the total number of customers
        private void btnDisplayTotalCustomers_Click(object sender, EventArgs e)
        {
            UpdateCustomerCount();
        }
        private void UpdateCustomerCount()
        {
            lblTotalCustomers.Items.Clear();
            lblTotalCustomers.Items.Add("Total Customers: " + $"{customerQueue.Count}");
        }

        private void btnDisplayQueue_Click(object sender, EventArgs e)
        {
            lblQueue.Text = "Queue: \n";
            int current = customerQueue.Head;
            for (int i = 0; i < customerQueue.Count; i++)
            {
                lblQueue.Text += customerQueue.GetCustomerByIndex(i).GetInformation() + "\n";
            }
        }

        private void btnHighestAmountOwed_Click(object sender, EventArgs e)
        {
            try
            {
                lblHighestAmountOwed.Items.Clear();
                Customer highestOwingCustomer = customerQueue.GetCustomerWithHighestAmountOwed();
                lblHighestAmountOwed.Items.Add("Customer owing the most: " + highestOwingCustomer.GetInformation());
            }
            catch (InvalidOperationException ex)
            {
                lblHighestAmountOwed.Items.Clear();
                lblHighestAmountOwed.Items.Add(ex.Message);
            }
        }

        private void btnTotalAmountOwed_Click(object sender, EventArgs e)
        {
            lblTotalAmountOwed.Items.Clear();
            float totalAmountOwed = customerQueue.CalculateTotalAmountOwed();
            lblTotalAmountOwed.Items.Add("Total amount owed: " + totalAmountOwed.ToString("C2"));
        }

        private void btnGetCustomerByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                lblCustomerAtIndex.Items.Clear();
                int index = int.Parse(txtCustomerIndex.Text);
                Customer customer = customerQueue.GetCustomerByIndex(index);
                lblCustomerAtIndex.Items.Add("Customer at index " + index + ": " + customer.GetInformation());
            }
            catch (Exception ex)
            {
                lblCustomerAtIndex.Items.Clear();
                lblCustomerAtIndex.Items.Add(ex.Message);
            }
        }

        private void lblQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
