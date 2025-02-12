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
    public partial class KupciForm : Form
    {
        private readonly MainForm _mainForm;

        public KupciForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
        }

        private void KupciForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medjuzupanijsko2024_v3DataSet8.Kupac' table. You can move, or remove it, as needed.
            
            this.StartPosition = FormStartPosition.Manual;
            this.Location = _mainForm.Location;

            dataGridKupci.CellFormatting += DataGridKupci_CellFormatting;

            LoadKupci();

            int width = 60;
            foreach (DataGridViewColumn column in dataGridKupci.Columns)
            {
                width += column.Width;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridKupci.Width = width;
        }

        private void DataGridKupci_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.Value == null || e.Value == DBNull.Value)
                {
                    e.Value = "Nije definirano";
                }
            }
        }

        private void dataGridKupci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new AppDbContext())
            {
                if (e.RowIndex >= 0 && dataGridKupci.Columns[e.ColumnIndex].Name == "Brisanje")
                {
                    BindingSource bs = (BindingSource)dataGridKupci.DataSource;
                    DataRowView rowView = (DataRowView)bs.Current;
                    int id = Convert.ToInt32(rowView["KupacId"]);

                    string stars = dataGridKupci.Rows[e.RowIndex].Cells["IzdaniRacuni"].Value?.ToString();

                    if (string.IsNullOrEmpty(stars))
                    {
                        bs.RemoveAt(e.RowIndex);

                        db.Kupci.Remove(db.Kupci.SingleOrDefault(k => k.KupacId == id));
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Kupac ima izdane račune, ne možete ga obrisati");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KupciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.Location = this.Location;
            _mainForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NoviKupacForm noviKupacForm = new NoviKupacForm(this);

            noviKupacForm.ShowDialog();
        }

        private void LoadKupci()
        {
            this.kupacTableAdapter.Fill(this.medjuzupanijsko2024_v3DataSet8.Kupac);

            if (dataGridKupci.Columns["Izdani računi"] == null)
            {
                DataGridViewTextBoxColumn izdaniRacuni = new DataGridViewTextBoxColumn();
                izdaniRacuni.Name = "IzdaniRacuni";
                izdaniRacuni.HeaderText = "Izdani računi";

                dataGridKupci.Columns.Add(izdaniRacuni);
            }

            if (dataGridKupci.Columns["Brisanje"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Brisanje";
                deleteButton.HeaderText = "Brisanje";
                deleteButton.Text = "Brisanje";
                deleteButton.UseColumnTextForButtonValue = true;

                dataGridKupci.Columns.Add(deleteButton);
            }

            using (var db = new AppDbContext())
            {
                foreach (DataGridViewRow row in dataGridKupci.Rows)
                {
                    BindingSource bs = (BindingSource)dataGridKupci.DataSource;
                    DataRowView bsRow = (DataRowView)bs[row.Index];
                    if (bsRow != null)
                    {
                        int id = Convert.ToInt32(bsRow["KupacId"]);
                        int count = db.Racuni.Where(r => r.KupacId == id).Count();
                        row.Cells[3].Value = new string('*', count);
                    }
                }
            }
        }

        public void DodajKupca(Kupac noviKupac)
        {
            using (var db = new AppDbContext())
            {
                db.Kupci.Add(noviKupac);
                db.SaveChanges();
            }

            LoadKupci();
        }
    }
}
