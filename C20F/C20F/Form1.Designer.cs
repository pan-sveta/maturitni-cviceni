namespace C20F
{
    partial class Form1
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
            this.txtPredani = new System.Windows.Forms.TextBox();
            this.btnPredat = new System.Windows.Forms.Button();
            this.btnKonec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPredani
            // 
            this.txtPredani.Location = new System.Drawing.Point(12, 12);
            this.txtPredani.Name = "txtPredani";
            this.txtPredani.Size = new System.Drawing.Size(260, 20);
            this.txtPredani.TabIndex = 0;
            // 
            // btnPredat
            // 
            this.btnPredat.Location = new System.Drawing.Point(12, 38);
            this.btnPredat.Name = "btnPredat";
            this.btnPredat.Size = new System.Drawing.Size(130, 23);
            this.btnPredat.TabIndex = 1;
            this.btnPredat.Text = "Předat";
            this.btnPredat.UseVisualStyleBackColor = true;
            this.btnPredat.Click += new System.EventHandler(this.btnPredat_Click);
            // 
            // btnKonec
            // 
            this.btnKonec.Location = new System.Drawing.Point(142, 38);
            this.btnKonec.Name = "btnKonec";
            this.btnKonec.Size = new System.Drawing.Size(130, 23);
            this.btnKonec.TabIndex = 2;
            this.btnKonec.Text = "Konec";
            this.btnKonec.UseVisualStyleBackColor = true;
            this.btnKonec.Click += new System.EventHandler(this.btnKonec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.btnKonec);
            this.Controls.Add(this.btnPredat);
            this.Controls.Add(this.txtPredani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPredat;
        private System.Windows.Forms.Button btnKonec;
        public System.Windows.Forms.TextBox txtPredani;
    }
}

