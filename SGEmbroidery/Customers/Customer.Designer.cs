namespace SGEmbroidery
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            sideCustomerPanel = new Panel();
            backButton = new Button();
            button4 = new Button();
            AddCustomerBtn = new Button();
            customerDashboardBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mainPanel = new Panel();
            TopPanel = new Panel();
            searchButton = new Button();
            textSearch = new TextBox();
            sideCustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideCustomerPanel
            // 
            sideCustomerPanel.BackColor = Color.Gold;
            sideCustomerPanel.Controls.Add(backButton);
            sideCustomerPanel.Controls.Add(button4);
            sideCustomerPanel.Controls.Add(AddCustomerBtn);
            sideCustomerPanel.Controls.Add(customerDashboardBtn);
            sideCustomerPanel.Controls.Add(pictureBox1);
            sideCustomerPanel.Controls.Add(label1);
            sideCustomerPanel.Dock = DockStyle.Left;
            sideCustomerPanel.Location = new Point(0, 0);
            sideCustomerPanel.Name = "sideCustomerPanel";
            sideCustomerPanel.Size = new Size(218, 461);
            sideCustomerPanel.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Red;
            backButton.ForeColor = SystemColors.ControlLight;
            backButton.Location = new Point(64, 431);
            backButton.Name = "backButton";
            backButton.Size = new Size(58, 27);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 300);
            button4.Name = "button4";
            button4.Size = new Size(163, 39);
            button4.TabIndex = 4;
            button4.Text = "Update Customer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AddCustomerBtn
            // 
            AddCustomerBtn.Location = new Point(12, 221);
            AddCustomerBtn.Name = "AddCustomerBtn";
            AddCustomerBtn.Size = new Size(163, 39);
            AddCustomerBtn.TabIndex = 2;
            AddCustomerBtn.Text = "Add Customer";
            AddCustomerBtn.UseVisualStyleBackColor = true;
            AddCustomerBtn.Click += AddCustomerBtn_Click;
            // 
            // customerDashboardBtn
            // 
            customerDashboardBtn.BackColor = Color.FloralWhite;
            customerDashboardBtn.Location = new Point(12, 147);
            customerDashboardBtn.Name = "customerDashboardBtn";
            customerDashboardBtn.Size = new Size(163, 39);
            customerDashboardBtn.TabIndex = 0;
            customerDashboardBtn.Text = "Dashbord";
            customerDashboardBtn.UseVisualStyleBackColor = false;
            customerDashboardBtn.Click += customerDashboardBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 81);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Liberation Sans", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(165, 27);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMERS";
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImageLayout = ImageLayout.None;
            mainPanel.Location = new Point(218, 40);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(566, 421);
            mainPanel.TabIndex = 1;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.ActiveBorder;
            TopPanel.Controls.Add(searchButton);
            TopPanel.Controls.Add(textSearch);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(218, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(566, 40);
            TopPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(499, 11);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(55, 23);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(289, 11);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Enter Customer Name/Organization";
            textSearch.Size = new Size(204, 23);
            textSearch.TabIndex = 0;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(TopPanel);
            Controls.Add(mainPanel);
            Controls.Add(sideCustomerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            sideCustomerPanel.ResumeLayout(false);
            sideCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideCustomerPanel;
        private Label label1;
        private Panel mainPanel;
        private PictureBox pictureBox1;
        private Button customerDashboardBtn;
        private Button backButton;
        private Button button4;
        private Button AddCustomerBtn;
        private Panel TopPanel;
        private Button searchButton;
        private TextBox textSearch;
    }
}