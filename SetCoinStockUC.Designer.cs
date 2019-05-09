namespace VendingMachien
{
    partial class SetStockUC
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
            this.buttonSetStock = new System.Windows.Forms.Button();
            this.textBoxNewStock = new System.Windows.Forms.TextBox();
            this.labelNewStockText = new System.Windows.Forms.Label();
            this.labelCoinText = new System.Windows.Forms.Label();
            this.labelCoinName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetStock
            // 
            this.buttonSetStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonSetStock.Location = new System.Drawing.Point(217, 158);
            this.buttonSetStock.Name = "buttonSetStock";
            this.buttonSetStock.Size = new System.Drawing.Size(157, 54);
            this.buttonSetStock.TabIndex = 0;
            this.buttonSetStock.Text = "Set Stock";
            this.buttonSetStock.UseVisualStyleBackColor = true;
            this.buttonSetStock.Click += new System.EventHandler(this.ButtonSetStock_Click);
            // 
            // textBoxNewStock
            // 
            this.textBoxNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textBoxNewStock.Location = new System.Drawing.Point(204, 83);
            this.textBoxNewStock.Name = "textBoxNewStock";
            this.textBoxNewStock.Size = new System.Drawing.Size(70, 38);
            this.textBoxNewStock.TabIndex = 1;
            // 
            // labelNewStockText
            // 
            this.labelNewStockText.AutoSize = true;
            this.labelNewStockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelNewStockText.Location = new System.Drawing.Point(32, 83);
            this.labelNewStockText.Name = "labelNewStockText";
            this.labelNewStockText.Size = new System.Drawing.Size(145, 31);
            this.labelNewStockText.TabIndex = 2;
            this.labelNewStockText.Text = "New Stock";
            // 
            // labelCoinText
            // 
            this.labelCoinText.AutoSize = true;
            this.labelCoinText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelCoinText.Location = new System.Drawing.Point(32, 31);
            this.labelCoinText.Name = "labelCoinText";
            this.labelCoinText.Size = new System.Drawing.Size(70, 31);
            this.labelCoinText.TabIndex = 3;
            this.labelCoinText.Text = "Coin";
            // 
            // labelCoinName
            // 
            this.labelCoinName.AutoSize = true;
            this.labelCoinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelCoinName.Location = new System.Drawing.Point(194, 30);
            this.labelCoinName.Name = "labelCoinName";
            this.labelCoinName.Size = new System.Drawing.Size(0, 31);
            this.labelCoinName.TabIndex = 4;
            // 
            // SetStockUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(111)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(569, 224);
            this.Controls.Add(this.labelCoinName);
            this.Controls.Add(this.labelCoinText);
            this.Controls.Add(this.labelNewStockText);
            this.Controls.Add(this.textBoxNewStock);
            this.Controls.Add(this.buttonSetStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetStockUC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetStock";
            this.Load += new System.EventHandler(this.SetStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetStock;
        private System.Windows.Forms.TextBox textBoxNewStock;
        private System.Windows.Forms.Label labelNewStockText;
        private System.Windows.Forms.Label labelCoinText;
        private System.Windows.Forms.Label labelCoinName;
    }
}