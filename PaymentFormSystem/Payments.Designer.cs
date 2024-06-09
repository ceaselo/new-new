namespace PaymentFormSystem
{
    partial class Payments
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WaterButton = new System.Windows.Forms.Button();
            this.InternetButton = new System.Windows.Forms.Button();
            this.ElectricityButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DefaultLabel = new System.Windows.Forms.Label();
            this.EducationButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name of the user :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Payment Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Electrical";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Internet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Water";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EducationButton);
            this.panel1.Controls.Add(this.WaterButton);
            this.panel1.Controls.Add(this.InternetButton);
            this.panel1.Controls.Add(this.ElectricityButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(9, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 229);
            this.panel1.TabIndex = 27;
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(417, 67);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(128, 72);
            this.WaterButton.TabIndex = 20;
            this.WaterButton.Text = "Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // InternetButton
            // 
            this.InternetButton.Location = new System.Drawing.Point(217, 67);
            this.InternetButton.Name = "InternetButton";
            this.InternetButton.Size = new System.Drawing.Size(128, 72);
            this.InternetButton.TabIndex = 19;
            this.InternetButton.Text = "Internet";
            this.InternetButton.UseVisualStyleBackColor = true;
            this.InternetButton.Click += new System.EventHandler(this.InternetButton_Click);
            // 
            // ElectricityButton
            // 
            this.ElectricityButton.Location = new System.Drawing.Point(19, 67);
            this.ElectricityButton.Name = "ElectricityButton";
            this.ElectricityButton.Size = new System.Drawing.Size(128, 72);
            this.ElectricityButton.TabIndex = 18;
            this.ElectricityButton.Text = "Electricity";
            this.ElectricityButton.UseVisualStyleBackColor = true;
            this.ElectricityButton.Click += new System.EventHandler(this.ElectricityButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Red;
            this.LogoutButton.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(11, 11);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(83, 28);
            this.LogoutButton.TabIndex = 26;
            this.LogoutButton.Text = "LOGOUT";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DefaultLabel
            // 
            this.DefaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultLabel.Location = new System.Drawing.Point(356, 112);
            this.DefaultLabel.Name = "DefaultLabel";
            this.DefaultLabel.Size = new System.Drawing.Size(195, 23);
            this.DefaultLabel.TabIndex = 28;
            this.DefaultLabel.Text = "label3";
            // 
            // EducationButton
            // 
            this.EducationButton.Location = new System.Drawing.Point(617, 67);
            this.EducationButton.Name = "EducationButton";
            this.EducationButton.Size = new System.Drawing.Size(128, 72);
            this.EducationButton.TabIndex = 21;
            this.EducationButton.Text = "Education";
            this.EducationButton.UseVisualStyleBackColor = true;
            this.EducationButton.Click += new System.EventHandler(this.EducationButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(642, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Education";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.DefaultLabel);
            this.Name = "Payments";
            this.Text = "Payments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Button InternetButton;
        private System.Windows.Forms.Button ElectricityButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label DefaultLabel;
        private System.Windows.Forms.Button EducationButton;
        private System.Windows.Forms.Label label7;
    }
}