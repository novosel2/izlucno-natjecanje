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

namespace IzlucnoNatjecanje
{
    public partial class ProizvodiForm : Form
    {
        private readonly MainForm _main;
        private readonly PotkatekorijaRepository _potkategorijaRepository;
        public List<Potkategorija> Potkategorije = new List<Potkategorija>();

        public ProizvodiForm(MainForm main)
        {
            InitializeComponent();
            _main = main;
            _potkategorijaRepository = new PotkatekorijaRepository();

            StartPosition = FormStartPosition.Manual;
            Location = _main.Location;
        }

        private void ProizvodiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Location = Location;
            _main.Show();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ProizvodiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medjuzupanijsko2024_v3DataSet.Proizvod' table. You can move, or remove it, as needed.
            this.proizvodTableAdapter.Fill(this.medjuzupanijsko2024_v3DataSet.Proizvod);
            dataProizvodi.Visible = false;
            lblLoading.Visible = true;

            Potkategorije = await Task.Run(() => _potkategorijaRepository.GetAllAsync());

            dataProizvodi.CellFormatting += DataProizvodi_CellFormatting;

            dataProizvodi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataProizvodi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            lblLoading.Visible = false;
            dataProizvodi.Visible = true;
        }

        private void DataProizvodi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.Value == DBNull.Value)
            {
                e.Value = "Nije definirano";
                return;
            }

            else if (e.ColumnIndex == 3)
            {
                if (!int.TryParse(e.Value.ToString(), out int id))
                {
                    e.Value = "Nije definirano";
                    return;
                }

                e.Value = Potkategorije.SingleOrDefault(p => p.PotkategorijaId == id).Naziv;
            }
        }

        private void dataProizvodi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int width = 0;

            foreach (DataGridViewColumn column in dataProizvodi.Columns)
            {
                width += column.Width;
            }

            dataProizvodi.Width = width + 60;
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string filter = txtFilter.Text;

            int fullCount = dataProizvodi.RowCount;

            BindingSource bs = new BindingSource();
            bs.DataSource = dataProizvodi.DataSource;

            bs.Filter = dataProizvodi.Columns[0].HeaderText.ToString() + " LIKE '%" + filter + "%'";

            dataProizvodi.DataSource = bs;

            int currentCount = dataProizvodi.RowCount;

            lblPrikazano.Text = $"Prikazano je {currentCount} od ukupno {fullCount} proizvoda.";
            lblPrikazano.Visible = true;
        }
    }
}
