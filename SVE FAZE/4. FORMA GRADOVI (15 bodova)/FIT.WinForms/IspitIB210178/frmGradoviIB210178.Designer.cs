namespace FIT.WinForms.IspitIB210178
{
    partial class frmGradoviIB210178
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
            pbZastava = new PictureBox();
            lblNaziv = new Label();
            groupBox1 = new GroupBox();
            btnGenerisi = new Button();
            chbAktivni = new CheckBox();
            tbBrojGradova = new TextBox();
            tbInfo = new TextBox();
            label1 = new Label();
            label3 = new Label();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnPromjeniStatus = new DataGridViewButtonColumn();
            label2 = new Label();
            btnDodaj = new Button();
            tbNazivGrada = new TextBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(141, 70);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 2;
            pbZastava.TabStop = false;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaziv.Location = new Point(159, 22);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(231, 50);
            lblNaziv.TabIndex = 3;
            lblNaziv.Text = "Naziv grada";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(chbAktivni);
            groupBox1.Controls.Add(tbBrojGradova);
            groupBox1.Controls.Add(tbInfo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(15, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 196);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(278, 22);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // chbAktivni
            // 
            chbAktivni.AutoSize = true;
            chbAktivni.Location = new Point(196, 25);
            chbAktivni.Name = "chbAktivni";
            chbAktivni.Size = new Size(76, 24);
            chbAktivni.TabIndex = 6;
            chbAktivni.Text = "Aktivni";
            chbAktivni.UseVisualStyleBackColor = true;
            // 
            // tbBrojGradova
            // 
            tbBrojGradova.Location = new Point(104, 23);
            tbBrojGradova.Name = "tbBrojGradova";
            tbBrojGradova.Size = new Size(86, 27);
            tbBrojGradova.TabIndex = 5;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 78);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(505, 112);
            tbInfo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 26);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 3;
            label3.Text = "Broj gradova:";
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, btnPromjeniStatus });
            dgvGradovi.Location = new Point(12, 138);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.Size = new Size(520, 158);
            dgvGradovi.TabIndex = 5;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Aktivan";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // btnPromjeniStatus
            // 
            btnPromjeniStatus.DataPropertyName = "btnPromjeniStatus";
            btnPromjeniStatus.HeaderText = "";
            btnPromjeniStatus.MinimumWidth = 6;
            btnPromjeniStatus.Name = "btnPromjeniStatus";
            btnPromjeniStatus.ReadOnly = true;
            btnPromjeniStatus.Text = "Promjeni status";
            btnPromjeniStatus.UseColumnTextForButtonValue = true;
            btnPromjeniStatus.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 100);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 3;
            label2.Text = "Unesite naziv novog grada:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(472, 95);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(60, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // tbNazivGrada
            // 
            tbNazivGrada.Location = new Point(208, 97);
            tbNazivGrada.Name = "tbNazivGrada";
            tbNazivGrada.Size = new Size(258, 27);
            tbNazivGrada.TabIndex = 5;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmGradoviIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 510);
            Controls.Add(btnDodaj);
            Controls.Add(dgvGradovi);
            Controls.Add(tbNazivGrada);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(lblNaziv);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB210178";
            Text = "frmGradoviIB210178";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNaziv;
        private GroupBox groupBox1;
        private Button btnGenerisi;
        private CheckBox chbAktivni;
        private TextBox tbBrojGradova;
        private TextBox tbInfo;
        private Label label3;
        private DataGridView dgvGradovi;
        private Label label2;
        private Button btnDodaj;
        private TextBox tbNazivGrada;
        private Label label1;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnPromjeniStatus;
        private ErrorProvider err;
    }
}