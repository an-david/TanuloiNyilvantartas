namespace TanuloiNyilvantartas
{
    partial class tagModositas
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
            this.button_Modosit = new System.Windows.Forms.Button();
            this.comboBox_Orszag = new System.Windows.Forms.ComboBox();
            this.numericUpDown_IrSzam = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_SzulEv = new System.Windows.Forms.NumericUpDown();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Tanulok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IrSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzulEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tanulok)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Modosit
            // 
            this.button_Modosit.Location = new System.Drawing.Point(651, 374);
            this.button_Modosit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Modosit.Name = "button_Modosit";
            this.button_Modosit.Size = new System.Drawing.Size(133, 36);
            this.button_Modosit.TabIndex = 17;
            this.button_Modosit.Text = "Modósítás";
            this.button_Modosit.UseVisualStyleBackColor = true;
            this.button_Modosit.Click += new System.EventHandler(this.button_Modosit_Click);
            // 
            // comboBox_Orszag
            // 
            this.comboBox_Orszag.FormattingEnabled = true;
            this.comboBox_Orszag.Items.AddRange(new object[] {
            "H",
            "RO",
            "HR",
            "E",
            "A"});
            this.comboBox_Orszag.Location = new System.Drawing.Point(518, 303);
            this.comboBox_Orszag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Orszag.Name = "comboBox_Orszag";
            this.comboBox_Orszag.Size = new System.Drawing.Size(283, 28);
            this.comboBox_Orszag.TabIndex = 16;
            // 
            // numericUpDown_IrSzam
            // 
            this.numericUpDown_IrSzam.Location = new System.Drawing.Point(518, 250);
            this.numericUpDown_IrSzam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_IrSzam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_IrSzam.Name = "numericUpDown_IrSzam";
            this.numericUpDown_IrSzam.Size = new System.Drawing.Size(285, 26);
            this.numericUpDown_IrSzam.TabIndex = 15;
            // 
            // numericUpDown_SzulEv
            // 
            this.numericUpDown_SzulEv.Location = new System.Drawing.Point(518, 199);
            this.numericUpDown_SzulEv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_SzulEv.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDown_SzulEv.Minimum = new decimal(new int[] {
            1921,
            0,
            0,
            0});
            this.numericUpDown_SzulEv.Name = "numericUpDown_SzulEv";
            this.numericUpDown_SzulEv.Size = new System.Drawing.Size(285, 26);
            this.numericUpDown_SzulEv.TabIndex = 14;
            this.numericUpDown_SzulEv.Value = new decimal(new int[] {
            2001,
            0,
            0,
            0});
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(518, 147);
            this.textBox_Nev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(283, 26);
            this.textBox_Nev.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Tag = "";
            this.label5.Text = "Ország:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Irányítószám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Születési év:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Név:";
            // 
            // dataGridView_Tanulok
            // 
            this.dataGridView_Tanulok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tanulok.Location = new System.Drawing.Point(26, 68);
            this.dataGridView_Tanulok.Name = "dataGridView_Tanulok";
            this.dataGridView_Tanulok.Size = new System.Drawing.Size(324, 402);
            this.dataGridView_Tanulok.TabIndex = 18;
            this.dataGridView_Tanulok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tanulok_CellContentClick);
            // 
            // tagModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 543);
            this.Controls.Add(this.dataGridView_Tanulok);
            this.Controls.Add(this.button_Modosit);
            this.Controls.Add(this.comboBox_Orszag);
            this.Controls.Add(this.numericUpDown_IrSzam);
            this.Controls.Add(this.numericUpDown_SzulEv);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tagModositas";
            this.Text = "tagModositas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tagModositas_FormClosing);
            this.Load += new System.EventHandler(this.tagModositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IrSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzulEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tanulok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Modosit;
        private System.Windows.Forms.ComboBox comboBox_Orszag;
        private System.Windows.Forms.NumericUpDown numericUpDown_IrSzam;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzulEv;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Tanulok;
    }
}