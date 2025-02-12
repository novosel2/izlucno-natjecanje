using IzlucnoNatjecanje.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzlucnoNatjecanje.Forms
{
    public partial class NoviKupacForm : Form
    {
        private readonly KupciForm _kupciForm;

        public NoviKupacForm(KupciForm kupciForm)
        {
            InitializeComponent();

            _kupciForm = kupciForm;

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void NoviKupacForm_Load(object sender, EventArgs e)
        {
            textTitula.Hide();

            comboTitula.Items.Add("Mr.");
            comboTitula.Items.Add("Ms.");
            comboTitula.Items.Add("Sr.");
            comboTitula.Items.Add("--");
        }

        private void comboTitula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTitula.SelectedItem.ToString() == "--")
            {
                textTitula.Show();
            }
            else
            {
                textTitula.Hide();
                textTitula.Text = "";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string titula = comboTitula.SelectedItem.ToString();
            string ime = textIme.Text;
            string prezime = textPrezime.Text;

            if (titula == "--")
            {
                titula = textTitula.Text;
            }

            if (string.IsNullOrEmpty(titula) || string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime))
            {
                MessageBox.Show("Niste popunili sva polja.");
            }
            else
            {
                Kupac kupac = new Kupac()
                {
                    Titula = titula,
                    Ime = ime,
                    Prezime = prezime
                };
                _kupciForm.DodajKupca(kupac);
            }

            Close();
        }
    }
}
