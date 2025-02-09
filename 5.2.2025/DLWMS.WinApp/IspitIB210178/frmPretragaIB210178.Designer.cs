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
            tbImePrezime = new TextBox();
            label1 = new Label();
            cbDrzava = new ComboBox();
            cbSpol = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dtpOD = new DateTimePicker();
            dtpDO = new DateTimePicker();
            label4 = new Label();
            dgvStudenti = new DataGridView();
            IndexImePrezime = new DataGridViewTextBoxColumn();
            ImeDrzave = new DataGridViewTextBoxColumn();
            ImeGrada = new DataGridViewTextBoxColumn();
            ImeSpola = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            Razmjena = new DataGridViewButtonColumn();
            label5 = new Label();
            chbAktivan = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(12, 30);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(276, 27);
            tbImePrezime.TabIndex = 0;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 5);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime ili prezime:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(294, 29);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(230, 28);
            cbDrzava.TabIndex = 2;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(530, 29);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(230, 28);
            cbSpol.TabIndex = 2;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "od";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 5);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "Spol:";
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(42, 63);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(250, 27);
            dtpOD.TabIndex = 3;
            dtpOD.Value = new DateTime(1990, 2, 5, 20, 34, 0, 0);
            dtpOD.ValueChanged += dtpOD_ValueChanged;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(322, 63);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(250, 27);
            dtpDO.TabIndex = 4;
            dtpDO.ValueChanged += dtpDO_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 70);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 1;
            label4.Text = "do";
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { IndexImePrezime, ImeDrzave, ImeGrada, ImeSpola, Aktivan, Razmjena });
            dgvStudenti.Location = new Point(12, 96);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(924, 342);
            dgvStudenti.TabIndex = 5;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            dgvStudenti.CellDoubleClick += dgvStudenti_CellDoubleClick;
            // 
            // IndexImePrezime
            // 
            IndexImePrezime.DataPropertyName = "IndexImePrezime";
            IndexImePrezime.HeaderText = "(Indeks) Ime Prezime";
            IndexImePrezime.MinimumWidth = 6;
            IndexImePrezime.Name = "IndexImePrezime";
            IndexImePrezime.ReadOnly = true;
            IndexImePrezime.Width = 225;
            // 
            // ImeDrzave
            // 
            ImeDrzave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImeDrzave.DataPropertyName = "ImeDrzave";
            ImeDrzave.HeaderText = "Država";
            ImeDrzave.MinimumWidth = 6;
            ImeDrzave.Name = "ImeDrzave";
            ImeDrzave.ReadOnly = true;
            // 
            // ImeGrada
            // 
            ImeGrada.DataPropertyName = "ImeGrada";
            ImeGrada.HeaderText = "Grad";
            ImeGrada.MinimumWidth = 6;
            ImeGrada.Name = "ImeGrada";
            ImeGrada.ReadOnly = true;
            ImeGrada.Width = 125;
            // 
            // ImeSpola
            // 
            ImeSpola.DataPropertyName = "ImeSpola";
            ImeSpola.HeaderText = "Spol";
            ImeSpola.MinimumWidth = 6;
            ImeSpola.Name = "ImeSpola";
            ImeSpola.ReadOnly = true;
            ImeSpola.Width = 125;
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
            // Razmjena
            // 
            Razmjena.DataPropertyName = "Razmjena";
            Razmjena.HeaderText = "";
            Razmjena.MinimumWidth = 6;
            Razmjena.Name = "Razmjena";
            Razmjena.ReadOnly = true;
            Razmjena.Text = "Razmjena";
            Razmjena.UseColumnTextForButtonValue = true;
            Razmjena.Width = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 5);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 1;
            label5.Text = "Država:";
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Checked = true;
            chbAktivan.CheckState = CheckState.Checked;
            chbAktivan.Location = new Point(585, 64);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(80, 24);
            chbAktivan.TabIndex = 6;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            chbAktivan.CheckedChanged += chbAktivan_CheckedChanged;
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 450);
            Controls.Add(chbAktivan);
            Controls.Add(dgvStudenti);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(cbSpol);
            Controls.Add(cbDrzava);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbImePrezime);
            Name = "frmPretragaIB210178";
            Text = "frmPretragaIB210178";
            Load += frmPretragaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbImePrezime;
        private Label label1;
        private ComboBox cbDrzava;
        private ComboBox cbSpol;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private Label label4;
        private DataGridView dgvStudenti;
        private Label label5;
        private CheckBox chbAktivan;
        private DataGridViewTextBoxColumn IndexImePrezime;
        private DataGridViewTextBoxColumn ImeDrzave;
        private DataGridViewTextBoxColumn ImeGrada;
        private DataGridViewTextBoxColumn ImeSpola;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn Razmjena;
    }
}