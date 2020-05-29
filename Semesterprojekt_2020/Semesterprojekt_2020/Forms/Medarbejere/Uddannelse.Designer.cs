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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.navn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_fjern_udd = new System.Windows.Forms.ComboBox();
            this.nu_udd = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_tilfoj_udd = new System.Windows.Forms.ComboBox();
            this.tilg_udd = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combobox_fjern_udd);
            this.groupBox1.Controls.Add(this.nu_udd);
            this.groupBox1.Location = new System.Drawing.Point(106, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 346);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuværende uddannelse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fjern uddannelse:";
            // 
            // combobox_fjern_udd
            // 
            this.combobox_fjern_udd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_fjern_udd.FormattingEnabled = true;
            this.combobox_fjern_udd.Location = new System.Drawing.Point(6, 40);
            this.combobox_fjern_udd.Name = "combobox_fjern_udd";
            this.combobox_fjern_udd.Size = new System.Drawing.Size(212, 21);
            this.combobox_fjern_udd.TabIndex = 1;
            this.combobox_fjern_udd.SelectionChangeCommitted += new System.EventHandler(this.combobox_fjern_udd_SelectionChangeCommitted);
            // 
            // nu_udd
            // 
            this.nu_udd.FormattingEnabled = true;
            this.nu_udd.Location = new System.Drawing.Point(6, 76);
            this.nu_udd.Name = "nu_udd";
            this.nu_udd.Size = new System.Drawing.Size(212, 264);
            this.nu_udd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.combobox_tilfoj_udd);
            this.groupBox2.Controls.Add(this.tilg_udd);
            this.groupBox2.Location = new System.Drawing.Point(467, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 346);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tilgængelig uddannelse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tilføj uddannelse:";
            // 
            // combobox_tilfoj_udd
            // 
            this.combobox_tilfoj_udd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_tilfoj_udd.FormattingEnabled = true;
            this.combobox_tilfoj_udd.Location = new System.Drawing.Point(6, 40);
            this.combobox_tilfoj_udd.Name = "combobox_tilfoj_udd";
            this.combobox_tilfoj_udd.Size = new System.Drawing.Size(212, 21);
            this.combobox_tilfoj_udd.TabIndex = 2;
            this.combobox_tilfoj_udd.SelectionChangeCommitted += new System.EventHandler(this.combobox_tilfoj_udd_SelectionChangeCommitted);
            // 
            // tilg_udd
            // 
            this.tilg_udd.FormattingEnabled = true;
            this.tilg_udd.Location = new System.Drawing.Point(6, 76);
            this.tilg_udd.Name = "tilg_udd";
            this.tilg_udd.Size = new System.Drawing.Size(212, 264);
            this.tilg_udd.TabIndex = 1;
            // 
            // Uddannelse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Uddannelse";
            this.Text = "Rediger uddannelse";
            this.Load += new System.EventHandler(this.Uddannelse_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label navn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_fjern_udd;
        private System.Windows.Forms.ListBox nu_udd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_tilfoj_udd;
        private System.Windows.Forms.ListBox tilg_udd;
    }
}