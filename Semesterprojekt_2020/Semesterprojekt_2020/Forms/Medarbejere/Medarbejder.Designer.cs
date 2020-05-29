namespace Semesterprojekt_2020.Forms
{
    partial class Medarbejdere
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
            this.medarbejder_oversigt = new System.Windows.Forms.DataGridView();
            this.opr_medarbejder = new System.Windows.Forms.Button();
            this.slet_medarbejder = new System.Windows.Forms.Button();
            this.vis_timereg = new System.Windows.Forms.Button();
            this.vis_uddannelse = new System.Windows.Forms.Button();
            this.red_medarbejder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medarbejder_oversigt)).BeginInit();
            this.SuspendLayout();
            // 
            // medarbejder_oversigt
            // 
            this.medarbejder_oversigt.AllowUserToAddRows = false;
            this.medarbejder_oversigt.AllowUserToDeleteRows = false;
            this.medarbejder_oversigt.AllowUserToResizeColumns = false;
            this.medarbejder_oversigt.AllowUserToResizeRows = false;
            this.medarbejder_oversigt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.medarbejder_oversigt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.medarbejder_oversigt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medarbejder_oversigt.Location = new System.Drawing.Point(12, 26);
            this.medarbejder_oversigt.MultiSelect = false;
            this.medarbejder_oversigt.Name = "medarbejder_oversigt";
            this.medarbejder_oversigt.ReadOnly = true;
            this.medarbejder_oversigt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medarbejder_oversigt.Size = new System.Drawing.Size(776, 322);
            this.medarbejder_oversigt.TabIndex = 0;
            this.medarbejder_oversigt.SelectionChanged += new System.EventHandler(this.medarbejder_oversigt_SelectionChanged);
            // 
            // opr_medarbejder
            // 
            this.opr_medarbejder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opr_medarbejder.Location = new System.Drawing.Point(36, 371);
            this.opr_medarbejder.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.opr_medarbejder.Name = "opr_medarbejder";
            this.opr_medarbejder.Size = new System.Drawing.Size(100, 50);
            this.opr_medarbejder.TabIndex = 1;
            this.opr_medarbejder.Text = "Opret";
            this.opr_medarbejder.UseVisualStyleBackColor = true;
            this.opr_medarbejder.Click += new System.EventHandler(this.opr_medarbejder_Click);
            // 
            // slet_medarbejder
            // 
            this.slet_medarbejder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.slet_medarbejder.Location = new System.Drawing.Point(341, 371);
            this.slet_medarbejder.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.slet_medarbejder.Name = "slet_medarbejder";
            this.slet_medarbejder.Size = new System.Drawing.Size(100, 50);
            this.slet_medarbejder.TabIndex = 2;
            this.slet_medarbejder.Text = "Slet";
            this.slet_medarbejder.UseVisualStyleBackColor = true;
            this.slet_medarbejder.Click += new System.EventHandler(this.slet_medarbejder_Click);
            // 
            // vis_timereg
            // 
            this.vis_timereg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vis_timereg.Location = new System.Drawing.Point(497, 371);
            this.vis_timereg.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.vis_timereg.Name = "vis_timereg";
            this.vis_timereg.Size = new System.Drawing.Size(100, 50);
            this.vis_timereg.TabIndex = 3;
            this.vis_timereg.Text = "Vis timeregistrering";
            this.vis_timereg.UseVisualStyleBackColor = true;
            this.vis_timereg.Click += new System.EventHandler(this.vis_timereg_Click);
            // 
            // vis_uddannelse
            // 
            this.vis_uddannelse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vis_uddannelse.Location = new System.Drawing.Point(657, 371);
            this.vis_uddannelse.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.vis_uddannelse.Name = "vis_uddannelse";
            this.vis_uddannelse.Size = new System.Drawing.Size(100, 50);
            this.vis_uddannelse.TabIndex = 4;
            this.vis_uddannelse.Text = "Vis uddannelse";
            this.vis_uddannelse.UseVisualStyleBackColor = true;
            this.vis_uddannelse.Click += new System.EventHandler(this.vis_uddannelse_Click);
            // 
            // red_medarbejder
            // 
            this.red_medarbejder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.red_medarbejder.Location = new System.Drawing.Point(190, 371);
            this.red_medarbejder.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.red_medarbejder.Name = "red_medarbejder";
            this.red_medarbejder.Size = new System.Drawing.Size(100, 50);
            this.red_medarbejder.TabIndex = 5;
            this.red_medarbejder.Text = "Rediger";
            this.red_medarbejder.UseVisualStyleBackColor = true;
            this.red_medarbejder.Click += new System.EventHandler(this.red_medarbejder_Click);
            // 
            // Medarbejdere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.red_medarbejder);
            this.Controls.Add(this.vis_uddannelse);
            this.Controls.Add(this.vis_timereg);
            this.Controls.Add(this.slet_medarbejder);
            this.Controls.Add(this.opr_medarbejder);
            this.Controls.Add(this.medarbejder_oversigt);
            this.Name = "Medarbejdere";
            this.Text = "Medarbejdere";
            this.Load += new System.EventHandler(this.Medarbejdere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medarbejder_oversigt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView medarbejder_oversigt;
        private System.Windows.Forms.Button opr_medarbejder;
        private System.Windows.Forms.Button slet_medarbejder;
        private System.Windows.Forms.Button vis_timereg;
        private System.Windows.Forms.Button vis_uddannelse;
        private System.Windows.Forms.Button red_medarbejder;
    }
}