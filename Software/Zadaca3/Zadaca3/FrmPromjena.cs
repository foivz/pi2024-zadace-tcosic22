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
    public partial class FrmPromjena : Form
    {

        public EventHandler StatusIzmjenjen;

        public FrmPromjena()
        {
            InitializeComponent();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPromjena_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Add("Zadana");
            cboStatus.Items.Add("U obradi");
            cboStatus.Items.Add("Pripremljena");
            cboStatus.Items.Add("Poslužena");

            cboStatus.SelectedIndex = 0;

            dtpVrijeme.Format = DateTimePickerFormat.Time;
            dtpVrijeme.ShowUpDown = true;
        }

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            try
            {
                int idStudent = int.Parse(txtStudent.Text);
                int idMeni = int.Parse(txtMeni.Text);
                string vrijeme = dtpVrijeme.Value.ToString("HH:mm:ss");
                string status = cboStatus.SelectedItem.ToString();

                RepozitorijNarudzba.PromijeniStatus(idStudent, idMeni, vrijeme, status);

                StatusIzmjenjen?.Invoke(this, EventArgs.Empty);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška pri unosu podataka: {ex.Message}");
            }
        }
    }
}
