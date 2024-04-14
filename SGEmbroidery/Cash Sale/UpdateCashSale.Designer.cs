namespace SGEmbroidery.Cash_Sale
{
    partial class UpdateCashSale
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
            Quantity = new DataGridViewTextBoxColumn();
            Particulars = new DataGridViewTextBoxColumn();
            At = new DataGridViewTextBoxColumn();
            Kshs = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Quantity, Particulars, At, Kshs });
            dataGridView1.Location = new Point(26, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(514, 319);
            dataGridView1.TabIndex = 15;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Particulars
            // 
            Particulars.HeaderText = "Particulars";
            Particulars.Name = "Particulars";
            // 
            // At
            // 
            At.HeaderText = "@";
            At.Name = "At";
            // 
            // Kshs
            // 
            Kshs.HeaderText = "Kshs";
            Kshs.Name = "Kshs";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(389, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 44);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 13;
            label1.Text = "Ms/Mr.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 12;
            // 
            // UpdateCashSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 461);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateCashSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCashSale";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Particulars;
        private DataGridViewTextBoxColumn At;
        private DataGridViewTextBoxColumn Kshs;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox1;
    }
}