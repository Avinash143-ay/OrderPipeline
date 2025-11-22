namespace OrderPipeline
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            cmbProduct = new ComboBox();
            chkExpress = new CheckBox();
            btnShipOrder = new Button();
            btnConfirmOrder = new Button();
            lblStatus = new Label();
            txtCustomer = new TextBox();
            numQty = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Laptop", "Mouse", "Keyboard" });
            cmbProduct.Location = new Point(30, 30);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(180, 28);
            cmbProduct.TabIndex = 0;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(220, 30);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.PlaceholderText = "Customer name";
            txtCustomer.Size = new Size(200, 27);
            txtCustomer.TabIndex = 1;
            // 
            // numQty
            // 
            numQty.Location = new Point(220, 70);
            numQty.Minimum = 1;
            numQty.Maximum = 1000;
            numQty.Value = 1;
            numQty.Name = "numQty";
            numQty.Size = new Size(80, 27);
            numQty.TabIndex = 2;
            // 
            // chkExpress
            // 
            chkExpress.AutoSize = true;
            chkExpress.Location = new Point(30, 70);
            chkExpress.Name = "chkExpress";
            chkExpress.Size = new Size(132, 24);
            chkExpress.TabIndex = 3;
            chkExpress.Text = "Express Delivery";
            chkExpress.UseVisualStyleBackColor = true;
            // 
            // btnShipOrder
            // 
            btnShipOrder.Location = new Point(30, 110);
            btnShipOrder.Name = "btnShipOrder";
            btnShipOrder.Size = new Size(120, 30);
            btnShipOrder.TabIndex = 4;
            btnShipOrder.Text = "Ship Order";
            btnShipOrder.UseVisualStyleBackColor = true;
            btnShipOrder.Click += btnShipOrder_Click;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Location = new Point(160, 110);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(120, 30);
            btnConfirmOrder.TabIndex = 5;
            btnConfirmOrder.Text = "Confirm Order";
            btnConfirmOrder.UseVisualStyleBackColor = true;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 155);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 220);
            Controls.Add(lblStatus);
            Controls.Add(btnConfirmOrder);
            Controls.Add(btnShipOrder);
            Controls.Add(numQty);
            Controls.Add(txtCustomer);
            Controls.Add(chkExpress);
            Controls.Add(cmbProduct);
            Name = "Form2";
            Text = "Shipping Console";
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduct;
        private CheckBox chkExpress;
        private Button btnShipOrder;
        private Button btnConfirmOrder;
        private Label lblStatus;
        private TextBox txtCustomer;
        private NumericUpDown numQty;
    }
}
