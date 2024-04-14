namespace SGEmbroidery.DeliveryNote
{
    partial class AddDelivery
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
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            lpoNumber = new TextBox();
            Items = new DataGridViewTextBoxColumn();
            Particulars = new DataGridViewTextBoxColumn();
            At = new DataGridViewTextBoxColumn();
            Kshs = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(418, 413);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 23;
            label4.Text = "Signature";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(371, 358);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 52);
            textBox3.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 413);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 21;
            label3.Text = "Receipient's Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 387);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 23);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 19;
            label2.Text = "Ms/Mr.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Items, Particulars, At, Kshs });
            dataGridView1.Location = new Point(26, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(514, 212);
            dataGridView1.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(389, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 15;
            label1.Text = "L.P.O No.";
            // 
            // lpoNumber
            // 
            lpoNumber.Location = new Point(105, 26);
            lpoNumber.Name = "lpoNumber";
            lpoNumber.Size = new Size(278, 23);
            lpoNumber.TabIndex = 14;
            // 
            // Items
            // 
            Items.HeaderText = "Items";
            Items.Name = "Items";
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
            // AddDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 461);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(lpoNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDelivery";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox lpoNumber;
        private DataGridViewTextBoxColumn Items;
        private DataGridViewTextBoxColumn Particulars;
        private DataGridViewTextBoxColumn At;
        private DataGridViewTextBoxColumn Kshs;
    }
}