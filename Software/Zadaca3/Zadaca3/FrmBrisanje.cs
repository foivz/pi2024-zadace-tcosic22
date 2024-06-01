using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadaca3.Repositories;

namespace Zadaca3
{
    public partial class FrmBrisanje : Form
    {
        public EventHandler NarudzbaObrisana;
        public FrmBrisanje()
        {
            InitializeComponent();
        }

        private void FrmBrisanje_Load(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int idStudent = int.Parse(txtStudent.Text);
                int idMeni = int.Parse(txtMeni.Text);

                var result = MessageBox.Show("Jeste li sigurni da želite obrisati odabranu narudžbu?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    RepozitorijNarudzba.ObrisiNarudzbu(idStudent, idMeni);
                }

                NarudzbaObrisana?.Invoke(this, EventArgs.Empty);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Pogreška pri unosu podataka: {ex.Message}");
            }
        }
    }
}
