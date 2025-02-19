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
            Text = $"Razmjena studenta {student.IndexImePrezime}";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var razmjena = new RazmjeneIB210178();
            razmjena.Okoncana = false;
            razmjena.PocetakRazmjene = dtpOD.Value;
            razmjena.KrajRazmjene = dtpDO.Value;
            razmjena.StudentId = student.Id;
            razmjena.ECTS = int.Parse(tbECTS.Text);
            razmjena.UniverzitetId = (cbUniverzitet.SelectedItem as UniverzitetiIB210178).Id;
            d
            db.SaveChanges();
        }

        private void cbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
