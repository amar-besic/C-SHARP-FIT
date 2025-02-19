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
        public frmPretragaIB210178()
        {
            InitializeComponent();
        }
        List<Student> studenti;
        private void frmPretragaIB210178_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbDrzava.DataSource = db.Drzave.ToList() ;
            cbSpol.DataSource = db.SpoloviIB210178.ToList();


        }

        private void Ucitaj()
        {

            

            studenti = db.Studenti
                  .Include(x => x.Grad.Drzava)
                  .Include(x => x.Spol)
                 .Where(x => x.Grad.DrzavaId == (cbDrzava.SelectedItem as Drzava ?? new Drzava()).Id)
                 .Where(x => x.SpolId == (cbSpol.SelectedItem as Spol ?? new Spol()).Id)
                 .Where(x => x.Ime.ToLower().Contains(tbImePrezime.Text.ToLower()) || x.Prezime.ToLower().Contains(tbImePrezime.Text.ToLower()))
                  .ToList();

            dgvStudenti.DataSource = studenti;

            Text = $"Broj prikazanih studenata: {studenti.Count}";


            if (studenti.Count == 0 && cbSpol.SelectedItem != null) 
                MessageBox.Show(
                $"Nema studenata sa podacima\r\n" +
                $"Država: {cbDrzava.SelectedItem} \r\n" +
                $"Spol: {cbSpol.SelectedItem} \r\n" +
                $"Imena ili prezimena: {tbImePrezime.Text}"
                ,"Obavjest",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                Ucitaj();
            }
            else if (e.ColumnIndex == btnRazmjena.Index)
            {
                var razmjena = new frmRazmjeneIB210178(studenti[e.RowIndex]);
                if (DialogResult.OK == razmjena.ShowDialog())
                    Ucitaj();

            }

        }

        private void dgvStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != Aktivan.Index && e.ColumnIndex != btnRazmjena.Index)
            {
                var frmEDIT = new frmStudentEditIB210178(studenti[e.RowIndex]);
                if (DialogResult.OK == frmEDIT.ShowDialog())
                    Ucitaj();
            }
           
        }
    }
}
