namespace Semesterprojekt_2020.Forms.Kunder
{
    partial class Kunde_sager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kunde_sager_navn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sag_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kunde_sag_oversigt = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kunde_sag_oversigt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kunde_sager_navn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vis sager for kunde:";
            // 
            // kunde_sager_navn
            // 
            this.kunde_sager_navn.AutoSize = true;
            this.kunde_sager_navn.Location = new System.Drawing.Point(48, 59);
            this.kunde_sager_navn.Name = "kunde_sager_navn";
            this.kunde_sager_navn.Size = new System.Drawing.Size(33, 13);
            this.kunde_sager_navn.TabIndex = 4;
            this.kunde_sager_navn.Text = "Navn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sag_status);
            this.groupBox2.Location = new System.Drawing.Point(318, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vælg sagsstatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sagsstatus:";
            // 
            // sag_status
            // 
            this.sag_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sag_status.FormattingEnabled = true;
            this.sag_status.Items.AddRange(new object[] {
            "Alle",
            "Åbent",
            "Lukket"});
            this.sag_status.Location = new System.Drawing.Point(96, 37);
            this.sag_status.Name = "sag_status";
            this.sag_status.Size = new System.Drawing.Size(145, 21);
            this.sag_status.TabIndex = 0;
            this.sag_status.SelectedValueChanged += new System.EventHandler(this.sag_status_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navn:";
            // 
            // kunde_sag_oversigt
            // 
            this.kunde_sag_oversigt.AllowUserToAddRows = false;
            this.kunde_sag_oversigt.AllowUserToDeleteRows = false;
            this.kunde_sag_oversigt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kunde_sag_oversigt.Location = new System.Drawing.Point(12, 130);
            this.kunde_sag_oversigt.Name = "kunde_sag_oversigt";
            this.kunde_sag_oversigt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kunde_sag_oversigt.Size = new System.Drawing.Size(776, 308);
            this.kunde_sag_oversigt.TabIndex = 2;
            // 
            // Kunde_sager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kunde_sag_oversigt);
            this.Name = "Kunde_sager";
            this.Text = "Kunde sager";
            this.Load += new System.EventHandler(this.Kunde_sager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kunde_sag_oversigt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kunde_sager_navn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView kunde_sag_oversigt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sag_status;
    }
}