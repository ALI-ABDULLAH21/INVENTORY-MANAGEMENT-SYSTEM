namespace INVENTORY_MANAGEMENT
{
    partial class Form6
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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            prdid = new TextBox();
            prdname = new TextBox();
            descp = new TextBox();
            cid = new TextBox();
            unitp = new TextBox();
            stockqty = new TextBox();
            recorder = new TextBox();
            suppid = new TextBox();
            date = new TextBox();
            prdgrid = new DataGridView();
            view = new Button();
            ADD = new Button();
            DELETEBOX = new TextBox();
            label11 = new Label();
            label12 = new Label();
            DELETEBUTT = new Button();
            ((System.ComponentModel.ISupportInitialize)prdgrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 8);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "ProductID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "ProductName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 91);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 120);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "CategoryID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 148);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "UnitPrice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 173);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 6;
            label7.Text = "StockQuantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 198);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 7;
            label8.Text = "RecorderLevel";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 229);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 8;
            label9.Text = "SupllierID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 257);
            label10.Name = "label10";
            label10.Size = new Size(66, 15);
            label10.TabIndex = 9;
            label10.Text = "DateAdded";
            // 
            // prdid
            // 
            prdid.Location = new Point(134, 26);
            prdid.Name = "prdid";
            prdid.Size = new Size(100, 23);
            prdid.TabIndex = 10;
            // 
            // prdname
            // 
            prdname.Location = new Point(134, 55);
            prdname.Name = "prdname";
            prdname.Size = new Size(100, 23);
            prdname.TabIndex = 11;
            // 
            // descp
            // 
            descp.Location = new Point(134, 84);
            descp.Name = "descp";
            descp.Size = new Size(100, 23);
            descp.TabIndex = 12;
            // 
            // cid
            // 
            cid.Location = new Point(134, 113);
            cid.Name = "cid";
            cid.Size = new Size(100, 23);
            cid.TabIndex = 13;
            // 
            // unitp
            // 
            unitp.Location = new Point(134, 142);
            unitp.Name = "unitp";
            unitp.Size = new Size(100, 23);
            unitp.TabIndex = 14;
            // 
            // stockqty
            // 
            stockqty.Location = new Point(134, 171);
            stockqty.Name = "stockqty";
            stockqty.Size = new Size(100, 23);
            stockqty.TabIndex = 15;
            // 
            // recorder
            // 
            recorder.Location = new Point(134, 200);
            recorder.Name = "recorder";
            recorder.Size = new Size(100, 23);
            recorder.TabIndex = 16;
            // 
            // suppid
            // 
            suppid.Location = new Point(134, 229);
            suppid.Name = "suppid";
            suppid.Size = new Size(100, 23);
            suppid.TabIndex = 17;
            // 
            // date
            // 
            date.Location = new Point(134, 258);
            date.Name = "date";
            date.Size = new Size(100, 23);
            date.TabIndex = 18;
            // 
            // prdgrid
            // 
            prdgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prdgrid.Location = new Point(301, 37);
            prdgrid.Name = "prdgrid";
            prdgrid.RowTemplate.Height = 25;
            prdgrid.Size = new Size(436, 244);
            prdgrid.TabIndex = 19;
            // 
            // view
            // 
            view.Location = new Point(473, 8);
            view.Name = "view";
            view.Size = new Size(75, 23);
            view.TabIndex = 20;
            view.Text = "view";
            view.UseVisualStyleBackColor = true;
            // 
            // ADD
            // 
            ADD.Location = new Point(134, 301);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 21;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // DELETEBOX
            // 
            DELETEBOX.Location = new Point(473, 333);
            DELETEBOX.Name = "DELETEBOX";
            DELETEBOX.Size = new Size(100, 23);
            DELETEBOX.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(501, 303);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 23;
            label11.Text = "Delete";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(403, 336);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 24;
            label12.Text = "ProductID";
            // 
            // DELETEBUTT
            // 
            DELETEBUTT.Location = new Point(484, 378);
            DELETEBUTT.Name = "DELETEBUTT";
            DELETEBUTT.Size = new Size(75, 23);
            DELETEBUTT.TabIndex = 25;
            DELETEBUTT.Text = "ENTER";
            DELETEBUTT.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(DELETEBUTT);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(DELETEBOX);
            Controls.Add(ADD);
            Controls.Add(view);
            Controls.Add(prdgrid);
            Controls.Add(date);
            Controls.Add(suppid);
            Controls.Add(recorder);
            Controls.Add(stockqty);
            Controls.Add(unitp);
            Controls.Add(cid);
            Controls.Add(descp);
            Controls.Add(prdname);
            Controls.Add(prdid);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)prdgrid).EndInit();
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
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox prdid;
        private TextBox prdname;
        private TextBox descp;
        private TextBox cid;
        private TextBox unitp;
        private TextBox stockqty;
        private TextBox recorder;
        private TextBox suppid;
        private TextBox date;
        private DataGridView prdgrid;
        private Button view;
        private Button ADD;
        private TextBox DELETEBOX;
        private Label label11;
        private Label label12;
        private Button DELETEBUTT;
    }
}