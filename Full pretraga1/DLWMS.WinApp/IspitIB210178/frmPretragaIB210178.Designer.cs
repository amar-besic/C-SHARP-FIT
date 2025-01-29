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
            cbSpol = new ComboBox();
            label2 = new Label();
            cbGrad = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dtpOD = new DateTimePicker();
            dtpDO = new DateTimePicker();
            label5 = new Label();
            tbImePrezime = new TextBox();
            chbAktivan = new CheckBox();
            dgvStudenti = new DataGridView();
            BrojIndeksa = new DataGridViewTextBoxColumn();
            ImePrezime = new DataGridViewTextBoxColumn();
            GradRođenja = new DataGridViewTextBoxColumn();
            SpolStudenta = new DataGridViewTextBoxColumn();
            DatumRodjenja = new DataGridViewTextBoxColumn();
            aa = new DataGridViewCheckBoxColumn();
            btnUvjerenja = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 14);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "rođen u periodu od";
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(66, 12);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(262, 28);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 49);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 0;
            label2.Text = "Ime i prezime";
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(66, 47);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(189, 28);
            cbGrad.TabIndex = 1;
            cbGrad.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 14);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 0;
            label3.Text = "Spol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 47);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 0;
            label4.Text = "Grad";
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(486, 11);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(250, 27);
            dtpOD.TabIndex = 2;
            dtpOD.Value = new DateTime(1990, 1, 1, 0, 30, 0, 0);
            dtpOD.ValueChanged += dtpOD_ValueChanged;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(775, 9);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(251, 27);
            dtpDO.TabIndex = 2;
            dtpDO.ValueChanged += dtpDO_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(742, 14);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 0;
            label5.Text = "do";
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(367, 44);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(583, 27);
            tbImePrezime.TabIndex = 3;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Checked = true;
            chbAktivan.CheckState = CheckState.Checked;
            chbAktivan.Location = new Point(956, 49);
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
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { BrojIndeksa, ImePrezime, GradRođenja, SpolStudenta, DatumRodjenja, aa, btnUvjerenja });
            dgvStudenti.Location = new Point(10, 81);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(1026, 357);
            dgvStudenti.TabIndex = 5;
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
            ImePrezime.HeaderText = "Ime i Prezime";
            ImePrezime.MinimumWidth = 6;
            ImePrezime.Name = "ImePrezime";
            ImePrezime.ReadOnly = true;
            // 
            // GradRođenja
            // 
            GradRođenja.DataPropertyName = "GradRođenja";
            GradRođenja.HeaderText = "Grad rođenja";
            GradRođenja.MinimumWidth = 6;
            GradRođenja.Name = "GradRođenja";
            GradRođenja.ReadOnly = true;
            GradRođenja.Width = 125;
            // 
            // SpolStudenta
            // 
            SpolStudenta.DataPropertyName = "SpolStudenta";
            SpolStudenta.HeaderText = "Spol";
            SpolStudenta.MinimumWidth = 6;
            SpolStudenta.Name = "SpolStudenta";
            SpolStudenta.ReadOnly = true;
            SpolStudenta.Width = 125;
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
            // aa
            // 
            aa.DataPropertyName = "Aktivan";
            aa.HeaderText = "Aktivan";
            aa.MinimumWidth = 6;
            aa.Name = "aa";
            aa.ReadOnly = true;
            aa.Width = 125;
            // 
            // btnUvjerenja
            // 
            btnUvjerenja.DataPropertyName = "btnUvjerenja";
            btnUvjerenja.HeaderText = "";
            btnUvjerenja.MinimumWidth = 6;
            btnUvjerenja.Name = "btnUvjerenja";
            btnUvjerenja.ReadOnly = true;
            btnUvjerenja.Text = "Uvjerenje";
            btnUvjerenja.UseColumnTextForButtonValue = true;
            btnUvjerenja.Width = 125;
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 450);
            Controls.Add(dgvStudenti);
            Controls.Add(chbAktivan);
            Controls.Add(tbImePrezime);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(cbGrad);
            Controls.Add(cbSpol);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
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
        private ComboBox cbSpol;
        private Label label2;
        private ComboBox cbGrad;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private Label label5;
        private TextBox tbImePrezime;
        private CheckBox chbAktivan;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn BrojIndeksa;
        private DataGridViewTextBoxColumn ImePrezime;
        private DataGridViewTextBoxColumn GradRođenja;
        private DataGridViewTextBoxColumn SpolStudenta;
        private DataGridViewTextBoxColumn DatumRodjenja;
        private DataGridViewCheckBoxColumn aa;
        private DataGridViewButtonColumn btnUvjerenja;
    }
}