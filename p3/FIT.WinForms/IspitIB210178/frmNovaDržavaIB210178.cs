using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB210178
{
    public partial class frmNovaDržavaIB210178 : Form
    {
        public frmNovaDržavaIB210178()
        {
            InitializeComponent();
        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            if (ofdZastava.ShowDialog() == DialogResult.OK)
                pbZastava.Image = Image.FromFile(ofdZastava.FileName);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
         
        }

    }
}
