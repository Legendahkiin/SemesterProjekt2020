namespace Semesterprojekt_2020.Forms.Sager
{
    partial class Rediger_sag
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
            this.red_sag_annuller = new System.Windows.Forms.Button();
            this.red_sag = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.red_sag_medid = new System.Windows.Forms.Label();
            this.red_sag_advokat_navn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.red_valg_advokat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.red_sag_kundeid = new System.Windows.Forms.Label();
            this.red_sag_kunde_navn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.red_valg_kunde = new System.Windows.Forms.Button();
            this.red_sag_startdato = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.red_sag_esttimer_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.red_sag_navn_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // red_sag_annuller
            // 
            this.red_sag_annuller.Location = new System.Drawing.Point(416, 373);
            this.red_sag_annuller.Name = "red_sag_annuller";
            this.red_sag_annuller.Size = new System.Drawing.Size(100, 50);
            this.red_sag_annuller.TabIndex = 41;
            this.red_sag_annuller.Text = "Annuller";
            this.red_sag_annuller.UseVisualStyleBackColor = true;
            this.red_sag_annuller.Click += new System.EventHandler(this.red_sag_annuller_Click);
            // 
            // red_sag
            // 
            this.red_sag.Location = new System.Drawing.Point(265, 373);
            this.red_sag.Name = "red_sag";
            this.red_sag.Size = new System.Drawing.Size(100, 50);
            this.red_sag.TabIndex = 40;
            this.red_sag.Text = "Rediger";
            this.red_sag.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.red_sag_startdato);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.red_sag_esttimer_txt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.red_sag_navn_txt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(50, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 331);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rediger sag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.red_sag_medid);
            this.groupBox2.Controls.Add(this.red_sag_advokat_navn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.red_valg_advokat);
            this.groupBox2.Location = new System.Drawing.Point(381, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vælg advokat";
            // 
            // red_sag_medid
            // 
            this.red_sag_medid.AutoSize = true;
            this.red_sag_medid.Location = new System.Drawing.Point(261, 27);
            this.red_sag_medid.Name = "red_sag_medid";
            this.red_sag_medid.Size = new System.Drawing.Size(0, 13);
            this.red_sag_medid.TabIndex = 18;
            // 
            // red_sag_advokat_navn
            // 
            this.red_sag_advokat_navn.AutoSize = true;
            this.red_sag_advokat_navn.Location = new System.Drawing.Point(62, 27);
            this.red_sag_advokat_navn.Name = "red_sag_advokat_navn";
            this.red_sag_advokat_navn.Size = new System.Drawing.Size(0, 13);
            this.red_sag_advokat_navn.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Advokat:";
            // 
            // red_valg_advokat
            // 
            this.red_valg_advokat.Location = new System.Drawing.Point(204, 65);
            this.red_valg_advokat.Name = "red_valg_advokat";
            this.red_valg_advokat.Size = new System.Drawing.Size(92, 29);
            this.red_valg_advokat.TabIndex = 12;
            this.red_valg_advokat.Text = "Vælg advokat...";
            this.red_valg_advokat.UseVisualStyleBackColor = true;
            this.red_valg_advokat.Click += new System.EventHandler(this.red_valg_advokat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.red_sag_kundeid);
            this.groupBox1.Controls.Add(this.red_sag_kunde_navn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.red_valg_kunde);
            this.groupBox1.Location = new System.Drawing.Point(381, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vælg kunde";
            // 
            // red_sag_kundeid
            // 
            this.red_sag_kundeid.AutoSize = true;
            this.red_sag_kundeid.Location = new System.Drawing.Point(261, 27);
            this.red_sag_kundeid.Name = "red_sag_kundeid";
            this.red_sag_kundeid.Size = new System.Drawing.Size(0, 13);
            this.red_sag_kundeid.TabIndex = 19;
            // 
            // red_sag_kunde_navn
            // 
            this.red_sag_kunde_navn.AutoSize = true;
            this.red_sag_kunde_navn.Location = new System.Drawing.Point(62, 27);
            this.red_sag_kunde_navn.Name = "red_sag_kunde_navn";
            this.red_sag_kunde_navn.Size = new System.Drawing.Size(0, 13);
            this.red_sag_kunde_navn.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kunde:";
            // 
            // red_valg_kunde
            // 
            this.red_valg_kunde.Location = new System.Drawing.Point(204, 65);
            this.red_valg_kunde.Name = "red_valg_kunde";
            this.red_valg_kunde.Size = new System.Drawing.Size(92, 29);
            this.red_valg_kunde.TabIndex = 11;
            this.red_valg_kunde.Text = "Vælg kunde...";
            this.red_valg_kunde.UseVisualStyleBackColor = true;
            this.red_valg_kunde.Click += new System.EventHandler(this.red_valg_kunde_Click);
            // 
            // red_sag_startdato
            // 
            this.red_sag_startdato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.red_sag_startdato.Location = new System.Drawing.Point(160, 95);
            this.red_sag_startdato.Name = "red_sag_startdato";
            this.red_sag_startdato.Size = new System.Drawing.Size(155, 20);
            this.red_sag_startdato.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start dato:";
            // 
            // red_sag_esttimer_txt
            // 
            this.red_sag_esttimer_txt.Location = new System.Drawing.Point(160, 69);
            this.red_sag_esttimer_txt.Name = "red_sag_esttimer_txt";
            this.red_sag_esttimer_txt.Size = new System.Drawing.Size(155, 20);
            this.red_sag_esttimer_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estimer timer:";
            // 
            // red_sag_navn_txt
            // 
            this.red_sag_navn_txt.Location = new System.Drawing.Point(160, 43);
            this.red_sag_navn_txt.Name = "red_sag_navn_txt";
            this.red_sag_navn_txt.Size = new System.Drawing.Size(155, 20);
            this.red_sag_navn_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sagnavn:";
            // 
            // Rediger_sag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.red_sag_annuller);
            this.Controls.Add(this.red_sag);
            this.Controls.Add(this.groupBox3);
            this.Name = "Rediger_sag";
            this.Text = "Rediger sag";
            this.Load += new System.EventHandler(this.Rediger_sag_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button red_sag_annuller;
        private System.Windows.Forms.Button red_sag;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label red_sag_medid;
        private System.Windows.Forms.Label red_sag_advokat_navn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button red_valg_advokat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label red_sag_kundeid;
        private System.Windows.Forms.Label red_sag_kunde_navn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button red_valg_kunde;
        private System.Windows.Forms.DateTimePicker red_sag_startdato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox red_sag_esttimer_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox red_sag_navn_txt;
        private System.Windows.Forms.Label label1;
    }
}