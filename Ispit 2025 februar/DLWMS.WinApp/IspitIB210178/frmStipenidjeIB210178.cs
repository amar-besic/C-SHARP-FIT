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
    public partial class frmStipenidjeIB210178 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<StipendijeGodineIB210178> stipendije;
        public frmStipenidjeIB210178()
        {
            InitializeComponent();
        }

        private void frmStipenidjeIB210178_Load(object sender, EventArgs e)
        {
            dgvStipendije.AutoGenerateColumns = false;
            cbGodina.DataSource = db.StipendijeGodineIB210178.ToList();
            cbTip.DataSource = db.StipendijeIB210178.ToList();
            Ucitaj();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                var stipendija = new StipendijeGodineIB210178();

                stipendija.Godina = int.Parse(cbGodina.SelectedItem.ToString());
                stipendija.StipendijaId = (cbTip.SelectedItem as StipendijeIB210178).Id;
                stipendija.Dodjeljivana = true;
                stipendija.Iznos = int.Parse(tbIznos.Text);
                //stipendija.Iznos = 200;
                db.StipendijeGodineIB210178.Add(stipendija);
                db.SaveChanges();
                Ucitaj();
            }
        }

        private void Ucitaj()
        {
            stipendije = db.StipendijeGodineIB210178.ToList();
            dgvStipendije.DataSource = stipendije;
        }

        private bool Valid()
        {
            return
                Validator.ProvjeriUnos(cbGodina, errorProvider1, Kljucevi.RequiredField) &&
                Validator.ProvjeriUnos(cbTip, errorProvider1, Kljucevi.RequiredField) &&
                Validator.ProvjeriUnos(tbIznos, errorProvider1, Kljucevi.RequiredField);
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (Valid())
            {

                Thread t1 = new Thread(() => Generisi());
                t1.Start();


            }
        }

        private void Generisi()
        {
            var info = "";
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);

                var stipendija = new StipendijeGodineIB210178();

                stipendija.Godina = 2025;
                stipendija.StipendijaId = 2;
                stipendija.Dodjeljivana = true;
                //stipendija.Iznos = int.Parse(tbIznos.Text);
                stipendija.Iznos = 200;
                db.StipendijeGodineIB210178.Add(stipendija);
                db.SaveChanges();

                info += $"{i + 1}. Generisana stipendija.\r\n";
            }

            Action action = () =>
            {

                tbInfo.Text = info;
                Ucitaj();


            };

            BeginInvoke(action);
        }

        private void dgvStipendije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stipendije[e.RowIndex].Dodjeljivana = !stipendije[e.RowIndex].Dodjeljivana;
            db.StipendijeGodineIB210178.Update(stipendije[e.RowIndex]);
            db.SaveChanges();
            Ucitaj();
        }
    }
}
