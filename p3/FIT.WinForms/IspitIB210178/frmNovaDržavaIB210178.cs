using FIT.Data;
using FIT.Data.IspitIB210178;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
        public frmNovaDržavaIB210178()
        {
            InitializeComponent();
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (ofdZastava.ShowDialog() == DialogResult.OK)
                pbZastava.Image = Image.FromFile(ofdZastava.FileName);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)  {
            if (validirano())
            {
                DrzaveIB210178 drzava=new DrzaveIB210178();
                
                drzava.Zastava = pbZastava.Image.ToByteArray();
                drzava.Naziv = tbNazivDrzave.Text;
                drzava.Status = chbAktivan.Checked;

               db.DrzaveIB210178.Add(drzava);
                db.SaveChanges();
                DialogResult= DialogResult.OK;

            }
        }

        private bool validirano()
        {
            return Validator.ProvjeriUnos(pbZastava,err,Kljucevi.ReqiredValue) && Validator.ProvjeriUnos(tbNazivDrzave, err, Kljucevi.ReqiredValue);
        }
    }
}
