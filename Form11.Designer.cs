namespace INVENTORY_MANAGEMENT
{
    partial class Form11
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ordid = new TextBox();
            custid = new TextBox();
            orddate = new TextBox();
            totalamount = new TextBox();
            status = new TextBox();
            ordhistgrid = new DataGridView();
            view = new Button();
            ADD = new Button();
            ((System.ComponentModel.ISupportInitialize)ordhistgrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(87, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "ORDERHISTORY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 63);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "OrderID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "CustomerID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 119);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "OrderDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 148);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "TotalAmount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 187);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // ordid
            // 
            ordid.Location = new Point(87, 53);
            ordid.Name = "ordid";
            ordid.Size = new Size(100, 23);
            ordid.TabIndex = 6;
            // 
            // custid
            // 
            custid.Location = new Point(87, 82);
            custid.Name = "custid";
            custid.Size = new Size(100, 23);
            custid.TabIndex = 7;
            // 
            // orddate
            // 
            orddate.Location = new Point(87, 111);
            orddate.Name = "orddate";
            orddate.Size = new Size(100, 23);
            orddate.TabIndex = 8;
            // 
            // totalamount
            // 
            totalamount.Location = new Point(87, 145);
            totalamount.Name = "totalamount";
            totalamount.Size = new Size(100, 23);
            totalamount.TabIndex = 9;
            // 
            // status
            // 
            status.Location = new Point(87, 184);
            status.Name = "status";
            status.Size = new Size(100, 23);
            status.TabIndex = 10;
            // 
            // ordhistgrid
            // 
            ordhistgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordhistgrid.Location = new Point(322, 82);
            ordhistgrid.Name = "ordhistgrid";
            ordhistgrid.RowTemplate.Height = 25;
            ordhistgrid.Size = new Size(416, 203);
            ordhistgrid.TabIndex = 11;
            // 
            // view
            // 
            view.Location = new Point(457, 44);
            view.Name = "view";
            view.Size = new Size(75, 23);
            view.TabIndex = 12;
            view.Text = "view";
            view.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            ADD.Location = new Point(100, 253);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 13;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ADD);
            Controls.Add(view);
            Controls.Add(ordhistgrid);
            Controls.Add(status);
            Controls.Add(totalamount);
            Controls.Add(orddate);
            Controls.Add(custid);
            Controls.Add(ordid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)ordhistgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ordid;
        private TextBox custid;
        private TextBox orddate;
        private TextBox totalamount;
        private TextBox status;
        private DataGridView ordhistgrid;
        private Button view;
        private Button ADD;
    }
}