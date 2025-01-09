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
            dgvDrzava.AutoGenerateColumns = false;
            var Drzave = db.DrzaveIB210178.ToList();

            for (int i = 0; i < Drzave.Count; i++)
            {
                Drzave[i].brojGradova = db.GradoviIB210178.Where(grad=> grad.DrzavaId == Drzave[i].Id).Count();
            }

            if (Drzave != null) { 
                dgvDrzava.DataSource = null;
                dgvDrzava.DataSource = Drzave;
            }

            
        }
    }
}
