using System;
using System.Windows.Forms;

namespace OrderPipeline
{
    public partial class Form2 : Form
    {
        public event EventHandler<ShipEventArgs>? OrderShipped;
        private bool orderConfirmed = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnConfirmOrder_Click(object? sender, EventArgs e)
        {
            orderConfirmed = true;
            lblStatus.Text = "Order confirmed";
        }

        private void btnShipOrder_Click(object? sender, EventArgs e)
        {
            if (!orderConfirmed)
            {
                MessageBox.Show("Order not confirmed yet!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                MessageBox.Show("Please enter a customer name.");
                return;
            }

            if (cmbProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // Always add ShowDispatch
            OrderShipped += ShowDispatch;

            // Dynamic Filtering: Attach or detach NotifyCourier
            if (chkExpress.Checked)
                OrderShipped += NotifyCourier;
            else
                OrderShipped -= NotifyCourier; // remove before firing

            var product = cmbProduct.SelectedItem.ToString() ?? string.Empty;
            var args = new ShipEventArgs(product, chkExpress.Checked)
            {
                Customer = txtCustomer.Text,
                Quantity = (int)numQty.Value
            };

            OrderShipped?.Invoke(this, args);

            // cleanup for repeated clicks (prevent multiple handlers)
            OrderShipped -= ShowDispatch;
            OrderShipped -= NotifyCourier;
        }

        private void ShowDispatch(object? sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Product dispatched: {e.Product} (Customer: {e.Customer}, Qty: {e.Quantity})";
        }

        private void NotifyCourier(object? sender, ShipEventArgs e)
        {
            if (e.Express)
                MessageBox.Show("Express delivery initiated!");
        }
    }
}
