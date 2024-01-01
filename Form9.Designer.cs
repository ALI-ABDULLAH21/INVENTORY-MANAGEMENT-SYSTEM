namespace INVENTORY_MANAGEMENT
{
    partial class ADD
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
            ORDER = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ordid = new TextBox();
            custid = new TextBox();
            orderdate = new TextBox();
            suppid = new TextBox();
            total = new TextBox();
            status = new TextBox();
            ORDERGRID = new DataGridView();
            VIEW = new Button();
            ADDO = new Button();
            ((System.ComponentModel.ISupportInitialize)ORDERGRID).BeginInit();
            SuspendLayout();
            // 
            // ORDER
            // 
            ORDER.AutoSize = true;
            ORDER.Location = new Point(81, 18);
            ORDER.Name = "ORDER";
            ORDER.Size = new Size(44, 15);
            ORDER.TabIndex = 0;
            ORDER.Text = "ORDER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "OrderID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "CustomerID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "OrderDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 147);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "SupllierID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 192);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 5;
            label6.Text = "TotalAmount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 224);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // ordid
            // 
            ordid.Location = new Point(123, 57);
            ordid.Name = "ordid";
            ordid.Size = new Size(100, 23);
            ordid.TabIndex = 7;
            // 
            // custid
            // 
            custid.Location = new Point(123, 86);
            custid.Name = "custid";
            custid.Size = new Size(100, 23);
            custid.TabIndex = 8;
            // 
            // orderdate
            // 
            orderdate.Location = new Point(123, 115);
            orderdate.Name = "orderdate";
            orderdate.Size = new Size(100, 23);
            orderdate.TabIndex = 9;
            // 
            // suppid
            // 
            suppid.Location = new Point(123, 144);
            suppid.Name = "suppid";
            suppid.Size = new Size(100, 23);
            suppid.TabIndex = 10;
            // 
            // total
            // 
            total.Location = new Point(123, 184);
            total.Name = "total";
            total.Size = new Size(100, 23);
            total.TabIndex = 11;
            // 
            // status
            // 
            status.Location = new Point(123, 216);
            status.Name = "status";
            status.Size = new Size(100, 23);
            status.TabIndex = 12;
            // 
            // ORDERGRID
            // 
            ORDERGRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ORDERGRID.Location = new Point(308, 57);
            ORDERGRID.Name = "ORDERGRID";
            ORDERGRID.RowTemplate.Height = 25;
            ORDERGRID.Size = new Size(393, 221);
            ORDERGRID.TabIndex = 13;
            // 
            // VIEW
            // 
            VIEW.Location = new Point(436, 17);
            VIEW.Name = "VIEW";
            VIEW.Size = new Size(75, 23);
            VIEW.TabIndex = 14;
            VIEW.Text = "VIEW";
            VIEW.UseVisualStyleBackColor = true;
            // 
            // ADDO
            // 
            ADDO.Location = new Point(122, 281);
            ADDO.Name = "ADDO";
            ADDO.Size = new Size(75, 23);
            ADDO.TabIndex = 15;
            ADDO.Text = "add";
            ADDO.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ADDO);
            Controls.Add(VIEW);
            Controls.Add(ORDERGRID);
            Controls.Add(status);
            Controls.Add(total);
            Controls.Add(suppid);
            Controls.Add(orderdate);
            Controls.Add(custid);
            Controls.Add(ordid);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ORDER);
            Name = "ADD";
            Text = "ADD";
            Load += ADD_Load;
            ((System.ComponentModel.ISupportInitialize)ORDERGRID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ORDER;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ordid;
        private TextBox custid;
        private TextBox orderdate;
        private TextBox suppid;
        private TextBox total;
        private TextBox status;
        private DataGridView ORDERGRID;
        private Button VIEW;
        private Button ADDO;
    }
}