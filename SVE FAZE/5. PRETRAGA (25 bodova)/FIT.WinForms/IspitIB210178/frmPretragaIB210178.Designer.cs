namespace FIT.WinForms.IspitIB210178
{
    partial class frmPretragaIB210178
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cbDrzave = new ComboBox();
            cbGradovi = new ComboBox();
            dgvStudenti = new DataGridView();
            Ime = new DataGridViewTextBoxColumn();
            Prezime = new DataGridViewTextBoxColumn();
            NazivGrada = new DataGridViewTextBoxColumn();
            NazivDrzave = new DataGridViewTextBoxColumn();
            Prosjek = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Država";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 17);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 0;
            label2.Text = "Grad";
            // 
            // cbDrzave
            // 
            cbDrzave.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzave.FormattingEnabled = true;
            cbDrzave.Location = new Point(12, 40);
            cbDrzave.Name = "cbDrzave";
            cbDrzave.Size = new Size(216, 28);
            cbDrzave.TabIndex = 1;
            cbDrzave.SelectedIndexChanged += cbDrzave_SelectedIndexChanged;
            // 
            // cbGradovi
            // 
            cbGradovi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGradovi.FormattingEnabled = true;
            cbGradovi.Location = new Point(250, 40);
            cbGradovi.Name = "cbGradovi";
            cbGradovi.Size = new Size(216, 28);
            cbGradovi.TabIndex = 1;
            cbGradovi.SelectedIndexChanged += cbGradovi_SelectedIndexChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { Ime, Prezime, NazivGrada, NazivDrzave, Prosjek });
            dgvStudenti.Location = new Point(12, 74);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.RowTemplate.Height = 29;
            dgvStudenti.ScrollBars = ScrollBars.Vertical;
            dgvStudenti.Size = new Size(776, 364);
            dgvStudenti.TabIndex = 2;
            // 
            // Ime
            // 
            Ime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ime.DataPropertyName = "Ime";
            Ime.HeaderText = "Ime";
            Ime.MinimumWidth = 6;
            Ime.Name = "Ime";
            Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            Prezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prezime.DataPropertyName = "Prezime";
            Prezime.HeaderText = "Prezime";
            Prezime.MinimumWidth = 6;
            Prezime.Name = "Prezime";
            Prezime.ReadOnly = true;
            // 
            // NazivGrada
            // 
            NazivGrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivGrada.DataPropertyName = "NazivGrada";
            NazivGrada.HeaderText = "Grad";
            NazivGrada.MinimumWidth = 6;
            NazivGrada.Name = "NazivGrada";
            NazivGrada.ReadOnly = true;
            // 
            // NazivDrzave
            // 
            NazivDrzave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivDrzave.DataPropertyName = "NazivDrzave";
            NazivDrzave.HeaderText = "Drzava";
            NazivDrzave.MinimumWidth = 6;
            NazivDrzave.Name = "NazivDrzave";
            NazivDrzave.ReadOnly = true;
            // 
            // Prosjek
            // 
            Prosjek.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prosjek.DataPropertyName = "Prosjek";
            Prosjek.HeaderText = "Prosjek";
            Prosjek.MinimumWidth = 6;
            Prosjek.Name = "Prosjek";
            Prosjek.ReadOnly = true;
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudenti);
            Controls.Add(cbGradovi);
            Controls.Add(cbDrzave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB210178";
            Text = "frmPretragaIB210178";
            Load += frmPretragaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbDrzave;
        private ComboBox cbGradovi;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewTextBoxColumn Prezime;
        private DataGridViewTextBoxColumn NazivGrada;
        private DataGridViewTextBoxColumn NazivDrzave;
        private DataGridViewTextBoxColumn Prosjek;
    }
}