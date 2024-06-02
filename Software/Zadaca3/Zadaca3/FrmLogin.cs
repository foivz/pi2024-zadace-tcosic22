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
    public partial class FrmLogin : Form
    {
        public static Zaposlenik UlogiraniZaposlenik { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Nije uneseno korisničko ime!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Nije unesena lozinka!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                UlogiraniZaposlenik = RepozitorijZaposlenik.DohvatiZaposlenika(txtUsername.Text);

                if(UlogiraniZaposlenik != null && UlogiraniZaposlenik.ProvjeriLozinku(txtPassword.Text))
                {
                    FrmNarudzbe frmNarudzbe = new FrmNarudzbe();
                    Hide();
                    frmNarudzbe.ShowDialog();
                    Close();
                }

                else
                {
                    MessageBox.Show("Uneseni krivi korisnički podaci!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
