using FIT.Data.IspitIB210178;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            UcitajVrjeme();
            UcitajDrzave();
        }

        private void UcitajDrzave()
        {
            dgvDrzave.AutoGenerateColumns = false;
            var Drzave = db.DrzaveIB210178.ToList();

            for (int i = 0; i < Drzave.Count(); i++)
            {
                Drzave[i].BrojGradova = db.GradoviIB210178.Where(w => w.DrzavaId == Drzave[i].Id).Count();
            }

            dgvDrzave.DataSource = Drzave;


        }

        private void sat_Tick(object sender, EventArgs e)
        {
            UcitajVrjeme();

        }

        private void UcitajVrjeme()
        {
            tsslVrjeme.Text = $"Trenutno vrjeme: {DateTime.Now.ToString("HH:mm:ss")}";

        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var novaDrzavafrm = new frmNovaDržavaIB210178();
            if (novaDrzavafrm.ShowDialog() == DialogResult.OK)
            {
                UcitajVrjeme();
                UcitajDrzave();
            }

        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Drzave = db.DrzaveIB210178.ToList();
            if (e.ColumnIndex != btnGradovi.Index)
            {
                var odabranaDrzava = Drzave[e.RowIndex];


                var novaDrzava = new frmNovaDržavaIB210178(odabranaDrzava);
                if (novaDrzava.ShowDialog() == DialogResult.OK)
                    UcitajDrzave();
            }
        }
    }
}
