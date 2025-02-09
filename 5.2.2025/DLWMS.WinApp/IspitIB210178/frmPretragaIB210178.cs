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
        bool mb = true;
        private void frmPretragaIB210178_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbDrzava.DataSource = db.Drzave.ToList();
            cbSpol.DataSource = db.SpoloviIB210178.ToList();

            ucitaj();


        }

        private void ucitaj()
        {
            studenti= db.Studenti.Include(x => x.Grad.Drzava)
            .Where(x => x.Aktivan == chbAktivan.Checked)
            .Where(x => x.Grad.Drzava == cbDrzava.SelectedItem)
            .Where(x => x.Spol == cbSpol.SelectedItem)
            .Where(x => (x.Ime + " " + x.Prezime).ToLower().Contains(tbImePrezime.Text.ToLower()))
            .Where(x => x.DatumRodjenja > dtpOD.Value)
            .Where(x => x.DatumRodjenja < dtpDO.Value)
            .ToList();

            dgvStudenti.DataSource = studenti;

            this.Text = $"Broj prikazanih studenata: {dgvStudenti.RowCount}";


            if (dgvStudenti.RowCount == 0)
            {
                if (mb == false)
                    MessageBox.Show($"U bazi nisu evidentirani studentin spola {cbSpol.SelectedItem}, koji u imenu i prezimenu posjeduju sadržaj {tbImePrezime.Text}, a koji su državljani {cbDrzava.SelectedItem}", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                mb = true;
            }
            else { mb = false; }

        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void dtpOD_ValueChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void dtpDO_ValueChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void IDod_TextChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void IDdo_TextChanged(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == Razmjena.Index)
            {


            }
            if (e.ColumnIndex == Aktivan.Index)
            {
                var student = studenti[e.RowIndex];
                student.Aktivan = !student.Aktivan;
                db.Studenti.Update(student);
                db.SaveChanges();
                ucitaj();
            }
        }

        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != Razmjena.Index)
            {

                var frmEdit = new frmStudentEditIB210178(studenti[e.RowIndex]);

                if(frmEdit.ShowDialog() == DialogResult.OK) { ucitaj(); }
            }
        }

       
    }
}
