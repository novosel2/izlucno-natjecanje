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
    public partial class IzvjestajiForm : Form
    {
        private readonly MainForm _main;

        public IzvjestajiForm(MainForm main)
        {
            InitializeComponent();
            _main = main;

            StartPosition = FormStartPosition.Manual;
            Location = _main.Location;
        }

        private void IzvjestajiForm_FormClosed(object sender, FormClosedEventArgs e)
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
