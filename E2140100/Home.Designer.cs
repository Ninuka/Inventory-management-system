namespace E2140100
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStriptxtStaff = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStriptxtItem = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriptxtOrder = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriptxtReports = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButtonReports = new System.Windows.Forms.ToolStripSplitButton();
            this.itemDemandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLogout = new System.Windows.Forms.ToolStripSplitButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriptxtStaff,
            this.toolStripSeparator1,
            this.toolStriptxtItem,
            this.toolStripSeparator2,
            this.toolStriptxtOrder,
            this.toolStripSeparator3,
            this.toolStriptxtReports,
            this.toolStripSplitButtonReports,
            this.toolStripSeparator4,
            this.toolStripLogout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStriptxtStaff
            // 
            this.toolStriptxtStaff.Name = "toolStriptxtStaff";
            this.toolStriptxtStaff.Size = new System.Drawing.Size(113, 22);
            this.toolStriptxtStaff.Text = "Staff Registration";
            this.toolStriptxtStaff.ButtonClick += new System.EventHandler(this.toolStriptxtStaff_ButtonClick);
            // 
            // toolStriptxtItem
            // 
            this.toolStriptxtItem.Name = "toolStriptxtItem";
            this.toolStriptxtItem.Size = new System.Drawing.Size(148, 22);
            this.toolStriptxtItem.Text = "Category Management ";
            this.toolStriptxtItem.ButtonClick += new System.EventHandler(this.toolStriptxtItem_ButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStriptxtOrder
            // 
            this.toolStriptxtOrder.Name = "toolStriptxtOrder";
            this.toolStriptxtOrder.Size = new System.Drawing.Size(130, 22);
            this.toolStriptxtOrder.Text = "Order Management ";
            this.toolStriptxtOrder.ButtonClick += new System.EventHandler(this.toolStriptxtOrder_ButtonClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStriptxtReports
            // 
            this.toolStriptxtReports.Name = "toolStriptxtReports";
            this.toolStriptxtReports.Size = new System.Drawing.Size(101, 22);
            this.toolStriptxtReports.Text = "Available Reports ";
            // 
            // toolStripSplitButtonReports
            // 
            this.toolStripSplitButtonReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDemandToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.toolStripSplitButtonReports.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonReports.Image")));
            this.toolStripSplitButtonReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonReports.Name = "toolStripSplitButtonReports";
            this.toolStripSplitButtonReports.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonReports.Text = "toolStripSplitButtonReports";
            // 
            // itemDemandToolStripMenuItem
            // 
            this.itemDemandToolStripMenuItem.Name = "itemDemandToolStripMenuItem";
            this.itemDemandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemDemandToolStripMenuItem.Text = "Item Demand";
            this.itemDemandToolStripMenuItem.Visible = false;
            this.itemDemandToolStripMenuItem.Click += new System.EventHandler(this.itemDemandToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.expensesToolStripMenuItem.Text = "Expenses";
            this.expensesToolStripMenuItem.Click += new System.EventHandler(this.expensesToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transactionsToolStripMenuItem.Text = "Daily Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLogout
            // 
            this.toolStripLogout.Name = "toolStripLogout";
            this.toolStripLogout.Size = new System.Drawing.Size(61, 22);
            this.toolStripLogout.Text = "Logout";
            this.toolStripLogout.ButtonClick += new System.EventHandler(this.toolStripLogout_ButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::E2140100.Properties.Resources.pastry_shop_logo_or_label_cook_is_holding_a_tray_vector_21219290;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 183);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E2140100.Properties.Resources._1892382;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(925, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonReports;
        private System.Windows.Forms.ToolStripMenuItem itemDemandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton toolStriptxtItem;
        private System.Windows.Forms.ToolStripSplitButton toolStriptxtOrder;
        private System.Windows.Forms.ToolStripLabel toolStriptxtReports;
        private System.Windows.Forms.ToolStripSplitButton toolStripLogout;
        private System.Windows.Forms.ToolStripSplitButton toolStriptxtStaff;
    }
}