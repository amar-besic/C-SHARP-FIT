namespace DLWMS.WinApp.IspitIB210178
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
            tbKredita = new TextBox();
            dtpPocetak = new DateTimePicker();
            dtpKraj = new DateTimePicker();
            btnSacuvaj = new Button();
            dgvRazmjena = new DataGridView();
            UniverzitetDrzava = new DataGridViewTextBoxColumn();
            PocetakRazmjene = new DataGridViewTextBoxColumn();
            KrajRazmjene = new DataGridViewTextBoxColumn();
            ECTS = new DataGridViewTextBoxColumn();
            Okoncana = new DataGridViewCheckBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            btnPotvrda = new Button();
            groupBox1 = new GroupBox();
            tbBrojKredita = new TextBox();
            tbBrojRazmjena = new TextBox();
            btnGenerisi = new Button();
            tbInfo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            cbUniverzitet2 = new ComboBox();
            label9 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            err = new ErrorProvider(components);
            prviprvi = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjena).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(12, 42);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(173, 28);
            cbDrzava.TabIndex = 0;
            cbDrzava.SelectedIndexChanged += cbDržava_SelectedIndexChanged;
            // 
            // cbUniverzitet
            // 
            cbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet.FormattingEnabled = true;
            cbUniverzitet.Location = new Point(191, 42);
            cbUniverzitet.Name = "cbUniverzitet";
            cbUniverzitet.Size = new Size(177, 28);
            cbUniverzitet.TabIndex = 1;
            // 
            // tbKredita
            // 
            tbKredita.Location = new Point(374, 42);
            tbKredita.Name = "tbKredita";
            tbKredita.Size = new Size(73, 27);
            tbKredita.TabIndex = 2;
            // 
            // dtpPocetak
            // 
            dtpPocetak.Location = new Point(453, 43);
            dtpPocetak.Name = "dtpPocetak";
            dtpPocetak.Size = new Size(250, 27);
            dtpPocetak.TabIndex = 3;
            dtpPocetak.Value = new DateTime(2025, 2, 4, 0, 0, 0, 0);
            // 
            // dtpKraj
            // 
            dtpKraj.Location = new Point(709, 43);
            dtpKraj.Name = "dtpKraj";
            dtpKraj.Size = new Size(250, 27);
            dtpKraj.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(965, 42);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // dgvRazmjena
            // 
            dgvRazmjena.AllowUserToAddRows = false;
            dgvRazmjena.AllowUserToDeleteRows = false;
            dgvRazmjena.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjena.Columns.AddRange(new DataGridViewColumn[] { UniverzitetDrzava, PocetakRazmjene, KrajRazmjene, ECTS, Okoncana, btnObrisi });
            dgvRazmjena.Location = new Point(12, 76);
            dgvRazmjena.Name = "dgvRazmjena";
            dgvRazmjena.ReadOnly = true;
            dgvRazmjena.RowHeadersWidth = 51;
            dgvRazmjena.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRazmjena.Size = new Size(1043, 205);
            dgvRazmjena.TabIndex = 5;
            dgvRazmjena.CellContentClick += dgvRazmjena_CellContentClick;
            // 
            // UniverzitetDrzava
            // 
            UniverzitetDrzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UniverzitetDrzava.DataPropertyName = "UniverzitetDrzava";
            UniverzitetDrzava.HeaderText = "Univerzitet";
            UniverzitetDrzava.MinimumWidth = 6;
            UniverzitetDrzava.Name = "UniverzitetDrzava";
            UniverzitetDrzava.ReadOnly = true;
            // 
            // PocetakRazmjene
            // 
            PocetakRazmjene.DataPropertyName = "PocetakRazmjene";
            PocetakRazmjene.HeaderText = "Početak";
            PocetakRazmjene.MinimumWidth = 6;
            PocetakRazmjene.Name = "PocetakRazmjene";
            PocetakRazmjene.ReadOnly = true;
            PocetakRazmjene.Width = 145;
            // 
            // KrajRazmjene
            // 
            KrajRazmjene.DataPropertyName = "KrajRazmjene";
            KrajRazmjene.HeaderText = "Kraj";
            KrajRazmjene.MinimumWidth = 6;
            KrajRazmjene.Name = "KrajRazmjene";
            KrajRazmjene.ReadOnly = true;
            KrajRazmjene.Width = 145;
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
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(965, 287);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(94, 29);
            btnPotvrda.TabIndex = 4;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbBrojKredita);
            groupBox1.Controls.Add(tbBrojRazmjena);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbUniverzitet2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(19, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1040, 225);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator razmjena";
            // 
            // tbBrojKredita
            // 
            tbBrojKredita.Location = new Point(147, 106);
            tbBrojKredita.Name = "tbBrojKredita";
            tbBrojKredita.Size = new Size(135, 27);
            tbBrojKredita.TabIndex = 10;
            // 
            // tbBrojRazmjena
            // 
            tbBrojRazmjena.Location = new Point(6, 106);
            tbBrojRazmjena.Name = "tbBrojRazmjena";
            tbBrojRazmjena.Size = new Size(135, 27);
            tbBrojRazmjena.TabIndex = 10;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(6, 138);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(276, 29);
            btnGenerisi.TabIndex = 9;
            btnGenerisi.Text = "Generiši razmjene >>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(288, 52);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.ReadOnly = true;
            tbInfo.Size = new Size(731, 167);
            tbInfo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(146, 83);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 7;
            label8.Text = "Broj kredita:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 83);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 7;
            label7.Text = "Broj razmjena:";
            // 
            // cbUniverzitet2
            // 
            cbUniverzitet2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet2.FormattingEnabled = true;
            cbUniverzitet2.Location = new Point(6, 52);
            cbUniverzitet2.Name = "cbUniverzitet2";
            cbUniverzitet2.Size = new Size(276, 28);
            cbUniverzitet2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(288, 29);
            label9.Name = "label9";
            label9.Size = new Size(38, 20);
            label9.TabIndex = 7;
            label9.Text = "Info:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 28);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 7;
            label6.Text = "Univerzitet:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 7;
            label1.Text = "Države:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 18);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 18);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 7;
            label3.Text = "Broj kredita";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 18);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 7;
            label4.Text = "Početak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(709, 20);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 7;
            label5.Text = "Kraj razmjene:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // prviprvi
            // 
            prviprvi.Location = new Point(1044, 533);
            prviprvi.Name = "prviprvi";
            prviprvi.Size = new Size(22, 27);
            prviprvi.TabIndex = 8;
            prviprvi.Value = new DateTime(2025, 1, 1, 16, 36, 0, 0);
            prviprvi.Visible = false;
            // 
            // frmRazmjeneIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 559);
            Controls.Add(prviprvi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvRazmjena);
            Controls.Add(btnPotvrda);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpKraj);
            Controls.Add(dtpPocetak);
            Controls.Add(tbKredita);
            Controls.Add(cbUniverzitet);
            Controls.Add(cbDrzava);
            Name = "frmRazmjeneIB210178";
            Text = "frmRazmjeneIB210178";
            Load += frmRazmjeneIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazmjena).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDrzava;
        private ComboBox cbUniverzitet;
        private TextBox tbKredita;
        private DateTimePicker dtpPocetak;
        private DateTimePicker dtpKraj;
        private Button btnSacuvaj;
        private DataGridView dgvRazmjena;
        private Button btnPotvrda;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider err;
        private DataGridViewTextBoxColumn UniverzitetDrzava;
        private DataGridViewTextBoxColumn PocetakRazmjene;
        private DataGridViewTextBoxColumn KrajRazmjene;
        private DataGridViewTextBoxColumn ECTS;
        private DataGridViewCheckBoxColumn Okoncana;
        private DataGridViewButtonColumn btnObrisi;
        private ComboBox cbUniverzitet2;
        private Label label6;
        private TextBox tbInfo;
        private TextBox tbBrojKredita;
        private TextBox tbBrojRazmjena;
        private Button btnGenerisi;
        private Label label9;
        private DateTimePicker prviprvi;
    }
}