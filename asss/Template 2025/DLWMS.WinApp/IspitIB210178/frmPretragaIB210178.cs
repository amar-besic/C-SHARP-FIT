using DLWMS.Data;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IspitIB210178
{
    public partial class frmPretragaIB210178 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> studenti;

        public frmPretragaIB210178()
        {
            InitializeComponent();
        }

        private void frmPretragaIB210178_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbDrzava.DataSource = db.Drzave.ToList();
           cbSpol.DataSource = db.SpoloviIB210178.ToList();

        }
        private void Ucitaj()
        {
           studenti = db.Studenti
                .Include(x=> x.Grad.Drzava)
                .Include(x=> x.Spol)
                
                .ToList();

            dgvStudenti.DataSource = studenti;

        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSpol.SelectedItem != null)
            Ucitaj();
        }


        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }
      
    }
}
