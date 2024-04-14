namespace SGEmbroidery.Invoice
{
    partial class CreateInvoice
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            ItemsNumber = new DataGridViewTextBoxColumn();
            Particulars = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Kshs = new DataGridViewTextBoxColumn();
            Cts = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ItemsNumber, Particulars, Quantity, Kshs, Cts });
            dataGridView1.Location = new Point(26, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(514, 323);
            dataGridView1.TabIndex = 7;
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
            // ItemsNumber
            // 
            ItemsNumber.HeaderText = "Items No.";
            ItemsNumber.Name = "ItemsNumber";
            // 
            // Particulars
            // 
            Particulars.HeaderText = "Particulars";
            Particulars.Name = "Particulars";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Kshs
            // 
            Kshs.HeaderText = "Kshs";
            Kshs.Name = "Kshs";
            // 
            // Cts
            // 
            Cts.HeaderText = "Cts";
            Cts.Name = "Cts";
            // 
            // CreateInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 461);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateInvoice";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ItemsNumber;
        private DataGridViewTextBoxColumn Particulars;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Kshs;
        private DataGridViewTextBoxColumn Cts;
    }
}