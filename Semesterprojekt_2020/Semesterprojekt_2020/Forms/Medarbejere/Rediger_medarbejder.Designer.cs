namespace Semesterprojekt_2020.Forms.Medarbejere
{
    partial class Rediger_medarbejder
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
            this.red_medarbejder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.red_med_bynavn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.red_med_postnr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.red_StillingComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.red_med_tlf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.red_med_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.red_med_adr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.red_med_navn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nu_med_navn = new System.Windows.Forms.Label();
            this.nu_med_tlf = new System.Windows.Forms.Label();
            this.nu_med_adr = new System.Windows.Forms.Label();
            this.nu_med_postnr = new System.Windows.Forms.Label();
            this.nu_med_email = new System.Windows.Forms.Label();
            this.nu_med_stilling = new System.Windows.Forms.Label();
            this.nu_med_bynavn = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Annuller
            // 
            this.Annuller.Location = new System.Drawing.Point(426, 388);
            this.Annuller.Name = "Annuller";
            this.Annuller.Size = new System.Drawing.Size(100, 50);
            this.Annuller.TabIndex = 23;
            this.Annuller.Text = "Annuller";
            this.Annuller.UseVisualStyleBackColor = true;
            this.Annuller.Click += new System.EventHandler(this.Annuller_Click);
            // 
            // red_medarbejder
            // 
            this.red_medarbejder.Location = new System.Drawing.Point(275, 388);
            this.red_medarbejder.Name = "red_medarbejder";
            this.red_medarbejder.Size = new System.Drawing.Size(100, 50);
            this.red_medarbejder.TabIndex = 22;
            this.red_medarbejder.Text = "Rediger";
            this.red_medarbejder.UseVisualStyleBackColor = true;
            this.red_medarbejder.Click += new System.EventHandler(this.red_medarbejder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 370);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rediger medarbejder";
            // 
            // red_med_bynavn
            // 
            this.red_med_bynavn.Location = new System.Drawing.Point(186, 131);
            this.red_med_bynavn.Name = "red_med_bynavn";
            this.red_med_bynavn.Size = new System.Drawing.Size(156, 20);
            this.red_med_bynavn.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bynavn:";
            // 
            // red_med_postnr
            // 
            this.red_med_postnr.Location = new System.Drawing.Point(91, 131);
            this.red_med_postnr.Name = "red_med_postnr";
            this.red_med_postnr.Size = new System.Drawing.Size(43, 20);
            this.red_med_postnr.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Postnr:";
            // 
            // red_StillingComboBox
            // 
            this.red_StillingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.red_StillingComboBox.FormattingEnabled = true;
            this.red_StillingComboBox.Location = new System.Drawing.Point(91, 209);
            this.red_StillingComboBox.Name = "red_StillingComboBox";
            this.red_StillingComboBox.Size = new System.Drawing.Size(251, 21);
            this.red_StillingComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stilling:";
            // 
            // red_med_tlf
            // 
            this.red_med_tlf.Location = new System.Drawing.Point(91, 183);
            this.red_med_tlf.Name = "red_med_tlf";
            this.red_med_tlf.Size = new System.Drawing.Size(251, 20);
            this.red_med_tlf.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefonnummer:";
            // 
            // red_med_email
            // 
            this.red_med_email.Location = new System.Drawing.Point(91, 157);
            this.red_med_email.Name = "red_med_email";
            this.red_med_email.Size = new System.Drawing.Size(251, 20);
            this.red_med_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // red_med_adr
            // 
            this.red_med_adr.Location = new System.Drawing.Point(91, 102);
            this.red_med_adr.Name = "red_med_adr";
            this.red_med_adr.Size = new System.Drawing.Size(251, 20);
            this.red_med_adr.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse:";
            // 
            // red_med_navn
            // 
            this.red_med_navn.Location = new System.Drawing.Point(91, 76);
            this.red_med_navn.Name = "red_med_navn";
            this.red_med_navn.Size = new System.Drawing.Size(251, 20);
            this.red_med_navn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.red_med_bynavn);
            this.groupBox1.Controls.Add(this.red_med_navn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.red_med_postnr);
            this.groupBox1.Controls.Add(this.red_med_adr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.red_StillingComboBox);
            this.groupBox1.Controls.Add(this.red_med_email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.red_med_tlf);
            this.groupBox1.Location = new System.Drawing.Point(395, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 345);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rediger medarbejderinfo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Navn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Bynavn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Adresse:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Postnr:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Stilling:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Telefonnummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nu_med_bynavn);
            this.groupBox2.Controls.Add(this.nu_med_stilling);
            this.groupBox2.Controls.Add(this.nu_med_email);
            this.groupBox2.Controls.Add(this.nu_med_postnr);
            this.groupBox2.Controls.Add(this.nu_med_adr);
            this.groupBox2.Controls.Add(this.nu_med_tlf);
            this.groupBox2.Controls.Add(this.nu_med_navn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 343);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuværende medarbejderinfo";
            // 
            // nu_med_navn
            // 
            this.nu_med_navn.AutoSize = true;
            this.nu_med_navn.Location = new System.Drawing.Point(95, 77);
            this.nu_med_navn.Name = "nu_med_navn";
            this.nu_med_navn.Size = new System.Drawing.Size(41, 13);
            this.nu_med_navn.TabIndex = 27;
            this.nu_med_navn.Text = "label15";
            // 
            // nu_med_tlf
            // 
            this.nu_med_tlf.AutoSize = true;
            this.nu_med_tlf.Location = new System.Drawing.Point(95, 184);
            this.nu_med_tlf.Name = "nu_med_tlf";
            this.nu_med_tlf.Size = new System.Drawing.Size(41, 13);
            this.nu_med_tlf.TabIndex = 28;
            this.nu_med_tlf.Text = "label16";
            // 
            // nu_med_adr
            // 
            this.nu_med_adr.AutoSize = true;
            this.nu_med_adr.Location = new System.Drawing.Point(95, 103);
            this.nu_med_adr.Name = "nu_med_adr";
            this.nu_med_adr.Size = new System.Drawing.Size(41, 13);
            this.nu_med_adr.TabIndex = 29;
            this.nu_med_adr.Text = "label17";
            // 
            // nu_med_postnr
            // 
            this.nu_med_postnr.AutoSize = true;
            this.nu_med_postnr.Location = new System.Drawing.Point(95, 132);
            this.nu_med_postnr.Name = "nu_med_postnr";
            this.nu_med_postnr.Size = new System.Drawing.Size(41, 13);
            this.nu_med_postnr.TabIndex = 30;
            this.nu_med_postnr.Text = "label18";
            // 
            // nu_med_email
            // 
            this.nu_med_email.AutoSize = true;
            this.nu_med_email.Location = new System.Drawing.Point(95, 158);
            this.nu_med_email.Name = "nu_med_email";
            this.nu_med_email.Size = new System.Drawing.Size(41, 13);
            this.nu_med_email.TabIndex = 31;
            this.nu_med_email.Text = "label19";
            // 
            // nu_med_stilling
            // 
            this.nu_med_stilling.AutoSize = true;
            this.nu_med_stilling.Location = new System.Drawing.Point(95, 210);
            this.nu_med_stilling.Name = "nu_med_stilling";
            this.nu_med_stilling.Size = new System.Drawing.Size(41, 13);
            this.nu_med_stilling.TabIndex = 32;
            this.nu_med_stilling.Text = "label20";
            // 
            // nu_med_bynavn
            // 
            this.nu_med_bynavn.AutoSize = true;
            this.nu_med_bynavn.Location = new System.Drawing.Point(198, 132);
            this.nu_med_bynavn.Name = "nu_med_bynavn";
            this.nu_med_bynavn.Size = new System.Drawing.Size(41, 13);
            this.nu_med_bynavn.TabIndex = 33;
            this.nu_med_bynavn.Text = "label21";
            // 
            // Rediger_medarbejder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Annuller);
            this.Controls.Add(this.red_medarbejder);
            this.Name = "Rediger_medarbejder";
            this.Text = "Rediger medarbejder";
            this.Load += new System.EventHandler(this.Rediger_medarbejder_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Annuller;
        private System.Windows.Forms.Button red_medarbejder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox red_med_bynavn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox red_med_postnr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox red_StillingComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox red_med_tlf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox red_med_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox red_med_adr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox red_med_navn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nu_med_bynavn;
        private System.Windows.Forms.Label nu_med_stilling;
        private System.Windows.Forms.Label nu_med_email;
        private System.Windows.Forms.Label nu_med_postnr;
        private System.Windows.Forms.Label nu_med_adr;
        private System.Windows.Forms.Label nu_med_tlf;
        private System.Windows.Forms.Label nu_med_navn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}