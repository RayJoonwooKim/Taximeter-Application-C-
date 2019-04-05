namespace Taximeter_Application
{
    partial class frmFillUpGas
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
            this.txtGas = new System.Windows.Forms.TextBox();
            this.btnFill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gas in Litres : ";
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(148, 116);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(59, 20);
            this.txtGas.TabIndex = 1;
            this.txtGas.TextChanged += new System.EventHandler(this.txtGas_TextChanged);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(102, 205);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(119, 35);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Balance : ";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(148, 35);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(35, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost : ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(148, 160);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 13);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate Gas Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current Gas : ";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Location = new System.Drawing.Point(148, 72);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(35, 13);
            this.lblGas.TabIndex = 10;
            this.lblGas.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "L";
            // 
            // frmFillUpGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 270);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmFillUpGas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill Up Gas";
            this.Load += new System.EventHandler(this.frmFillUpGas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label label7;
    }
}