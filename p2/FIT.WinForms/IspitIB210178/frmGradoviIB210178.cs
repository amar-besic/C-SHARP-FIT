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
        DLWMSDbContext db = new DLWMSDbContext();
        DrzaveIB210178 odabranaDrzava;
        List<GradoviIB210178> Gradovi;

        public frmGradoviIB210178(Data.IspitIB210178.DrzaveIB210178 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;


        }

        private void frmGradoviIB210178_Load(object sender, EventArgs e)
        {
            ucitajHeder();

            ucitajGradove();




        }

        private void ucitajHeder()
        {
            pbZastava.Image = odabranaDrzava.Zastava.ToImage();
            lblNaziv.Text = odabranaDrzava.Naziv.ToString();
        }

        private void ucitajGradove()
        {
            dgvGradovi.AutoGenerateColumns = false;

            var gradovi = db.GradoviIB210178.Where(w => w.DrzavaId == odabranaDrzava.Id).ToList();
            Gradovi = gradovi;
            dgvGradovi.DataSource = gradovi;


        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnPromjeni.Index)
            {
                var odabranigrad = Gradovi[e.RowIndex];
                odabranigrad.Status = !odabranigrad.Status;
                db.GradoviIB210178.Update(odabranigrad);
                db.SaveChanges();
                ucitajGradove();
               
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
                
        }
    }
}
