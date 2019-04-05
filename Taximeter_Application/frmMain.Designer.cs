namespace Taximeter_Application
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuNewTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.fuelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFillUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuelLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.statementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNetIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMileage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewTrip,
            this.fuelsToolStripMenuItem,
            this.statementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuNewTrip
            // 
            this.mnuNewTrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTripToolStripMenuItem,
            this.mnuViewTrip});
            this.mnuNewTrip.Name = "mnuNewTrip";
            this.mnuNewTrip.Size = new System.Drawing.Size(44, 20);
            this.mnuNewTrip.Text = "Trips";
            // 
            // newTripToolStripMenuItem
            // 
            this.newTripToolStripMenuItem.Name = "newTripToolStripMenuItem";
            this.newTripToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newTripToolStripMenuItem.Text = "New Trip";
            this.newTripToolStripMenuItem.Click += new System.EventHandler(this.newTripToolStripMenuItem_Click);
            // 
            // mnuViewTrip
            // 
            this.mnuViewTrip.Name = "mnuViewTrip";
            this.mnuViewTrip.Size = new System.Drawing.Size(127, 22);
            this.mnuViewTrip.Text = "View Trips";
            this.mnuViewTrip.Click += new System.EventHandler(this.mnuViewTrip_Click);
            // 
            // fuelsToolStripMenuItem
            // 
            this.fuelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFillUp,
            this.mnuFuelLevel});
            this.fuelsToolStripMenuItem.Name = "fuelsToolStripMenuItem";
            this.fuelsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fuelsToolStripMenuItem.Text = "Fuels";
            // 
            // mnuFillUp
            // 
            this.mnuFillUp.Name = "mnuFillUp";
            this.mnuFillUp.Size = new System.Drawing.Size(129, 22);
            this.mnuFillUp.Text = "Fill Up Gas";
            this.mnuFillUp.Click += new System.EventHandler(this.mnuFillUp_Click);
            // 
            // mnuFuelLevel
            // 
            this.mnuFuelLevel.Name = "mnuFuelLevel";
            this.mnuFuelLevel.Size = new System.Drawing.Size(129, 22);
            this.mnuFuelLevel.Text = "Fuel Level";
            this.mnuFuelLevel.Click += new System.EventHandler(this.mnuFuelLevel_Click);
            // 
            // statementToolStripMenuItem
            // 
            this.statementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNetIncome,
            this.mnuMileage});
            this.statementToolStripMenuItem.Name = "statementToolStripMenuItem";
            this.statementToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.statementToolStripMenuItem.Text = "Statement";
            // 
            // mnuNetIncome
            // 
            this.mnuNetIncome.Name = "mnuNetIncome";
            this.mnuNetIncome.Size = new System.Drawing.Size(136, 22);
            this.mnuNetIncome.Text = "Net Income";
            this.mnuNetIncome.Click += new System.EventHandler(this.mnuNetIncome_Click);
            // 
            // mnuMileage
            // 
            this.mnuMileage.Name = "mnuMileage";
            this.mnuMileage.Size = new System.Drawing.Size(136, 22);
            this.mnuMileage.Text = "Mileage";
            this.mnuMileage.Click += new System.EventHandler(this.mnuMileage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taximeter_Application.Properties.Resources.taxi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Taximeter Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNewTrip;
        private System.Windows.Forms.ToolStripMenuItem newTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewTrip;
        private System.Windows.Forms.ToolStripMenuItem fuelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFillUp;
        private System.Windows.Forms.ToolStripMenuItem mnuFuelLevel;
        private System.Windows.Forms.ToolStripMenuItem statementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNetIncome;
        private System.Windows.Forms.ToolStripMenuItem mnuMileage;
    }
}

