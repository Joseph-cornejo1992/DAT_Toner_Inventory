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
            this.OBSNonInventory = new System.Windows.Forms.TabPage();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.tonerInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Controls.Add(this.inventoryButton);
            this.mainPanel.Controls.Add(this.barcodeNumberScanner);
            this.mainPanel.Controls.Add(this.quantityLabel);
            this.mainPanel.Controls.Add(this.quantityText);
            this.mainPanel.Controls.Add(this.barCodeInput);
            this.mainPanel.Controls.Add(this.sendEmailButton);
            this.mainPanel.Controls.Add(this.checkOutButton);
            this.mainPanel.Controls.Add(this.checkInButton);
            this.mainPanel.Location = new System.Drawing.Point(12, 21);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 1011);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // barcodeNumberScanner
            // 
            this.barcodeNumberScanner.AutoSize = true;
            this.barcodeNumberScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeNumberScanner.Location = new System.Drawing.Point(194, 154);
            this.barcodeNumberScanner.Name = "barcodeNumberScanner";
            this.barcodeNumberScanner.Size = new System.Drawing.Size(417, 59);
            this.barcodeNumberScanner.TabIndex = 7;
            this.barcodeNumberScanner.Text = "Barcode Scanner";
            this.barcodeNumberScanner.Click += new System.EventHandler(this.label1_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(268, 406);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(228, 59);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityText
            // 
            this.quantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.Location = new System.Drawing.Point(505, 372);
            this.quantityText.Multiline = true;
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(248, 93);
            this.quantityText.TabIndex = 5;
            // 
            // barCodeInput
            // 
            this.barCodeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barCodeInput.Location = new System.Drawing.Point(31, 226);
            this.barCodeInput.Multiline = true;
            this.barCodeInput.Name = "barCodeInput";
            this.barCodeInput.Size = new System.Drawing.Size(722, 108);
            this.barCodeInput.TabIndex = 4;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.White;
            this.sendEmailButton.Location = new System.Drawing.Point(31, 679);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(722, 112);
            this.sendEmailButton.TabIndex = 2;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.BackColor = System.Drawing.Color.Red;
            this.checkOutButton.Location = new System.Drawing.Point(384, 570);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(369, 112);
            this.checkOutButton.TabIndex = 1;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = false;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.BackColor = System.Drawing.Color.Lime;
            this.checkInButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkInButton.Location = new System.Drawing.Point(31, 570);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(359, 112);
            this.checkInButton.TabIndex = 0;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = false;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // tonerInventory
            // 
            this.tonerInventory.Controls.Add(this.OBSInventory);
            this.tonerInventory.Controls.Add(this.OBSNonInventory);
            this.tonerInventory.Location = new System.Drawing.Point(815, 21);
            this.tonerInventory.Name = "tonerInventory";
            this.tonerInventory.SelectedIndex = 0;
            this.tonerInventory.Size = new System.Drawing.Size(890, 1011);
            this.tonerInventory.TabIndex = 1;
            // 
            // OBSInventory
            // 
            this.OBSInventory.Location = new System.Drawing.Point(4, 33);
            this.OBSInventory.Name = "OBSInventory";
            this.OBSInventory.Padding = new System.Windows.Forms.Padding(3);
            this.OBSInventory.Size = new System.Drawing.Size(882, 974);
            this.OBSInventory.TabIndex = 0;
            this.OBSInventory.Text = "OBS";
            this.OBSInventory.UseVisualStyleBackColor = true;
            this.OBSInventory.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // OBSNonInventory
            // 
            this.OBSNonInventory.Location = new System.Drawing.Point(4, 33);
            this.OBSNonInventory.Name = "OBSNonInventory";
            this.OBSNonInventory.Padding = new System.Windows.Forms.Padding(3);
            this.OBSNonInventory.Size = new System.Drawing.Size(882, 974);
            this.OBSNonInventory.TabIndex = 1;
            this.OBSNonInventory.Text = "Non-OBS";
            this.OBSNonInventory.UseVisualStyleBackColor = true;
            this.OBSNonInventory.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(446, 943);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(337, 67);
            this.inventoryButton.TabIndex = 8;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 1044);
            this.Controls.Add(this.tonerInventory);
            this.Controls.Add(this.mainPanel);
            this.Name = "inventoryForm";
            this.Text = "DAT Toner Inventory";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tonerInventory.ResumeLayout(false);
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
        private System.Windows.Forms.Button inventoryButton;
    }
}