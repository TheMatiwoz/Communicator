namespace Communicator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProjekcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTworcachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(3, 55);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(419, 22);
            this.textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(478, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 282);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz tekst aby skonwertowac";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "WYŚLIJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 353);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "KONWERTUJ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ConvertText_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProjekcieToolStripMenuItem,
            this.oTworcachToolStripMenuItem,
            this.wyjdzToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // oProjekcieToolStripMenuItem
            // 
            this.oProjekcieToolStripMenuItem.Name = "oProjekcieToolStripMenuItem";
            this.oProjekcieToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.oProjekcieToolStripMenuItem.Text = "O projekcie";
            this.oProjekcieToolStripMenuItem.Click += new System.EventHandler(this.oProjekcieToolStripMenuItem_Click);
            // 
            // oTworcachToolStripMenuItem
            // 
            this.oTworcachToolStripMenuItem.Name = "oTworcachToolStripMenuItem";
            this.oTworcachToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.oTworcachToolStripMenuItem.Text = "O tworcach";
            this.oTworcachToolStripMenuItem.Click += new System.EventHandler(this.oTworcachToolStripMenuItem_Click);
            // 
            // wyjdzToolStripMenuItem
            // 
            this.wyjdzToolStripMenuItem.Name = "wyjdzToolStripMenuItem";
            this.wyjdzToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.wyjdzToolStripMenuItem.Text = "Wyjdz";
            this.wyjdzToolStripMenuItem.Click += new System.EventHandler(this.wyjdzToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProjekcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTworcachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdzToolStripMenuItem;
    }
}

