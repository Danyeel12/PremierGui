namespace PremierGui
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblBirth = new System.Windows.Forms.Label();
            this.PremierStartEnd = new System.Windows.Forms.Label();
            this.lstPremier = new System.Windows.Forms.ListBox();
            this.picPremier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(50, 22);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(105, 20);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "PremierName";
            // 
            // LblBirth
            // 
            this.LblBirth.AutoSize = true;
            this.LblBirth.Location = new System.Drawing.Point(50, 411);
            this.LblBirth.Name = "LblBirth";
            this.LblBirth.Size = new System.Drawing.Size(139, 20);
            this.LblBirth.TabIndex = 2;
            this.LblBirth.Text = "Premier Birth Date";
            // 
            // PremierStartEnd
            // 
            this.PremierStartEnd.AutoSize = true;
            this.PremierStartEnd.Location = new System.Drawing.Point(50, 461);
            this.PremierStartEnd.Name = "PremierStartEnd";
            this.PremierStartEnd.Size = new System.Drawing.Size(135, 20);
            this.PremierStartEnd.TabIndex = 3;
            this.PremierStartEnd.Text = "Premier Start End";
            // 
            // lstPremier
            // 
            this.lstPremier.FormattingEnabled = true;
            this.lstPremier.ItemHeight = 20;
            this.lstPremier.Location = new System.Drawing.Point(555, 22);
            this.lstPremier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPremier.Name = "lstPremier";
            this.lstPremier.Size = new System.Drawing.Size(160, 504);
            this.lstPremier.TabIndex = 4;
            this.lstPremier.SelectedIndexChanged += new System.EventHandler(this.lstPremier_SelectedIndexChanged);
            // 
            // picPremier
            // 
            this.picPremier.InitialImage = null;
            this.picPremier.Location = new System.Drawing.Point(54, 91);
            this.picPremier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPremier.Name = "picPremier";
            this.picPremier.Size = new System.Drawing.Size(293, 368);
            this.picPremier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPremier.TabIndex = 5;
            this.picPremier.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 562);
            this.Controls.Add(this.picPremier);
            this.Controls.Add(this.lstPremier);
            this.Controls.Add(this.PremierStartEnd);
            this.Controls.Add(this.LblBirth);
            this.Controls.Add(this.LblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPremier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblBirth;
        private System.Windows.Forms.Label PremierStartEnd;
        private System.Windows.Forms.ListBox lstPremier;
        private System.Windows.Forms.PictureBox picPremier;
    }
}

