namespace VendingMachien
{
    partial class FormVendingMachine
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.buttonAddBalance = new System.Windows.Forms.Button();
            this.labelBalanceText = new System.Windows.Forms.Label();
            this.labelCurrentBalanceValue = new System.Windows.Forms.Label();
            this.buttonRefundBalance = new System.Windows.Forms.Button();
            this.listBoxSoldProducts = new System.Windows.Forms.ListBox();
            this.labelTextProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(714, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1153, 719);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 241);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(111)))), ((int)(((byte)(164)))));
            this.panelProduct.Location = new System.Drawing.Point(8, 8);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(2);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(962, 964);
            this.panelProduct.TabIndex = 4;
            // 
            // buttonAddBalance
            // 
            this.buttonAddBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.buttonAddBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonAddBalance.Location = new System.Drawing.Point(972, 876);
            this.buttonAddBalance.Name = "buttonAddBalance";
            this.buttonAddBalance.Size = new System.Drawing.Size(151, 67);
            this.buttonAddBalance.TabIndex = 5;
            this.buttonAddBalance.Text = "Add Balance";
            this.buttonAddBalance.UseVisualStyleBackColor = false;
            this.buttonAddBalance.Click += new System.EventHandler(this.ButtonAddBalance_Click);
            // 
            // labelBalanceText
            // 
            this.labelBalanceText.AutoSize = true;
            this.labelBalanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelBalanceText.Location = new System.Drawing.Point(967, 770);
            this.labelBalanceText.Name = "labelBalanceText";
            this.labelBalanceText.Size = new System.Drawing.Size(90, 25);
            this.labelBalanceText.TabIndex = 6;
            this.labelBalanceText.Text = "Balance";
            // 
            // labelCurrentBalanceValue
            // 
            this.labelCurrentBalanceValue.AutoSize = true;
            this.labelCurrentBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelCurrentBalanceValue.Location = new System.Drawing.Point(1076, 770);
            this.labelCurrentBalanceValue.Name = "labelCurrentBalanceValue";
            this.labelCurrentBalanceValue.Size = new System.Drawing.Size(72, 25);
            this.labelCurrentBalanceValue.TabIndex = 7;
            this.labelCurrentBalanceValue.Text = "€ 0,00";
            // 
            // buttonRefundBalance
            // 
            this.buttonRefundBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefundBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.buttonRefundBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefundBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.buttonRefundBalance.Location = new System.Drawing.Point(972, 804);
            this.buttonRefundBalance.Name = "buttonRefundBalance";
            this.buttonRefundBalance.Size = new System.Drawing.Size(151, 67);
            this.buttonRefundBalance.TabIndex = 8;
            this.buttonRefundBalance.Text = "Refund Balance";
            this.buttonRefundBalance.UseVisualStyleBackColor = false;
            this.buttonRefundBalance.Click += new System.EventHandler(this.ButtonRefundBalance_Click);
            // 
            // listBoxSoldProducts
            // 
            this.listBoxSoldProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSoldProducts.FormattingEnabled = true;
            this.listBoxSoldProducts.Location = new System.Drawing.Point(975, 48);
            this.listBoxSoldProducts.Name = "listBoxSoldProducts";
            this.listBoxSoldProducts.Size = new System.Drawing.Size(218, 654);
            this.listBoxSoldProducts.TabIndex = 0;
            // 
            // labelTextProduct
            // 
            this.labelTextProduct.AutoSize = true;
            this.labelTextProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelTextProduct.Location = new System.Drawing.Point(975, 8);
            this.labelTextProduct.Name = "labelTextProduct";
            this.labelTextProduct.Size = new System.Drawing.Size(183, 31);
            this.labelTextProduct.TabIndex = 9;
            this.labelTextProduct.Text = "Products Sold";
            // 
            // FormVendingMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(111)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(1196, 972);
            this.Controls.Add(this.labelTextProduct);
            this.Controls.Add(this.listBoxSoldProducts);
            this.Controls.Add(this.buttonRefundBalance);
            this.Controls.Add(this.labelCurrentBalanceValue);
            this.Controls.Add(this.labelBalanceText);
            this.Controls.Add(this.buttonAddBalance);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVendingMachine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.FormVendingMachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Button buttonAddBalance;
        private System.Windows.Forms.Label labelBalanceText;
        public System.Windows.Forms.Label labelCurrentBalanceValue;
        private System.Windows.Forms.Button buttonRefundBalance;
        private System.Windows.Forms.ListBox listBoxSoldProducts;
        private System.Windows.Forms.Label labelTextProduct;
    }
}

