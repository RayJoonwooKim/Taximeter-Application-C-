namespace Taximeter_Application
{
    partial class frmNewTrip
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txt_start_time = new System.Windows.Forms.TextBox();
            this.txt_finish_time = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Finish Time : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed : ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(268, 315);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 38);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txt_start_time
            // 
            this.txt_start_time.Location = new System.Drawing.Point(133, 45);
            this.txt_start_time.Name = "txt_start_time";
            this.txt_start_time.Size = new System.Drawing.Size(89, 20);
            this.txt_start_time.TabIndex = 5;
            // 
            // txt_finish_time
            // 
            this.txt_finish_time.Location = new System.Drawing.Point(133, 100);
            this.txt_finish_time.Name = "txt_finish_time";
            this.txt_finish_time.Size = new System.Drawing.Size(89, 20);
            this.txt_finish_time.TabIndex = 7;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(133, 156);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(89, 20);
            this.txtSpeed.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "km/h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ex: 12:30 -> 12.30";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(62, 198);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(207, 38);
            this.btnEstimate.TabIndex = 13;
            this.btnEstimate.Text = "Estimate Fuel Consumption";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ex: 12:30 -> 12.30";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEstimate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_start_time);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_finish_time);
            this.groupBox1.Controls.Add(this.txtSpeed);
            this.groupBox1.Location = new System.Drawing.Point(37, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 259);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstimate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblFuel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(333, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 127);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel Information";
            // 
            // lblEstimate
            // 
            this.lblEstimate.AutoSize = true;
            this.lblEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimate.Location = new System.Drawing.Point(257, 90);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Size = new System.Drawing.Size(52, 16);
            this.lblEstimate.TabIndex = 3;
            this.lblEstimate.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Estimated Consumption (Litres) : ";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(182, 45);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(48, 16);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "lblFuel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Current Fuel (Litres)  : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMileage);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(333, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 67);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mileage";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileage.Location = new System.Drawing.Point(99, 35);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(57, 16);
            this.lblMileage.TabIndex = 15;
            this.lblMileage.Text = "mileage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mileage : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCost);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(333, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 53);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cost of Trip";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cost : ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(99, 27);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "lblCost";
            // 
            // frmNewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 377);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "frmNewTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start New Trip";
            this.Load += new System.EventHandler(this.frmNewTrip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txt_start_time;
        private System.Windows.Forms.TextBox txt_finish_time;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEstimate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label10;
    }
}