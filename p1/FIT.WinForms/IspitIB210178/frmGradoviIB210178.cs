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
    public partial class frmGradoviIB210178 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmGradoviIB210178()
        {
            InitializeComponent();
        }

        private void frmGradoviIB210178_Load(object sender, EventArgs e)
        {
            var Gradovi = db.GradoviIB210178.ToList();

            if (Gradovi != null)
            {
                dgvGradovi.DataSource = null;
                dgvGradovi.DataSource = Gradovi;

            }
        }

      
    }
}
