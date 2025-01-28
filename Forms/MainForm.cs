using IzlucnoNatjecanje.assets;
using IzlucnoNatjecanje.Forms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuDostava_Click(object sender, EventArgs e)
        {
            Hide();
            var dostavaForm = new DostavaForm(this);

            dostavaForm.ShowDialog();
        }
        private void btnDostava_Click(object sender, EventArgs e)
        {
            Hide();
            var dostavaForm = new DostavaForm(this);

            dostavaForm.ShowDialog();
        }


        private void menuProizvodi_Click(object sender, EventArgs e)
        {
            Hide();
            var proizvodiForm = new ProizvodiForm(this);

            proizvodiForm.ShowDialog();
        }
        private void btnProizvodi_Click(object sender, EventArgs e)
        {
            Hide();
            var proizvodiForm = new ProizvodiForm(this);

            proizvodiForm.ShowDialog();
        }

        private void menuKupci_Click(object sender, EventArgs e)
        {
            Hide();
            var kupciForm = new KupciForm(this);

            kupciForm.ShowDialog();
        }
        private void btnKupci_Click(object sender, EventArgs e)
        {
            Hide();
            var kupciForm = new KupciForm(this);

            kupciForm.ShowDialog();
        }

        private void menuIzvjestaji_Click(object sender, EventArgs e)
        {
            Hide();
            var izvjestajiForm = new IzvjestajiForm(this);

            izvjestajiForm.ShowDialog();
        }
        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            Hide();
            var izvjestajiForm = new IzvjestajiForm(this);

            izvjestajiForm.ShowDialog();
        }
    }
}
