using IzlucnoNatjecanje.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzlucnoNatjecanje.Forms
{
    public partial class ProizvodiForm : Form
    {
        private readonly MainForm _mainForm;

        public ProizvodiForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = _mainForm.Location;
        }

        private void ProizvodiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medjuzupanijsko2024_v3DataSet7.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.medjuzupanijsko2024_v3DataSet7.Proizvod);
            lblLoading.Show();
            lblFilter.Hide();
            txtFilter.Hide();
            btnFiltriraj.Hide();
            dataGridProizvodi.Hide();

            int width = 0;
            foreach (DataGridViewColumn column in dataGridProizvodi.Columns)
            {
                width += column.Width;
            }

            width += 60;

            dataGridProizvodi.Width = width;

            lblLoading.Hide();
            lblFilter.Show();
            txtFilter.Show();
            btnFiltriraj.Show();
            dataGridProizvodi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProizvodiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Location = this.Location;
            _mainForm.Show();
        }

        private void dataGridProizvodi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridProizvodi.CellFormatting += DataGridProizvodi_CellFormatting;
        }

        private void DataGridProizvodi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value)
            {
                e.Value = "Nije definirano";
            }

            if (e.ColumnIndex == 3)
            {
                if (e.Value != null && e.Value is int id)
                {
                    using (var db = new AppDbContext())
                    {
                        e.Value = db.Potkategorije.SingleOrDefault(p => p.PotkategorijaId == id).Naziv;
                    }
                }
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var filter = txtFilter.Text;

                BindingSource bs = (BindingSource)dataGridProizvodi.DataSource;

                if (bs != null)
                {
                    bs.Filter = $"Naziv LIKE '%{filter}%'";
                }

                int filteredCount = bs.Count;
                int count = db.Proizvodi.Count();

                lblFiltered.Text = $"Prikazano je {filteredCount} od ukupno {count} proizvoda";
                lblFiltered.Visible = true;
            }
        }
    }
}
