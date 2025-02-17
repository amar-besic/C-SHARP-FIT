using DLWMS.Data;
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
    public partial class frmStudentInfoIB210178 : Form
    {
        private Student student;

        public frmStudentInfoIB210178()
        {
            InitializeComponent();
        }

        public frmStudentInfoIB210178(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void frmStudentInfoIB210178_Load(object sender, EventArgs e)
        {
            this.Text = student.BrojIndeksa;
            pbSlika.Image = student.Slika.ToImage();
            lblimePrezime.Text = student.ImePrezime;
            lblGrad.Text = $"Grad: {student.imeGrada}";
        }
    }
}
