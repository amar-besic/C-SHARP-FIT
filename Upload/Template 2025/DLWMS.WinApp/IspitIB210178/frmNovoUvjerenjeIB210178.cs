using DLWMS.Data;
using DLWMS.Data.IspitIB210178;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
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
    public partial class frmNovoUvjerenjeIB210178 : Form
    {
        DLWMSContext db = new DLWMSContext();
        private Student student;

        public frmNovoUvjerenjeIB210178()
        {
            InitializeComponent();
        }

        public frmNovoUvjerenjeIB210178(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (ofdUplatnica.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(ofdUplatnica.FileName);
            }
        }

        private void frmNovoUvjerenjeIB210178_Load(object sender, EventArgs e)
        {
            cbVrsta.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validrano())
            {
                var uvjerenje = new StudentiUvjerenjaIB210178();
                uvjerenje.Uplatnica = pbUplatnica.Image.ToByteArray();
                uvjerenje.Vrsta = cbVrsta.Text;
                uvjerenje.Svrha = tbSvrha.Text;
                uvjerenje.StudentId = student.Id;
                uvjerenje.Printano = false;
                uvjerenje.Vrjeme = DateTime.Now;

                db.StudentiUvjerenjaIB210178.Add(uvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool validrano()
        {
            return Validator.ProvjeriUnos(pbUplatnica, err, Kljucevi.RequiredField) && Validator.ProvjeriUnos(tbSvrha, err, Kljucevi.RequiredField);
        }
    }
}
