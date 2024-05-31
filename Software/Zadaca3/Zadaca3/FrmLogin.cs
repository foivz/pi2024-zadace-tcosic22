using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca3
{
    public partial class FrmLogin : Form
    {
        string username = "AnaLaric12";
        string password = "lozinka1";
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
                if(txtUsername.Text == username && txtPassword.Text == password)
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
