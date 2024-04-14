namespace SGEmbroidery.Invoice
{
    partial class InvoiceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceScreen));
            backButton = new Button();
            updateInvoiceBtn = new Button();
            addInvoiceBtn = new Button();
            invoiceDashboard = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mainPanel = new Panel();
            sideCustomerPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideCustomerPanel.SuspendLayout();
            SuspendLayout();
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
            // updateInvoiceBtn
            // 
            updateInvoiceBtn.Location = new Point(12, 300);
            updateInvoiceBtn.Name = "updateInvoiceBtn";
            updateInvoiceBtn.Size = new Size(163, 39);
            updateInvoiceBtn.TabIndex = 4;
            updateInvoiceBtn.Text = "Update Invoice";
            updateInvoiceBtn.UseVisualStyleBackColor = true;
            updateInvoiceBtn.Click += updateInvoiceBtn_Click;
            // 
            // addInvoiceBtn
            // 
            addInvoiceBtn.Location = new Point(12, 221);
            addInvoiceBtn.Name = "addInvoiceBtn";
            addInvoiceBtn.Size = new Size(163, 39);
            addInvoiceBtn.TabIndex = 2;
            addInvoiceBtn.Text = "Add Invoice";
            addInvoiceBtn.UseVisualStyleBackColor = true;
            addInvoiceBtn.Click += addInvoiceBtn_Click;
            // 
            // invoiceDashboard
            // 
            invoiceDashboard.BackColor = Color.FloralWhite;
            invoiceDashboard.Location = new Point(12, 147);
            invoiceDashboard.Name = "invoiceDashboard";
            invoiceDashboard.Size = new Size(163, 39);
            invoiceDashboard.TabIndex = 0;
            invoiceDashboard.Text = "Dashbord";
            invoiceDashboard.UseVisualStyleBackColor = false;
            invoiceDashboard.Click += invoiceDashboard_Click;
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
            label1.Location = new Point(33, 96);
            label1.Name = "label1";
            label1.Size = new Size(110, 27);
            label1.TabIndex = 0;
            label1.Text = "INVOICE";
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
            sideCustomerPanel.Controls.Add(backButton);
            sideCustomerPanel.Controls.Add(updateInvoiceBtn);
            sideCustomerPanel.Controls.Add(addInvoiceBtn);
            sideCustomerPanel.Controls.Add(invoiceDashboard);
            sideCustomerPanel.Controls.Add(pictureBox1);
            sideCustomerPanel.Controls.Add(label1);
            sideCustomerPanel.Dock = DockStyle.Left;
            sideCustomerPanel.Location = new Point(0, 0);
            sideCustomerPanel.Name = "sideCustomerPanel";
            sideCustomerPanel.Size = new Size(218, 461);
            sideCustomerPanel.TabIndex = 2;
            // 
            // InvoiceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(mainPanel);
            Controls.Add(sideCustomerPanel);
            MaximizeBox = false;
            Name = "InvoiceScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InvoiceScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideCustomerPanel.ResumeLayout(false);
            sideCustomerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Button updateInvoiceBtn;
        private Button addInvoiceBtn;
        private Button invoiceDashboard;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel mainPanel;
        private Panel sideCustomerPanel;
    }
}