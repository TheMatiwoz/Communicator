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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProjekcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTworcachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox.Location = new System.Drawing.Point(12, 36);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(470, 340);
            this.textBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(470, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "WYŚLIJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(470, 78);
            this.button2.TabIndex = 3;
            this.button2.Text = "KONWERTUJ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ConvertText_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(970, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProjekcieToolStripMenuItem,
            this.oTworcachToolStripMenuItem,
            this.wyjdzToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Chartreuse;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // oProjekcieToolStripMenuItem
            // 
            this.oProjekcieToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.oProjekcieToolStripMenuItem.ForeColor = System.Drawing.Color.Chartreuse;
            this.oProjekcieToolStripMenuItem.Name = "oProjekcieToolStripMenuItem";
            this.oProjekcieToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.oProjekcieToolStripMenuItem.Text = "O projekcie";
            this.oProjekcieToolStripMenuItem.Click += new System.EventHandler(this.oProjekcieToolStripMenuItem_Click);
            // 
            // oTworcachToolStripMenuItem
            // 
            this.oTworcachToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.oTworcachToolStripMenuItem.ForeColor = System.Drawing.Color.Chartreuse;
            this.oTworcachToolStripMenuItem.Name = "oTworcachToolStripMenuItem";
            this.oTworcachToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.oTworcachToolStripMenuItem.Text = "O tworcach";
            this.oTworcachToolStripMenuItem.Click += new System.EventHandler(this.oTworcachToolStripMenuItem_Click);
            // 
            // wyjdzToolStripMenuItem
            // 
            this.wyjdzToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.wyjdzToolStripMenuItem.ForeColor = System.Drawing.Color.Chartreuse;
            this.wyjdzToolStripMenuItem.Name = "wyjdzToolStripMenuItem";
            this.wyjdzToolStripMenuItem.Size = new System.Drawing.Size(186, 30);
            this.wyjdzToolStripMenuItem.Text = "Wyjdz";
            this.wyjdzToolStripMenuItem.Click += new System.EventHandler(this.wyjdzToolStripMenuItem_Click);
            // 
            // readBox
            // 
            this.readBox.BackColor = System.Drawing.Color.Black;
            this.readBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.readBox.ForeColor = System.Drawing.Color.Chartreuse;
            this.readBox.Location = new System.Drawing.Point(488, 36);
            this.readBox.Multiline = true;
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readBox.Size = new System.Drawing.Size(470, 340);
            this.readBox.TabIndex = 5;
            this.readBox.Text = "Skonwertuj tekst aby wysłać";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(970, 502);
            this.Controls.Add(this.readBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProjekcieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTworcachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdzToolStripMenuItem;
        private System.Windows.Forms.TextBox readBox;
    }
}

