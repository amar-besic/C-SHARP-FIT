using DLWMS.Data;
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
    public partial class frmRazmjeneIB210178 : Form
    {
        private Student student;
        DLWMSContext db = new DLWMSContext();


        public frmRazmjeneIB210178(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmRazmjeneIB210178_Load(object sender, EventArgs e)
        {
            cbDržava.DataSource = db.Drzave.ToList();

            cbUniverzitet.DataSource = db.UniverzitetiIB210178.ToList();
        
        }

        private void Ucitaj()
        {
            //dgvRazmjene.DataSource=db.RazmjeneIB210178.ToList();
        }

        private void cbDržava_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUniverzitet.DataSource = db.UniverzitetiIB210178.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var razmjena = new RazmjeneIB210178();
            razmjena.StudentId = student.Id;
            razmjena.UniverzitetId = 1;
            razmjena.Okoncana = false;
            razmjena.ECTS = 10;
            razmjena.PocetakRazmjene = dtpDO.Value;
            razmjena.KrajRazmjene = dtpDO.Value;
            db.RazmjeneIB210178.Add( razmjena );
            db.SaveChanges();
            Ucitaj();
        }
    }
}
