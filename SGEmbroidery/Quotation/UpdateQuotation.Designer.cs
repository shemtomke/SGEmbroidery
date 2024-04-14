namespace SGEmbroidery.Quotation
{
    partial class UpdateQuotation
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
            dataGridView1 = new DataGridView();
            ItemsNumber = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            At = new DataGridViewTextBoxColumn();
            VAT = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemsNumber, Description, Quantity, At, VAT, Amount });
            dataGridView1.Location = new Point(26, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(514, 323);
            dataGridView1.TabIndex = 7;
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
            Quantity.HeaderText = "Quantity";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(389, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(36, 21);
            label1.TabIndex = 5;
            label1.Text = "REF";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 4;
            // 
            // UpdateQuotation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 461);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateQuotation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateQuotation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ItemsNumber;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn At;
        private DataGridViewTextBoxColumn VAT;
        private DataGridViewTextBoxColumn Amount;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox1;
    }
}