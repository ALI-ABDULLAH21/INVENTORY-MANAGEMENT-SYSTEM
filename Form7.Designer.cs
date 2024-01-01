namespace INVENTORY_MANAGEMENT
{
    partial class Form7
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
            SUPPLIER = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            suppid = new TextBox();
            suppname = new TextBox();
            cntchperson = new TextBox();
            cntchnum = new TextBox();
            email = new TextBox();
            address = new TextBox();
            suppgrid = new DataGridView();
            button1 = new Button();
            Add = new Button();
            label1 = new Label();
            label8 = new Label();
            DELETEBOX = new TextBox();
            DELETEBUTT = new Button();
            ((System.ComponentModel.ISupportInitialize)suppgrid).BeginInit();
            SuspendLayout();
            // 
            // SUPPLIER
            // 
            SUPPLIER.AutoSize = true;
            SUPPLIER.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            SUPPLIER.Location = new Point(18, 9);
            SUPPLIER.Name = "SUPPLIER";
            SUPPLIER.Size = new Size(94, 25);
            SUPPLIER.TabIndex = 0;
            SUPPLIER.Text = "SUPPLIER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "SupplierID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "SupplierName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "ContactPerson";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 4;
            label5.Text = "ContactNumber";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 184);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 223);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 6;
            label7.Text = "Address";
            // 
            // suppid
            // 
            suppid.Location = new Point(118, 30);
            suppid.Name = "suppid";
            suppid.Size = new Size(100, 23);
            suppid.TabIndex = 7;
            // 
            // suppname
            // 
            suppname.Location = new Point(118, 72);
            suppname.Name = "suppname";
            suppname.Size = new Size(100, 23);
            suppname.TabIndex = 8;
            // 
            // cntchperson
            // 
            cntchperson.Location = new Point(118, 109);
            cntchperson.Name = "cntchperson";
            cntchperson.Size = new Size(100, 23);
            cntchperson.TabIndex = 9;
            // 
            // cntchnum
            // 
            cntchnum.Location = new Point(118, 143);
            cntchnum.Name = "cntchnum";
            cntchnum.Size = new Size(100, 23);
            cntchnum.TabIndex = 10;
            // 
            // email
            // 
            email.Location = new Point(118, 176);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 11;
            // 
            // address
            // 
            address.Location = new Point(118, 215);
            address.Name = "address";
            address.Size = new Size(100, 23);
            address.TabIndex = 12;
            // 
            // suppgrid
            // 
            suppgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppgrid.Location = new Point(292, 55);
            suppgrid.Name = "suppgrid";
            suppgrid.RowTemplate.Height = 25;
            suppgrid.Size = new Size(453, 214);
            suppgrid.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(447, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "VIEW";
            button1.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(118, 275);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(533, 302);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 16;
            label1.Text = "DELETE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(431, 336);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 17;
            label8.Text = "SUPPLIERID";
            // 
            // DELETEBOX
            // 
            DELETEBOX.Location = new Point(521, 333);
            DELETEBOX.Name = "DELETEBOX";
            DELETEBOX.Size = new Size(100, 23);
            DELETEBOX.TabIndex = 18;
            // 
            // DELETEBUTT
            // 
            DELETEBUTT.Location = new Point(533, 376);
            DELETEBUTT.Name = "DELETEBUTT";
            DELETEBUTT.Size = new Size(75, 23);
            DELETEBUTT.TabIndex = 19;
            DELETEBUTT.Text = "ENTER";
            DELETEBUTT.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(DELETEBUTT);
            Controls.Add(DELETEBOX);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(Add);
            Controls.Add(button1);
            Controls.Add(suppgrid);
            Controls.Add(address);
            Controls.Add(email);
            Controls.Add(cntchnum);
            Controls.Add(cntchperson);
            Controls.Add(suppname);
            Controls.Add(suppid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SUPPLIER);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)suppgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SUPPLIER;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox suppid;
        private TextBox suppname;
        private TextBox cntchperson;
        private TextBox cntchnum;
        private TextBox email;
        private TextBox address;
        private DataGridView suppgrid;
        private Button button1;
        private Button Add;
        private Label label1;
        private Label label8;
        private TextBox DELETEBOX;
        private Button DELETEBUTT;
    }
}