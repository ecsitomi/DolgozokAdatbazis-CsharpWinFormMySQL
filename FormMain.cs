using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Betöltéskor mit tegyen
            //Beállítja a születési naptár intervallumát
            dateTimePicker_Szul.MinDate = DateTime.Now.AddYears(-100);
            dateTimePicker_Szul.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker_Szul.Value = DateTime.Now.AddYears(-30);

            Program.db.selectDolgozo() // az adatbázis dolgozóit letöltöm egy listába
        }

        //ÚJ gombra mit tegyen
        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // adatok ellenőrzése
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nincs megadva a dolgozó neve!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Nev.Focus();
                return;
            }
            if (!(radioButton_No.Checked || radioButton_Ferfi.Checked || radioButton_Egyeb.Checked))
            {
                MessageBox.Show("Nincs megadva a dolgozó neme!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioButton_No.Focus();
                return;
            }
            // adatok kiírása
            string nev = textBox_Nev.Text;
            DateTime szuletes = dateTimePicker_Szul.Value;
            string nem = string.Empty;
            if (radioButton_No.Checked)
            {
                nem = "nő";
            } else if (radioButton_Ferfi.Checked) 
            {
                nem = "férfi";
            } else 
            { 
                nem = "egyéb";
            }
            Program.db.instertDolgozo(nev, szuletes, nem);
            // adatmezők kiürítése
            adatokTorlese();
        }
        private void adatokTorlese()
        {
            textBox_Nev.Clear();
            dateTimePicker_Szul.Value= DateTime.Now;
            radioButton_Egyeb.Checked = false;
            radioButton_Ferfi.Checked = false;
            radioButton_No.Checked = false;
        }
    }
}
