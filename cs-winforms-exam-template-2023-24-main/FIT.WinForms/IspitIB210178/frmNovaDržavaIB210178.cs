using FIT.Data;
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
        public frmNovaDržavaIB210178()
        {
            InitializeComponent();
        }



        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validiraj()) {

                byte[] zastava = pbZastava.Image.ToByteArray();
                string naziv = tbNaziv.Text;
                bool status = chbAktivan.Checked;

                

                


            }
        }

        private bool validiraj()
        {
            return Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue)&& Validator.ProvjeriUnos(tbNaziv, err, Kljucevi.ReqiredValue);
        }
    }
}
