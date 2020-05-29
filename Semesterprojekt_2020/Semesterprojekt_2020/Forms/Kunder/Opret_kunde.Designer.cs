namespace Semesterprojekt_2020.Forms.Kunder
{
    partial class Opret_kunde
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
            this.opr_kunde = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kunde_bynavn_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kunde_adr_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kunde_tlf_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kunde_email_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kunde_postnr_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kunde_navn_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Annuller
            // 
            this.Annuller.Location = new System.Drawing.Point(418, 381);
            this.Annuller.Name = "Annuller";
            this.Annuller.Size = new System.Drawing.Size(100, 50);
            this.Annuller.TabIndex = 35;
            this.Annuller.Text = "Annuller";
            this.Annuller.UseVisualStyleBackColor = true;
            this.Annuller.Click += new System.EventHandler(this.Annuller_Click);
            // 
            // opr_kunde
            // 
            this.opr_kunde.Location = new System.Drawing.Point(267, 381);
            this.opr_kunde.Name = "opr_kunde";
            this.opr_kunde.Size = new System.Drawing.Size(100, 50);
            this.opr_kunde.TabIndex = 34;
            this.opr_kunde.Text = "Opret";
            this.opr_kunde.UseVisualStyleBackColor = true;
            this.opr_kunde.Click += new System.EventHandler(this.opr_kunde_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kunde_bynavn_txt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.kunde_adr_txt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.kunde_tlf_txt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.kunde_email_txt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.kunde_postnr_txt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.kunde_navn_txt);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(108, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 331);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opret kunde";
            // 
            // kunde_bynavn_txt
            // 
            this.kunde_bynavn_txt.Location = new System.Drawing.Point(251, 131);
            this.kunde_bynavn_txt.Name = "kunde_bynavn_txt";
            this.kunde_bynavn_txt.Size = new System.Drawing.Size(159, 20);
            this.kunde_bynavn_txt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "By:";
            // 
            // kunde_adr_txt
            // 
            this.kunde_adr_txt.Location = new System.Drawing.Point(160, 157);
            this.kunde_adr_txt.Name = "kunde_adr_txt";
            this.kunde_adr_txt.Size = new System.Drawing.Size(251, 20);
            this.kunde_adr_txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresse:";
            // 
            // kunde_tlf_txt
            // 
            this.kunde_tlf_txt.Location = new System.Drawing.Point(160, 208);
            this.kunde_tlf_txt.Name = "kunde_tlf_txt";
            this.kunde_tlf_txt.Size = new System.Drawing.Size(251, 20);
            this.kunde_tlf_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefonnummer:";
            // 
            // kunde_email_txt
            // 
            this.kunde_email_txt.Location = new System.Drawing.Point(160, 182);
            this.kunde_email_txt.Name = "kunde_email_txt";
            this.kunde_email_txt.Size = new System.Drawing.Size(251, 20);
            this.kunde_email_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // kunde_postnr_txt
            // 
            this.kunde_postnr_txt.Location = new System.Drawing.Point(160, 131);
            this.kunde_postnr_txt.Name = "kunde_postnr_txt";
            this.kunde_postnr_txt.Size = new System.Drawing.Size(47, 20);
            this.kunde_postnr_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Postnr:";
            // 
            // kunde_navn_txt
            // 
            this.kunde_navn_txt.Location = new System.Drawing.Point(160, 105);
            this.kunde_navn_txt.Name = "kunde_navn_txt";
            this.kunde_navn_txt.Size = new System.Drawing.Size(251, 20);
            this.kunde_navn_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn:";
            // 
            // Opret_kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Annuller);
            this.Controls.Add(this.opr_kunde);
            this.Controls.Add(this.groupBox3);
            this.Name = "Opret_kunde";
            this.Text = "Opret Kunde";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Annuller;
        private System.Windows.Forms.Button opr_kunde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox kunde_tlf_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kunde_email_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kunde_postnr_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kunde_navn_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kunde_adr_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kunde_bynavn_txt;
    }
}