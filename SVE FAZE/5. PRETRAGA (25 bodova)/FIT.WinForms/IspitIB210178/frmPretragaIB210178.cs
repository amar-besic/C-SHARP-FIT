using FIT.Data;
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
    public partial class frmPretragaIB210178 : Form
    {
     
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> studenti;
        public frmPretragaIB210178()
        {
            InitializeComponent();
        }

        private void frmPretragaIB210178_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            
            cbDrzave.DataSource = db.DrzaveIB210178.ToList();
            
        }

        private void cbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvStudenti.DataSource = null;

            cbGradovi.DataSource = db.GradoviIB210178.Where(w => w.DrzavaId == (cbDrzave.SelectedItem as DrzaveIB210178).Id).ToList();

           

        }

        private void cbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

            UcitajStudente();

            
        }
        
        private void UcitajStudente()
        {


         studenti = db.Studenti.Where(w => w.GradId == (cbGradovi.SelectedItem as GradoviIB210178).Id).ToList();

           
            for (int i = 0; i < studenti.Count; i++)
            {
                if (db.PolozeniPredmeti.Where(w => w.StudentId == studenti[i].Id).Count() == 0) studenti[i].prosjek = 5; 
                else studenti[i].prosjek = db.PolozeniPredmeti.Where(w=> w.StudentId == studenti[i].Id).Average(x=> x.Ocjena);
                
            }
            


            dgvStudenti.DataSource = studenti;

            

        }
    }
}
