namespace SGEmbroidery.Cash_Sale
{
    partial class CashSaleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashSaleScreen));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sideCustomerPanel = new Panel();
            backButton = new Button();
            updateCashSale = new Button();
            createCashSale = new Button();
            cashSaleDashboard = new Button();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideCustomerPanel.SuspendLayout();
            SuspendLayout();
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
            label1.Location = new Point(25, 96);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 0;
            label1.Text = "CASH SALE";
            // 
            // sideCustomerPanel
            // 
            sideCustomerPanel.BackColor = Color.Gold;
            sideCustomerPanel.Controls.Add(backButton);
            sideCustomerPanel.Controls.Add(updateCashSale);
            sideCustomerPanel.Controls.Add(createCashSale);
            sideCustomerPanel.Controls.Add(cashSaleDashboard);
            sideCustomerPanel.Controls.Add(pictureBox1);
            sideCustomerPanel.Controls.Add(label1);
            sideCustomerPanel.Dock = DockStyle.Left;
            sideCustomerPanel.Location = new Point(0, 0);
            sideCustomerPanel.Name = "sideCustomerPanel";
            sideCustomerPanel.Size = new Size(218, 461);
            sideCustomerPanel.TabIndex = 2;
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
            // updateCashSale
            // 
            updateCashSale.Location = new Point(12, 300);
            updateCashSale.Name = "updateCashSale";
            updateCashSale.Size = new Size(163, 39);
            updateCashSale.TabIndex = 4;
            updateCashSale.Text = "Update Cash Sale";
            updateCashSale.UseVisualStyleBackColor = true;
            updateCashSale.Click += updateCashSale_Click;
            // 
            // createCashSale
            // 
            createCashSale.Location = new Point(12, 221);
            createCashSale.Name = "createCashSale";
            createCashSale.Size = new Size(163, 39);
            createCashSale.TabIndex = 2;
            createCashSale.Text = "Create Cash Sale";
            createCashSale.UseVisualStyleBackColor = true;
            createCashSale.Click += createCashSale_Click;
            // 
            // cashSaleDashboard
            // 
            cashSaleDashboard.BackColor = Color.FloralWhite;
            cashSaleDashboard.Location = new Point(12, 147);
            cashSaleDashboard.Name = "cashSaleDashboard";
            cashSaleDashboard.Size = new Size(163, 39);
            cashSaleDashboard.TabIndex = 0;
            cashSaleDashboard.Text = "Dashbord";
            cashSaleDashboard.UseVisualStyleBackColor = false;
            cashSaleDashboard.Click += cashSaleDashboard_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImageLayout = ImageLayout.None;
            mainPanel.Dock = DockStyle.Right;
            mainPanel.Location = new Point(218, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(566, 461);
            mainPanel.TabIndex = 3;
            // 
            // CashSaleScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(sideCustomerPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CashSaleScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashSaleScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideCustomerPanel.ResumeLayout(false);
            sideCustomerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel sideCustomerPanel;
        private Button backButton;
        private Button updateCashSale;
        private Button createCashSale;
        private Button cashSaleDashboard;
        private Panel mainPanel;
    }
}