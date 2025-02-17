using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Izvjestaji;
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
    public partial class frmPretragaIB210178 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> studenti;

        Spol spol;
        Grad grad;
        bool aktivan = true;
        DateTime OD;
        DateTime DO = DateTime.Now;
        string imePrezime = "";

        public frmPretragaIB210178()
        {
            InitializeComponent();
        }

        private void frmPretragaIB210178_Load(object sender, EventArgs e)
        {
            dgvStudenti.AutoGenerateColumns = false;
            cbGrad.DataSource = db.Gradovi.ToList();
            cbSpol.DataSource = db.SpolIB210178.ToList();


            UcitajStudente();
        }

        private void UcitajStudente()
        {
            spol = cbSpol.SelectedItem as Spol ?? new Spol();




            var filtriraniStudenti = db.Studenti.Where(x => x.GradId == grad.Id).Where(x => x.SpolId == spol.Id).Where(x => x.Aktivan == aktivan).Where(x => x.DatumRodjenja > OD).Where(x => x.DatumRodjenja < DO).Where(x => x.Prezime.ToLower().Contains(imePrezime) || x.Ime.ToLower().Contains(imePrezime)).ToList();



            dgvStudenti.DataSource = filtriraniStudenti;
            lblBrojStudenata.Text = $"Broj studenata: {filtriraniStudenti.Count}";

            studenti = filtriraniStudenti;
        }

        private void cbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void cbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            grad = cbGrad.SelectedItem as Grad ?? new Grad();
            UcitajStudente();
        }

        private void chbAktivan_CheckedChanged(object sender, EventArgs e)
        {
            aktivan = chbAktivan.Checked;
            UcitajStudente();
        }

        private void dtpPodjenOD_ValueChanged(object sender, EventArgs e)
        {
            OD = dtpPodjenOD.Value;
            UcitajStudente();
        }

        private void dtpRodjenDO_ValueChanged(object sender, EventArgs e)
        {
            DO = dtpRodjenDO.Value;
            UcitajStudente();
        }

        private void tbImePrezime_TextChanged(object sender, EventArgs e)
        {
            imePrezime = tbImePrezime.Text.ToLower();
            UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == btnUvjerenja.Index)
            {
                var uvjerenja = new frmUvjerenjaIB210178(studenti[e.RowIndex]);
                uvjerenja.ShowDialog();

            }
            else
            {
                var izvjestaj = new frmStudentInfoIB210178(studenti[e.RowIndex]);
                izvjestaj.ShowDialog();
            }
        }
    }
}
