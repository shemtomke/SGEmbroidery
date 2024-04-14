namespace SGEmbroidery.Quotation
{
    partial class PrintReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintReport));
            letterHead = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            referenceOrganizationName = new Label();
            label6 = new Label();
            dateOfQuotation = new Label();
            label8 = new Label();
            label9 = new Label();
            quotationView = new DataGridView();
            ItemsNumber = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            At = new DataGridViewTextBoxColumn();
            VAT = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            totalCost = new Label();
            vatAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)letterHead).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quotationView).BeginInit();
            SuspendLayout();
            // 
            // letterHead
            // 
            letterHead.Image = (Image)resources.GetObject("letterHead.Image");
            letterHead.Location = new Point(9, 15);
            letterHead.Margin = new Padding(0);
            letterHead.Name = "letterHead";
            letterHead.Size = new Size(100, 56);
            letterHead.TabIndex = 0;
            letterHead.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(174, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 37);
            label1.TabIndex = 1;
            label1.Text = "S & G EMBROIDERY LTD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(174, 33);
            label2.Name = "label2";
            label2.Size = new Size(317, 19);
            label2.TabIndex = 2;
            label2.Text = "Kongowea Kengeleni Opposite Co-operative Bank.";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(letterHead);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 749);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(198, 52);
            label3.Name = "label3";
            label3.Size = new Size(261, 19);
            label3.TabIndex = 3;
            label3.Text = "Tel : +254754666609 / +254704038775";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(198, 71);
            label4.Name = "label4";
            label4.Size = new Size(227, 19);
            label4.TabIndex = 4;
            label4.Text = "Email : sgembroideryltd@gmail.com";
            // 
            // panel2
            // 
            panel2.Controls.Add(vatAmount);
            panel2.Controls.Add(totalCost);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(quotationView);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dateOfQuotation);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(referenceOrganizationName);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 642);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(52, 78);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 5;
            label5.Text = "REF : ";
            // 
            // referenceOrganizationName
            // 
            referenceOrganizationName.AutoSize = true;
            referenceOrganizationName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            referenceOrganizationName.Location = new Point(102, 78);
            referenceOrganizationName.Name = "referenceOrganizationName";
            referenceOrganizationName.Size = new Size(128, 19);
            referenceOrganizationName.TabIndex = 6;
            referenceOrganizationName.Text = "Organization Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(225, 12);
            label6.Name = "label6";
            label6.Size = new Size(111, 21);
            label6.TabIndex = 7;
            label6.Text = "QUOTATIONS";
            // 
            // dateOfQuotation
            // 
            dateOfQuotation.AutoSize = true;
            dateOfQuotation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfQuotation.Location = new Point(424, 35);
            dateOfQuotation.Name = "dateOfQuotation";
            dateOfQuotation.Size = new Size(83, 19);
            dateOfQuotation.TabIndex = 9;
            dateOfQuotation.Text = "00/00/2023";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(374, 35);
            label8.Name = "label8";
            label8.Size = new Size(52, 19);
            label8.TabIndex = 8;
            label8.Text = "Date : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(48, 106);
            label9.Name = "label9";
            label9.Size = new Size(504, 20);
            label9.TabIndex = 10;
            label9.Text = "We thanks for your inquiry and we are pleased to submit our bid as follow :";
            // 
            // quotationView
            // 
            quotationView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quotationView.Columns.AddRange(new DataGridViewColumn[] { ItemsNumber, Description, Quantity, At, VAT, Amount });
            quotationView.Location = new Point(12, 138);
            quotationView.Name = "quotationView";
            quotationView.RowTemplate.Height = 25;
            quotationView.Size = new Size(555, 332);
            quotationView.TabIndex = 11;
            // 
            // ItemsNumber
            // 
            ItemsNumber.HeaderText = "Items No.";
            ItemsNumber.Name = "ItemsNumber";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Qty";
            Quantity.Name = "Quantity";
            // 
            // At
            // 
            At.HeaderText = "@";
            At.Name = "At";
            // 
            // VAT
            // 
            VAT.HeaderText = "V.A.T";
            VAT.Name = "VAT";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(290, 531);
            label10.Name = "label10";
            label10.Size = new Size(148, 19);
            label10.TabIndex = 12;
            label10.Text = "GRAND TOTAL COST ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(290, 495);
            label11.Name = "label11";
            label11.Size = new Size(135, 19);
            label11.TabIndex = 13;
            label11.Text = "PLUS 16% OF V.A.T";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(27, 577);
            label12.Name = "label12";
            label12.Size = new Size(69, 19);
            label12.TabIndex = 14;
            label12.Text = "Manager";
            // 
            // totalCost
            // 
            totalCost.AutoSize = true;
            totalCost.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            totalCost.Location = new Point(444, 531);
            totalCost.Name = "totalCost";
            totalCost.Size = new Size(60, 19);
            totalCost.TabIndex = 15;
            totalCost.Text = "5555.00";
            // 
            // vatAmount
            // 
            vatAmount.AutoSize = true;
            vatAmount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            vatAmount.Location = new Point(444, 495);
            vatAmount.Name = "vatAmount";
            vatAmount.Size = new Size(60, 19);
            vatAmount.TabIndex = 16;
            vatAmount.Text = "5555.00";
            // 
            // PrintReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(579, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PrintReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Print Quotation";
            ((System.ComponentModel.ISupportInitialize)letterHead).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quotationView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox letterHead;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label6;
        private Label referenceOrganizationName;
        private Label label5;
        private Label dateOfQuotation;
        private Label label8;
        private DataGridView quotationView;
        private DataGridViewTextBoxColumn ItemsNumber;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn At;
        private DataGridViewTextBoxColumn VAT;
        private DataGridViewTextBoxColumn Amount;
        private Label label9;
        private Label label10;
        private Label vatAmount;
        private Label totalCost;
        private Label label12;
        private Label label11;
    }
}