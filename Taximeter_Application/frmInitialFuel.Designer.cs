namespace Taximeter_Application
{
    partial class frmInitialFuel
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
            this.txtFuelLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFuelLevel
            // 
            this.txtFuelLevel.Location = new System.Drawing.Point(114, 41);
            this.txtFuelLevel.Name = "txtFuelLevel";
            this.txtFuelLevel.Size = new System.Drawing.Size(100, 20);
            this.txtFuelLevel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuel Level (Litres): ";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(220, 39);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // frmInitialFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 102);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuelLevel);
            this.MaximizeBox = false;
            this.Name = "frmInitialFuel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial Fuel Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuelLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFill;
    }
}