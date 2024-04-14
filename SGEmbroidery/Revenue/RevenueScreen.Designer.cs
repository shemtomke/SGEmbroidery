namespace SGEmbroidery.Progress
{
    partial class RevenueScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueScreen));
            mainPanel = new Panel();
            sideCustomerPanel = new Panel();
            companyProgressBtn = new Button();
            backButton = new Button();
            addExpensesBtn = new Button();
            addFinancesBtn = new Button();
            revenueDashboardBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sideCustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImageLayout = ImageLayout.None;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(218, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(566, 461);
            mainPanel.TabIndex = 3;
            // 
            // sideCustomerPanel
            // 
            sideCustomerPanel.BackColor = Color.Gold;
            sideCustomerPanel.Controls.Add(companyProgressBtn);
            sideCustomerPanel.Controls.Add(backButton);
            sideCustomerPanel.Controls.Add(addExpensesBtn);
            sideCustomerPanel.Controls.Add(addFinancesBtn);
            sideCustomerPanel.Controls.Add(revenueDashboardBtn);
            sideCustomerPanel.Controls.Add(pictureBox1);
            sideCustomerPanel.Controls.Add(label1);
            sideCustomerPanel.Dock = DockStyle.Left;
            sideCustomerPanel.Location = new Point(0, 0);
            sideCustomerPanel.Name = "sideCustomerPanel";
            sideCustomerPanel.Size = new Size(218, 461);
            sideCustomerPanel.TabIndex = 2;
            // 
            // companyProgressBtn
            // 
            companyProgressBtn.Location = new Point(12, 377);
            companyProgressBtn.Name = "companyProgressBtn";
            companyProgressBtn.Size = new Size(163, 39);
            companyProgressBtn.TabIndex = 6;
            companyProgressBtn.Text = "Company Progress";
            companyProgressBtn.UseVisualStyleBackColor = true;
            companyProgressBtn.Click += companyProgressBtn_Click;
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
            // addExpensesBtn
            // 
            addExpensesBtn.Location = new Point(12, 300);
            addExpensesBtn.Name = "addExpensesBtn";
            addExpensesBtn.Size = new Size(163, 39);
            addExpensesBtn.TabIndex = 4;
            addExpensesBtn.Text = "Add Expenses";
            addExpensesBtn.UseVisualStyleBackColor = true;
            addExpensesBtn.Click += addExpensesBtn_Click;
            // 
            // addFinancesBtn
            // 
            addFinancesBtn.Location = new Point(12, 221);
            addFinancesBtn.Name = "addFinancesBtn";
            addFinancesBtn.Size = new Size(163, 39);
            addFinancesBtn.TabIndex = 2;
            addFinancesBtn.Text = "Add Finances";
            addFinancesBtn.UseVisualStyleBackColor = true;
            addFinancesBtn.Click += addFinancesBtn_Click;
            // 
            // revenueDashboardBtn
            // 
            revenueDashboardBtn.BackColor = Color.FloralWhite;
            revenueDashboardBtn.Location = new Point(12, 147);
            revenueDashboardBtn.Name = "revenueDashboardBtn";
            revenueDashboardBtn.Size = new Size(163, 39);
            revenueDashboardBtn.TabIndex = 0;
            revenueDashboardBtn.Text = "Dashboard";
            revenueDashboardBtn.UseVisualStyleBackColor = false;
            revenueDashboardBtn.Click += revenueDashboardBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 90);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Liberation Sans", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 96);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 0;
            label1.Text = "REVENUE";
            // 
            // RevenueScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(mainPanel);
            Controls.Add(sideCustomerPanel);
            Name = "RevenueScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Progress";
            sideCustomerPanel.ResumeLayout(false);
            sideCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel sideCustomerPanel;
        private Button backButton;
        private Button addExpensesBtn;
        private Button addFinancesBtn;
        private Button revenueDashboardBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Button companyProgressBtn;
    }
}