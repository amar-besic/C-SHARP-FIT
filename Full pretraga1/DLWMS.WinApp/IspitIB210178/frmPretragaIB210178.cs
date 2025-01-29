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
        Grad grad;
        Spol spol;
        DateTime OD;
        DateTime DO = DateTime.Now;
        bool aktivan = true;
        string ime = "";

        public frmPretragaIB210178()
        {
            InitializeComponent();
        }

        private void frmPretragaIB210178_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;

            cbGrad.DataSource = db.Gradovi.ToList();
            cbSpol.DataSource = db.SpolIB210178.ToList();
            studenti = db.Studenti.ToList();

            Popuni();
        }

        private void Popuni()
        {


            var studentiPretrazeni = studenti.Where(s => s.GradId == grad.Id).Where(s => s.SpolId == spol.Id).Where(s => s.Aktivan == aktivan).Where(s => s.DatumRodjenja > OD).Where(s => s.DatumRodjenja < DO).Where(s=> s.Ime.ToLower().Contains(ime.ToLower()) || s.Prezime.ToLower().Contains(ime.ToLower())).ToList();

            

            dgvStudenti.DataSource = studentiPretrazeni;
            if (dgvStudenti.RowCount == 0) MessageBox.Show("Test");
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            grad = cbGrad.SelectedItem as Grad;
            Popuni();
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            spol = cbSpol.SelectedItem as Spol;
            Popuni();
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            aktivan = chbAktivan.Checked;
            Popuni();
        }

        private void dtpOD_ValueChanged(object sender, EventArgs e)
        {
            OD = dtpOD.Value;
            Popuni();
        }

        private void dtpDO_ValueChanged(object sender, EventArgs e)
        {
            DO = dtpDO.Value;
            Popuni();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            ime = tbImePrezime.Text;
            Popuni();
            //kontejns
        }
    }
}
