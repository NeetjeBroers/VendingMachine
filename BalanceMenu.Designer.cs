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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonRefundBalance
            // 
            this.buttonRefundBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.buttonRefundBalance.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonRefundBalance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRefundBalance.FlatAppearance.BorderSize = 5;
            this.buttonRefundBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefundBalance.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefundBalance.Location = new System.Drawing.Point(620, 711);
            this.buttonRefundBalance.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefundBalance.Name = "buttonRefundBalance";
            this.buttonRefundBalance.Size = new System.Drawing.Size(165, 109);
            this.buttonRefundBalance.TabIndex = 1;
            this.buttonRefundBalance.Text = "Refund Balance";
            this.buttonRefundBalance.UseVisualStyleBackColor = false;
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentBalance.Location = new System.Drawing.Point(546, 14);
            this.labelCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(167, 49);
            this.labelCurrentBalance.TabIndex = 2;
            this.labelCurrentBalance.Text = "Balance";
            // 
            // labelCurrentBalanceValue
            // 
            this.labelCurrentBalanceValue.AutoSize = true;
            this.labelCurrentBalanceValue.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentBalanceValue.Location = new System.Drawing.Point(741, 14);
            this.labelCurrentBalanceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentBalanceValue.Name = "labelCurrentBalanceValue";
            this.labelCurrentBalanceValue.Size = new System.Drawing.Size(45, 49);
            this.labelCurrentBalanceValue.TabIndex = 3;
            this.labelCurrentBalanceValue.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.panel1.Location = new System.Drawing.Point(18, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 806);
            this.panel1.TabIndex = 4;
            // 
            // BalanceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(111)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(840, 838);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCurrentBalanceValue);
            this.Controls.Add(this.labelCurrentBalance);
            this.Controls.Add(this.buttonRefundBalance);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BalanceMenu";
            this.Text = "Balance Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRefundBalance;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Label labelCurrentBalanceValue;
        private System.Windows.Forms.Panel panel1;
    }
}