namespace VendingMachine
{
    partial class Form1
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
            this.labelFakkaGlenn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFakkaGlenn
            // 
            this.labelFakkaGlenn.AutoSize = true;
            this.labelFakkaGlenn.Location = new System.Drawing.Point(354, 165);
            this.labelFakkaGlenn.Name = "labelFakkaGlenn";
            this.labelFakkaGlenn.Size = new System.Drawing.Size(68, 13);
            this.labelFakkaGlenn.TabIndex = 0;
            this.labelFakkaGlenn.Text = "Fakka Glenn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFakkaGlenn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

