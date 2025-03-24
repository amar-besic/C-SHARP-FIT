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
        }

        private void frmStudentEditIB210178_Load(object sender, EventArgs e)
        {
            lblIme.Text = student.ToString();
            lblIndex.Text = student.BrojIndeksa;
            pbSlika.Image = student.Slika.ToImage();

            cbDrzava.DataSource = db.Drzave.ToList();
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGrad.DataSource = db.Gradovi.Where(x => x.DrzavaId == (cbDrzava.SelectedItem as Drzava).Id).ToList();
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if(ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdSlika.FileName);
            }
        }

        private void pbSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validte())
            {
                student.Slika = pbSlika.Image.ToByteArray();
                student.GradId = (cbGrad.SelectedItem as Grad).Id;
                student.Grad = cbGrad.SelectedItem as Grad;

                db.Update(student);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool Validte()
        {
            return Validator.ProvjeriUnos(pbSlika, err, Kljucevi.RequiredField) && Validator.ProvjeriUnos(cbDrzava, err, Kljucevi.RequiredField)&& Validator.ProvjeriUnos(cbGrad, err, Kljucevi.RequiredField);
        }
    }
}
