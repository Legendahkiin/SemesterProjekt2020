namespace Semesterprojekt_2020.Forms.Sager
{
    partial class Valg_kunde
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
            this.valg_kunde_oversigt = new System.Windows.Forms.DataGridView();
            this.kunde_valgt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valg_kunde_oversigt)).BeginInit();
            this.SuspendLayout();
            // 
            // valg_kunde_oversigt
            // 
            this.valg_kunde_oversigt.AllowUserToAddRows = false;
            this.valg_kunde_oversigt.AllowUserToDeleteRows = false;
            this.valg_kunde_oversigt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valg_kunde_oversigt.Location = new System.Drawing.Point(12, 12);
            this.valg_kunde_oversigt.Name = "valg_kunde_oversigt";
            this.valg_kunde_oversigt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.valg_kunde_oversigt.Size = new System.Drawing.Size(262, 335);
            this.valg_kunde_oversigt.TabIndex = 0;
            this.valg_kunde_oversigt.SelectionChanged += new System.EventHandler(this.valg_kunde_oversigt_SelectionChanged);
            // 
            // kunde_valgt
            // 
            this.kunde_valgt.Location = new System.Drawing.Point(44, 388);
            this.kunde_valgt.Name = "kunde_valgt";
            this.kunde_valgt.Size = new System.Drawing.Size(100, 50);
            this.kunde_valgt.TabIndex = 38;
            this.kunde_valgt.Text = "Vælg";
            this.kunde_valgt.UseVisualStyleBackColor = true;
            this.kunde_valgt.Click += new System.EventHandler(this.kunde_valgt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 39;
            this.button1.Text = "Anuller";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Valg_kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kunde_valgt);
            this.Controls.Add(this.valg_kunde_oversigt);
            this.Name = "Valg_kunde";
            this.Text = "Valg_kunde";
            this.Load += new System.EventHandler(this.Valg_kunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valg_kunde_oversigt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView valg_kunde_oversigt;
        private System.Windows.Forms.Button kunde_valgt;
        private System.Windows.Forms.Button button1;
    }
}