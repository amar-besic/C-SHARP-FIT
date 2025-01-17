using FIT.Data.IspitIB210178;
using FIT.Infrastructure;
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
    public partial class frmDrzaveIB210178 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmDrzaveIB210178()
        {
            InitializeComponent();
        }

        private void frmDrzaveIB210178_Load(object sender, EventArgs e)
        {
            UcitajDrzave();
        }

        private void UcitajDrzave()
        {
            dgvDrzave.AutoGenerateColumns = false;



            var Drzave = db.DrzaveIB210178.ToList();
            //-------------|PREBROJ GRADOVE|--------------
            for (int i = 0; i < Drzave.Count(); i++)
                Drzave[i].BrojGradova = db.GradoviIB210178.Where(w => w.DrzavaId == Drzave[i].Id).Count();
            //--------------------------------------------


            dgvDrzave.DataSource = Drzave;
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var frmNova = new frmNovaDržavaIB210178();
            if(frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajDrzave();
            }
        }
    }
}
