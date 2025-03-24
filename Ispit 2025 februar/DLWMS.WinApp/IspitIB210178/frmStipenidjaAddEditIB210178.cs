using DLWMS.Data.IspitIB210178;
using DLWMS.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.IspitIB210178
{
    public partial class frmStipenidjaAddEditIB210178 : Form
    {
        private StudentiStipendijeIB210178 izabranaStipendija;
        DLWMSContext db = new DLWMSContext();

        public frmStipenidjaAddEditIB210178()
        {
            InitializeComponent();
        }

        public frmStipenidjaAddEditIB210178(StudentiStipendijeIB210178 studentiStipendijeIB210178)
        {
            InitializeComponent();
            this.izabranaStipendija = studentiStipendijeIB210178;
        }

        private void frmStipenidjaAddEditIB210178_Load(object sender, EventArgs e)
        {
            cbGodina.SelectedIndex = 0;
            cbStudent.DataSource = db.Studenti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var NovaStipendija = new StudentiStipendijeIB210178();
            var stipGodina = new StipendijeGodineIB210178();

            
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbStipendija.DataSource = db.StipendijeGodineIB210178.ToList();
        }
    }
}
