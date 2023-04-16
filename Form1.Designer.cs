namespace Podaci_o_radnicima___opcije
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prikaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sveRadnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radnikeSaPlatomVecomOd50000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prikaziToolStripMenuItem
            // 
            this.prikaziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sveRadnikeToolStripMenuItem,
            this.radnikeSaPlatomVecomOd50000ToolStripMenuItem,
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem});
            this.prikaziToolStripMenuItem.Name = "prikaziToolStripMenuItem";
            this.prikaziToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.prikaziToolStripMenuItem.Text = "Prikazi";
            // 
            // sveRadnikeToolStripMenuItem
            // 
            this.sveRadnikeToolStripMenuItem.Name = "sveRadnikeToolStripMenuItem";
            this.sveRadnikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sveRadnikeToolStripMenuItem.Text = "Sve radnike";
            this.sveRadnikeToolStripMenuItem.Click += new System.EventHandler(this.sveRadnikeToolStripMenuItem_Click);
            // 
            // radnikeSaPlatomVecomOd50000ToolStripMenuItem
            // 
            this.radnikeSaPlatomVecomOd50000ToolStripMenuItem.Name = "radnikeSaPlatomVecomOd50000ToolStripMenuItem";
            this.radnikeSaPlatomVecomOd50000ToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.radnikeSaPlatomVecomOd50000ToolStripMenuItem.Text = "Radnike sa platom vecom od 50000";
            this.radnikeSaPlatomVecomOd50000ToolStripMenuItem.Click += new System.EventHandler(this.radnikeSaPlatomVecomOd50000ToolStripMenuItem_Click);
            // 
            // imeIPrezimeZaSvakogRadnikaToolStripMenuItem
            // 
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Name = "imeIPrezimeZaSvakogRadnikaToolStripMenuItem";
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Text = "Ime i prezime za svakog radnika";
            this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem.Click += new System.EventHandler(this.imeIPrezimeZaSvakogRadnikaToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(574, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 511);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spisak radnika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Podaci o radnicima";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prikaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sveRadnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radnikeSaPlatomVecomOd50000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imeIPrezimeZaSvakogRadnikaToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

