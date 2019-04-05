namespace Taximeter_Application
{
    partial class frmNetIncome
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNetIncome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Current Net Income : ";
            // 
            // lblNetIncome
            // 
            this.lblNetIncome.AutoSize = true;
            this.lblNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetIncome.Location = new System.Drawing.Point(181, 132);
            this.lblNetIncome.Name = "lblNetIncome";
            this.lblNetIncome.Size = new System.Drawing.Size(86, 31);
            this.lblNetIncome.TabIndex = 1;
            this.lblNetIncome.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            // 
            // frmNetIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNetIncome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmNetIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Net Income";
            this.Load += new System.EventHandler(this.frmNetIncome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNetIncome;
        private System.Windows.Forms.Label label2;
    }
}