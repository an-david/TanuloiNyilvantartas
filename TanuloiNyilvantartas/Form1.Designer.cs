namespace TanuloiNyilvantartas
{
    partial class Form_Nyito
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
            this.tagokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felvételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modósításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tagokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tagokToolStripMenuItem
            // 
            this.tagokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felvételToolStripMenuItem,
            this.modósításToolStripMenuItem});
            this.tagokToolStripMenuItem.Name = "tagokToolStripMenuItem";
            this.tagokToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.tagokToolStripMenuItem.Text = "Tagok";
            // 
            // felvételToolStripMenuItem
            // 
            this.felvételToolStripMenuItem.Name = "felvételToolStripMenuItem";
            this.felvételToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.felvételToolStripMenuItem.Text = "Felvétel";
            this.felvételToolStripMenuItem.Click += new System.EventHandler(this.felvételToolStripMenuItem_Click);
            // 
            // modósításToolStripMenuItem
            // 
            this.modósításToolStripMenuItem.Name = "modósításToolStripMenuItem";
            this.modósításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modósításToolStripMenuItem.Text = "Modósítás";
            this.modósításToolStripMenuItem.Click += new System.EventHandler(this.modósításToolStripMenuItem_Click);
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyito";
            this.Text = "Tanulói Nyilvántartás";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tagokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felvételToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modósításToolStripMenuItem;
    }
}

