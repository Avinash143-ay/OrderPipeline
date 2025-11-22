namespace OrderPipeline
{
    partial class Form1
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnProcessOrder = new Button();
            checkBox1 = new CheckBox();
            numQty = new NumericUpDown();
            txtCustomer = new TextBox();
            cmbProduct = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(329, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 0;
            lblStatus.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 103);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Product";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 54);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 148);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            label4.Click += label4_Click;
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.Location = new Point(424, 194);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(120, 29);
            btnProcessOrder.TabIndex = 4;
            btnProcessOrder.Text = "Process Order";
            btnProcessOrder.UseVisualStyleBackColor = true;
            btnProcessOrder.Click += btnProcessOrder_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(424, 253);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // numQty
            // 
            numQty.Location = new Point(424, 141);
            numQty.Name = "numQty";
            numQty.Size = new Size(150, 27);
            numQty.TabIndex = 6;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(437, 54);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(125, 27);
            txtCustomer.TabIndex = 8;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Laptop", "Mouse", "Keyboard" });
            cmbProduct.Location = new Point(424, 95);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(151, 28);
            cmbProduct.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbProduct);
            Controls.Add(txtCustomer);
            Controls.Add(numQty);
            Controls.Add(checkBox1);
            Controls.Add(btnProcessOrder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Name = "Form1";
            Text = "Order Pipeline";
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnProcessOrder;
        private CheckBox checkBox1;
        private NumericUpDown numQty;
        private TextBox txtCustomer;
        private ComboBox cmbProduct;
    }
}
