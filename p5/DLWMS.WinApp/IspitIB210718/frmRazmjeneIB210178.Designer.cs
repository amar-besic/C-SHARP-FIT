namespace DLWMS.WinApp.IspitIB210718
{
    partial class frmRazmjeneIB210178
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
            components = new System.ComponentModel.Container();
            cbDrzava = new ComboBox();
            cbUniverzitet = new ComboBox();
            tbKredit = new TextBox();
            dtpOD = new DateTimePicker();
            dtpDO = new DateTimePicker();
            dgvRazmjene = new DataGridView();
            Dr = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Sacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            UnDr = new DataGridViewTextBoxColumn();
            PocetakRazmjene = new DataGridViewTextBoxColumn();
            KrajRazmjene = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(20, 45);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(208, 28);
            cbDrzava.TabIndex = 0;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbUniverzitet
            // 
            cbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet.FormattingEnabled = true;
            cbUniverzitet.Location = new Point(234, 45);
            cbUniverzitet.Name = "cbUniverzitet";
            cbUniverzitet.Size = new Size(208, 28);
            cbUniverzitet.TabIndex = 0;
            cbUniverzitet.SelectedIndexChanged += cbUniverzitet_SelectedIndexChanged;
            // 
            // tbKredit
            // 
            tbKredit.Location = new Point(448, 46);
            tbKredit.Name = "tbKredit";
            tbKredit.Size = new Size(59, 27);
            tbKredit.TabIndex = 1;
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(513, 46);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(250, 27);
            dtpOD.TabIndex = 2;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(769, 46);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(250, 27);
            dtpDO.TabIndex = 2;
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.AllowUserToAddRows = false;
            dgvRazmjene.AllowUserToDeleteRows = false;
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { UnDr, PocetakRazmjene, KrajRazmjene, ECTS, Okoncana, btnObrisi });
            dgvRazmjene.Location = new Point(20, 89);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.Size = new Size(1081, 349);
            dgvRazmjene.TabIndex = 3;
            dgvRazmjene.CellContentClick += dgvRazmjene_CellContentClick;
            // 
            // Dr
            // 
            Dr.AutoSize = true;
            Dr.Location = new Point(20, 23);
            Dr.Name = "Dr";
            Dr.Size = new Size(58, 20);
            Dr.TabIndex = 4;
            Dr.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 22);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 22);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Broj kredita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 23);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 4;
            label4.Text = "Početak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(769, 22);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Kraj razmjene:";
            // 
            // Sacuvaj
            // 
            Sacuvaj.Location = new Point(1033, 44);
            Sacuvaj.Name = "Sacuvaj";
            Sacuvaj.Size = new Size(68, 29);
            Sacuvaj.TabIndex = 5;
            Sacuvaj.Text = "Sačuvaj";
            Sacuvaj.UseVisualStyleBackColor = true;
            Sacuvaj.Click += Sacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UnDr
            // 
            UnDr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UnDr.DataPropertyName = "UnDr";
            UnDr.HeaderText = "Univerzitet";
            UnDr.MinimumWidth = 6;
            UnDr.Name = "UnDr";
            UnDr.ReadOnly = true;
            // 
            // PocetakRazmjene
            // 
            PocetakRazmjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PocetakRazmjene.DataPropertyName = "PocetakRazmjene";
            PocetakRazmjene.HeaderText = "Početak";
            PocetakRazmjene.MinimumWidth = 6;
            PocetakRazmjene.Name = "PocetakRazmjene";
            PocetakRazmjene.ReadOnly = true;
            // 
            // KrajRazmjene
            // 
            KrajRazmjene.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KrajRazmjene.DataPropertyName = "KrajRazmjene";
            KrajRazmjene.HeaderText = "Kraj";
            KrajRazmjene.MinimumWidth = 6;
            KrajRazmjene.Name = "KrajRazmjene";
            KrajRazmjene.ReadOnly = true;
            // 
            // ECTS
            // 
            ECTS.DataPropertyName = "ECTS";
            ECTS.HeaderText = "ECTS";
            ECTS.MinimumWidth = 6;
            ECTS.Name = "ECTS";
            ECTS.ReadOnly = true;
            ECTS.Width = 125;
            // 
            // Okoncana
            // 
            Okoncana.DataPropertyName = "Okoncana";
            Okoncana.HeaderText = "Okončana";
            Okoncana.MinimumWidth = 6;
            Okoncana.Name = "Okoncana";
            Okoncana.ReadOnly = true;
            Okoncana.Resizable = DataGridViewTriState.True;
            Okoncana.SortMode = DataGridViewColumnSortMode.Automatic;
            Okoncana.Width = 125;
            // 
            // btnObrisi
            // 
            btnObrisi.DataPropertyName = "btnObrisi";
            btnObrisi.HeaderText = "";
            btnObrisi.MinimumWidth = 6;
            btnObrisi.Name = "btnObrisi";
            btnObrisi.ReadOnly = true;
            btnObrisi.Resizable = DataGridViewTriState.True;
            btnObrisi.SortMode = DataGridViewColumnSortMode.Automatic;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseColumnTextForButtonValue = true;
            btnObrisi.Width = 125;
            // 
            // frmRazmjeneIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 450);
            Controls.Add(Sacuvaj);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Dr);
            Controls.Add(dgvRazmjene);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(tbKredit);
            Controls.Add(cbUniverzitet);
            Controls.Add(cbDrzava);
            Name = "frmRazmjeneIB210178";
            Text = "frmRazmjeneIB210178";
            Load += frmRazmjeneIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDrzava;
        private ComboBox cbUniverzitet;
        private TextBox tbKredit;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private DataGridView dgvRazmjene;
        private Label Dr;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Sacuvaj;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn UnDr;
        private DataGridViewTextBoxColumn PocetakRazmjene;
        private DataGridViewTextBoxColumn KrajRazmjene;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn btnObrisi;
    }
}