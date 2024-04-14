namespace SGEmbroidery.Progress
{
    partial class AddFinance
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
            fromDateTimePicker1 = new DateTimePicker();
            toDateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            totalAmount = new TextBox();
            addRecordBtn = new Button();
            SuspendLayout();
            // 
            // fromDateTimePicker1
            // 
            fromDateTimePicker1.Location = new Point(219, 46);
            fromDateTimePicker1.Name = "fromDateTimePicker1";
            fromDateTimePicker1.Size = new Size(200, 23);
            fromDateTimePicker1.TabIndex = 0;
            // 
            // toDateTimePicker1
            // 
            toDateTimePicker1.Location = new Point(219, 103);
            toDateTimePicker1.Name = "toDateTimePicker1";
            toDateTimePicker1.Size = new Size(200, 23);
            toDateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 2;
            label1.Text = "FROM DATE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 105);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "TO DATE :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 172);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 4;
            label3.Text = "TOTAL AMOUNT";
            // 
            // totalAmount
            // 
            totalAmount.Location = new Point(219, 174);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(200, 23);
            totalAmount.TabIndex = 5;
            // 
            // addRecordBtn
            // 
            addRecordBtn.Location = new Point(404, 404);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(130, 30);
            addRecordBtn.TabIndex = 6;
            addRecordBtn.Text = "ADD RECORD";
            addRecordBtn.UseVisualStyleBackColor = true;
            addRecordBtn.Click += button1_Click;
            // 
            // AddFinance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 461);
            Controls.Add(addRecordBtn);
            Controls.Add(totalAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toDateTimePicker1);
            Controls.Add(fromDateTimePicker1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddFinance";
            Text = "FinancialYear";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fromDateTimePicker1;
        private DateTimePicker toDateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox totalAmount;
        private Button addRecordBtn;
    }
}