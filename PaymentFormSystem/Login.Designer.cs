namespace PaymentFormSystem
{
    partial class Login
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserDetails = new System.Windows.Forms.Label();
            this.EnterEmailTextBox = new System.Windows.Forms.TextBox();
            this.EnterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(550, 341);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 31);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(926, 481);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(80, 31);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Email or Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOG IN";
            // 
            // UserDetails
            // 
            this.UserDetails.AutoSize = true;
            this.UserDetails.Location = new System.Drawing.Point(865, 526);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(193, 18);
            this.UserDetails.TabIndex = 5;
            this.UserDetails.Text = "Don\'t have an account yet?";
            this.UserDetails.Click += new System.EventHandler(this.UserDetails_Click);
            // 
            // EnterEmailTextBox
            // 
            this.EnterEmailTextBox.Location = new System.Drawing.Point(405, 170);
            this.EnterEmailTextBox.Name = "EnterEmailTextBox";
            this.EnterEmailTextBox.Size = new System.Drawing.Size(292, 26);
            this.EnterEmailTextBox.TabIndex = 6;
            // 
            // EnterPasswordTextBox
            // 
            this.EnterPasswordTextBox.Location = new System.Drawing.Point(405, 254);
            this.EnterPasswordTextBox.Name = "EnterPasswordTextBox";
            this.EnterPasswordTextBox.Size = new System.Drawing.Size(292, 26);
            this.EnterPasswordTextBox.TabIndex = 7;
            this.EnterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.EnterPasswordTextBox);
            this.Controls.Add(this.EnterEmailTextBox);
            this.Controls.Add(this.UserDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UserDetails;
        private System.Windows.Forms.TextBox EnterEmailTextBox;
        private System.Windows.Forms.TextBox EnterPasswordTextBox;
    }
}