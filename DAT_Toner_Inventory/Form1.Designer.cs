namespace DAT_Toner_Inventory
{
    partial class inventoryForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.barcodeNumberScanner = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.barCodeInput = new System.Windows.Forms.TextBox();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.tonerInventory = new System.Windows.Forms.TabControl();
            this.OBSInventory = new System.Windows.Forms.TabPage();
            this.OBSDataGridView = new System.Windows.Forms.DataGridView();
            this.OBSNonInventory = new System.Windows.Forms.TabPage();
            this.NonOBSDataGridView = new System.Windows.Forms.DataGridView();
            this.mainPanel.SuspendLayout();
            this.tonerInventory.SuspendLayout();
            this.OBSInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OBSDataGridView)).BeginInit();
            this.OBSNonInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NonOBSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Controls.Add(this.barcodeNumberScanner);
            this.mainPanel.Controls.Add(this.quantityLabel);
            this.mainPanel.Controls.Add(this.quantityText);
            this.mainPanel.Controls.Add(this.barCodeInput);
            this.mainPanel.Controls.Add(this.sendEmailButton);
            this.mainPanel.Controls.Add(this.checkOutButton);
            this.mainPanel.Controls.Add(this.checkInButton);
            this.mainPanel.Location = new System.Drawing.Point(7, 11);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(428, 548);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // barcodeNumberScanner
            // 
            this.barcodeNumberScanner.AutoSize = true;
            this.barcodeNumberScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeNumberScanner.Location = new System.Drawing.Point(106, 83);
            this.barcodeNumberScanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.barcodeNumberScanner.Name = "barcodeNumberScanner";
            this.barcodeNumberScanner.Size = new System.Drawing.Size(245, 36);
            this.barcodeNumberScanner.TabIndex = 7;
            this.barcodeNumberScanner.Text = "Barcode Scanner";
            this.barcodeNumberScanner.Click += new System.EventHandler(this.label1_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(138, 218);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(133, 36);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityText
            // 
            this.quantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.Location = new System.Drawing.Point(275, 202);
            this.quantityText.Margin = new System.Windows.Forms.Padding(2);
            this.quantityText.Multiline = true;
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(137, 52);
            this.quantityText.TabIndex = 5;
            // 
            // barCodeInput
            // 
            this.barCodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCodeInput.Location = new System.Drawing.Point(17, 122);
            this.barCodeInput.Margin = new System.Windows.Forms.Padding(2);
            this.barCodeInput.Multiline = true;
            this.barCodeInput.Name = "barCodeInput";
            this.barCodeInput.Size = new System.Drawing.Size(396, 60);
            this.barCodeInput.TabIndex = 4;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.White;
            this.sendEmailButton.Location = new System.Drawing.Point(17, 368);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(394, 61);
            this.sendEmailButton.TabIndex = 2;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.BackColor = System.Drawing.Color.Red;
            this.checkOutButton.Location = new System.Drawing.Point(209, 309);
            this.checkOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(201, 61);
            this.checkOutButton.TabIndex = 1;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = false;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.BackColor = System.Drawing.Color.Lime;
            this.checkInButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkInButton.Location = new System.Drawing.Point(17, 309);
            this.checkInButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(196, 61);
            this.checkInButton.TabIndex = 0;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = false;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // tonerInventory
            // 
            this.tonerInventory.Controls.Add(this.OBSInventory);
            this.tonerInventory.Controls.Add(this.OBSNonInventory);
            this.tonerInventory.Location = new System.Drawing.Point(445, 11);
            this.tonerInventory.Margin = new System.Windows.Forms.Padding(2);
            this.tonerInventory.Name = "tonerInventory";
            this.tonerInventory.SelectedIndex = 0;
            this.tonerInventory.Size = new System.Drawing.Size(485, 548);
            this.tonerInventory.TabIndex = 1;
            // 
            // OBSInventory
            // 
            this.OBSInventory.Controls.Add(this.OBSDataGridView);
            this.OBSInventory.Location = new System.Drawing.Point(4, 22);
            this.OBSInventory.Margin = new System.Windows.Forms.Padding(2);
            this.OBSInventory.Name = "OBSInventory";
            this.OBSInventory.Padding = new System.Windows.Forms.Padding(2);
            this.OBSInventory.Size = new System.Drawing.Size(477, 522);
            this.OBSInventory.TabIndex = 0;
            this.OBSInventory.Text = "OBS";
            this.OBSInventory.UseVisualStyleBackColor = true;
            this.OBSInventory.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // OBSDataGridView
            // 
            this.OBSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OBSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OBSDataGridView.Location = new System.Drawing.Point(2, 2);
            this.OBSDataGridView.Name = "OBSDataGridView";
            this.OBSDataGridView.Size = new System.Drawing.Size(473, 518);
            this.OBSDataGridView.TabIndex = 0;
            this.OBSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OBSDataGridView_CellContentClick);
            // 
            // OBSNonInventory
            // 
            this.OBSNonInventory.Controls.Add(this.NonOBSDataGridView);
            this.OBSNonInventory.Location = new System.Drawing.Point(4, 22);
            this.OBSNonInventory.Margin = new System.Windows.Forms.Padding(2);
            this.OBSNonInventory.Name = "OBSNonInventory";
            this.OBSNonInventory.Padding = new System.Windows.Forms.Padding(2);
            this.OBSNonInventory.Size = new System.Drawing.Size(477, 522);
            this.OBSNonInventory.TabIndex = 1;
            this.OBSNonInventory.Text = "Non-OBS";
            this.OBSNonInventory.UseVisualStyleBackColor = true;
            this.OBSNonInventory.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // NonOBSDataGridView
            // 
            this.NonOBSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NonOBSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NonOBSDataGridView.Location = new System.Drawing.Point(2, 2);
            this.NonOBSDataGridView.Name = "NonOBSDataGridView";
            this.NonOBSDataGridView.Size = new System.Drawing.Size(473, 518);
            this.NonOBSDataGridView.TabIndex = 0;
            this.NonOBSDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 566);
            this.Controls.Add(this.tonerInventory);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "inventoryForm";
            this.Text = "DAT Toner Inventory";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tonerInventory.ResumeLayout(false);
            this.OBSInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OBSDataGridView)).EndInit();
            this.OBSNonInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NonOBSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.TabControl tonerInventory;
        private System.Windows.Forms.TabPage OBSInventory;
        private System.Windows.Forms.TabPage OBSNonInventory;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.TextBox barCodeInput;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label barcodeNumberScanner;
        private System.Windows.Forms.DataGridView OBSDataGridView;
        private System.Windows.Forms.DataGridView NonOBSDataGridView;
    }
}