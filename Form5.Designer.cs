namespace INVENTORY_MANAGEMENT
{
    partial class Form5
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
            label1 = new Label();
            CustomerID = new Label();
            CustomerName = new Label();
            CustomerNumber = new Label();
            Email = new Label();
            Address = new Label();
            custid = new TextBox();
            custname = new TextBox();
            custnum = new TextBox();
            custemail = new TextBox();
            custaddress = new TextBox();
            custgrid = new DataGridView();
            view = new Button();
            ADD = new Button();
            ((System.ComponentModel.ISupportInitialize)custgrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Location = new Point(25, 54);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(70, 15);
            CustomerID.TabIndex = 1;
            CustomerID.Text = "CustomerID";
            // 
            // CustomerName
            // 
            CustomerName.AutoSize = true;
            CustomerName.Location = new Point(25, 109);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(91, 15);
            CustomerName.TabIndex = 2;
            CustomerName.Text = "CustomerName";
            // 
            // CustomerNumber
            // 
            CustomerNumber.AutoSize = true;
            CustomerNumber.Location = new Point(25, 166);
            CustomerNumber.Name = "CustomerNumber";
            CustomerNumber.Size = new Size(103, 15);
            CustomerNumber.TabIndex = 3;
            CustomerNumber.Text = "CustomerNumber";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(25, 218);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(25, 261);
            Address.Name = "Address";
            Address.Size = new Size(49, 15);
            Address.TabIndex = 5;
            Address.Text = "Address";
            // 
            // custid
            // 
            custid.Location = new Point(163, 52);
            custid.Name = "custid";
            custid.Size = new Size(100, 23);
            custid.TabIndex = 6;
            // 
            // custname
            // 
            custname.Location = new Point(163, 109);
            custname.Name = "custname";
            custname.Size = new Size(100, 23);
            custname.TabIndex = 7;
            // 
            // custnum
            // 
            custnum.Location = new Point(163, 166);
            custnum.Name = "custnum";
            custnum.Size = new Size(100, 23);
            custnum.TabIndex = 8;
            // 
            // custemail
            // 
            custemail.Location = new Point(163, 218);
            custemail.Name = "custemail";
            custemail.Size = new Size(100, 23);
            custemail.TabIndex = 9;
            // 
            // custaddress
            // 
            custaddress.Location = new Point(163, 261);
            custaddress.Name = "custaddress";
            custaddress.Size = new Size(100, 23);
            custaddress.TabIndex = 10;
            // 
            // custgrid
            // 
            custgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custgrid.Location = new Point(352, 42);
            custgrid.Name = "custgrid";
            custgrid.RowTemplate.Height = 25;
            custgrid.Size = new Size(402, 230);
            custgrid.TabIndex = 11;
            // 
            // view
            // 
            view.Location = new Point(427, 12);
            view.Name = "view";
            view.Size = new Size(75, 23);
            view.TabIndex = 12;
            view.Text = "view";
            view.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            ADD.Location = new Point(172, 315);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 13;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ADD);
            Controls.Add(view);
            Controls.Add(custgrid);
            Controls.Add(custaddress);
            Controls.Add(custemail);
            Controls.Add(custnum);
            Controls.Add(custname);
            Controls.Add(custid);
            Controls.Add(Address);
            Controls.Add(Email);
            Controls.Add(CustomerNumber);
            Controls.Add(CustomerName);
            Controls.Add(CustomerID);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)custgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CustomerID;
        private Label CustomerName;
        private Label CustomerNumber;
        private Label Email;
        private Label Address;
        private TextBox custid;
        private TextBox custname;
        private TextBox custnum;
        private TextBox custemail;
        private TextBox custaddress;
        private DataGridView custgrid;
        private Button view;
        private Button ADD;
    }
}