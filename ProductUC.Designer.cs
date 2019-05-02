namespace VendingMachien
{
    partial class ProductUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(-3, 284);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(64, 13);
            this.labelProductPrice.TabIndex = 1;
            this.labelProductPrice.Text = "Price € 2,00";
            // 
            // labelProductStock
            // 
            this.labelProductStock.AutoSize = true;
            this.labelProductStock.Location = new System.Drawing.Point(100, 284);
            this.labelProductStock.Name = "labelProductStock";
            this.labelProductStock.Size = new System.Drawing.Size(50, 13);
            this.labelProductStock.TabIndex = 2;
            this.labelProductStock.Text = "Stock 10";
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelProductStock);
            this.Controls.Add(this.labelProductPrice);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(150, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelProductPrice;
        public System.Windows.Forms.Label labelProductStock;
    }
}
