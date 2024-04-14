namespace SGEmbroidery
{
    partial class TheInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheInventory));
            mainPanel = new Panel();
            sideCustomerPanel = new Panel();
            AddItemCategoryBtn = new Button();
            backButton = new Button();
            UpdateInventoryBtn = new Button();
            AddInventoryBtn = new Button();
            inventoryDashboardBtn = new Button();
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
            sideCustomerPanel.Controls.Add(AddItemCategoryBtn);
            sideCustomerPanel.Controls.Add(backButton);
            sideCustomerPanel.Controls.Add(UpdateInventoryBtn);
            sideCustomerPanel.Controls.Add(AddInventoryBtn);
            sideCustomerPanel.Controls.Add(inventoryDashboardBtn);
            sideCustomerPanel.Controls.Add(pictureBox1);
            sideCustomerPanel.Controls.Add(label1);
            sideCustomerPanel.Dock = DockStyle.Left;
            sideCustomerPanel.Location = new Point(0, 0);
            sideCustomerPanel.Name = "sideCustomerPanel";
            sideCustomerPanel.Size = new Size(218, 461);
            sideCustomerPanel.TabIndex = 2;
            // 
            // AddItemCategoryBtn
            // 
            AddItemCategoryBtn.Location = new Point(12, 295);
            AddItemCategoryBtn.Name = "AddItemCategoryBtn";
            AddItemCategoryBtn.Size = new Size(163, 39);
            AddItemCategoryBtn.TabIndex = 6;
            AddItemCategoryBtn.Text = "Add Item Category";
            AddItemCategoryBtn.UseVisualStyleBackColor = true;
            AddItemCategoryBtn.Click += AddItemCategoryBtn_Click;
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
            backButton.Click += backButton_Click_1;
            // 
            // UpdateInventoryBtn
            // 
            UpdateInventoryBtn.Location = new Point(12, 365);
            UpdateInventoryBtn.Name = "UpdateInventoryBtn";
            UpdateInventoryBtn.Size = new Size(163, 39);
            UpdateInventoryBtn.TabIndex = 4;
            UpdateInventoryBtn.Text = "Update Inventory";
            UpdateInventoryBtn.UseVisualStyleBackColor = true;
            UpdateInventoryBtn.Click += UpdateInventoryBtn_Click;
            // 
            // AddInventoryBtn
            // 
            AddInventoryBtn.Location = new Point(12, 221);
            AddInventoryBtn.Name = "AddInventoryBtn";
            AddInventoryBtn.Size = new Size(163, 39);
            AddInventoryBtn.TabIndex = 2;
            AddInventoryBtn.Text = "Add Inventory";
            AddInventoryBtn.UseVisualStyleBackColor = true;
            AddInventoryBtn.Click += AddInventoryBtn_Click;
            // 
            // inventoryDashboardBtn
            // 
            inventoryDashboardBtn.BackColor = Color.FloralWhite;
            inventoryDashboardBtn.Location = new Point(12, 147);
            inventoryDashboardBtn.Name = "inventoryDashboardBtn";
            inventoryDashboardBtn.Size = new Size(163, 39);
            inventoryDashboardBtn.TabIndex = 0;
            inventoryDashboardBtn.Text = "Dashbord";
            inventoryDashboardBtn.UseVisualStyleBackColor = false;
            inventoryDashboardBtn.Click += inventoryDashboardBtn_Click;
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
            label1.Location = new Point(26, 96);
            label1.Name = "label1";
            label1.Size = new Size(149, 27);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(784, 461);
            Controls.Add(mainPanel);
            Controls.Add(sideCustomerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TheInventory";
            sideCustomerPanel.ResumeLayout(false);
            sideCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel sideCustomerPanel;
        private Button AddItemCategoryBtn;
        private Button backButton;
        private Button UpdateInventoryBtn;
        private Button AddInventoryBtn;
        private Button inventoryDashboardBtn;
        private PictureBox pictureBox1;
        private Label label1;
    }
}