using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace loginForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Betöltéskor mit tegyen
        private void FormMain_Load(object sender, EventArgs e)
        {
            //Beállítja a születési naptár intervallumát
            dateTimePicker_Szul.MinDate = DateTime.Now.AddYears(-100);
            dateTimePicker_Szul.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker_Szul.Value = DateTime.Now.AddYears(-30);
            listBox_Dolgozok.Items.Clear();
            //listBox_Dolgozok.SelectedItem = -1; //elején ne válasszon ki senkit
            //nem működik, automatikus kiválaszt, de végülis ez nem okoz gondot

            selectDolgozo(); // az adatbázis dolgozóit letöltöm egy listába és a listboxban megjelenítem
        }
        private void selectDolgozo()
        {
            List<Dolgozo> dolgozok = Program.db.selectDolgozo();
            listBox_Dolgozok.DataSource = dolgozok;
            listBox_Dolgozok.DisplayMember = "dolgozoKiirasa"; //Dolgozo osztályból hivatkozok rá, hogy mi jelenjen meg
            //listBox_Dolgozok.Items.AddRange(dolgozok.ToArray()); ez nem jeleníti meg szépen
        }

        // adatok ellenőrzése a groupboxban
        private void ellenorzes()
        {
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
        }

        //ÚJ gombra mit tegyen
        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ellenorzes();
            // adatok kiírása
            textBox_ID.Text = string.Empty;
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
            selectDolgozo(); //ha töltöttél fel új dolgozót akkor frissüljön a megjelenő lista is
        }
        private void adatokTorlese()
        {
            textBox_Nev.Clear();
            dateTimePicker_Szul.Value= DateTime.Now.AddYears(-30);
            radioButton_Egyeb.Checked = false;
            radioButton_Ferfi.Checked = false;
            radioButton_No.Checked = false;
        }

        //Listboxban kiválasztás és Groupbox frissítése
        private void listBox_Dolgozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dolgozo kivalasztottDolgozo = (Dolgozo)listBox_Dolgozok.SelectedItem;
            groupBoxFrissitese(kivalasztottDolgozo);
        }
        private void groupBoxFrissitese(Dolgozo kivalasztottDolgozo)
        {
            textBox_ID.Text = kivalasztottDolgozo.id.ToString();
            textBox_Nev.Text = kivalasztottDolgozo.nev;
            dateTimePicker_Szul.Value = kivalasztottDolgozo.szuletes;
            if (kivalasztottDolgozo.nem == "nő")
            {
                radioButton_No.Checked = true;
            } 
            else if (kivalasztottDolgozo.nem=="férfi")
            {
                radioButton_Ferfi.Checked = true;
            } 
            else 
            { 
                radioButton_Egyeb.Checked = true;
            }
        }
        //Dolgozó adatainak módosítása
        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dolgozo kivalasztottDolgozo = (Dolgozo)listBox_Dolgozok.SelectedItem; //hogy az ID-t beolvassa
            string nem = kivalasztottDolgozo.nem;
            if (radioButton_Egyeb.Checked)
            {
                nem = "egyéb";
            }
            else if (radioButton_Ferfi.Checked)
            {
                nem = "férfi";
            }
            else
            {
                nem = "nő";
            }
            ellenorzes();
            Dolgozo updateDolgozo = new Dolgozo(kivalasztottDolgozo.id, textBox_Nev.Text,dateTimePicker_Szul.Value,nem);
            Program.db.updateDolgozo(updateDolgozo); //itt történik a módosítás az adatbázis osztályban
            selectDolgozo(); //frissíti a listát
        }
    }
}
