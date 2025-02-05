using DLWMS.Data;
using DLWMS.Data.IspitIB210178;
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
    public partial class frmUvjerenjaIB210178 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student student;
        List<StudentiUvjerenjaIB210178> uvjerenja;
        public frmUvjerenjaIB210178()
        {
            InitializeComponent();
        }

        public frmUvjerenjaIB210178(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmUvjerenjaIB210178_Load(object sender, EventArgs e)
        {
            dgvUvjernja.AutoGenerateColumns = false;
          
            ucitaj();


        }

        private void ucitaj()
        {
            var studentovaUvjerenja = db.StudentiUvjerenjaIB210178.Where(w => w.StudentId == student.Id).ToList();

            dgvUvjernja.DataSource = studentovaUvjerenja;
            uvjerenja = studentovaUvjerenja;
            this.Text = $"Broj uvjerenja ->  {uvjerenja.Count()}";
        }

        private void dgvUvjernja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnBriši.Index)
            {
                if (MessageBox.Show("Da i ste skigurni da želite izbrisati uvjerenje?", "Piranje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                var uvjerenje = uvjerenja[e.RowIndex];
                db.StudentiUvjerenjaIB210178.Remove(uvjerenje);
                db.SaveChanges();
                ucitaj();
                }
                
            }
            if (e.ColumnIndex == btnPrintaj.Index)
            {
                
                var uvjerenje = uvjerenja[e.RowIndex];
                uvjerenje.Printano = true;
                db.StudentiUvjerenjaIB210178.Update(uvjerenje);
                db.SaveChanges();
                ucitaj();

                var frmizvjestaj = new frmIzvjestaji();
                frmizvjestaj.ShowDialog();
            }
        }

        private void btnZahtjev_Click(object sender, EventArgs e)
        {
            var novo = new frmNovoUvjerenjeIB210178(student);
            if(novo.ShowDialog() == DialogResult.OK)
            {
                ucitaj();
            }
        }
    }
}
