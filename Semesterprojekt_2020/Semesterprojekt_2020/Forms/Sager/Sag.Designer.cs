namespace Semesterprojekt_2020.Forms.Sager
{
    partial class Sag
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
            this.opr_sag = new System.Windows.Forms.Button();
            this.red_sag = new System.Windows.Forms.Button();
            this.slet_sag = new System.Windows.Forms.Button();
            this.vis_sag = new System.Windows.Forms.Button();
            this.sag_oversigt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sag_oversigt)).BeginInit();
            this.SuspendLayout();
            // 
            // opr_sag
            // 
            this.opr_sag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opr_sag.Location = new System.Drawing.Point(133, 371);
            this.opr_sag.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.opr_sag.Name = "opr_sag";
            this.opr_sag.Size = new System.Drawing.Size(100, 50);
            this.opr_sag.TabIndex = 2;
            this.opr_sag.Text = "Opret";
            this.opr_sag.UseVisualStyleBackColor = true;
            // 
            // red_sag
            // 
            this.red_sag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.red_sag.Location = new System.Drawing.Point(277, 371);
            this.red_sag.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.red_sag.Name = "red_sag";
            this.red_sag.Size = new System.Drawing.Size(100, 50);
            this.red_sag.TabIndex = 6;
            this.red_sag.Text = "Rediger";
            this.red_sag.UseVisualStyleBackColor = true;
            // 
            // slet_sag
            // 
            this.slet_sag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.slet_sag.Location = new System.Drawing.Point(422, 371);
            this.slet_sag.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.slet_sag.Name = "slet_sag";
            this.slet_sag.Size = new System.Drawing.Size(100, 50);
            this.slet_sag.TabIndex = 7;
            this.slet_sag.Text = "Slet";
            this.slet_sag.UseVisualStyleBackColor = true;
            // 
            // vis_sag
            // 
            this.vis_sag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vis_sag.Location = new System.Drawing.Point(566, 371);
            this.vis_sag.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.vis_sag.Name = "vis_sag";
            this.vis_sag.Size = new System.Drawing.Size(100, 50);
            this.vis_sag.TabIndex = 8;
            this.vis_sag.Text = "Vis mere info";
            this.vis_sag.UseVisualStyleBackColor = true;
            // 
            // sag_oversigt
            // 
            this.sag_oversigt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sag_oversigt.Location = new System.Drawing.Point(12, 26);
            this.sag_oversigt.Name = "sag_oversigt";
            this.sag_oversigt.Size = new System.Drawing.Size(776, 322);
            this.sag_oversigt.TabIndex = 9;
            // 
            // Sager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sag_oversigt);
            this.Controls.Add(this.vis_sag);
            this.Controls.Add(this.slet_sag);
            this.Controls.Add(this.red_sag);
            this.Controls.Add(this.opr_sag);
            this.Name = "Sager";
            this.Text = "Sager";
            this.Load += new System.EventHandler(this.Sager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sag_oversigt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opr_sag;
        private System.Windows.Forms.Button red_sag;
        private System.Windows.Forms.Button slet_sag;
        private System.Windows.Forms.Button vis_sag;
        private System.Windows.Forms.DataGridView sag_oversigt;
    }
}