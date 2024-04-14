namespace SGEmbroidery.Progress
{
    partial class Expenses
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
            addExpenseBtn = new Button();
            amount = new TextBox();
            label3 = new Label();
            label1 = new Label();
            fromDateTimePicker = new DateTimePicker();
            expenseDescription = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // addExpenseBtn
            // 
            addExpenseBtn.Location = new Point(407, 405);
            addExpenseBtn.Name = "addExpenseBtn";
            addExpenseBtn.Size = new Size(130, 30);
            addExpenseBtn.TabIndex = 13;
            addExpenseBtn.Text = "ADD EXPENSE";
            addExpenseBtn.UseVisualStyleBackColor = true;
            addExpenseBtn.Click += addExpenseBtn_Click;
            // 
            // amount
            // 
            amount.Location = new Point(220, 205);
            amount.Name = "amount";
            amount.Size = new Size(200, 23);
            amount.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 203);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 11;
            label3.Text = "AMOUNT :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 9;
            label1.Text = "DATE PURCHASED : ";
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.Location = new Point(220, 36);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(200, 23);
            fromDateTimePicker.TabIndex = 7;
            // 
            // expenseDescription
            // 
            expenseDescription.Location = new Point(220, 96);
            expenseDescription.Multiline = true;
            expenseDescription.Name = "expenseDescription";
            expenseDescription.Size = new Size(200, 91);
            expenseDescription.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 94);
            label2.Name = "label2";
            label2.Size = new Size(185, 21);
            label2.TabIndex = 14;
            label2.Text = "EXPENSE DESCRIPTION : ";
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 461);
            Controls.Add(expenseDescription);
            Controls.Add(label2);
            Controls.Add(addExpenseBtn);
            Controls.Add(amount);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(fromDateTimePicker);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expenses";
            Text = "Expenses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addExpenseBtn;
        private TextBox amount;
        private Label label3;
        private Label label1;
        private DateTimePicker fromDateTimePicker;
        private TextBox expenseDescription;
        private Label label2;
    }
}