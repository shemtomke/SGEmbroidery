namespace SGEmbroidery.The_Inventory
{
    partial class AddItem
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
            label5 = new Label();
            addInventoryBtn = new Button();
            itemCategoryTxtBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(137, 28);
            label5.Name = "label5";
            label5.Size = new Size(249, 39);
            label5.TabIndex = 29;
            label5.Text = "Add Item Details";
            // 
            // addInventoryBtn
            // 
            addInventoryBtn.Anchor = AnchorStyles.None;
            addInventoryBtn.Location = new Point(395, 403);
            addInventoryBtn.Name = "addInventoryBtn";
            addInventoryBtn.Size = new Size(132, 30);
            addInventoryBtn.TabIndex = 28;
            addInventoryBtn.Text = "Add Item";
            addInventoryBtn.UseVisualStyleBackColor = true;
            addInventoryBtn.Click += addInventoryBtn_Click;
            // 
            // itemCategoryTxtBox
            // 
            itemCategoryTxtBox.Anchor = AnchorStyles.None;
            itemCategoryTxtBox.Location = new Point(147, 108);
            itemCategoryTxtBox.Name = "itemCategoryTxtBox";
            itemCategoryTxtBox.Size = new Size(282, 23);
            itemCategoryTxtBox.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 109);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 26;
            label1.Text = "Item Category";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 461);
            Controls.Add(label5);
            Controls.Add(addInventoryBtn);
            Controls.Add(itemCategoryTxtBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button addInventoryBtn;
        private TextBox itemCategoryTxtBox;
        private Label label1;
    }
}