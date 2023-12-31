namespace loginForm
{
    partial class FormMain
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
            this.dolgozóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiléptetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.groupBox_Kivalasztott = new System.Windows.Forms.GroupBox();
            this.radioButton_Egyeb = new System.Windows.Forms.RadioButton();
            this.radioButton_Ferfi = new System.Windows.Forms.RadioButton();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_Szul = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox_Kivalasztott.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dolgozóToolStripMenuItem,
            this.termékToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dolgozóToolStripMenuItem
            // 
            this.dolgozóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.kiléptetésToolStripMenuItem});
            this.dolgozóToolStripMenuItem.Name = "dolgozóToolStripMenuItem";
            this.dolgozóToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.dolgozóToolStripMenuItem.Text = "Dolgozó";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // kiléptetésToolStripMenuItem
            // 
            this.kiléptetésToolStripMenuItem.Name = "kiléptetésToolStripMenuItem";
            this.kiléptetésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiléptetésToolStripMenuItem.Text = "Kiléptetés";
            this.kiléptetésToolStripMenuItem.Click += new System.EventHandler(this.kiléptetésToolStripMenuItem_Click);
            // 
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.módosításToolStripMenuItem1,
            this.törlésToolStripMenuItem});
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.termékToolStripMenuItem.Text = "Termék";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.újToolStripMenuItem1.Text = "Új";
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(13, 28);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(152, 186);
            this.listBox_Dolgozok.TabIndex = 2;
            this.listBox_Dolgozok.SelectedIndexChanged += new System.EventHandler(this.listBox_Dolgozok_SelectedIndexChanged);
            // 
            // groupBox_Kivalasztott
            // 
            this.groupBox_Kivalasztott.Controls.Add(this.radioButton_Egyeb);
            this.groupBox_Kivalasztott.Controls.Add(this.radioButton_Ferfi);
            this.groupBox_Kivalasztott.Controls.Add(this.radioButton_No);
            this.groupBox_Kivalasztott.Controls.Add(this.dateTimePicker_Szul);
            this.groupBox_Kivalasztott.Controls.Add(this.label3);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_Nev);
            this.groupBox_Kivalasztott.Controls.Add(this.label2);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_ID);
            this.groupBox_Kivalasztott.Controls.Add(this.label1);
            this.groupBox_Kivalasztott.Location = new System.Drawing.Point(171, 28);
            this.groupBox_Kivalasztott.Name = "groupBox_Kivalasztott";
            this.groupBox_Kivalasztott.Size = new System.Drawing.Size(213, 183);
            this.groupBox_Kivalasztott.TabIndex = 3;
            this.groupBox_Kivalasztott.TabStop = false;
            this.groupBox_Kivalasztott.Text = "Kiválasztott dolgozó";
            // 
            // radioButton_Egyeb
            // 
            this.radioButton_Egyeb.AutoSize = true;
            this.radioButton_Egyeb.Location = new System.Drawing.Point(132, 139);
            this.radioButton_Egyeb.Name = "radioButton_Egyeb";
            this.radioButton_Egyeb.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Egyeb.TabIndex = 8;
            this.radioButton_Egyeb.TabStop = true;
            this.radioButton_Egyeb.Text = "Egyéb";
            this.radioButton_Egyeb.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ferfi
            // 
            this.radioButton_Ferfi.AutoSize = true;
            this.radioButton_Ferfi.Location = new System.Drawing.Point(76, 139);
            this.radioButton_Ferfi.Name = "radioButton_Ferfi";
            this.radioButton_Ferfi.Size = new System.Drawing.Size(45, 17);
            this.radioButton_Ferfi.TabIndex = 7;
            this.radioButton_Ferfi.TabStop = true;
            this.radioButton_Ferfi.Text = "Férfi";
            this.radioButton_Ferfi.UseVisualStyleBackColor = true;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Location = new System.Drawing.Point(26, 139);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(39, 17);
            this.radioButton_No.TabIndex = 6;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "Nő";
            this.radioButton_No.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Szul
            // 
            this.dateTimePicker_Szul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szul.Location = new System.Drawing.Point(47, 101);
            this.dateTimePicker_Szul.Name = "dateTimePicker_Szul";
            this.dateTimePicker_Szul.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker_Szul.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Szül.";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(46, 62);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(148, 20);
            this.textBox_Nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(46, 24);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(148, 20);
            this.textBox_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 231);
            this.Controls.Add(this.groupBox_Kivalasztott);
            this.Controls.Add(this.listBox_Dolgozok);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Adatbázis";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_Kivalasztott.ResumeLayout(false);
            this.groupBox_Kivalasztott.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dolgozóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiléptetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem termékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_Dolgozok;
        private System.Windows.Forms.GroupBox groupBox_Kivalasztott;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Egyeb;
        private System.Windows.Forms.RadioButton radioButton_Ferfi;
        private System.Windows.Forms.RadioButton radioButton_No;
    }
}