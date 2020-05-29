namespace Semesterprojekt_2020.Forms.Sager
{
    partial class Valg_advokat
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
            this.button1 = new System.Windows.Forms.Button();
            this.advokat_valgt = new System.Windows.Forms.Button();
            this.valg_advokat_oversigt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.valg_advokat_oversigt)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 42;
            this.button1.Text = "Anuller";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // advokat_valgt
            // 
            this.advokat_valgt.Location = new System.Drawing.Point(44, 388);
            this.advokat_valgt.Name = "advokat_valgt";
            this.advokat_valgt.Size = new System.Drawing.Size(100, 50);
            this.advokat_valgt.TabIndex = 41;
            this.advokat_valgt.Text = "Vælg";
            this.advokat_valgt.UseVisualStyleBackColor = true;
            this.advokat_valgt.Click += new System.EventHandler(this.advokat_valgt_Click);
            // 
            // valg_advokat_oversigt
            // 
            this.valg_advokat_oversigt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valg_advokat_oversigt.Location = new System.Drawing.Point(12, 12);
            this.valg_advokat_oversigt.Name = "valg_advokat_oversigt";
            this.valg_advokat_oversigt.Size = new System.Drawing.Size(262, 335);
            this.valg_advokat_oversigt.TabIndex = 40;
            this.valg_advokat_oversigt.SelectionChanged += new System.EventHandler(this.valg_kunde_oversigt_SelectionChanged);
            // 
            // Valg_advokat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advokat_valgt);
            this.Controls.Add(this.valg_advokat_oversigt);
            this.Name = "Valg_advokat";
            this.Text = "Valg_advokat";
            this.Load += new System.EventHandler(this.Valg_advokat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valg_advokat_oversigt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button advokat_valgt;
        private System.Windows.Forms.DataGridView valg_advokat_oversigt;
    }
}