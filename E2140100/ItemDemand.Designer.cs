namespace E2140100
{
    partial class ItemDemand
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
            this.groupBoxItemDemand = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DemandChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxItemDemand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemandChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxItemDemand
            // 
            this.groupBoxItemDemand.BackgroundImage = global::E2140100.Properties.Resources._1892382;
            this.groupBoxItemDemand.Controls.Add(this.label2);
            this.groupBoxItemDemand.Controls.Add(this.label1);
            this.groupBoxItemDemand.Controls.Add(this.dateTimePicker1);
            this.groupBoxItemDemand.Controls.Add(this.dateTimePicker2);
            this.groupBoxItemDemand.Controls.Add(this.btnReset);
            this.groupBoxItemDemand.Controls.Add(this.btnExit);
            this.groupBoxItemDemand.Controls.Add(this.btnSort);
            this.groupBoxItemDemand.Location = new System.Drawing.Point(12, 12);
            this.groupBoxItemDemand.Name = "groupBoxItemDemand";
            this.groupBoxItemDemand.Size = new System.Drawing.Size(254, 208);
            this.groupBoxItemDemand.TabIndex = 0;
            this.groupBoxItemDemand.TabStop = false;
            this.groupBoxItemDemand.Text = "Item Demand";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(11, 160);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(92, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(173, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(48, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Form :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To :";
            // 
            // DemandChart
            // 
            chartArea2.Name = "ChartArea1";
            this.DemandChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DemandChart.Legends.Add(legend2);
            this.DemandChart.Location = new System.Drawing.Point(391, 12);
            this.DemandChart.Name = "DemandChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "qty";
            this.DemandChart.Series.Add(series2);
            this.DemandChart.Size = new System.Drawing.Size(473, 368);
            this.DemandChart.TabIndex = 1;
            this.DemandChart.Text = "chart1";
            // 
            // ItemDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E2140100.Properties.Resources._1892382;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 436);
            this.Controls.Add(this.DemandChart);
            this.Controls.Add(this.groupBoxItemDemand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemDemand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Demand";
            this.Load += new System.EventHandler(this.ItemDemand_Load);
            this.groupBoxItemDemand.ResumeLayout(false);
            this.groupBoxItemDemand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemandChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxItemDemand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart DemandChart;
    }
}