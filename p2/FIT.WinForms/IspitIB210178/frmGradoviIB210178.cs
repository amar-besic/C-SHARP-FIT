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
        public frmGradoviIB210178(Data.IspitIB210178.DrzaveIB210178 odabranaDrzava)
        {
            InitializeComponent();
            this.odabranaDrzava = odabranaDrzava;

            
        }

        private void frmGradoviIB210178_Load(object sender, EventArgs e)
        {
            pbZastava.Image = odabranaDrzava.Zastava.ToImage();
            citajGradove();



            
        }

        private void citajGradove()
        {
          

            var gradovi = db.GradoviIB210178.Where(w => w.DrzavaId == odabranaDrzava.Id).ToList();

            dgvGradovi.DataSource = gradovi;
            

        }
    }
}
