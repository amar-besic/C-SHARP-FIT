using DLWMS.Data;
using DLWMS.Data.IspitIB210178;
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

namespace DLWMS.WinApp.IspitIB210178
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
            dgvRazmjena.AutoGenerateColumns = false;
            cbDrzava.DataSource = db.Drzave.ToList();
            this.Text = $"Razmjena studenta: {student.IndexImePrezime}";
            Ucitaj();

            cbUniverzitet2.DataSource = db.UniverzitetiIB210178.ToList();

        }

        private void Ucitaj()
        {

            razmjene = db.RazmjeneIB210178.Where(x => x.Student == student).ToList();
            dgvRazmjena.DataSource = razmjene;
        }

        private void cbDržava_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUniverzitet.DataSource = db.UniverzitetiIB210178.Where(x => x.Drzava == cbDrzava.SelectedItem).ToList();

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                var razmjena = new RazmjeneIB210178();
                razmjena.Okoncana = dtpKraj.Value > DateTime.Now ? false : true;
                
                razmjena.UniverzitetId = (cbUniverzitet.SelectedItem as UniverzitetiIB210178).Id;
                razmjena.ECTS = int.TryParse(tbKredita.Text, out var rezultat) ? rezultat : 1;
                razmjena.PocetakRazmjene = dtpPocetak.Value;
                razmjena.KrajRazmjene = dtpKraj.Value;
                razmjena.StudentId = student.Id;



                db.RazmjeneIB210178.Add(razmjena);
                db.SaveChanges();
                Ucitaj();



            }
        }

        private bool Validacija()
        {
            bool ishod = true;
            if (dtpPocetak.Value > dtpKraj.Value)
            {
                MessageBox.Show("Datum početka nesmje biti veci od datuma kraja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ishod = false;
            }

            if (razmjene.Exists(x => (dtpPocetak.Value >= x.PocetakRazmjene && dtpPocetak.Value <= x.KrajRazmjene)
                || (dtpKraj.Value >= x.PocetakRazmjene && dtpKraj.Value <= x.KrajRazmjene) || (dtpKraj.Value >= x.KrajRazmjene && dtpPocetak.Value <= x.PocetakRazmjene)
                ))
            {
                MessageBox.Show($"U periodu od {dtpPocetak.Value} do {dtpKraj.Value} postoje vec zabiljezene razmjene.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ishod = false;
            }

            if (!Validator.ProvjeriUnos(tbKredita, err, Kljucevi.RequiredField) && !Validator.ProvjeriUnos(cbUniverzitet, err, Kljucevi.RequiredField)) ishod = false;


            if (ishod == false) MessageBox.Show("Nisu ispunjeni svi uslovi.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return ishod;


        }

        private void dgvRazmjena_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == btnObrisi.Index)
            {
                var razmjena = razmjene[e.RowIndex];
                if (MessageBox.Show(
                        "Da li ste sigurni da želite obrisati podatke o razmjeni" +
                        $"\r\n{student.IndexImePrezime} na" +
                        $"\r\nUniverzitet u {razmjena.Univerzitet} ({razmjena.Univerzitet.Drzava})", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.RazmjeneIB210178.Remove(razmjena);
                    db.SaveChanges();
                    Ucitaj();
                }
            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            // 1. dio
            // -- postavljenje threada
            // -- pokretanje threada
            // -- validacija
            // -- [---]

            if (Validacija2())
            {

                Thread thread = new Thread(() => GenerisiRazmjene());
                thread.Start();

            }
        }

     
        private void GenerisiRazmjene()
        {

            // 2. dio
            // -- pohrane
            // -- kalkulacije
            // -- sleep
            string info ="";
            for (int i = 0; i < int.Parse(tbBrojRazmjena.Text); i++)
            {

                var novaRazmjena = new RazmjeneIB210178();
                novaRazmjena.StudentId = student.Id;
                novaRazmjena.UniverzitetId = (cbUniverzitet2.SelectedItem as UniverzitetiIB210178).Id;
                novaRazmjena.ECTS = int.Parse(tbBrojKredita.Text);
                novaRazmjena.PocetakRazmjene = new DateTime(2025,1,1);
                novaRazmjena.KrajRazmjene = novaRazmjena.PocetakRazmjene.AddDays(int.Parse(tbBrojKredita.Text) + (i + 1));
                novaRazmjena.Okoncana = novaRazmjena.KrajRazmjene > DateTime.Now ? false : true;
                db.RazmjeneIB210178.Add(novaRazmjena);
            
                info += $"{i + 1.ToString()}. razmjena za {student.IndexImePrezime} na {cbUniverzitet2.SelectedItem.ToString()} ({new DateTime(2025, 1, 1)} - {new DateTime(2025, 1, 1).AddDays(int.Parse(tbBrojKredita.Text) + (i + 1))}) \r\n";

                Thread.Sleep(300);
             }
                db.SaveChanges();
                

            Action action = () =>
            {
                // 3. dio
                // -- ispisi
                // -- ucitavanje
                // -- mbox

                tbInfo.Text = info;
                Ucitaj();
                MessageBox.Show($"Uspjesno dodano {tbBrojRazmjena.Text} razmjena za studenta {student.IndexImePrezime}.", "Obavještenje",MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            BeginInvoke(action);


        }

        private bool Validacija2()
        {
            bool ishod = true;
            if (!Validator.ProvjeriUnos(tbBrojRazmjena, err, Kljucevi.RequiredField) && !Validator.ProvjeriUnos(tbBrojKredita, err, Kljucevi.RequiredField)) ishod = false;

            return ishod;
        }
    }
}
