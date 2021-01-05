namespace Communicator
{
    partial class ProjectInfoForm
    { 
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInfoForm));
            this.projectInfoLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projectInfoLabel1
            // 
            this.projectInfoLabel1.Location = new System.Drawing.Point(12, 9);
            this.projectInfoLabel1.Name = "projectInfoLabel1";
            this.projectInfoLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projectInfoLabel1.Size = new System.Drawing.Size(265, 212);
            this.projectInfoLabel1.TabIndex = 0;
            this.projectInfoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 230);
            this.Controls.Add(this.projectInfoLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectInfoForm";
            this.Text = "Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label projectInfoLabel1;

    }
}