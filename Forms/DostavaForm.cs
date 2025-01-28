using IzlucnoNatjecanje.Data;
using IzlucnoNatjecanje.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzlucnoNatjecanje.assets
{
    public partial class DostavaForm : Form
    {
        private readonly MainForm _main;
        private readonly DostavaRepository _dostavaRepository;
        public List<MetodaDostave> MetodeDostave = new List<MetodaDostave>();

        public DostavaForm(MainForm mainForm)
        {
            InitializeComponent();
            _main = mainForm;
            _dostavaRepository = new DostavaRepository();

            StartPosition = FormStartPosition.Manual;
            Location = _main.Location;
        }



        private async void DostavaForm_LoadAsync(object sender, EventArgs e)
        {
            comboMetode.Hide();
            label1.Hide();
            lblLoading.Show();

            MetodeDostave = await Task.Run(() => _dostavaRepository.GetAllAsync());

            comboMetode.Items.AddRange(MetodeDostave.ToArray());

            lblLoading.Hide();
            comboMetode.Show();
            label1.Show();
        }

        private void DostavaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Location = Location;
            _main.Show();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboMetode_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodaDostave selectedItem = comboMetode.SelectedItem as MetodaDostave;

            if (IsSelectedNull(selectedItem))
            {
                return;
            }

            txtNaziv.Text = selectedItem.Naziv;
            txtCijena.Text = selectedItem.Cijena.ToString();
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            MetodaDostave selectedItem = comboMetode.SelectedItem as MetodaDostave;
            lblError.Text = "";
            lblError.Visible = false;
            lblSucceed.Visible = false;

            if (IsSelectedNull(selectedItem))
            {
                return;
            }

            string noviNaziv = txtNaziv.Text;
            decimal novaCijena;

            CheckValues(noviNaziv, out novaCijena);

            if (lblError.Visible)
                return;

            MetodaDostave novaMetodaDostave = new MetodaDostave()
            {
                MetodaDostaveId = selectedItem.MetodaDostaveId,
                Racun = selectedItem.Racun,
                Naziv = noviNaziv,
                Cijena = novaCijena
            };

            _dostavaRepository.Update(selectedItem, novaMetodaDostave);

            if (! await _dostavaRepository.IsSavedAsync())
            {
                lblError.Text += " *Nismo uspjeli spremiti promjene, pokušaj ponovno* ";
                lblError.Visible = true;

                return;
            }

            MetodeDostave.Remove(selectedItem);
            MetodeDostave.Add(novaMetodaDostave);

            comboMetode.Items.Clear();
            comboMetode.Items.AddRange(MetodeDostave.ToArray());
            comboMetode.SelectedItem = novaMetodaDostave;

            lblSucceed.Visible = true;
        }

        private void CheckValues(string noviNaziv, out decimal novaCijena)
        {
            if (!decimal.TryParse(txtCijena.Text, out novaCijena))
            {
                lblError.Text += " *Cijena mora biti broj* ";
                lblError.Visible = true;
            }
            if (novaCijena < 0)
            {
                lblError.Text += " *Cijena mora biti veća od 0* ";
                lblError.Visible = true;
            }
            if (noviNaziv.Length < 3)
            {
                lblError.Text += " *Naziv mora imati barem 3 slova* ";
                lblError.Visible = true;
            }
        }

        private bool IsSelectedNull(MetodaDostave selectedItem)
        {
            if (selectedItem == null)
            {
                txtNaziv.Text = "";
                txtCijena.Text = "";

                txtNaziv.Visible =
                txtCijena.Visible =
                lblNaziv.Visible =
                lblCijena.Visible =
                btnSpremi.Visible = false;

                return true;
            }

            txtNaziv.Visible =
            txtCijena.Visible =
            lblNaziv.Visible =
            lblCijena.Visible =
            btnSpremi.Visible = true;

            return false;
        }
    }
}
