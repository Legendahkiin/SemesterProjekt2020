namespace Semesterprojekt_2020.Forms
{
    partial class Uddannelse
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
            this.nu_udd = new System.Windows.Forms.ListBox();
            this.tilg_udd = new System.Windows.Forms.ListBox();
            this.flyt_hojre = new System.Windows.Forms.Button();
            this.flyt_venstre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.navn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nu_udd
            // 
            this.nu_udd.FormattingEnabled = true;
            this.nu_udd.Items.AddRange(new object[] {
            "Bolighandel",
            "Skilsmisse"});
            this.nu_udd.Location = new System.Drawing.Point(107, 111);
            this.nu_udd.Name = "nu_udd";
            this.nu_udd.Size = new System.Drawing.Size(224, 303);
            this.nu_udd.TabIndex = 1;
            // 
            // tilg_udd
            // 
            this.tilg_udd.FormattingEnabled = true;
            this.tilg_udd.Items.AddRange(new object[] {
            "Samvær",
            "Forældremyndighed"});
            this.tilg_udd.Location = new System.Drawing.Point(468, 111);
            this.tilg_udd.Name = "tilg_udd";
            this.tilg_udd.Size = new System.Drawing.Size(224, 303);
            this.tilg_udd.TabIndex = 1;
            // 
            // flyt_hojre
            // 
            this.flyt_hojre.Location = new System.Drawing.Point(383, 197);
            this.flyt_hojre.Name = "flyt_hojre";
            this.flyt_hojre.Size = new System.Drawing.Size(37, 37);
            this.flyt_hojre.TabIndex = 2;
            this.flyt_hojre.Text = ">";
            this.flyt_hojre.UseVisualStyleBackColor = true;
            // 
            // flyt_venstre
            // 
            this.flyt_venstre.Location = new System.Drawing.Point(383, 271);
            this.flyt_venstre.Name = "flyt_venstre";
            this.flyt_venstre.Size = new System.Drawing.Size(37, 37);
            this.flyt_venstre.TabIndex = 3;
            this.flyt_venstre.Text = "<";
            this.flyt_venstre.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(107, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuværende uddannelse";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(468, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tilgængelig uddannelse";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.navn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uddannelse for:";
            // 
            // navn
            // 
            this.navn.AutoSize = true;
            this.navn.Location = new System.Drawing.Point(106, 29);
            this.navn.Name = "navn";
            this.navn.Size = new System.Drawing.Size(33, 13);
            this.navn.TabIndex = 4;
            this.navn.Text = "Navn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn:";
            // 
            // Uddannelse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.flyt_venstre);
            this.Controls.Add(this.flyt_hojre);
            this.Controls.Add(this.tilg_udd);
            this.Controls.Add(this.nu_udd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Uddannelse";
            this.Text = "Uddannelse";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox nu_udd;
        private System.Windows.Forms.ListBox tilg_udd;
        private System.Windows.Forms.Button flyt_hojre;
        private System.Windows.Forms.Button flyt_venstre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label navn;
        private System.Windows.Forms.Label label1;
    }
}