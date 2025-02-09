using DLWMS.Data;
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
    public partial class frmStudentEditIB210178 : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();
        public frmStudentEditIB210178(Student student)
        {
            InitializeComponent();
            this.student = student;

            cbDrzava.DataSource = db.Drzave.ToList();
            cbDrzava.SelectedIndex = student.Grad.Drzava.Id - 1;
            cbGrad.DataSource = db.Gradovi.Where(x => x.Drzava == cbDrzava.SelectedItem).ToList();

            var gradoviDrzave = db.Gradovi.Where(x => x.Drzava == cbDrzava.SelectedItem).ToList();

            var redniBroj = 0;

            for (int i = 0; i < gradoviDrzave.Count(); i++)
                if (gradoviDrzave[i].Id == student.GradId)
                    redniBroj = i;


            cbGrad.SelectedIndex = redniBroj;


            pbSlika.Image = student.Slika.ToImage();


            lblImePrezime.Text = $"{student.Ime} {student.Prezime}";
            lblIndex.Text = student.BrojIndeksa;
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGrad.DataSource = db.Gradovi.Where(x => x.Drzava == cbDrzava.SelectedItem).ToList();

        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validirano())
            {
                student.Slika = pbSlika.Image.ToByteArray();
                student.GradId = (cbGrad.SelectedItem as Grad).Id;
                student.Grad = cbGrad.SelectedItem as Grad;
                
                db.Studenti.Update(student);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool validirano()
        {
            return Validator.ProvjeriUnos(pbSlika, err, Kljucevi.RequiredField);
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if(ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdSlika.FileName);
            }
        }
    }
}
