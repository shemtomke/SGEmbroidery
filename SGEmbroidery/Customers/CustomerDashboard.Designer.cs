namespace SGEmbroidery.Customers
{
    partial class CustomerDashboard
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
            customersLbl = new Label();
            numberOfCustomers = new Label();
            customerDataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customerDataView).BeginInit();
            SuspendLayout();
            // 
            // customersLbl
            // 
            customersLbl.Anchor = AnchorStyles.None;
            customersLbl.AutoSize = true;
            customersLbl.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            customersLbl.Location = new Point(19, 28);
            customersLbl.Name = "customersLbl";
            customersLbl.Size = new Size(126, 22);
            customersLbl.TabIndex = 3;
            customersLbl.Text = "CUSTOMERS";
            // 
            // numberOfCustomers
            // 
            numberOfCustomers.Anchor = AnchorStyles.None;
            numberOfCustomers.AutoSize = true;
            numberOfCustomers.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numberOfCustomers.Location = new Point(151, 28);
            numberOfCustomers.Name = "numberOfCustomers";
            numberOfCustomers.Size = new Size(30, 22);
            numberOfCustomers.TabIndex = 4;
            numberOfCustomers.Text = "00";
            numberOfCustomers.Click += numberOfCustomers_Click;
            // 
            // customerDataView
            // 
            customerDataView.Anchor = AnchorStyles.None;
            customerDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataView.Location = new Point(19, 67);
            customerDataView.Name = "customerDataView";
            customerDataView.RowTemplate.Height = 25;
            customerDataView.Size = new Size(535, 359);
            customerDataView.TabIndex = 5;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 461);
            Controls.Add(customerDataView);
            Controls.Add(numberOfCustomers);
            Controls.Add(customersLbl);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "CustomerDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerDashboard";
            ((System.ComponentModel.ISupportInitialize)customerDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label customersLbl;
        private Label numberOfCustomers;
        private DataGridView customerDataView;
    }
}