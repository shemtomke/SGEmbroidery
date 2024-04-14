namespace SGEmbroidery.Inventorys
{
    partial class InventoryDashboard
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
            inventoryDataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)inventoryDataView).BeginInit();
            SuspendLayout();
            // 
            // inventoryDataView
            // 
            inventoryDataView.Anchor = AnchorStyles.None;
            inventoryDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryDataView.Location = new Point(12, 65);
            inventoryDataView.Name = "inventoryDataView";
            inventoryDataView.RowTemplate.Height = 25;
            inventoryDataView.Size = new Size(535, 359);
            inventoryDataView.TabIndex = 6;
            inventoryDataView.CellContentClick += inventoryDataView_CellContentClick;
            // 
            // InventoryDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(566, 461);
            Controls.Add(inventoryDataView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryDashboard";
            ((System.ComponentModel.ISupportInitialize)inventoryDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView inventoryDataView;
    }
}