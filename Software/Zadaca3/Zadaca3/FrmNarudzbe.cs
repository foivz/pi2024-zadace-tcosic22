using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca3.Models;
using Zadaca3.Repositories;

namespace Zadaca3
{
    public partial class FrmNarudzbe : Form
    {
        public FrmNarudzbe()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmNarudzbe_Load(object sender, EventArgs e)
        {
            PrikaziNarudzbe();
        }

        private void PrikaziNarudzbe()
        {
            List<Narudzba> narudzbe = RepozitorijNarudzba.DohvatiNarudzbe();
            dgvNarudzbe.DataSource = narudzbe;
        }
    }
}
