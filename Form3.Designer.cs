using System;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT
{
    partial class Form3
    {
        private Button Product;
        private Button Order;
        private Button OrderDetail;
        private Button OrderHistory;
        private Button OrderDetailHistory;

        private void InitializeComponent()
        {
            Product = new Button();
            Order = new Button();
            OrderDetail = new Button();
            OrderHistory = new Button();
            OrderDetailHistory = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Product
            // 
            Product.Location = new Point(303, 86);
            Product.Name = "Product";
            Product.Size = new Size(87, 23);
            Product.TabIndex = 0;
            Product.Text = "Product";
            Product.UseVisualStyleBackColor = true;
            Product.Click += Product_Click;
            // 
            // Order
            // 
            Order.Location = new Point(465, 86);
            Order.Name = "Order";
            Order.Size = new Size(109, 23);
            Order.TabIndex = 1;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = true;
            Order.Click += Order_Click;
            // 
            // OrderDetail
            // 
            OrderDetail.Location = new Point(303, 151);
            OrderDetail.Name = "OrderDetail";
            OrderDetail.Size = new Size(87, 23);
            OrderDetail.TabIndex = 2;
            OrderDetail.Text = "OrderDetail";
            OrderDetail.UseVisualStyleBackColor = true;
            OrderDetail.Click += Orderdetail_Click;
            // 
            // OrderHistory
            // 
            OrderHistory.Location = new Point(465, 151);
            OrderHistory.Name = "OrderHistory";
            OrderHistory.Size = new Size(109, 23);
            OrderHistory.TabIndex = 3;
            OrderHistory.Text = "OrderHistory";
            OrderHistory.UseVisualStyleBackColor = true;
            OrderHistory.Click += OrderHistory_Click;
            // 
            // OrderDetailHistory
            // 
            OrderDetailHistory.Location = new Point(390, 220);
            OrderDetailHistory.Name = "OrderDetailHistory";
            OrderDetailHistory.Size = new Size(75, 23);
            OrderDetailHistory.TabIndex = 4;
            OrderDetailHistory.Text = "OrderDetailHistory";
            OrderDetailHistory.UseVisualStyleBackColor = true;
            OrderDetailHistory.Click += OrderDetailHistory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(303, 22);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 5;
            label1.Text = "WELCOME TO EMPLOYEE PORTAL";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(OrderDetailHistory);
            Controls.Add(OrderHistory);
            Controls.Add(OrderDetail);
            Controls.Add(Order);
            Controls.Add(Product);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
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

        private void Orderdetail_Click(object sender, EventArgs e)
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
