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

namespace DLWMS.WinApp.IndeksIB201718
{
    public partial class frmStudentEditIB210178 : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();


        public frmStudentEditIB210178(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentEditIB210178_Load(object sender, EventArgs e)
        {
            pbSlika.Image = student.Slika.ToImage();
            lblIme.Text = student.ToString();
            lblIndex.Text = student.BrojIndeksa;

            cbDrzava.DataSource = db.Drzave.ToList();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdSlika.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validator.ProvjeriUnos(cbGrad, err, Kljucevi.RequiredField))
            {
                student.GradId = (cbGrad.SelectedItem as Grad).Id;
                student.Grad = cbGrad.SelectedItem as Grad;
                student.Slika = pbSlika.Image.ToByteArray();
                db.Studenti.Update(student);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGrad.DataSource = db.Gradovi.Where(x=> x.DrzavaId == (cbDrzava.SelectedItem as Drzava).Id).ToList();
        }
    }
}
