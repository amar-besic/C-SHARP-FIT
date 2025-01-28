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
    public partial class frmNovaDržavaIB210178 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        bool edit = false;
        private DrzaveIB210178 odabranaDrzava;

        public frmNovaDržavaIB210178()
        {
            InitializeComponent();
            
        }

        public frmNovaDržavaIB210178(DrzaveIB210178 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;
            edit = true;
        }


       

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (ofdZastava.ShowDialog() == DialogResult.OK)
                pbZastava.Image = Image.FromFile(ofdZastava.FileName);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validirano())
            {
                var drzava = new DrzaveIB210178();
                if (edit) drzava = odabranaDrzava;
                drzava.Zastava = pbZastava.Image.ToByteArray();
                drzava.Naziv = tbNaziv.Text;
                drzava.Status = chbAktivan.Checked;

                if (edit) db.DrzaveIB210178.Update(drzava);

                else db.DrzaveIB210178.Add(drzava);
                
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool Validirano()
        {
            return Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue) && Validator.ProvjeriUnos(tbNaziv, err, Kljucevi.ReqiredValue);
        }

        private void frmNovaDržavaIB210178_Load(object sender, EventArgs e)
        {
            if (edit) dodjeliOdabranu();
            
        }

        private void dodjeliOdabranu() {
            pbZastava.Image = odabranaDrzava.Zastava.ToImage();
            tbNaziv.Text = odabranaDrzava.Naziv;
            chbAktivan.Checked = odabranaDrzava.Status;
        }
    }
}
