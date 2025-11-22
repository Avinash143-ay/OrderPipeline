using System;
using System.Windows.Forms;

namespace OrderPipeline
{
    public partial class Form1 : Form
    {
        // Events
        public event EventHandler<OrderEventArgs> OrderCreated;
        public event EventHandler OrderRejected;
        public event EventHandler<OrderEventArgs> OrderConfirmed;

        // State used in lab task 2
        private bool orderConfirmed = false;

        public Form1()
        {
            InitializeComponent();

            // Subscribe events
            OrderCreated += ValidateOrder;
            OrderCreated += DisplayOrderInfo;

            OrderRejected += ShowRejection;
            OrderConfirmed += ShowConfirmation;
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            var args = new OrderEventArgs(
                txtCustomer.Text,
                cmbProduct.SelectedItem?.ToString(),
                (int)numQty.Value
            );

            OrderCreated?.Invoke(this, args);
        }

        private void ValidateOrder(object sender, OrderEventArgs e)
        {
            if (e.Quantity <= 0)
            {
                lblStatus.Text = "Invalid Quantity!";
                OrderRejected?.Invoke(this, EventArgs.Empty);
                return;
            }

            lblStatus.Text = "Validated";

            // Chain next event
            OrderConfirmed?.Invoke(this, e);
        }

        private void DisplayOrderInfo(object sender, OrderEventArgs e)
        {
            MessageBox.Show(
                $"Customer: {e.Customer}\nProduct: {e.Product}\nQty: {e.Quantity}",
                "Order Summary"
            );
        }

        private void ShowRejection(object sender, EventArgs e)
        {
            lblStatus.Text = "Order Invalid – Please retry";
        }

        private void ShowConfirmation(object sender, OrderEventArgs e)
        {
            lblStatus.Text = $"Order Processed Successfully for {e.Customer}";
            orderConfirmed = true;   // used in Task 2
        }

        // Designer generated handlers kept to satisfy designer references
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            // Clear any previous status when customer name changes
            lblStatus.Text = string.Empty;
        }
    }

    public class OrderEventArgs : EventArgs
    {
        public string Customer { get; }
        public string Product { get; }
        public int Quantity { get; }

        public OrderEventArgs(string cust, string prod, int qty)
        {
            Customer = cust;
            Product = prod;
            Quantity = qty;
        }
    }

    public class ShipEventArgs : EventArgs
    {
        public string Product { get; }
        public bool Express { get; }

        // Added so Form2 can attach customer and quantity via object initializer
        public string Customer { get; set; } = string.Empty;
        public int Quantity { get; set; }

        public ShipEventArgs(string p, bool ex)
            => (Product, Express) = (p, ex);
    }
}
