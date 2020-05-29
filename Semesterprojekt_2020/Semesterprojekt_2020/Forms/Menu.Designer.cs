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
            this.verdensur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Medarbejdere
            // 
            this.Medarbejdere.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Medarbejdere.Location = new System.Drawing.Point(106, 64);
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
            this.Kunder.Location = new System.Drawing.Point(106, 123);
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
            this.Sager.Location = new System.Drawing.Point(106, 183);
            this.Sager.Margin = new System.Windows.Forms.Padding(0);
            this.Sager.Name = "Sager";
            this.Sager.Size = new System.Drawing.Size(100, 50);
            this.Sager.TabIndex = 2;
            this.Sager.Text = "Sager";
            this.Sager.UseVisualStyleBackColor = true;
            this.Sager.Click += new System.EventHandler(this.Sager_Click);
            // 
            // verdensur
            // 
            this.verdensur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.verdensur.Location = new System.Drawing.Point(106, 243);
            this.verdensur.Margin = new System.Windows.Forms.Padding(0);
            this.verdensur.Name = "verdensur";
            this.verdensur.Size = new System.Drawing.Size(100, 50);
            this.verdensur.TabIndex = 3;
            this.verdensur.Text = "Verdensur";
            this.verdensur.UseVisualStyleBackColor = true;
            this.verdensur.Click += new System.EventHandler(this.verdensur_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 338);
            this.Controls.Add(this.verdensur);
            this.Controls.Add(this.Sager);
            this.Controls.Add(this.Kunder);
            this.Controls.Add(this.Medarbejdere);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Medarbejdere;
        private System.Windows.Forms.Button Kunder;
        private System.Windows.Forms.Button Sager;
        private System.Windows.Forms.Button verdensur;
    }
}

