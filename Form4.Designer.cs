namespace INVENTORY_MANAGEMENT
{
    partial class Form4
    {
        private Button Customer;
        private Button Orderdetail;

        private void InitializeComponent()
        {
            Customer = new Button();
            Orderdetail = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Customer
            // 
            Customer.Location = new Point(249, 152);
            Customer.Name = "Customer";
            Customer.Size = new Size(75, 23);
            Customer.TabIndex = 0;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = true;
            Customer.Click += Customer_Click;
            // 
            // Orderdetail
            // 
            Orderdetail.Location = new Point(459, 152);
            Orderdetail.Name = "Orderdetail";
            Orderdetail.Size = new Size(104, 23);
            Orderdetail.TabIndex = 1;
            Orderdetail.Text = "Orderdetail";
            Orderdetail.UseVisualStyleBackColor = true;
            Orderdetail.Click += Orderdetail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(259, 52);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 2;
            label1.Text = "WELCOME T0 CUSTOMER PORTAL";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Orderdetail);
            Controls.Add(Customer);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            // Create an instance of Form5 and show it
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void Orderdetail_Click(object sender, EventArgs e)
        {
            // Create an instance of Form9 and show it
            ADD form9 = new ADD();
            form9.Show();
        }

        private Label label1;
    }
}
