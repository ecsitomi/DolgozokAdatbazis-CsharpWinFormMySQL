namespace loginForm
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Felhasznalo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Jelszo = new System.Windows.Forms.TextBox();
            this.button_Belepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // textBox_Felhasznalo
            // 
            this.textBox_Felhasznalo.Location = new System.Drawing.Point(149, 12);
            this.textBox_Felhasznalo.Name = "textBox_Felhasznalo";
            this.textBox_Felhasznalo.Size = new System.Drawing.Size(192, 20);
            this.textBox_Felhasznalo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(84, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jelszó";
            // 
            // textBox_Jelszo
            // 
            this.textBox_Jelszo.Location = new System.Drawing.Point(149, 41);
            this.textBox_Jelszo.Name = "textBox_Jelszo";
            this.textBox_Jelszo.Size = new System.Drawing.Size(192, 20);
            this.textBox_Jelszo.TabIndex = 2;
            this.textBox_Jelszo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Jelszo_KeyPress);
            // 
            // button_Belepes
            // 
            this.button_Belepes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Belepes.Location = new System.Drawing.Point(88, 78);
            this.button_Belepes.Name = "button_Belepes";
            this.button_Belepes.Size = new System.Drawing.Size(191, 49);
            this.button_Belepes.TabIndex = 3;
            this.button_Belepes.Text = "Belépés";
            this.button_Belepes.UseVisualStyleBackColor = true;
            this.button_Belepes.Click += new System.EventHandler(this.button_Belepes_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 148);
            this.Controls.Add(this.button_Belepes);
            this.Controls.Add(this.textBox_Jelszo);
            this.Controls.Add(this.textBox_Felhasznalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Belépés";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Felhasznalo;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Jelszo;
        private System.Windows.Forms.Button button_Belepes;
    }
}

