namespace Semesterprojekt_2020.Forms
{
    partial class Verdensur
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
            this.components = new System.ComponentModel.Container();
            this.Lbltime = new System.Windows.Forms.Label();
            this.Lblsecond = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSanFranciscoTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbltime
            // 
            this.Lbltime.AutoSize = true;
            this.Lbltime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbltime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltime.Location = new System.Drawing.Point(3, 9);
            this.Lbltime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbltime.Name = "Lbltime";
            this.Lbltime.Size = new System.Drawing.Size(286, 110);
            this.Lbltime.TabIndex = 3;
            this.Lbltime.Text = "22:22";
            this.Lbltime.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lblsecond
            // 
            this.Lblsecond.AutoSize = true;
            this.Lblsecond.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lblsecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lblsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsecond.Location = new System.Drawing.Point(363, 50);
            this.Lblsecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblsecond.Name = "Lblsecond";
            this.Lblsecond.Size = new System.Drawing.Size(64, 46);
            this.Lblsecond.TabIndex = 2;
            this.Lblsecond.Text = "22";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(329, 128);
            this.LblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(310, 57);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "MAJ 29 2020";
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDay.Location = new System.Drawing.Point(329, 243);
            this.LblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(227, 73);
            this.LblDay.TabIndex = 4;
            this.LblDay.Text = "Fredag";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // lblSanFranciscoTime
            // 
            this.lblSanFranciscoTime.AutoSize = true;
            this.lblSanFranciscoTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSanFranciscoTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSanFranciscoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanFranciscoTime.Location = new System.Drawing.Point(11, 269);
            this.lblSanFranciscoTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSanFranciscoTime.Name = "lblSanFranciscoTime";
            this.lblSanFranciscoTime.Size = new System.Drawing.Size(286, 110);
            this.lblSanFranciscoTime.TabIndex = 7;
            this.lblSanFranciscoTime.Text = "22:22";
            // 
            // Verdensur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(699, 388);
            this.Controls.Add(this.lblSanFranciscoTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblDay);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.Lblsecond);
            this.Controls.Add(this.Lbltime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Verdensur";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Verdensur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbltime;
        private System.Windows.Forms.Label Lblsecond;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSanFranciscoTime;
    }
}

