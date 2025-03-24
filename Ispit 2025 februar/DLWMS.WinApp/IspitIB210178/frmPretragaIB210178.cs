using DLWMS.Data.IspitIB210178;
using DLWMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
        List<StudentiStipendijeIB210178> stipendije;
        public frmPretragaIB210178()
        {
            InitializeComponent();
        }

        private void frmPretragaIB210178_Load(object sender, EventArgs e)
        {
            dgvStipendije.AutoGenerateColumns = false;
            cbGodina.SelectedIndex = 0;
            cbStipendija.DataSource = db.StipendijeIB210178.ToList();
        }
        private void Ucitaj()
        {
            stipendije = db.StudentiStipendijeIB210178
                .Include(x => x.Student)
                .Include(y => y.StipendijaGodina.Stipendija)
                .Where(x => x.StipendijaGodina.Godina.ToString() == cbGodina.SelectedItem.ToString())
                .Where(x => x.StipendijaGodina.StipendijaId == (cbStipendija.SelectedItem as StipendijeIB210178).Id)
                .ToList();


            Text = $"Broj prikazanih stipendija: {stipendije.Count()}";
            dgvStipendije.DataSource = stipendije;

            if (stipendije.Count() == 0) MessageBox.Show($"Nema primjenih {cbStipendija.SelectedItem} stipendija u {cbGodina.SelectedItem} godini", "Obavjest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStipendija.SelectedItem != null) Ucitaj();
        }



        private void cbStipendija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void dgvStipendije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnUkloni.Index)
            {
                if (MessageBox.Show("Da li ste sigurni da zelite izbrisati stipendiju?", "Obavjest", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.StudentiStipendijeIB210178.Remove(stipendije[e.RowIndex]);
                    db.SaveChanges();
                    Ucitaj();
                }
            }
        }

        private void dgvStipendije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var EDIT = new frmStipenidjaAddEditIB210178(stipendije[e.RowIndex]);

            if (EDIT.ShowDialog() == DialogResult.OK) Ucitaj();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var NOVA = new frmStipenidjaAddEditIB210178();

            if (NOVA.ShowDialog() == DialogResult.OK) Ucitaj();
        }

        private void btnStipendijePoGodinama_Click(object sender, EventArgs e)
        {
            var frmStipendija = new frmStipenidjeIB210178();
            frmStipendija.ShowDialog();
        }

       
    }
}
