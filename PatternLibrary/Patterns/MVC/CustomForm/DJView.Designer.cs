namespace PatternLibrary.Patterns.MVC.CustomForm
{
    partial class DJView
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
            this.lBPMText = new System.Windows.Forms.Label();
            this.lCurrentBPM = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lBPMText
            // 
            this.lBPMText.AutoSize = true;
            this.lBPMText.Location = new System.Drawing.Point(12, 50);
            this.lBPMText.Name = "lBPMText";
            this.lBPMText.Size = new System.Drawing.Size(30, 13);
            this.lBPMText.TabIndex = 1;
            this.lBPMText.Text = "BPM";
            // 
            // lCurrentBPM
            // 
            this.lCurrentBPM.AutoSize = true;
            this.lCurrentBPM.Location = new System.Drawing.Point(70, 49);
            this.lCurrentBPM.Name = "lCurrentBPM";
            this.lCurrentBPM.Size = new System.Drawing.Size(0, 13);
            this.lCurrentBPM.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // DJView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 88);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lCurrentBPM);
            this.Controls.Add(this.lBPMText);
            this.Name = "DJView";
            this.Text = "DJView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBPMText;
        private System.Windows.Forms.Label lCurrentBPM;
        private System.Windows.Forms.ProgressBar progressBar1;

    }
}