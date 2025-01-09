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
        private DrzaveIB210178 odabranaDrzava;
        bool edit = false;
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
            if (Validiranje())
            {
                var drzava = new DrzaveIB210178();
                if (edit) drzava = odabranaDrzava;

                drzava.Zastava = pbZastava.Image.ToByteArray();
                drzava.Status = chbAktivan.Checked;
                drzava.Naziv = tbNaziv.Text;


                if(edit) db.DrzaveIB210178.Update(drzava);
                else db.DrzaveIB210178.Add(drzava);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool Validiranje()
        {
            return Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue) && Validator.ProvjeriUnos(tbNaziv, err, Kljucevi.ReqiredValue);
        }

        private void frmNovaDržavaIB210178_Load(object sender, EventArgs e)
        {
            if (edit)  {
            pbZastava.Image = odabranaDrzava.Zastava.ToImage();
            chbAktivan.Checked = odabranaDrzava.Status;
            tbNaziv.Text = odabranaDrzava.Naziv;
            }
        }
    }
}
