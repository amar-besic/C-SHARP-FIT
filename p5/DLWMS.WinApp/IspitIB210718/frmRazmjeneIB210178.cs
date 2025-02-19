using DLWMS.Data;
using DLWMS.Data.IspitIB210718;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmRazmjeneIB210178 : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();
        List<RazmjeneIB210178> razmjene;

        public frmRazmjeneIB210178(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmRazmjeneIB210178_Load(object sender, EventArgs e)
        {
            dgvRazmjene.AutoGenerateColumns = false;
            cbDrzava.DataSource = db.Drzave.ToList();
            Ucitaj();
            Text = $"Razmjene studenta {student}";
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            if (validirao())
            {
                var novaRazmjena = new RazmjeneIB210178();
                novaRazmjena.StudentId = student.Id;
                novaRazmjena.Okoncana = dtpDO.Value < DateTime.Now ? true : false;
                novaRazmjena.UniverzitetId = (cbUniverzitet.SelectedItem as UniverzitetiIB210178).Id;
                novaRazmjena.PocetakRazmjene = dtpOD.Value;
                novaRazmjena.KrajRazmjene = dtpDO.Value;
                novaRazmjena.ECTS = int.Parse(tbKredit.Text);
                db.RazmjeneIB210178.Add(novaRazmjena);
                db.SaveChanges();
                Ucitaj();
            }
        }

        private bool validirao()
        {
            return Validator.ProvjeriUnos(tbKredit, errorProvider1, Kljucevi.RequiredField) && Validator.ProvjeriUnos(cbUniverzitet, errorProvider1, Kljucevi.RequiredField) &&
                Validator.ProvjeriUnos(cbDrzava, errorProvider1, Kljucevi.RequiredField);
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUniverzitet.DataSource = db.UniverzitetiIB210178.Where(x => x.DrzavaId == (cbDrzava.SelectedItem as Drzava).Id).ToList();

        }

        private void cbUniverzitet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ucitaj()
        {
           razmjene =  db.RazmjeneIB210178.Where(x => x.StudentId == student.Id).ToList();

            dgvRazmjene.DataSource = razmjene;
        }

        private void dgvRazmjene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == btnObrisi.Index)
            {
                if (MessageBox.Show("Test", "Obavjest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.RazmjeneIB210178.Remove(razmjene[e.RowIndex]);
                    db.SaveChanges();
                    Ucitaj();
                } 
            }
        }
    }
}
