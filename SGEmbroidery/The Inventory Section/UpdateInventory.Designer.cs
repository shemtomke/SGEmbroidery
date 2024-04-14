namespace SGEmbroidery.Inventorys
{
    partial class UpdateInventory
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
            label6 = new Label();
            sizeTxtBx = new TextBox();
            label5 = new Label();
            label4 = new Label();
            colourTextBx = new TextBox();
            label3 = new Label();
            quantityTxtBx = new TextBox();
            label2 = new Label();
            deleteCustomerBtn = new Button();
            updateInventoryBtn = new Button();
            inventoryCategoryCombo = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 225);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 39;
            label6.Text = "Sizes";
            // 
            // sizeTxtBx
            // 
            sizeTxtBx.Anchor = AnchorStyles.None;
            sizeTxtBx.Location = new Point(170, 225);
            sizeTxtBx.Name = "sizeTxtBx";
            sizeTxtBx.Size = new Size(282, 23);
            sizeTxtBx.TabIndex = 38;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(97, 28);
            label5.Name = "label5";
            label5.Size = new Size(355, 39);
            label5.TabIndex = 37;
            label5.Text = "Update Inventory Details";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 285);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 35;
            label4.Text = "Colour";
            // 
            // colourTextBx
            // 
            colourTextBx.Anchor = AnchorStyles.None;
            colourTextBx.Location = new Point(170, 284);
            colourTextBx.Name = "colourTextBx";
            colourTextBx.Size = new Size(282, 23);
            colourTextBx.TabIndex = 34;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 163);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 33;
            label3.Text = "Quantity";
            // 
            // quantityTxtBx
            // 
            quantityTxtBx.Anchor = AnchorStyles.None;
            quantityTxtBx.Location = new Point(170, 163);
            quantityTxtBx.Name = "quantityTxtBx";
            quantityTxtBx.Size = new Size(282, 23);
            quantityTxtBx.TabIndex = 32;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 103);
            label2.Name = "label2";
            label2.Size = new Size(128, 19);
            label2.TabIndex = 31;
            label2.Text = "Inventory Category";
            // 
            // deleteCustomerBtn
            // 
            deleteCustomerBtn.Anchor = AnchorStyles.None;
            deleteCustomerBtn.Location = new Point(25, 406);
            deleteCustomerBtn.Name = "deleteCustomerBtn";
            deleteCustomerBtn.Size = new Size(132, 30);
            deleteCustomerBtn.TabIndex = 43;
            deleteCustomerBtn.Text = "Delete Inventory";
            deleteCustomerBtn.UseVisualStyleBackColor = true;
            deleteCustomerBtn.Click += deleteCustomerBtn_Click;
            // 
            // updateInventoryBtn
            // 
            updateInventoryBtn.Anchor = AnchorStyles.None;
            updateInventoryBtn.Location = new Point(387, 406);
            updateInventoryBtn.Name = "updateInventoryBtn";
            updateInventoryBtn.Size = new Size(132, 30);
            updateInventoryBtn.TabIndex = 42;
            updateInventoryBtn.Text = "Update Inventory";
            updateInventoryBtn.UseVisualStyleBackColor = true;
            updateInventoryBtn.Click += updateInventoryBtn_Click;
            // 
            // inventoryCategoryCombo
            // 
            inventoryCategoryCombo.FormattingEnabled = true;
            inventoryCategoryCombo.Location = new Point(178, 103);
            inventoryCategoryCombo.Name = "inventoryCategoryCombo";
            inventoryCategoryCombo.Size = new Size(274, 23);
            inventoryCategoryCombo.TabIndex = 44;
            inventoryCategoryCombo.SelectedIndexChanged += InventoryComboChange;
            inventoryCategoryCombo.SelectedValueChanged += InventoryComboChange;
            // 
            // UpdateInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(561, 461);
            Controls.Add(inventoryCategoryCombo);
            Controls.Add(deleteCustomerBtn);
            Controls.Add(updateInventoryBtn);
            Controls.Add(label6);
            Controls.Add(sizeTxtBx);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(colourTextBx);
            Controls.Add(label3);
            Controls.Add(quantityTxtBx);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateInventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox sizeTxtBx;
        private Label label5;
        private Label label4;
        private TextBox colourTextBx;
        private Label label3;
        private TextBox quantityTxtBx;
        private Label label2;
        private Button deleteCustomerBtn;
        private Button updateInventoryBtn;
        private ComboBox inventoryCategoryCombo;
    }
}