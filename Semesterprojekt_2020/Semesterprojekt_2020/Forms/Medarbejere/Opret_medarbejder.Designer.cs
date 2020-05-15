namespace Semesterprojekt_2020.Forms.Medarbejere
{
    partial class Opret_medarbejder
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
            this.flyt_venstre = new System.Windows.Forms.Button();
            this.flyt_hojre = new System.Windows.Forms.Button();
            this.tilg_udd = new System.Windows.Forms.ListBox();
            this.nu_udd = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Annuller = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flyt_venstre
            // 
            this.flyt_venstre.Location = new System.Drawing.Point(384, 297);
            this.flyt_venstre.Name = "flyt_venstre";
            this.flyt_venstre.Size = new System.Drawing.Size(37, 37);
            this.flyt_venstre.TabIndex = 9;
            this.flyt_venstre.Text = "<";
            this.flyt_venstre.UseVisualStyleBackColor = true;
            // 
            // flyt_hojre
            // 
            this.flyt_hojre.Location = new System.Drawing.Point(384, 223);
            this.flyt_hojre.Name = "flyt_hojre";
            this.flyt_hojre.Size = new System.Drawing.Size(37, 37);
            this.flyt_hojre.TabIndex = 8;
            this.flyt_hojre.Text = ">";
            this.flyt_hojre.UseVisualStyleBackColor = true;
            // 
            // tilg_udd
            // 
            this.tilg_udd.FormattingEnabled = true;
            this.tilg_udd.Items.AddRange(new object[] {
            "Samvær",
            "Forældremyndighed"});
            this.tilg_udd.Location = new System.Drawing.Point(469, 209);
            this.tilg_udd.Name = "tilg_udd";
            this.tilg_udd.Size = new System.Drawing.Size(224, 147);
            this.tilg_udd.TabIndex = 5;
            // 
            // nu_udd
            // 
            this.nu_udd.FormattingEnabled = true;
            this.nu_udd.Location = new System.Drawing.Point(108, 209);
            this.nu_udd.Name = "nu_udd";
            this.nu_udd.Size = new System.Drawing.Size(224, 147);
            this.nu_udd.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(108, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuværende uddannelse";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(469, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tilgængelig uddannelse";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(108, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 156);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opret ny medarbejder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(251, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefonnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stilling:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Opret";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Annuller
            // 
            this.Annuller.Location = new System.Drawing.Point(419, 388);
            this.Annuller.Name = "Annuller";
            this.Annuller.Size = new System.Drawing.Size(100, 50);
            this.Annuller.TabIndex = 14;
            this.Annuller.Text = "Annuller";
            this.Annuller.UseVisualStyleBackColor = true;
            // 
            // Opret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Annuller);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flyt_venstre);
            this.Controls.Add(this.flyt_hojre);
            this.Controls.Add(this.tilg_udd);
            this.Controls.Add(this.nu_udd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Opret";
            this.Text = "OpretRediger";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flyt_venstre;
        private System.Windows.Forms.Button flyt_hojre;
        private System.Windows.Forms.ListBox tilg_udd;
        private System.Windows.Forms.ListBox nu_udd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Annuller;
    }
}