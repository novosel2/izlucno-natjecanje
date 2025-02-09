using IzlucnoNatjecanje.Data;
using IzlucnoNatjecanje.Data.Repositories;
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
    public partial class KupciForm : Form
    {
        private readonly MainForm _main;
        private BindingSource kupciBindingSource = new BindingSource();
        private readonly AppDbContext db;

        public KupciForm(MainForm main)
        {
            InitializeComponent();
            _main = main;

            StartPosition = FormStartPosition.Manual;
            Location = _main.Location;

            db = new AppDbContext();
            dataGridKupci.DataSource = kupciBindingSource;
        }

        private void KupciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Location = Location;
            _main.Show();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void KupciForm_LoadAsync(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            dataGridKupci.Visible = false;
            btnNovi.Visible = false;

            var kupci = await Task.Run(() => db.Kupci
                .Include(k => k.Racun)
                .ToListAsync());

            kupciBindingSource.DataSource = kupci.Select(k => new
            {
                k.KupacId,
                k.Ime,
                k.Prezime,
                k.Titula,
                Racun = new string('*', k.Racun.Count),
                Tag = k
            });
                
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Brisanje";
            deleteButtonColumn.Text = "OBRIŠI";
            deleteButtonColumn.Name = "btnDelete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 100;

            dataGridKupci.Columns.Add(deleteButtonColumn);


            lblLoading.Visible = false;
            dataGridKupci.Visible = true;
            btnNovi.Visible = true;
        }

        private async void dataGridKupci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridKupci.Columns["btnDelete"].Index)
            {
                var selectedKupac = (Kupac)dataGridKupci.Rows[e.RowIndex].DataBoundItem;

                if (selectedKupac == null)
                {
                    return;
                }

                var kupacId = selectedKupac.KupacId;

                if (kupacId != null)
                {
                    var kupac = await db.Kupci
                        .SingleOrDefaultAsync(k => k.KupacId == kupacId);
                }


            }
        }
    }
}
