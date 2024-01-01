namespace INVENTORY_MANAGEMENT
{
    partial class Form2
    {
        private Button Customer;
        private Button Supplier;
        private Button StockTransaction;
        private Button Product;
        private Button Order;
        private Button OrderDetail;
        private Button OrderHistory;
        private Button OrderDetailHistory;

        private void InitializeComponent()
        {
            Customer = new Button();
            Supplier = new Button();
            StockTransaction = new Button();
            Product = new Button();
            Order = new Button();
            OrderDetail = new Button();
            OrderHistory = new Button();
            OrderDetailHistory = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Customer
            // 
            Customer.Location = new Point(365, 90);
            Customer.Name = "Customer";
            Customer.Size = new Size(109, 23);
            Customer.TabIndex = 5;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = true;
            Customer.Click += Customer_Click;
            // 
            // Supplier
            // 
            Supplier.Location = new Point(500, 90);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(127, 23);
            Supplier.TabIndex = 6;
            Supplier.Text = "Supplier";
            Supplier.UseVisualStyleBackColor = true;
            Supplier.Click += Supplier_Click;
            // 
            // StockTransaction
            // 
            StockTransaction.Location = new Point(500, 142);
            StockTransaction.Name = "StockTransaction";
            StockTransaction.Size = new Size(127, 23);
            StockTransaction.TabIndex = 7;
            StockTransaction.Text = "Stock Transaction";
            StockTransaction.UseVisualStyleBackColor = true;
            StockTransaction.Click += StockTransaction_Click;
            // 
            // Product
            // 
            Product.Location = new Point(365, 142);
            Product.Name = "Product";
            Product.Size = new Size(109, 23);
            Product.TabIndex = 8;
            Product.Text = "Product";
            Product.UseVisualStyleBackColor = true;
            Product.Click += Product_Click;
            // 
            // Order
            // 
            Order.Location = new Point(365, 191);
            Order.Name = "Order";
            Order.Size = new Size(109, 23);
            Order.TabIndex = 9;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = true;
            Order.Click += Order_Click;
            // 
            // OrderDetail
            // 
            OrderDetail.Location = new Point(500, 191);
            OrderDetail.Name = "OrderDetail";
            OrderDetail.Size = new Size(127, 23);
            OrderDetail.TabIndex = 10;
            OrderDetail.Text = "OrderDetail";
            OrderDetail.UseVisualStyleBackColor = true;
            OrderDetail.Click += OrderDetail_Click;
            // 
            // OrderHistory
            // 
            OrderHistory.Location = new Point(365, 242);
            OrderHistory.Name = "OrderHistory";
            OrderHistory.Size = new Size(109, 23);
            OrderHistory.TabIndex = 11;
            OrderHistory.Text = "OrderHistory";
            OrderHistory.UseVisualStyleBackColor = true;
            OrderHistory.Click += OrderHistory_Click;
            // 
            // OrderDetailHistory
            // 
            OrderDetailHistory.Location = new Point(500, 242);
            OrderDetailHistory.Name = "OrderDetailHistory";
            OrderDetailHistory.Size = new Size(127, 23);
            OrderDetailHistory.TabIndex = 12;
            OrderDetailHistory.Text = "OrderDetailHistory";
            OrderDetailHistory.UseVisualStyleBackColor = true;
            OrderDetailHistory.Click += OrderDetailHistory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(365, 24);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 13;
            label1.Text = "WELCOME TO ADMIN PORTAL";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 333);
            Controls.Add(label1);
            Controls.Add(OrderDetailHistory);
            Controls.Add(OrderHistory);
            Controls.Add(OrderDetail);
            Controls.Add(Order);
            Controls.Add(Product);
            Controls.Add(StockTransaction);
            Controls.Add(Supplier);
            Controls.Add(Customer);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            // Create an instance of Form5 and show it
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            // Create an instance of Form7 and show it
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void StockTransaction_Click(object sender, EventArgs e)
        {
            // Create an instance of Form8 and show it
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void Product_Click(object sender, EventArgs e)
        {
            // Create an instance of Form6 and show it
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            // Create an instance of Form9 and show it
            ADD form9 = new ADD();
            form9.Show();
        }

        private void OrderDetail_Click(object sender, EventArgs e)
        {
            // Create an instance of Form10 and show it
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void OrderHistory_Click(object sender, EventArgs e)
        {
            // Create an instance of Form11 and show it
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void OrderDetailHistory_Click(object sender, EventArgs e)
        {
            // Create an instance of Form12 and show it
            Form12 form12 = new Form12();
            form12.Show();
        }

        private Label label1;
    }
}
