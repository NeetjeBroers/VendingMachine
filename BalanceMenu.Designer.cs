namespace VendingMachien
{
    partial class BalanceMenu
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
            this.buttonRefundBalance = new System.Windows.Forms.Button();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.labelCurrentBalanceValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRefundBalance
            // 
            this.buttonRefundBalance.Location = new System.Drawing.Point(413, 462);
            this.buttonRefundBalance.Name = "buttonRefundBalance";
            this.buttonRefundBalance.Size = new System.Drawing.Size(110, 71);
            this.buttonRefundBalance.TabIndex = 1;
            this.buttonRefundBalance.Text = "Refund Balance";
            this.buttonRefundBalance.UseVisualStyleBackColor = true;
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelCurrentBalance.Location = new System.Drawing.Point(364, 9);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(112, 31);
            this.labelCurrentBalance.TabIndex = 2;
            this.labelCurrentBalance.Text = "Balance";
            // 
            // labelCurrentBalanceValue
            // 
            this.labelCurrentBalanceValue.AutoSize = true;
            this.labelCurrentBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelCurrentBalanceValue.Location = new System.Drawing.Point(494, 9);
            this.labelCurrentBalanceValue.Name = "labelCurrentBalanceValue";
            this.labelCurrentBalanceValue.Size = new System.Drawing.Size(29, 31);
            this.labelCurrentBalanceValue.TabIndex = 3;
            this.labelCurrentBalanceValue.Text = "0";
            // 
            // BalanceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 545);
            this.Controls.Add(this.labelCurrentBalanceValue);
            this.Controls.Add(this.labelCurrentBalance);
            this.Controls.Add(this.buttonRefundBalance);
            this.Name = "BalanceMenu";
            this.Text = "Balance Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRefundBalance;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label labelCurrentBalanceValue;
    }
}