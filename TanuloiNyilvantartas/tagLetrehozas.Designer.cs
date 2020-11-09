namespace TanuloiNyilvantartas
{
    partial class tagLetrehozas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.numericUpDown_SzulEv = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_IrSzam = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Orszag = new System.Windows.Forms.ComboBox();
            this.button_Felvetel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzulEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IrSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Születési év:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Irányítószám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 3;
            this.label5.Tag = "";
            this.label5.Text = "Ország:";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(260, 139);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(190, 26);
            this.textBox_Nev.TabIndex = 4;
            // 
            // numericUpDown_SzulEv
            // 
            this.numericUpDown_SzulEv.Location = new System.Drawing.Point(260, 184);
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
            this.numericUpDown_SzulEv.Size = new System.Drawing.Size(190, 26);
            this.numericUpDown_SzulEv.TabIndex = 5;
            this.numericUpDown_SzulEv.Value = new decimal(new int[] {
            2001,
            0,
            0,
            0});
            // 
            // numericUpDown_IrSzam
            // 
            this.numericUpDown_IrSzam.Location = new System.Drawing.Point(260, 237);
            this.numericUpDown_IrSzam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_IrSzam.Name = "numericUpDown_IrSzam";
            this.numericUpDown_IrSzam.Size = new System.Drawing.Size(190, 26);
            this.numericUpDown_IrSzam.TabIndex = 6;
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
            this.comboBox_Orszag.Location = new System.Drawing.Point(260, 290);
            this.comboBox_Orszag.Name = "comboBox_Orszag";
            this.comboBox_Orszag.Size = new System.Drawing.Size(190, 28);
            this.comboBox_Orszag.TabIndex = 7;
            // 
            // button_Felvetel
            // 
            this.button_Felvetel.Location = new System.Drawing.Point(495, 213);
            this.button_Felvetel.Name = "button_Felvetel";
            this.button_Felvetel.Size = new System.Drawing.Size(184, 35);
            this.button_Felvetel.TabIndex = 8;
            this.button_Felvetel.Text = "Felvétel adatbázisba";
            this.button_Felvetel.UseVisualStyleBackColor = true;
            this.button_Felvetel.Click += new System.EventHandler(this.button_Felvetel_Click);
            // 
            // tagLetrehozas
            // 
            this.ClientSize = new System.Drawing.Size(765, 493);
            this.Controls.Add(this.button_Felvetel);
            this.Controls.Add(this.comboBox_Orszag);
            this.Controls.Add(this.numericUpDown_IrSzam);
            this.Controls.Add(this.numericUpDown_SzulEv);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "tagLetrehozas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tagLetrehozas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzulEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IrSzam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzulEv;
        private System.Windows.Forms.NumericUpDown numericUpDown_IrSzam;
        private System.Windows.Forms.ComboBox comboBox_Orszag;
        private System.Windows.Forms.Button button_Felvetel;
    }
}