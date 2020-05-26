namespace Semesterprojekt_2020.Forms.Kunder
{
    partial class Rediger_kunde
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
            this.red_kunde = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.red_kunde_bynavn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.red_kunde_postnr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.red_kunde_navn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.red_kunde_adresse = new System.Windows.Forms.TextBox();
            this.red_kunde_tlfnr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.red_kunde_email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nu_kunde_adresse = new System.Windows.Forms.Label();
            this.nu_kunde_email = new System.Windows.Forms.Label();
            this.nu_kunde_tlfnr = new System.Windows.Forms.Label();
            this.nu_kunde_bynavn = new System.Windows.Forms.Label();
            this.nu_kunde_postnr = new System.Windows.Forms.Label();
            this.nu_kunde_navn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.Annuller.TabIndex = 32;
            this.Annuller.Text = "Annuller";
            this.Annuller.UseVisualStyleBackColor = true;
            this.Annuller.Click += new System.EventHandler(this.Annuller_Click);
            // 
            // red_kunde
            // 
            this.red_kunde.Location = new System.Drawing.Point(267, 373);
            this.red_kunde.Name = "red_kunde";
            this.red_kunde.Size = new System.Drawing.Size(100, 50);
            this.red_kunde.TabIndex = 31;
            this.red_kunde.Text = "Rediger";
            this.red_kunde.UseVisualStyleBackColor = true;
            this.red_kunde.Click += new System.EventHandler(this.red_kunde_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 331);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rediger kunde";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.red_kunde_bynavn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.red_kunde_postnr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.red_kunde_navn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.red_kunde_adresse);
            this.groupBox2.Controls.Add(this.red_kunde_tlfnr);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.red_kunde_email);
            this.groupBox2.Location = new System.Drawing.Point(420, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 275);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Redigerede kundeinfo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bynavn:";
            // 
            // red_kunde_bynavn
            // 
            this.red_kunde_bynavn.Location = new System.Drawing.Point(182, 61);
            this.red_kunde_bynavn.Name = "red_kunde_bynavn";
            this.red_kunde_bynavn.Size = new System.Drawing.Size(132, 20);
            this.red_kunde_bynavn.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Postnr:";
            // 
            // red_kunde_postnr
            // 
            this.red_kunde_postnr.Location = new System.Drawing.Point(90, 61);
            this.red_kunde_postnr.Name = "red_kunde_postnr";
            this.red_kunde_postnr.Size = new System.Drawing.Size(34, 20);
            this.red_kunde_postnr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn:";
            // 
            // red_kunde_navn
            // 
            this.red_kunde_navn.Location = new System.Drawing.Point(90, 35);
            this.red_kunde_navn.Name = "red_kunde_navn";
            this.red_kunde_navn.Size = new System.Drawing.Size(224, 20);
            this.red_kunde_navn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse:";
            // 
            // red_kunde_adresse
            // 
            this.red_kunde_adresse.Location = new System.Drawing.Point(90, 87);
            this.red_kunde_adresse.Name = "red_kunde_adresse";
            this.red_kunde_adresse.Size = new System.Drawing.Size(224, 20);
            this.red_kunde_adresse.TabIndex = 4;
            // 
            // red_kunde_tlfnr
            // 
            this.red_kunde_tlfnr.Location = new System.Drawing.Point(90, 139);
            this.red_kunde_tlfnr.Name = "red_kunde_tlfnr";
            this.red_kunde_tlfnr.Size = new System.Drawing.Size(224, 20);
            this.red_kunde_tlfnr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefonnummer:";
            // 
            // red_kunde_email
            // 
            this.red_kunde_email.Location = new System.Drawing.Point(90, 113);
            this.red_kunde_email.Name = "red_kunde_email";
            this.red_kunde_email.Size = new System.Drawing.Size(224, 20);
            this.red_kunde_email.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nu_kunde_adresse);
            this.groupBox1.Controls.Add(this.nu_kunde_email);
            this.groupBox1.Controls.Add(this.nu_kunde_tlfnr);
            this.groupBox1.Controls.Add(this.nu_kunde_bynavn);
            this.groupBox1.Controls.Add(this.nu_kunde_postnr);
            this.groupBox1.Controls.Add(this.nu_kunde_navn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 275);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuværende kundeinfo";
            // 
            // nu_kunde_adresse
            // 
            this.nu_kunde_adresse.AutoSize = true;
            this.nu_kunde_adresse.Location = new System.Drawing.Point(85, 87);
            this.nu_kunde_adresse.Name = "nu_kunde_adresse";
            this.nu_kunde_adresse.Size = new System.Drawing.Size(41, 13);
            this.nu_kunde_adresse.TabIndex = 32;
            this.nu_kunde_adresse.Text = "label20";
            // 
            // nu_kunde_email
            // 
            this.nu_kunde_email.AutoSize = true;
            this.nu_kunde_email.Location = new System.Drawing.Point(85, 113);
            this.nu_kunde_email.Name = "nu_kunde_email";
            this.nu_kunde_email.Size = new System.Drawing.Size(41, 13);
            this.nu_kunde_email.TabIndex = 31;
            this.nu_kunde_email.Text = "label19";
            // 
            // nu_kunde_tlfnr
            // 
            this.nu_kunde_tlfnr.AutoSize = true;
            this.nu_kunde_tlfnr.Location = new System.Drawing.Point(85, 139);
            this.nu_kunde_tlfnr.Name = "nu_kunde_tlfnr";
            this.nu_kunde_tlfnr.Size = new System.Drawing.Size(41, 13);
            this.nu_kunde_tlfnr.TabIndex = 30;
            this.nu_kunde_tlfnr.Text = "label18";
            // 
            // nu_kunde_bynavn
            // 
            this.nu_kunde_bynavn.AutoSize = true;
            this.nu_kunde_bynavn.Location = new System.Drawing.Point(173, 61);
            this.nu_kunde_bynavn.Name = "nu_kunde_bynavn";
            this.nu_kunde_bynavn.Size = new System.Drawing.Size(41, 13);
            this.nu_kunde_bynavn.TabIndex = 29;
            this.nu_kunde_bynavn.Text = "label17";
            // 
            // nu_kunde_postnr
            // 
            this.nu_kunde_postnr.AutoSize = true;
            this.nu_kunde_postnr.Location = new System.Drawing.Point(85, 61);
            this.nu_kunde_postnr.Name = "nu_kunde_postnr";
            this.nu_kunde_postnr.Size = new System.Drawing.Size(41, 13);
            this.nu_kunde_postnr.TabIndex = 28;
            this.nu_kunde_postnr.Text = "label16";
            // 
            // nu_kunde_navn
            // 
            this.nu_kunde_navn.AutoSize = true;
            this.nu_kunde_navn.Location = new System.Drawing.Point(85, 35);
            this.nu_kunde_navn.Name = "nu_kunde_navn";
            this.nu_kunde_navn.Size = new System.Drawing.Size(33, 13);
            this.nu_kunde_navn.TabIndex = 27;
            this.nu_kunde_navn.Text = "Navn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Bynavn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Navn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Postnr:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Telefonnummer:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Adresse:";
            // 
            // Rediger_kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Annuller);
            this.Controls.Add(this.red_kunde);
            this.Controls.Add(this.groupBox3);
            this.Name = "Rediger_kunde";
            this.Text = "Rediger_kunde";
            this.Load += new System.EventHandler(this.Rediger_kunde_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Annuller;
        private System.Windows.Forms.Button red_kunde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox red_kunde_tlfnr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox red_kunde_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox red_kunde_adresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox red_kunde_navn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox red_kunde_bynavn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox red_kunde_postnr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label nu_kunde_adresse;
        private System.Windows.Forms.Label nu_kunde_email;
        private System.Windows.Forms.Label nu_kunde_tlfnr;
        private System.Windows.Forms.Label nu_kunde_bynavn;
        private System.Windows.Forms.Label nu_kunde_postnr;
        private System.Windows.Forms.Label nu_kunde_navn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
    }
}