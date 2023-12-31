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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_Belepes_Click(object sender, EventArgs e)
        {
            //Ki vannak e töltve a mezők?
            if (string.IsNullOrEmpty(textBox_Felhasznalo.Text))
            {
                MessageBox.Show("Nincs megadva felhasználónév!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Felhasznalo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Jelszo.Text))
            {
                MessageBox.Show("Nincs megadva jelszó!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Jelszo.Focus();
                return;
            }
            if (textBox_Felhasznalo.Text=="admin"&&textBox_Jelszo.Text=="admin")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox_Jelszo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                button_Belepes_Click(sender, e);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //betöltéskor mit tegyen
        }
    }
}
