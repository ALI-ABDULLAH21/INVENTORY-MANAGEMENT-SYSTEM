namespace INVENTORY_MANAGEMENT
{
    partial class Form12
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
            label7 = new Label();
            orddetail = new TextBox();
            ordid = new TextBox();
            prdid = new TextBox();
            quantity = new TextBox();
            unitprice = new TextBox();
            subtotal = new TextBox();
            ORDHISTDETAILGRID = new DataGridView();
            VIEW = new Button();
            ADD = new Button();
            ((System.ComponentModel.ISupportInitialize)ORDHISTDETAILGRID).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 13);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "ORDERDETAILHISTORY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "OrderDetailID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "OrderID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 85);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "ProductID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 150);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "UnitPrice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 202);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Subtotal";
            // 
            // orddetail
            // 
            orddetail.Location = new Point(109, 26);
            orddetail.Name = "orddetail";
            orddetail.Size = new Size(100, 23);
            orddetail.TabIndex = 7;
            // 
            // ordid
            // 
            ordid.Location = new Point(109, 55);
            ordid.Name = "ordid";
            ordid.Size = new Size(100, 23);
            ordid.TabIndex = 8;
            // 
            // prdid
            // 
            prdid.Location = new Point(109, 85);
            prdid.Name = "prdid";
            prdid.Size = new Size(100, 23);
            prdid.TabIndex = 9;
            // 
            // quantity
            // 
            quantity.Location = new Point(108, 114);
            quantity.Name = "quantity";
            quantity.Size = new Size(100, 23);
            quantity.TabIndex = 10;
            // 
            // unitprice
            // 
            unitprice.Location = new Point(108, 150);
            unitprice.Name = "unitprice";
            unitprice.Size = new Size(100, 23);
            unitprice.TabIndex = 11;
            // 
            // subtotal
            // 
            subtotal.Location = new Point(108, 202);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(100, 23);
            subtotal.TabIndex = 12;
            // 
            // ORDHISTDETAILGRID
            // 
            ORDHISTDETAILGRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ORDHISTDETAILGRID.Location = new Point(341, 58);
            ORDHISTDETAILGRID.Name = "ORDHISTDETAILGRID";
            ORDHISTDETAILGRID.RowTemplate.Height = 25;
            ORDHISTDETAILGRID.Size = new Size(407, 225);
            ORDHISTDETAILGRID.TabIndex = 13;
            // 
            // VIEW
            // 
            VIEW.Location = new Point(134, 253);
            VIEW.Name = "VIEW";
            VIEW.Size = new Size(75, 23);
            VIEW.TabIndex = 14;
            VIEW.Text = "VIEW";
            VIEW.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            ADD.Location = new Point(32, 253);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 15;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ADD);
            Controls.Add(VIEW);
            Controls.Add(ORDHISTDETAILGRID);
            Controls.Add(subtotal);
            Controls.Add(unitprice);
            Controls.Add(quantity);
            Controls.Add(prdid);
            Controls.Add(ordid);
            Controls.Add(orddetail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)ORDHISTDETAILGRID).EndInit();
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
        private Label label7;
        private TextBox orddetail;
        private TextBox ordid;
        private TextBox prdid;
        private TextBox quantity;
        private TextBox unitprice;
        private TextBox subtotal;
        private DataGridView ORDHISTDETAILGRID;
        private Button VIEW;
        private Button ADD;
    }
}