using FIT.Data;
using FIT.Data.IspitIB210178;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB210178
{
    public partial class frmGradoviIB210178 : Form
    {
        private DrzaveIB210178 odabranaDrzava;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmGradoviIB210178(DrzaveIB210178 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
            pbZastava.Image = odabranaDrzava.Zastava.ToImage();
            lblNaziv.Text = odabranaDrzava.Naziv;
            ucitajGradove();
        }

        private void frmGradoviIB210178_Load(object sender, EventArgs e)
        {
            

         

        }

        private void ucitajGradove()
        {

            var gradovi = db.GradoviIB210178.Where(w => w.DrzavaId == odabranaDrzava.Id).ToList();
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.DataSource = gradovi;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ( validirano()){
                GradoviIB210178 noviGrad = new GradoviIB210178();
                noviGrad.DrzavaId = odabranaDrzava.Id;
                noviGrad.Naziv= odabranaDrzava.Naziv;
                noviGrad.Status = true;
                db.Add(noviGrad);
                db.SaveChanges();
                
                ucitajGradove();
            }


        }

        private bool validirano()
        {
            return Validator.ProvjeriUnos(tbNazivGrada, err, Kljucevi.ReqiredValue);
        }

        

    }
}
