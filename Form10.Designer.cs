namespace INVENTORY_MANAGEMENT
{
    partial class Form10
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            orderdetailgrid = new DataGridView();
            VIEW = new Button();
            ADD = new Button();
            ((System.ComponentModel.ISupportInitialize)orderdetailgrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "ORDERDETAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 39);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "OrderDetailID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 75);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "OrderID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 110);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "ProductID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 144);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 176);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "UnitPrice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 207);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Subtotal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(125, 199);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            // 
            // orderdetailgrid
            // 
            orderdetailgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderdetailgrid.Location = new Point(360, 42);
            orderdetailgrid.Name = "orderdetailgrid";
            orderdetailgrid.RowTemplate.Height = 25;
            orderdetailgrid.Size = new Size(377, 246);
            orderdetailgrid.TabIndex = 13;
            // 
            // VIEW
            // 
            VIEW.Location = new Point(496, 9);
            VIEW.Name = "VIEW";
            VIEW.Size = new Size(75, 23);
            VIEW.TabIndex = 14;
            VIEW.Text = "VIEW";
            VIEW.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            ADD.Location = new Point(147, 283);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 15;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ADD);
            Controls.Add(VIEW);
            Controls.Add(orderdetailgrid);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10";
            Text = "Form10";
            Load += Form10_Load;
            ((System.ComponentModel.ISupportInitialize)orderdetailgrid).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView orderdetailgrid;
        private Button VIEW;
        private Button ADD;
    }
}