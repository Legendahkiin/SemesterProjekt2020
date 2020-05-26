namespace Semesterprojekt_2020.Forms.Kunder
{
    partial class Kunde
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
            this.red_kunde = new System.Windows.Forms.Button();
            this.slet_kunde = new System.Windows.Forms.Button();
            this.opr_kunde = new System.Windows.Forms.Button();
            this.kunde_oversigt = new System.Windows.Forms.DataGridView();
            this.vis_kunde_sager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kunde_oversigt)).BeginInit();
            this.SuspendLayout();
            // 
            // red_kunde
            // 
            this.red_kunde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.red_kunde.Location = new System.Drawing.Point(276, 373);
            this.red_kunde.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.red_kunde.Name = "red_kunde";
            this.red_kunde.Size = new System.Drawing.Size(100, 50);
            this.red_kunde.TabIndex = 11;
            this.red_kunde.Text = "Rediger";
            this.red_kunde.UseVisualStyleBackColor = true;
            this.red_kunde.Click += new System.EventHandler(this.red_kunde_Click);
            // 
            // slet_kunde
            // 
            this.slet_kunde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.slet_kunde.Location = new System.Drawing.Point(427, 373);
            this.slet_kunde.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.slet_kunde.Name = "slet_kunde";
            this.slet_kunde.Size = new System.Drawing.Size(100, 50);
            this.slet_kunde.TabIndex = 8;
            this.slet_kunde.Text = "Slet";
            this.slet_kunde.UseVisualStyleBackColor = true;
            // 
            // opr_kunde
            // 
            this.opr_kunde.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opr_kunde.Location = new System.Drawing.Point(122, 373);
            this.opr_kunde.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.opr_kunde.Name = "opr_kunde";
            this.opr_kunde.Size = new System.Drawing.Size(100, 50);
            this.opr_kunde.TabIndex = 7;
            this.opr_kunde.Text = "Opret";
            this.opr_kunde.UseVisualStyleBackColor = true;
            this.opr_kunde.Click += new System.EventHandler(this.opr_kunde_Click);
            // 
            // kunde_oversigt
            // 
            this.kunde_oversigt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kunde_oversigt.Location = new System.Drawing.Point(12, 28);
            this.kunde_oversigt.Name = "kunde_oversigt";
            this.kunde_oversigt.Size = new System.Drawing.Size(776, 322);
            this.kunde_oversigt.TabIndex = 6;
            this.kunde_oversigt.SelectionChanged += new System.EventHandler(this.kunde_oversigt_SelectionChanged);
            // 
            // vis_kunde_sager
            // 
            this.vis_kunde_sager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vis_kunde_sager.Location = new System.Drawing.Point(583, 373);
            this.vis_kunde_sager.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.vis_kunde_sager.Name = "vis_kunde_sager";
            this.vis_kunde_sager.Size = new System.Drawing.Size(100, 50);
            this.vis_kunde_sager.TabIndex = 9;
            this.vis_kunde_sager.Text = "Vis kundens sager";
            this.vis_kunde_sager.UseVisualStyleBackColor = true;
            // 
            // Kunder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.red_kunde);
            this.Controls.Add(this.vis_kunde_sager);
            this.Controls.Add(this.slet_kunde);
            this.Controls.Add(this.opr_kunde);
            this.Controls.Add(this.kunde_oversigt);
            this.Name = "Kunder";
            this.Text = "Kunder";
            this.Load += new System.EventHandler(this.Kunder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kunde_oversigt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button red_kunde;
        private System.Windows.Forms.Button slet_kunde;
        private System.Windows.Forms.Button opr_kunde;
        private System.Windows.Forms.DataGridView kunde_oversigt;
        private System.Windows.Forms.Button vis_kunde_sager;
    }
}