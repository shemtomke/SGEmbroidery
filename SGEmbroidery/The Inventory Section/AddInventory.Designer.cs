namespace SGEmbroidery.Inventory
{
    partial class AddInventory
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
            label5 = new Label();
            addInventoryBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            itemCategoryCombo = new ComboBox();
            sizeCombo = new ComboBox();
            quantityTxtBx = new TextBox();
            colorCombo = new ComboBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 301);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 27;
            label6.Text = "Color";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(137, 28);
            label5.Name = "label5";
            label5.Size = new Size(316, 39);
            label5.TabIndex = 25;
            label5.Text = "Add Inventory Details";
            // 
            // addInventoryBtn
            // 
            addInventoryBtn.Anchor = AnchorStyles.None;
            addInventoryBtn.Location = new Point(395, 403);
            addInventoryBtn.Name = "addInventoryBtn";
            addInventoryBtn.Size = new Size(132, 30);
            addInventoryBtn.TabIndex = 24;
            addInventoryBtn.Text = "Add Inventory";
            addInventoryBtn.UseVisualStyleBackColor = true;
            addInventoryBtn.Click += addInventoryBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 239);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 21;
            label3.Text = "Quantity";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 176);
            label2.Name = "label2";
            label2.Size = new Size(32, 19);
            label2.TabIndex = 19;
            label2.Text = "Size";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 109);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 17;
            label1.Text = "Item Category";
            // 
            // itemCategoryCombo
            // 
            itemCategoryCombo.FormattingEnabled = true;
            itemCategoryCombo.Location = new Point(163, 109);
            itemCategoryCombo.Name = "itemCategoryCombo";
            itemCategoryCombo.Size = new Size(282, 23);
            itemCategoryCombo.TabIndex = 28;
            // 
            // sizeCombo
            // 
            sizeCombo.FormattingEnabled = true;
            sizeCombo.Location = new Point(163, 176);
            sizeCombo.Name = "sizeCombo";
            sizeCombo.Size = new Size(282, 23);
            sizeCombo.TabIndex = 29;
            // 
            // quantityTxtBx
            // 
            quantityTxtBx.Anchor = AnchorStyles.None;
            quantityTxtBx.Location = new Point(163, 237);
            quantityTxtBx.Name = "quantityTxtBx";
            quantityTxtBx.Size = new Size(282, 23);
            quantityTxtBx.TabIndex = 20;
            // 
            // colorCombo
            // 
            colorCombo.FormattingEnabled = true;
            colorCombo.Location = new Point(163, 300);
            colorCombo.Name = "colorCombo";
            colorCombo.Size = new Size(282, 23);
            colorCombo.TabIndex = 30;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(561, 461);
            Controls.Add(colorCombo);
            Controls.Add(sizeCombo);
            Controls.Add(itemCategoryCombo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(addInventoryBtn);
            Controls.Add(label3);
            Controls.Add(quantityTxtBx);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddInventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button addInventoryBtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox itemCategoryCombo;
        private ComboBox sizeCombo;
        private TextBox quantityTxtBx;
        private ComboBox colorCombo;
    }
}