namespace SGEmbroidery.Customers
{
    partial class AddCustomer
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
            customerName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            customerOrganization = new TextBox();
            label3 = new Label();
            primaryPhone = new TextBox();
            label4 = new Label();
            customerEmail = new TextBox();
            addCustomerBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            secondaryPhone = new TextBox();
            SuspendLayout();
            // 
            // customerName
            // 
            customerName.Anchor = AnchorStyles.None;
            customerName.Location = new Point(167, 109);
            customerName.Name = "customerName";
            customerName.Size = new Size(282, 23);
            customerName.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 111);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 151);
            label2.Name = "label2";
            label2.Size = new Size(93, 57);
            label2.TabIndex = 3;
            label2.Text = "Organization/\r\nCompany/\r\nInstitution";
            // 
            // customerOrganization
            // 
            customerOrganization.Anchor = AnchorStyles.None;
            customerOrganization.Location = new Point(167, 166);
            customerOrganization.Name = "customerOrganization";
            customerOrganization.Size = new Size(282, 23);
            customerOrganization.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 241);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 5;
            label3.Text = "Primary Phone";
            // 
            // primaryPhone
            // 
            primaryPhone.Anchor = AnchorStyles.None;
            primaryPhone.Location = new Point(167, 239);
            primaryPhone.Name = "primaryPhone";
            primaryPhone.Size = new Size(282, 23);
            primaryPhone.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 362);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // customerEmail
            // 
            customerEmail.Anchor = AnchorStyles.None;
            customerEmail.Location = new Point(167, 360);
            customerEmail.Name = "customerEmail";
            customerEmail.Size = new Size(282, 23);
            customerEmail.TabIndex = 6;
            // 
            // addCustomerBtn
            // 
            addCustomerBtn.Anchor = AnchorStyles.None;
            addCustomerBtn.Location = new Point(399, 405);
            addCustomerBtn.Name = "addCustomerBtn";
            addCustomerBtn.Size = new Size(132, 30);
            addCustomerBtn.TabIndex = 12;
            addCustomerBtn.Text = "Add Customer";
            addCustomerBtn.UseVisualStyleBackColor = true;
            addCustomerBtn.Click += addCustomerBtn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(141, 30);
            label5.Name = "label5";
            label5.Size = new Size(319, 39);
            label5.TabIndex = 13;
            label5.Text = "Add Customer Details";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 303);
            label6.Name = "label6";
            label6.Size = new Size(115, 19);
            label6.TabIndex = 15;
            label6.Text = "Secondary Phone";
            // 
            // secondaryPhone
            // 
            secondaryPhone.Anchor = AnchorStyles.None;
            secondaryPhone.Location = new Point(167, 301);
            secondaryPhone.Name = "secondaryPhone";
            secondaryPhone.Size = new Size(282, 23);
            secondaryPhone.TabIndex = 14;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(566, 461);
            Controls.Add(label6);
            Controls.Add(secondaryPhone);
            Controls.Add(label5);
            Controls.Add(addCustomerBtn);
            Controls.Add(label4);
            Controls.Add(customerEmail);
            Controls.Add(label3);
            Controls.Add(primaryPhone);
            Controls.Add(label2);
            Controls.Add(customerOrganization);
            Controls.Add(label1);
            Controls.Add(customerName);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerName;
        private Label label1;
        private Label label2;
        private TextBox customerOrganization;
        private Label label3;
        private TextBox primaryPhone;
        private Label label4;
        private TextBox customerEmail;
        private Button addCustomerBtn;
        private Label label5;
        private Label label6;
        private TextBox secondaryPhone;
    }
}