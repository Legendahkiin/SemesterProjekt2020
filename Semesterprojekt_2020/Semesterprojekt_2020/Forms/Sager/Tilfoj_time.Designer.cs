namespace Semesterprojekt_2020.Forms.Sager
{
    partial class Tilfoj_time
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.time_anuller = new System.Windows.Forms.Button();
            this.time_opr = new System.Windows.Forms.Button();
            this.time_valg_advokat = new System.Windows.Forms.Button();
            this.time_advokatid = new System.Windows.Forms.Label();
            this.time_advokat_navn = new System.Windows.Forms.Label();
            this.time_ydelse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time_antalkm = new System.Windows.Forms.TextBox();
            this.time_antaltimer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antal timer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.time_anuller);
            this.groupBox1.Controls.Add(this.time_opr);
            this.groupBox1.Controls.Add(this.time_valg_advokat);
            this.groupBox1.Controls.Add(this.time_advokatid);
            this.groupBox1.Controls.Add(this.time_advokat_navn);
            this.groupBox1.Controls.Add(this.time_ydelse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.time_antalkm);
            this.groupBox1.Controls.Add(this.time_antaltimer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 240);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tilføj timer til sag";
            // 
            // time_anuller
            // 
            this.time_anuller.Location = new System.Drawing.Point(164, 184);
            this.time_anuller.Name = "time_anuller";
            this.time_anuller.Size = new System.Drawing.Size(100, 50);
            this.time_anuller.TabIndex = 39;
            this.time_anuller.Text = "Anuller";
            this.time_anuller.UseVisualStyleBackColor = true;
            // 
            // time_opr
            // 
            this.time_opr.Location = new System.Drawing.Point(58, 184);
            this.time_opr.Name = "time_opr";
            this.time_opr.Size = new System.Drawing.Size(100, 50);
            this.time_opr.TabIndex = 38;
            this.time_opr.Text = "Opret";
            this.time_opr.UseVisualStyleBackColor = true;
            this.time_opr.Click += new System.EventHandler(this.time_opr_Click);
            // 
            // time_valg_advokat
            // 
            this.time_valg_advokat.Location = new System.Drawing.Point(223, 35);
            this.time_valg_advokat.Name = "time_valg_advokat";
            this.time_valg_advokat.Size = new System.Drawing.Size(97, 20);
            this.time_valg_advokat.TabIndex = 12;
            this.time_valg_advokat.Text = "Vælg advokat...";
            this.time_valg_advokat.UseVisualStyleBackColor = true;
            this.time_valg_advokat.Click += new System.EventHandler(this.time_valg_advokat_Click);
            // 
            // time_advokatid
            // 
            this.time_advokatid.AutoSize = true;
            this.time_advokatid.Location = new System.Drawing.Point(6, 16);
            this.time_advokatid.Name = "time_advokatid";
            this.time_advokatid.Size = new System.Drawing.Size(0, 13);
            this.time_advokatid.TabIndex = 11;
            // 
            // time_advokat_navn
            // 
            this.time_advokat_navn.AutoSize = true;
            this.time_advokat_navn.Location = new System.Drawing.Point(88, 39);
            this.time_advokat_navn.Name = "time_advokat_navn";
            this.time_advokat_navn.Size = new System.Drawing.Size(39, 13);
            this.time_advokat_navn.TabIndex = 10;
            this.time_advokat_navn.Text = "Label1";
            // 
            // time_ydelse
            // 
            this.time_ydelse.FormattingEnabled = true;
            this.time_ydelse.Items.AddRange(new object[] {
            "Arveret",
            "Ejendoms handel",
            "Forældremyndighed",
            "Inkasso",
            "Konkurs",
            "Tvangsauktion",
            "Skilsmisse",
            "Samvær"});
            this.time_ydelse.Location = new System.Drawing.Point(91, 114);
            this.time_ydelse.Name = "time_ydelse";
            this.time_ydelse.Size = new System.Drawing.Size(121, 21);
            this.time_ydelse.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Advokat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ydelse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Antal kilometer:";
            // 
            // time_antalkm
            // 
            this.time_antalkm.Location = new System.Drawing.Point(91, 88);
            this.time_antalkm.Name = "time_antalkm";
            this.time_antalkm.Size = new System.Drawing.Size(121, 20);
            this.time_antalkm.TabIndex = 3;
            // 
            // time_antaltimer
            // 
            this.time_antaltimer.Location = new System.Drawing.Point(91, 62);
            this.time_antaltimer.Name = "time_antaltimer";
            this.time_antaltimer.Size = new System.Drawing.Size(121, 20);
            this.time_antaltimer.TabIndex = 2;
            // 
            // Tilfoj_time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tilfoj_time";
            this.Text = "Tilfoj_time";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button time_valg_advokat;
        private System.Windows.Forms.Label time_advokatid;
        private System.Windows.Forms.Label time_advokat_navn;
        private System.Windows.Forms.ComboBox time_ydelse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_antalkm;
        private System.Windows.Forms.TextBox time_antaltimer;
        private System.Windows.Forms.Button time_anuller;
        private System.Windows.Forms.Button time_opr;
    }
}