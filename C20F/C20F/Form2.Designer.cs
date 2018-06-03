namespace C20F
{
    partial class Form2
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
            this.btnZpet = new System.Windows.Forms.Button();
            this.txtPredano = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnZpet
            // 
            this.btnZpet.Location = new System.Drawing.Point(12, 38);
            this.btnZpet.Name = "btnZpet";
            this.btnZpet.Size = new System.Drawing.Size(260, 23);
            this.btnZpet.TabIndex = 4;
            this.btnZpet.Text = "Zpět";
            this.btnZpet.UseVisualStyleBackColor = true;
            this.btnZpet.Click += new System.EventHandler(this.btnZpet_Click);
            // 
            // txtPredano
            // 
            this.txtPredano.Location = new System.Drawing.Point(12, 12);
            this.txtPredano.Name = "txtPredano";
            this.txtPredano.ReadOnly = true;
            this.txtPredano.Size = new System.Drawing.Size(260, 20);
            this.txtPredano.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.btnZpet);
            this.Controls.Add(this.txtPredano);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZpet;
        private System.Windows.Forms.TextBox txtPredano;
    }
}