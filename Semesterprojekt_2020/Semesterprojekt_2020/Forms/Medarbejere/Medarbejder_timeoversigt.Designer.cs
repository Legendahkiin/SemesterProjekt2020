namespace Semesterprojekt_2020.Forms
{
    partial class Timeregistrereing
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
            this.med_timeoversigt = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.antalKM = new System.Windows.Forms.Label();
            this.antaltimer = new System.Windows.Forms.Label();
            this.med_time_navn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fraDatoValg = new System.Windows.Forms.DateTimePicker();
            this.tilDatoValg = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.med_timeoversigt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // med_timeoversigt
            // 
            this.med_timeoversigt.AllowUserToAddRows = false;
            this.med_timeoversigt.AllowUserToDeleteRows = false;
            this.med_timeoversigt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.med_timeoversigt.Location = new System.Drawing.Point(12, 130);
            this.med_timeoversigt.Name = "med_timeoversigt";
            this.med_timeoversigt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.med_timeoversigt.Size = new System.Drawing.Size(776, 308);
            this.med_timeoversigt.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.antalKM);
            this.groupBox1.Controls.Add(this.antaltimer);
            this.groupBox1.Controls.Add(this.med_time_navn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timeregistrering for:";
            // 
            // antalKM
            // 
            this.antalKM.AutoSize = true;
            this.antalKM.Location = new System.Drawing.Point(160, 86);
            this.antalKM.Name = "antalKM";
            this.antalKM.Size = new System.Drawing.Size(76, 13);
            this.antalKM.TabIndex = 6;
            this.antalKM.Text = "Antal kilometer";
            // 
            // antaltimer
            // 
            this.antaltimer.AutoSize = true;
            this.antaltimer.Location = new System.Drawing.Point(160, 56);
            this.antaltimer.Name = "antaltimer";
            this.antaltimer.Size = new System.Drawing.Size(56, 13);
            this.antaltimer.TabIndex = 5;
            this.antaltimer.Text = "Antal timer";
            // 
            // med_time_navn
            // 
            this.med_time_navn.AutoSize = true;
            this.med_time_navn.Location = new System.Drawing.Point(160, 29);
            this.med_time_navn.Name = "med_time_navn";
            this.med_time_navn.Size = new System.Drawing.Size(33, 13);
            this.med_time_navn.TabIndex = 4;
            this.med_time_navn.Text = "Navn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tilDatoValg);
            this.groupBox2.Controls.Add(this.fraDatoValg);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(439, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vælg periode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antal kilometer i periode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antal timer i periode:";
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
            // fraDatoValg
            // 
            this.fraDatoValg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fraDatoValg.Location = new System.Drawing.Point(30, 31);
            this.fraDatoValg.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.fraDatoValg.Name = "fraDatoValg";
            this.fraDatoValg.Size = new System.Drawing.Size(125, 20);
            this.fraDatoValg.TabIndex = 4;
            this.fraDatoValg.Value = new System.DateTime(2020, 5, 27, 20, 33, 38, 0);
            this.fraDatoValg.ValueChanged += new System.EventHandler(this.fraDatoValg_ValueChanged);
            // 
            // tilDatoValg
            // 
            this.tilDatoValg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tilDatoValg.Location = new System.Drawing.Point(177, 31);
            this.tilDatoValg.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.tilDatoValg.Name = "tilDatoValg";
            this.tilDatoValg.Size = new System.Drawing.Size(125, 20);
            this.tilDatoValg.TabIndex = 5;
            this.tilDatoValg.Value = new System.DateTime(2020, 5, 27, 0, 0, 0, 0);
            this.tilDatoValg.ValueChanged += new System.EventHandler(this.tilDatoValg_ValueChanged);
            // 
            // Timeregistrereing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.med_timeoversigt);
            this.Name = "Timeregistrereing";
            this.Text = "Medarbejder timeoversigt";
            this.Load += new System.EventHandler(this.Timeregistrereing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.med_timeoversigt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView med_timeoversigt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label antalKM;
        private System.Windows.Forms.Label antaltimer;
        private System.Windows.Forms.Label med_time_navn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tilDatoValg;
        private System.Windows.Forms.DateTimePicker fraDatoValg;
    }
}