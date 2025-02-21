using DLWMS.Data;
using DLWMS.Data.IndeksIB201718;
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

namespace DLWMS.WinApp.IndeksIB201718
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

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validirano())
            {
                var razmjena = new RazmjeneIB210178();
                razmjena.Okoncana = dtpDO.Value < DateTime.Now ? false : true;
                razmjena.PocetakRazmjene = dtpOD.Value;
                razmjena.KrajRazmjene = dtpDO.Value;
                razmjena.ECTS = int.Parse(tbKredit.Text);
                razmjena.StudentId = student.Id;
                razmjena.UniverzitetId = (cbUniverzitet.SelectedItem as UniverzitetiIB210178).Id;
                db.RazmjeneIB210178.Add(razmjena);
                db.SaveChanges();
                Ucitaj();
            }
        }

        private void Ucitaj()
        {
            razmjene = db.RazmjeneIB210178.Where(x => x.StudentId == student.Id).ToList();
            dgvRazmjene.DataSource = razmjene;
        }

        private bool Validirano()
        {
            return Validator.ProvjeriUnos(cbUniverzitet, err, Kljucevi.RequiredField) && Validator.ProvjeriUnos(tbKredit, err, Kljucevi.RequiredField);

        }

        private void cbUniverzitet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUniverzitet.DataSource = db.UniverzitetiIB210178.Where(x => x.DrzavaId == (cbDrzava.SelectedItem as Drzava).Id).ToList();
        }

        private void dgvRazmjene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == btnObrisi.Index)
            {

                if (MessageBox.Show("Da li ste sigurni da zelite obrisati.", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    db.RazmjeneIB210178.Remove(razmjene[e.RowIndex]);
                    db.SaveChanges();
                    Ucitaj();
                }

            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            // 1. dio
            // -- validacija
            // -- postavljenje threada
            // -- pokretanje threada
            // -- sve sto je vezano za combo box 
            if (validacija2())
            {

            Thread thread = new Thread(() => GenerisiRazmjene());
            thread.Start();
            }



        }

        private bool validacija2()
        {
            return Validator.ProvjeriUnos(cbUniveziteti2, err, Kljucevi.RequiredField) && Validator.ProvjeriUnos(tbKredit2, err, Kljucevi.RequiredField) && Validator.ProvjeriUnos(tbBrojRazmjena, err, Kljucevi.RequiredField);
        }

        private void GenerisiRazmjene()
        {
            // 2. dio
            // -- pohrane
            // -- operacije
            // -- sleep 
            
          


            Action action = () =>
            {
                // 3. dio
                // -- ispisi
                // -- mbox
                // -- ucitavanje

            };
            BeginInvoke(action);




        }
    }
}
