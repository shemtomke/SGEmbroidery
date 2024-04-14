namespace SGEmbroidery
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            inventoryBtn = new Button();
            customersBtn = new Button();
            cashSaleBtn = new Button();
            revenueBtn = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            invoiceBtn = new Button();
            deliveryNoteBtn = new Button();
            quotationBtn = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 110);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(146, 9);
            label2.Name = "label2";
            label2.Size = new Size(530, 31);
            label2.TabIndex = 1;
            label2.Text = "EMBROIDERY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(360, 66);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // inventoryBtn
            // 
            inventoryBtn.BackgroundImageLayout = ImageLayout.Center;
            inventoryBtn.Image = (Image)resources.GetObject("inventoryBtn.Image");
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(495, 23);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.RightToLeft = RightToLeft.No;
            inventoryBtn.Size = new Size(190, 110);
            inventoryBtn.TabIndex = 3;
            inventoryBtn.Text = "INVENTORY";
            inventoryBtn.TextAlign = ContentAlignment.MiddleRight;
            inventoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += button1_Click;
            // 
            // customersBtn
            // 
            customersBtn.BackgroundImageLayout = ImageLayout.Center;
            customersBtn.Image = (Image)resources.GetObject("customersBtn.Image");
            customersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            customersBtn.Location = new Point(299, 23);
            customersBtn.Name = "customersBtn";
            customersBtn.RightToLeft = RightToLeft.No;
            customersBtn.Size = new Size(190, 110);
            customersBtn.TabIndex = 2;
            customersBtn.Text = "CUSTOMERS";
            customersBtn.TextAlign = ContentAlignment.MiddleRight;
            customersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customersBtn.UseVisualStyleBackColor = true;
            customersBtn.Click += button2_Click_1;
            // 
            // cashSaleBtn
            // 
            cashSaleBtn.BackgroundImageLayout = ImageLayout.Center;
            cashSaleBtn.Image = (Image)resources.GetObject("cashSaleBtn.Image");
            cashSaleBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cashSaleBtn.Location = new Point(103, 139);
            cashSaleBtn.Name = "cashSaleBtn";
            cashSaleBtn.RightToLeft = RightToLeft.No;
            cashSaleBtn.Size = new Size(190, 110);
            cashSaleBtn.TabIndex = 4;
            cashSaleBtn.Text = "CASH SALE";
            cashSaleBtn.TextAlign = ContentAlignment.MiddleRight;
            cashSaleBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cashSaleBtn.UseVisualStyleBackColor = true;
            cashSaleBtn.Click += cashSaleBtn_Click;
            // 
            // revenueBtn
            // 
            revenueBtn.BackgroundImageLayout = ImageLayout.Center;
            revenueBtn.Image = (Image)resources.GetObject("revenueBtn.Image");
            revenueBtn.Location = new Point(103, 23);
            revenueBtn.Name = "revenueBtn";
            revenueBtn.RightToLeft = RightToLeft.No;
            revenueBtn.Size = new Size(190, 101);
            revenueBtn.TabIndex = 1;
            revenueBtn.Text = "REVENUE";
            revenueBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            revenueBtn.UseVisualStyleBackColor = true;
            revenueBtn.Click += revenueBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(revenueBtn);
            flowLayoutPanel1.Controls.Add(customersBtn);
            flowLayoutPanel1.Controls.Add(inventoryBtn);
            flowLayoutPanel1.Controls.Add(cashSaleBtn);
            flowLayoutPanel1.Controls.Add(invoiceBtn);
            flowLayoutPanel1.Controls.Add(deliveryNoteBtn);
            flowLayoutPanel1.Controls.Add(quotationBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 110);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(100, 20, 50, 50);
            flowLayoutPanel1.Size = new Size(800, 390);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // invoiceBtn
            // 
            invoiceBtn.BackgroundImageLayout = ImageLayout.Center;
            invoiceBtn.Image = (Image)resources.GetObject("invoiceBtn.Image");
            invoiceBtn.Location = new Point(299, 139);
            invoiceBtn.Name = "invoiceBtn";
            invoiceBtn.RightToLeft = RightToLeft.No;
            invoiceBtn.Size = new Size(192, 101);
            invoiceBtn.TabIndex = 5;
            invoiceBtn.Text = "INVOICE";
            invoiceBtn.TextAlign = ContentAlignment.MiddleRight;
            invoiceBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            invoiceBtn.UseVisualStyleBackColor = true;
            invoiceBtn.Click += invoiceBtn_Click;
            // 
            // deliveryNoteBtn
            // 
            deliveryNoteBtn.BackgroundImageLayout = ImageLayout.Center;
            deliveryNoteBtn.ForeColor = SystemColors.ControlText;
            deliveryNoteBtn.Image = (Image)resources.GetObject("deliveryNoteBtn.Image");
            deliveryNoteBtn.Location = new Point(497, 139);
            deliveryNoteBtn.Name = "deliveryNoteBtn";
            deliveryNoteBtn.RightToLeft = RightToLeft.No;
            deliveryNoteBtn.Size = new Size(190, 101);
            deliveryNoteBtn.TabIndex = 6;
            deliveryNoteBtn.Text = "DELIVERY NOTE";
            deliveryNoteBtn.TextAlign = ContentAlignment.MiddleRight;
            deliveryNoteBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deliveryNoteBtn.UseVisualStyleBackColor = true;
            deliveryNoteBtn.Click += button7_Click;
            // 
            // quotationBtn
            // 
            quotationBtn.BackgroundImageLayout = ImageLayout.Center;
            quotationBtn.Image = (Image)resources.GetObject("quotationBtn.Image");
            quotationBtn.Location = new Point(103, 255);
            quotationBtn.Name = "quotationBtn";
            quotationBtn.RightToLeft = RightToLeft.No;
            quotationBtn.Size = new Size(190, 101);
            quotationBtn.TabIndex = 7;
            quotationBtn.Text = "QUOTATION";
            quotationBtn.TextAlign = ContentAlignment.MiddleRight;
            quotationBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            quotationBtn.UseVisualStyleBackColor = true;
            quotationBtn.Click += quotationBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 500);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button inventoryBtn;
        private Button customersBtn;
        private Button cashSaleBtn;
        private Button revenueBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button invoiceBtn;
        private Label label2;
        private Label label1;
        private Button deliveryNoteBtn;
        private Button quotationBtn;
    }
}