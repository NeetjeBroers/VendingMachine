namespace VendingMachien
{
    partial class AdminPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSalesData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.buttonGetSalesData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesData)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSalesData
            // 
            this.chartSalesData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartSalesData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSalesData.Legends.Add(legend2);
            this.chartSalesData.Location = new System.Drawing.Point(1, 0);
            this.chartSalesData.Name = "chartSalesData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            series2.YValuesPerPoint = 4;
            this.chartSalesData.Series.Add(series2);
            this.chartSalesData.Size = new System.Drawing.Size(564, 582);
            this.chartSalesData.TabIndex = 0;
            this.chartSalesData.Text = "Sales Data";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(574, 75);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFromDate.TabIndex = 1;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerToDate.Location = new System.Drawing.Point(574, 144);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerToDate.TabIndex = 2;
            // 
            // labelFromDate
            // 
            this.labelFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Location = new System.Drawing.Point(571, 45);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(56, 13);
            this.labelFromDate.TabIndex = 3;
            this.labelFromDate.Text = "From Date";
            // 
            // labelToDate
            // 
            this.labelToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelToDate.AutoSize = true;
            this.labelToDate.Location = new System.Drawing.Point(571, 128);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(46, 13);
            this.labelToDate.TabIndex = 4;
            this.labelToDate.Text = "To Date";
            // 
            // buttonGetSalesData
            // 
            this.buttonGetSalesData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetSalesData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetSalesData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buttonGetSalesData.Location = new System.Drawing.Point(574, 201);
            this.buttonGetSalesData.Name = "buttonGetSalesData";
            this.buttonGetSalesData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGetSalesData.Size = new System.Drawing.Size(200, 68);
            this.buttonGetSalesData.TabIndex = 5;
            this.buttonGetSalesData.Text = "Get Data";
            this.buttonGetSalesData.UseVisualStyleBackColor = true;
            this.buttonGetSalesData.Click += new System.EventHandler(this.ButtonGetSalesData_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.buttonGetSalesData);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.chartSalesData);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalesData;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Button buttonGetSalesData;
    }
}