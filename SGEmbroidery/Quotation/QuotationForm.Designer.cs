namespace SGEmbroidery.Quotation
{
    partial class QuotationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotationForm));
            sideCustomerPanel = new Panel();
            backButton = new Button();
            updateQuotationBtn = new Button();
            CreateQuotationBtn = new Button();
            printQuotationBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            mainPanel = new Panel();
            sideCustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sideCustomerPanel
            // 
            sideCustomerPanel.BackColor = Color.Gold;
            sideCustomerPanel.Controls.Add(backButton);
            sideCustomerPanel.Controls.Add(updateQuotationBtn);
            sideCustomerPanel.Controls.Add(CreateQuotationBtn);
            sideCustomerPanel.Controls.Add(printQuotationBtn);
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
            // updateQuotationBtn
            // 
            updateQuotationBtn.Location = new Point(12, 300);
            updateQuotationBtn.Name = "updateQuotationBtn";
            updateQuotationBtn.Size = new Size(163, 39);
            updateQuotationBtn.TabIndex = 4;
            updateQuotationBtn.Text = "Update Quotation";
            updateQuotationBtn.UseVisualStyleBackColor = true;
            updateQuotationBtn.Click += updateQuotationBtn_Click;
            // 
            // CreateQuotationBtn
            // 
            CreateQuotationBtn.Location = new Point(12, 221);
            CreateQuotationBtn.Name = "CreateQuotationBtn";
            CreateQuotationBtn.Size = new Size(163, 39);
            CreateQuotationBtn.TabIndex = 2;
            CreateQuotationBtn.Text = "Create Quotation";
            CreateQuotationBtn.UseVisualStyleBackColor = true;
            CreateQuotationBtn.Click += CreateQuotationBtn_Click;
            // 
            // printQuotationBtn
            // 
            printQuotationBtn.BackColor = Color.FloralWhite;
            printQuotationBtn.Location = new Point(12, 147);
            printQuotationBtn.Name = "printQuotationBtn";
            printQuotationBtn.Size = new Size(163, 39);
            printQuotationBtn.TabIndex = 0;
            printQuotationBtn.Text = "Quotations";
            printQuotationBtn.UseVisualStyleBackColor = false;
            printQuotationBtn.Click += printQuotationBtn_Click;
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
            label1.Text = "QUOTATION";
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
            // QuotationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(sideCustomerPanel);
            Controls.Add(mainPanel);
            Name = "QuotationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuotationForm";
            sideCustomerPanel.ResumeLayout(false);
            sideCustomerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideCustomerPanel;
        private Button backButton;
        private Button updateQuotationBtn;
        private Button CreateQuotationBtn;
        private Button printQuotationBtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel mainPanel;
    }
}