namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            password = new TextBox();
            Login = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 26);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(402, 45);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO LOGIN PAGE";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 100);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 148);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // username
            // 
            username.Location = new Point(250, 108);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(254, 31);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(250, 156);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(254, 31);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            // 
            // Login
            // 
            Login.BackColor = Color.LimeGreen;
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.ButtonHighlight;
            Login.Location = new Point(392, 217);
            Login.Name = "Login";
            Login.Size = new Size(112, 34);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Red;
            Cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.ForeColor = SystemColors.ControlLight;
            Cancel.Location = new Point(263, 217);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(112, 34);
            Cancel.TabIndex = 6;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(770, 435);
            Controls.Add(Cancel);
            Controls.Add(Login);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "LoginScreen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private Button Login;
        private Button Cancel;
    }
}
