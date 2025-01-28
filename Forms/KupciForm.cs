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
        private readonly MainForm _main;

        public KupciForm(MainForm main)
        {
            InitializeComponent();
            _main = main;

            StartPosition = FormStartPosition.Manual;
            Location = _main.Location;
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
    }
}
