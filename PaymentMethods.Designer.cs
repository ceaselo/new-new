namespace PaymentFormSystem
{
    partial class PaymentMethod
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
            this.dataGridViewPaymentMethods = new System.Windows.Forms.DataGridView();
            this.PaymentMethodTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PaymentMethodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentMethods)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPaymentMethods
            // 
            this.dataGridViewPaymentMethods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaymentMethods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentMethodId,
            this.MethodName});
            this.dataGridViewPaymentMethods.Location = new System.Drawing.Point(49, 182);
            this.dataGridViewPaymentMethods.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPaymentMethods.Name = "dataGridViewPaymentMethods";
            this.dataGridViewPaymentMethods.Size = new System.Drawing.Size(878, 271);
            this.dataGridViewPaymentMethods.TabIndex = 1;
            // 
            // PaymentMethodTextBox
            // 
            this.PaymentMethodTextBox.Location = new System.Drawing.Point(267, 42);
            this.PaymentMethodTextBox.Name = "PaymentMethodTextBox";
            this.PaymentMethodTextBox.Size = new System.Drawing.Size(274, 26);
            this.PaymentMethodTextBox.TabIndex = 2;
            this.PaymentMethodTextBox.TextChanged += new System.EventHandler(this.PaymentMethodTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payment Method:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(412, 100);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 32);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(292, 100);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(87, 32);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(173, 100);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(87, 32);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PaymentMethodId
            // 
            this.PaymentMethodId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PaymentMethodId.HeaderText = "PaymentMethodId";
            this.PaymentMethodId.Name = "PaymentMethodId";
            // 
            // MethodName
            // 
            this.MethodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MethodName.HeaderText = "MethodName";
            this.MethodName.Name = "MethodName";
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 477);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentMethodTextBox);
            this.Controls.Add(this.dataGridViewPaymentMethods);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentMethod";
            this.Text = "PaymentMethods";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentMethods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPaymentMethods;
        private System.Windows.Forms.TextBox PaymentMethodTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MethodName;
    }
}