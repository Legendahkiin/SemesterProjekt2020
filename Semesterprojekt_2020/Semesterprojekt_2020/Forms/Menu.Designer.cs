namespace Semesterprojekt_2020
{
    partial class Menu
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
            this.Medarbejdere = new System.Windows.Forms.Button();
            this.Kunder = new System.Windows.Forms.Button();
            this.Sager = new System.Windows.Forms.Button();
            this.DatabaseKnap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Medarbejdere
            // 
            this.Medarbejdere.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Medarbejdere.Location = new System.Drawing.Point(9, 10);
            this.Medarbejdere.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.Medarbejdere.Name = "Medarbejdere";
            this.Medarbejdere.Size = new System.Drawing.Size(100, 50);
            this.Medarbejdere.TabIndex = 0;
            this.Medarbejdere.Text = "Medarbejdere";
            this.Medarbejdere.UseVisualStyleBackColor = true;
            this.Medarbejdere.Click += new System.EventHandler(this.Medarbejdere_Click);
            // 
            // Kunder
            // 
            this.Kunder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kunder.Location = new System.Drawing.Point(9, 69);
            this.Kunder.Margin = new System.Windows.Forms.Padding(0);
            this.Kunder.Name = "Kunder";
            this.Kunder.Size = new System.Drawing.Size(100, 50);
            this.Kunder.TabIndex = 1;
            this.Kunder.Text = "Kunder";
            this.Kunder.UseVisualStyleBackColor = true;
            this.Kunder.Click += new System.EventHandler(this.Kunder_Click);
            // 
            // Sager
            // 
            this.Sager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sager.Location = new System.Drawing.Point(9, 129);
            this.Sager.Margin = new System.Windows.Forms.Padding(0);
            this.Sager.Name = "Sager";
            this.Sager.Size = new System.Drawing.Size(100, 50);
            this.Sager.TabIndex = 2;
            this.Sager.Text = "Sager";
            this.Sager.UseVisualStyleBackColor = true;
            // 
            // DatabaseKnap
            // 
            this.DatabaseKnap.Location = new System.Drawing.Point(9, 182);
            this.DatabaseKnap.Name = "DatabaseKnap";
            this.DatabaseKnap.Size = new System.Drawing.Size(100, 42);
            this.DatabaseKnap.TabIndex = 3;
            this.DatabaseKnap.Text = "Indlæs Database";
            this.DatabaseKnap.UseVisualStyleBackColor = true;
            this.DatabaseKnap.Click += new System.EventHandler(this.DatabaseKnap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 214);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DatabaseKnap);
            this.Controls.Add(this.Sager);
            this.Controls.Add(this.Kunder);
            this.Controls.Add(this.Medarbejdere);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Medarbejdere;
        private System.Windows.Forms.Button Kunder;
        private System.Windows.Forms.Button Sager;
        private System.Windows.Forms.Button DatabaseKnap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

