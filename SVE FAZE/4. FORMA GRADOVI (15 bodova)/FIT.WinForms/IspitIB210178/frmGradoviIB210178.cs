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
        List<GradoviIB210178> gradovi;
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

             gradovi = db.GradoviIB210178.Where(w => w.DrzavaId == odabranaDrzava.Id).ToList();
            dgvGradovi.AutoGenerateColumns = false;
            dgvGradovi.DataSource = gradovi;
        }

      

       

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            if (validirano())
            {
                GradoviIB210178 noviGrad = new GradoviIB210178();
                noviGrad.DrzavaId = odabranaDrzava.Id;
                noviGrad.Naziv = tbNazivGrada.Text;
                noviGrad.Status = true;
                db.GradoviIB210178.Add(noviGrad);
                db.SaveChanges();

                ucitajGradove();
            }
        }

        private bool validirano()
        {
            if( Validator.ProvjeriUnos(tbNazivGrada, err, Kljucevi.ReqiredValue))
            {
                for (int i = 0; i < gradovi.Count; i++)
                {
                    if (gradovi[i].Naziv.ToLower() == tbNazivGrada.Text.ToLower())
                    {
                        MessageBox.Show($"Grad {gradovi[i]} vec postoji" );
                        return false;
                    }
                }
                return true;
            }
            return false;
       
        }
    }
}
