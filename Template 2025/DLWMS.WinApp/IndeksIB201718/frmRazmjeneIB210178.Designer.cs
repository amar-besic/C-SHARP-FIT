namespace DLWMS.WinApp.IndeksIB201718
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
            btnSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvRazmjene = new DataGridView();
            Univerzitet = new DataGridViewTextBoxColumn();
            PocetakRazmjene = new DataGridViewTextBoxColumn();
            KrajRazmjene = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbUniveziteti2 = new ComboBox();
            tbKredit2 = new TextBox();
            tbBrojRazmjena = new TextBox();
            tbInfo = new TextBox();
            btnGenerisi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(23, 33);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(151, 28);
            cbDrzava.TabIndex = 0;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbUniverzitet
            // 
            cbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet.FormattingEnabled = true;
            cbUniverzitet.Location = new Point(180, 34);
            cbUniverzitet.Name = "cbUniverzitet";
            cbUniverzitet.Size = new Size(151, 28);
            cbUniverzitet.TabIndex = 0;
            cbUniverzitet.SelectedIndexChanged += cbUniverzitet_SelectedIndexChanged;
            // 
            // tbKredit
            // 
            tbKredit.Location = new Point(337, 35);
            tbKredit.Name = "tbKredit";
            tbKredit.Size = new Size(58, 27);
            tbKredit.TabIndex = 1;
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(401, 35);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(250, 27);
            dtpOD.TabIndex = 2;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(657, 34);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(250, 27);
            dtpDO.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(913, 32);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 9);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 9);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Broj kredita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 9);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 4;
            label4.Text = "Početak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(657, 9);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 4;
            label5.Text = "Kraj razmjene:";
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.AllowUserToAddRows = false;
            dgvRazmjene.AllowUserToDeleteRows = false;
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { Univerzitet, PocetakRazmjene, KrajRazmjene, ECTS, Okoncana, btnObrisi });
            dgvRazmjene.Location = new Point(23, 68);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazmjene.Size = new Size(984, 199);
            dgvRazmjene.TabIndex = 5;
            dgvRazmjene.CellContentClick += dgvRazmjene_CellContentClick;
            // 
            // Univerzitet
            // 
            Univerzitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Univerzitet.DataPropertyName = "Univerzitet";
            Univerzitet.HeaderText = "Univerzitet";
            Univerzitet.MinimumWidth = 6;
            Univerzitet.Name = "Univerzitet";
            Univerzitet.ReadOnly = true;
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
            btnObrisi.Text = "Obriši";
            btnObrisi.UseColumnTextForButtonValue = true;
            btnObrisi.Width = 125;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbUniveziteti2);
            groupBox1.Controls.Add(tbKredit2);
            groupBox1.Controls.Add(tbBrojRazmjena);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Location = new Point(25, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(979, 225);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 76);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 4;
            label8.Text = "Broj kredita:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(233, 21);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 4;
            label9.Text = "Info:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 76);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 4;
            label7.Text = "Broj razmjena:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 21);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 4;
            label6.Text = "Univerzitet:";
            // 
            // cbUniveziteti2
            // 
            cbUniveziteti2.FormattingEnabled = true;
            cbUniveziteti2.Location = new Point(20, 45);
            cbUniveziteti2.Name = "cbUniveziteti2";
            cbUniveziteti2.Size = new Size(190, 28);
            cbUniveziteti2.TabIndex = 3;
            // 
            // tbKredit2
            // 
            tbKredit2.Location = new Point(119, 96);
            tbKredit2.Name = "tbKredit2";
            tbKredit2.Size = new Size(95, 27);
            tbKredit2.TabIndex = 2;
            // 
            // tbBrojRazmjena
            // 
            tbBrojRazmjena.Location = new Point(20, 96);
            tbBrojRazmjena.Name = "tbBrojRazmjena";
            tbBrojRazmjena.Size = new Size(96, 27);
            tbBrojRazmjena.TabIndex = 2;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(233, 45);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.Size = new Size(731, 174);
            tbInfo.TabIndex = 1;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(17, 129);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(197, 29);
            btnGenerisi.TabIndex = 0;
            btnGenerisi.Text = "Generiši razmjene >>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // frmRazmjeneIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 517);
            Controls.Add(groupBox1);
            Controls.Add(dgvRazmjene);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(tbKredit);
            Controls.Add(cbUniverzitet);
            Controls.Add(cbDrzava);
            Name = "frmRazmjeneIB210178";
            Text = "frmRazmjeneIB210178";
            Load += frmRazmjeneIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDrzava;
        private ComboBox cbUniverzitet;
        private TextBox tbKredit;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private Button btnSacuvaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvRazmjene;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn Univerzitet;
        private DataGridViewTextBoxColumn PocetakRazmjene;
        private DataGridViewTextBoxColumn KrajRazmjene;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn btnObrisi;
        private GroupBox groupBox1;
        private TextBox tbInfo;
        private Button btnGenerisi;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbUniveziteti2;
        private TextBox tbKredit2;
        private TextBox tbBrojRazmjena;
        private Label label9;
    }
}