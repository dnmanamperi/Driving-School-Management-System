﻿namespace driving_school_management_system
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.DriversBtn = new System.Windows.Forms.Button();
            this.LearnersBtn = new System.Windows.Forms.Button();
            this.VehiclesBtn = new System.Windows.Forms.Button();
            this.ScheduleBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ScheduleBtn);
            this.panel1.Controls.Add(this.VehiclesBtn);
            this.panel1.Controls.Add(this.LearnersBtn);
            this.panel1.Controls.Add(this.DriversBtn);
            this.panel1.Controls.Add(this.DashboardBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 450);
            this.panel1.TabIndex = 0;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Location = new System.Drawing.Point(3, 125);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(206, 44);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // DriversBtn
            // 
            this.DriversBtn.Location = new System.Drawing.Point(3, 175);
            this.DriversBtn.Name = "DriversBtn";
            this.DriversBtn.Size = new System.Drawing.Size(206, 44);
            this.DriversBtn.TabIndex = 1;
            this.DriversBtn.Text = "Drivers";
            this.DriversBtn.UseVisualStyleBackColor = true;
            this.DriversBtn.Click += new System.EventHandler(this.DriversBtn_Click);
            // 
            // LearnersBtn
            // 
            this.LearnersBtn.Location = new System.Drawing.Point(3, 225);
            this.LearnersBtn.Name = "LearnersBtn";
            this.LearnersBtn.Size = new System.Drawing.Size(206, 44);
            this.LearnersBtn.TabIndex = 2;
            this.LearnersBtn.Text = "Learners";
            this.LearnersBtn.UseVisualStyleBackColor = true;
            this.LearnersBtn.Click += new System.EventHandler(this.LearnersBtn_Click);
            // 
            // VehiclesBtn
            // 
            this.VehiclesBtn.Location = new System.Drawing.Point(3, 275);
            this.VehiclesBtn.Name = "VehiclesBtn";
            this.VehiclesBtn.Size = new System.Drawing.Size(206, 44);
            this.VehiclesBtn.TabIndex = 3;
            this.VehiclesBtn.Text = "Vehicles";
            this.VehiclesBtn.UseVisualStyleBackColor = true;
            this.VehiclesBtn.Click += new System.EventHandler(this.VehiclesBtn_Click);
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.Location = new System.Drawing.Point(3, 325);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(206, 44);
            this.ScheduleBtn.TabIndex = 4;
            this.ScheduleBtn.Text = "Schedule";
            this.ScheduleBtn.UseVisualStyleBackColor = true;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 116);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(212, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(704, 450);
            this.panelRight.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L Tracker Plus";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ScheduleBtn;
        private System.Windows.Forms.Button VehiclesBtn;
        private System.Windows.Forms.Button LearnersBtn;
        private System.Windows.Forms.Button DriversBtn;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRight;
    }
}