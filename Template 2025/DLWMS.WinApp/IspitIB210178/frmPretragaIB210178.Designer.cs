namespace DLWMS.WinApp.IspitIB210178
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbSpol = new ComboBox();
            cbGrad = new ComboBox();
            dtpPodjenOD = new DateTimePicker();
            dtpRodjenDO = new DateTimePicker();
            tbImePrezime = new TextBox();
            chbAktivan = new CheckBox();
            dgvStudenti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            imeGrada = new DataGridViewTextBoxColumn();
            imeSpola = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnUvjerenja = new DataGridViewButtonColumn();
            lblBrojStudenata = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Spol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 12);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 0;
            label2.Text = "rođen u periodu od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(674, 9);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 49);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 0;
            label4.Text = "Grad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 48);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 0;
            label5.Text = "ime i prezime";
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(57, 9);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(211, 28);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(57, 46);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(211, 28);
            cbGrad.TabIndex = 1;
            cbGrad.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // dtpPodjenOD
            // 
            dtpPodjenOD.Location = new Point(418, 7);
            dtpPodjenOD.Name = "dtpPodjenOD";
            dtpPodjenOD.Size = new Size(250, 27);
            dtpPodjenOD.TabIndex = 2;
            dtpPodjenOD.Value = new DateTime(1990, 1, 29, 20, 22, 0, 0);
            dtpPodjenOD.ValueChanged += dtpPodjenOD_ValueChanged;
            // 
            // dtpRodjenDO
            // 
            dtpRodjenDO.Location = new Point(707, 7);
            dtpRodjenDO.Name = "dtpRodjenDO";
            dtpRodjenDO.Size = new Size(250, 27);
            dtpRodjenDO.TabIndex = 2;
            dtpRodjenDO.ValueChanged += dtpRodjenDO_ValueChanged;
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(380, 47);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(473, 27);
            tbImePrezime.TabIndex = 3;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Checked = true;
            chbAktivan.CheckState = CheckState.Checked;
            chbAktivan.Location = new Point(860, 49);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(80, 24);
            chbAktivan.TabIndex = 4;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, imeGrada, imeSpola, DatumRodjenja, Aktivan, btnUvjerenja });
            dgvStudenti.Location = new Point(12, 91);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(971, 347);
            dgvStudenti.TabIndex = 5;
            dgvStudenti.CellClick += dgvStudenti_CellContentClick;
            // 
            // BrojIndeksa
            // 
            BrojIndeksa.DataPropertyName = "BrojIndeksa";
            BrojIndeksa.HeaderText = "Broj indeksa";
            BrojIndeksa.MinimumWidth = 6;
            BrojIndeksa.Name = "BrojIndeksa";
            BrojIndeksa.ReadOnly = true;
            BrojIndeksa.Width = 125;
            // 
            // ImePrezime
            // 
            ImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImePrezime.DataPropertyName = "ImePrezime";
            ImePrezime.HeaderText = "Ime i prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // imeGrada
            // 
            imeGrada.DataPropertyName = "imeGrada";
            imeGrada.HeaderText = "Grad rođenja";
            imeGrada.MinimumWidth = 6;
            imeGrada.Name = "imeGrada";
            imeGrada.ReadOnly = true;
            imeGrada.Width = 125;
            // 
            // imeSpola
            // 
            imeSpola.DataPropertyName = "imeSpola";
            imeSpola.HeaderText = "Spol";
            imeSpola.MinimumWidth = 6;
            imeSpola.Name = "imeSpola";
            imeSpola.ReadOnly = true;
            imeSpola.Width = 125;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.DataPropertyName = "DatumRodjenja";
            DatumRodjenja.HeaderText = "Datum rođenja";
            DatumRodjenja.MinimumWidth = 6;
            DatumRodjenja.Name = "DatumRodjenja";
            DatumRodjenja.ReadOnly = true;
            DatumRodjenja.Width = 155;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // btnUvjerenja
            // 
            btnUvjerenja.DataPropertyName = "btnUvjerenja";
            btnUvjerenja.HeaderText = "";
            btnUvjerenja.MinimumWidth = 6;
            btnUvjerenja.Name = "btnUvjerenja";
            btnUvjerenja.ReadOnly = true;
            btnUvjerenja.Resizable = DataGridViewTriState.True;
            btnUvjerenja.Text = "Uvjerenja";
            btnUvjerenja.UseColumnTextForButtonValue = true;
            btnUvjerenja.Width = 125;
            // 
            // lblBrojStudenata
            // 
            lblBrojStudenata.AutoSize = true;
            lblBrojStudenata.Location = new Point(12, 441);
            lblBrojStudenata.Name = "lblBrojStudenata";
            lblBrojStudenata.Size = new Size(108, 20);
            lblBrojStudenata.TabIndex = 6;
            lblBrojStudenata.Text = "Broj studenata:";
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 466);
            Controls.Add(lblBrojStudenata);
            Controls.Add(dgvStudenti);
            Controls.Add(chbAktivan);
            Controls.Add(tbImePrezime);
            Controls.Add(dtpRodjenDO);
            Controls.Add(dtpPodjenOD);
            Controls.Add(cbGrad);
            Controls.Add(cbSpol);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB210178";
            Text = "Pretraga studenta";
            Load += frmPretragaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbSpol;
        private ComboBox cbGrad;
        private DateTimePicker dtpPodjenOD;
        private DateTimePicker dtpRodjenDO;
        private TextBox tbImePrezime;
        private CheckBox chbAktivan;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn imeGrada;
        private DataGridViewTextBoxColumn imeSpola;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnUvjerenja;
        private Label lblBrojStudenata;
    }
}