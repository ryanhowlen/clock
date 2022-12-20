namespace clockk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(197, 118);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(285, 130);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "22:22";
            this.labelTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(30, 312);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(384, 67);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "October 10 2002";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDay.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDay.ForeColor = System.Drawing.Color.White;
            this.labelDay.Location = new System.Drawing.Point(488, 312);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(221, 67);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Thursday";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSec.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSec.ForeColor = System.Drawing.Color.White;
            this.labelSec.Location = new System.Drawing.Point(488, 190);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(64, 52);
            this.labelSec.TabIndex = 3;
            this.labelSec.Text = "22";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTime;
        private Label labelDate;
        private Label labelDay;
        private Label labelSec;
        private System.Windows.Forms.Timer timer;
    }
}