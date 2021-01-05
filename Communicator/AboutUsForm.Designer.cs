namespace Communicator
{
    partial class AboutUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUsForm));
            this.labelMW = new System.Windows.Forms.Label();
            this.labelMS = new System.Windows.Forms.Label();
            this.pictureBoxMS = new System.Windows.Forms.PictureBox();
            this.pictureBoxMW = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMW)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMW
            // 
            this.labelMW.Location = new System.Drawing.Point(157, 12);
            this.labelMW.Name = "labelMW";
            this.labelMW.Size = new System.Drawing.Size(226, 117);
            this.labelMW.TabIndex = 2;
            this.labelMW.Text = "label1";
            // 
            // labelMS
            // 
            this.labelMS.Location = new System.Drawing.Point(157, 135);
            this.labelMS.Name = "labelMS";
            this.labelMS.Size = new System.Drawing.Size(223, 117);
            this.labelMS.TabIndex = 3;
            this.labelMS.Text = "label1";
            // 
            // pictureBoxMS
            // 
            this.pictureBoxMS.ErrorImage = null;
            this.pictureBoxMS.Image = global::Communicator.Properties.Resources.MS;
            this.pictureBoxMS.Location = new System.Drawing.Point(13, 135);
            this.pictureBoxMS.Name = "pictureBoxMS";
            this.pictureBoxMS.Size = new System.Drawing.Size(129, 114);
            this.pictureBoxMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMS.TabIndex = 1;
            this.pictureBoxMS.TabStop = false;
            // 
            // pictureBoxMW
            // 
            this.pictureBoxMW.ErrorImage = null;
            this.pictureBoxMW.Image = global::Communicator.Properties.Resources.MW;
            this.pictureBoxMW.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxMW.Name = "pictureBoxMW";
            this.pictureBoxMW.Size = new System.Drawing.Size(129, 117);
            this.pictureBoxMW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMW.TabIndex = 0;
            this.pictureBoxMW.TabStop = false;
            // 
            // AboutUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.labelMS);
            this.Controls.Add(this.labelMW);
            this.Controls.Add(this.pictureBoxMS);
            this.Controls.Add(this.pictureBoxMW);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutUsForm";
            this.Text = "O nas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMW;
        private System.Windows.Forms.PictureBox pictureBoxMS;
        private System.Windows.Forms.Label labelMW;
        private System.Windows.Forms.Label labelMS;
    }
}