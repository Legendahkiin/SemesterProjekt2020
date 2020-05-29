namespace Semesterprojekt_2020.Forms.Sager
{
    partial class Opret_sag
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
            this.Annuller = new System.Windows.Forms.Button();
            this.opr_sag = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sag_medid = new System.Windows.Forms.Label();
            this.sag_advokat_navn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valg_advokat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sag_kundeid = new System.Windows.Forms.Label();
            this.sag_kunde_navn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valg_kunde = new System.Windows.Forms.Button();
            this.sag_startdato = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.sag_esttimer_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sag_navn_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Annuller
            // 
            this.Annuller.Location = new System.Drawing.Point(418, 373);
            this.Annuller.Name = "Annuller";
            this.Annuller.Size = new System.Drawing.Size(100, 50);
            this.Annuller.TabIndex = 38;
            this.Annuller.Text = "Annuller";
            this.Annuller.UseVisualStyleBackColor = true;
            // 
            // opr_sag
            // 
            this.opr_sag.Location = new System.Drawing.Point(267, 373);
            this.opr_sag.Name = "opr_sag";
            this.opr_sag.Size = new System.Drawing.Size(100, 50);
            this.opr_sag.TabIndex = 37;
            this.opr_sag.Text = "Opret";
            this.opr_sag.UseVisualStyleBackColor = true;
            this.opr_sag.Click += new System.EventHandler(this.opr_sag_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.sag_startdato);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.sag_esttimer_txt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.sag_navn_txt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(52, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 331);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opret sag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sag_medid);
            this.groupBox2.Controls.Add(this.sag_advokat_navn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.valg_advokat);
            this.groupBox2.Location = new System.Drawing.Point(381, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vælg advokat";
            // 
            // sag_medid
            // 
            this.sag_medid.AutoSize = true;
            this.sag_medid.Location = new System.Drawing.Point(261, 27);
            this.sag_medid.Name = "sag_medid";
            this.sag_medid.Size = new System.Drawing.Size(0, 13);
            this.sag_medid.TabIndex = 18;
            // 
            // sag_advokat_navn
            // 
            this.sag_advokat_navn.AutoSize = true;
            this.sag_advokat_navn.Location = new System.Drawing.Point(62, 27);
            this.sag_advokat_navn.Name = "sag_advokat_navn";
            this.sag_advokat_navn.Size = new System.Drawing.Size(0, 13);
            this.sag_advokat_navn.TabIndex = 17;
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
            // valg_advokat
            // 
            this.valg_advokat.Location = new System.Drawing.Point(204, 65);
            this.valg_advokat.Name = "valg_advokat";
            this.valg_advokat.Size = new System.Drawing.Size(92, 29);
            this.valg_advokat.TabIndex = 12;
            this.valg_advokat.Text = "Vælg advokat...";
            this.valg_advokat.UseVisualStyleBackColor = true;
            this.valg_advokat.Click += new System.EventHandler(this.valg_advokat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sag_kundeid);
            this.groupBox1.Controls.Add(this.sag_kunde_navn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.valg_kunde);
            this.groupBox1.Location = new System.Drawing.Point(381, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vælg kunde";
            // 
            // sag_kundeid
            // 
            this.sag_kundeid.AutoSize = true;
            this.sag_kundeid.Location = new System.Drawing.Point(261, 27);
            this.sag_kundeid.Name = "sag_kundeid";
            this.sag_kundeid.Size = new System.Drawing.Size(0, 13);
            this.sag_kundeid.TabIndex = 19;
            // 
            // sag_kunde_navn
            // 
            this.sag_kunde_navn.AutoSize = true;
            this.sag_kunde_navn.Location = new System.Drawing.Point(62, 27);
            this.sag_kunde_navn.Name = "sag_kunde_navn";
            this.sag_kunde_navn.Size = new System.Drawing.Size(0, 13);
            this.sag_kunde_navn.TabIndex = 16;
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
            // valg_kunde
            // 
            this.valg_kunde.Location = new System.Drawing.Point(204, 65);
            this.valg_kunde.Name = "valg_kunde";
            this.valg_kunde.Size = new System.Drawing.Size(92, 29);
            this.valg_kunde.TabIndex = 11;
            this.valg_kunde.Text = "Vælg kunde...";
            this.valg_kunde.UseVisualStyleBackColor = true;
            this.valg_kunde.Click += new System.EventHandler(this.valg_kunde_Click);
            // 
            // sag_startdato
            // 
            this.sag_startdato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sag_startdato.Location = new System.Drawing.Point(160, 95);
            this.sag_startdato.Name = "sag_startdato";
            this.sag_startdato.Size = new System.Drawing.Size(155, 20);
            this.sag_startdato.TabIndex = 9;
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
            // sag_esttimer_txt
            // 
            this.sag_esttimer_txt.Location = new System.Drawing.Point(160, 69);
            this.sag_esttimer_txt.Name = "sag_esttimer_txt";
            this.sag_esttimer_txt.Size = new System.Drawing.Size(155, 20);
            this.sag_esttimer_txt.TabIndex = 2;
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
            // sag_navn_txt
            // 
            this.sag_navn_txt.Location = new System.Drawing.Point(160, 43);
            this.sag_navn_txt.Name = "sag_navn_txt";
            this.sag_navn_txt.Size = new System.Drawing.Size(155, 20);
            this.sag_navn_txt.TabIndex = 1;
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
            // Opret_sag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Annuller);
            this.Controls.Add(this.opr_sag);
            this.Controls.Add(this.groupBox3);
            this.Name = "Opret_sag";
            this.Text = "Opret Sag";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Annuller;
        private System.Windows.Forms.Button opr_sag;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sag_esttimer_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sag_navn_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sag_advokat_navn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button valg_advokat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sag_kunde_navn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button valg_kunde;
        private System.Windows.Forms.DateTimePicker sag_startdato;
        private System.Windows.Forms.Label sag_medid;
        private System.Windows.Forms.Label sag_kundeid;
    }
}