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

namespace DLWMS.WinApp.IndeksIB201718
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
                .Include(x => x.Grad.Drzava)
                .Include(x => x.Spol)
                .Where(x => x.Grad.DrzavaId == (cbDrzava.SelectedItem as Drzava).Id)
                .Where(x => x.SpolId == (cbSpol.SelectedItem as Spol).Id)
                .Where(x => x.Ime.ToLower().Contains(tbIMePrezime.Text.ToLower()) || x.Prezime.ToLower().Contains(tbIMePrezime.Text.ToLower()))
                .ToList();

            dgvStudenti.DataSource = studenti;

            if (studenti.Count == 0) {
                MessageBox.Show($"Nema studenta sa podacima \r\n Država: {cbDrzava.SelectedItem.ToString()}\r\n Spol: {cbSpol.SelectedItem.ToString()}\r\n Sa imenom ili prezimenom: {tbIMePrezime.Text}","Upozorenje ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            Text = $"Broj pretrazenih studenata: {studenti.Count()}";
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

        private void tbIMePrezime_TextChanged(object sender, EventArgs e)
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
                Ucitaj();

            }
            if (e.ColumnIndex == btnRazmjene.Index)
            {
                var Razmjena = new frmRazmjeneIB210178(studenti[e.RowIndex]);
                Razmjena.ShowDialog();
            }
        }

        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != Aktivan.Index || e.ColumnIndex != btnRazmjene.Index)
            {
                var EDIT = new frmStudentEditIB210178(studenti[e.RowIndex]);
                if(EDIT.ShowDialog() == DialogResult.OK) Ucitaj();
            }
        }
    }
}
