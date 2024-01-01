namespace INVENTORY_MANAGEMENT
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            Login = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 89);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 170);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Username
            // 
            Username.Location = new Point(386, 89);
            Username.Name = "Username";
            Username.Size = new Size(100, 23);
            Username.TabIndex = 2;
            // 
            // Password
            // 
            Password.Location = new Point(386, 167);
            Password.Name = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 3;
            // 
            // Login
            // 
            Login.BackColor = SystemColors.HotTrack;
            Login.Location = new Point(301, 236);
            Login.Name = "Login";
            Login.Size = new Size(91, 30);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HotTrack;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(233, 21);
            label3.Name = "label3";
            label3.Size = new Size(311, 25);
            label3.TabIndex = 5;
            label3.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Inventory_Management_c;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 450);
            Controls.Add(label3);
            Controls.Add(Login);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Username;
        private TextBox Password;
        private Button Login;
        private Label label3;
    }
}
