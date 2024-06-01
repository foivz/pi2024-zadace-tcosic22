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
    public partial class FrmDodavanje : Form
    {

        public event EventHandler NarudzbaDodana;

        public FrmDodavanje()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                int idStudent = int.Parse(txtStudent.Text);
                int idMeni = int.Parse(txtMeni.Text);
                string vrijeme = Vrijeme.Value.ToString("HH:mm:ss");
                double cijena = double.Parse(txtCijena.Text);
                string status = cboStatus.SelectedItem.ToString();
                string kupon = txtKupon.Text;
                string datum = dtpDatum.Value.ToString("yyyy-MM-dd");
                int idZaposlen = int.Parse(txtZaposlenik.Text);

                Narudzba narudzba = new Narudzba
                {
                    IdStudenta = idStudent,
                    OdabraniMeni = idMeni,
                    VrijemePripreme = vrijeme,
                    Cijena = cijena,
                    Status = status,
                    IskoristenKupon = kupon,
                    Datum = datum,
                    IdZaposlenik = idZaposlen
                };

                RepozitorijNarudzba.DodajNarudzbu(narudzba);

                NarudzbaDodana?.Invoke(this, EventArgs.Empty);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška pri unosu podataka: {ex.Message}");
            }
        }

        private void FrmDodavanje_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Add("Zadana");
            cboStatus.Items.Add("U obradi");
            cboStatus.Items.Add("Pripremljena");
            cboStatus.Items.Add("Poslužena");

            cboStatus.SelectedIndex = 0;

            Vrijeme.Format = DateTimePickerFormat.Time;
            Vrijeme.ShowUpDown = true;
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vrijeme_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
