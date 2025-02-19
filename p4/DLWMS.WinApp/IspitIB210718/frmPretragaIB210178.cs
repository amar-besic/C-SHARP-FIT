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

namespace DLWMS.WinApp.IspitIB210718
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
            cbSpol.DataSource = db.SpolIB201178.ToList();

        }
        private void Ucitaj()
        {
            studenti = db.Studenti
               .Include(x => x.Grad.Drzava)
               .Include(x => x.Spol)
               .Where(x => x.Grad.DrzavaId == (cbDrzava.SelectedItem as Drzava).Id)
               .Where(x => x.SpolId == (cbSpol.SelectedItem as Spol).Id)
               .Where(x => x.Ime.ToLower().Contains(tbImePrezime.Text.ToLower()) || x.Prezime.ToLower().Contains(tbImePrezime.Text.ToLower()))
               .ToList();

            dgvStudenti.DataSource = studenti;

            Text = $"Broj pretrazenih studenata je: {studenti.Count()}";

            if (studenti.Count == 0) MessageBox.Show($"Nema studenata sa podacima: \r\n Država: {cbDrzava.SelectedItem} \r\n Spol: {cbSpol.SelectedItem} \r\n Ime ili prezime: {tbImePrezime.Text} "
               , "Obavjest", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpol.SelectedItem != null)
                Ucitaj();
        }


        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Aktivan.Index)
            {
                studenti[e.RowIndex].Aktivan = !studenti[e.RowIndex].Aktivan;
                db.Studenti.Update(studenti[e.RowIndex]);
                db.SaveChanges();
            }
            if (e.ColumnIndex == btnRazmjene.Index)
            {
                var frmRazmjena = new frmRazmjeneIB210178(studenti[e.RowIndex]);
                frmRazmjena.ShowDialog();
            }
        }

        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != btnRazmjene.Index || e.ColumnIndex != Aktivan.Index)
            {
                var frmEDIT = new frmStudentEditIB210178(studenti[e.RowIndex]);
                if (frmEDIT.ShowDialog() == DialogResult.OK) Ucitaj();
            }
        }
    }
}
