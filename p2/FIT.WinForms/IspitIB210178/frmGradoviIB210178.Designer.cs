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
            pbZastava = new PictureBox();
            lblNaziv = new Label();
            label2 = new Label();
            tbNaziv = new TextBox();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnPromjeni = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            btnGenerisi = new Button();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(17, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(163, 75);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 3;
            pbZastava.TabStop = false;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaziv.Location = new Point(194, 21);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(279, 52);
            lblNaziv.TabIndex = 4;
            lblNaziv.Text = "Naziv države";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 107);
            label2.Name = "label2";
            label2.Size = new Size(188, 20);
            label2.TabIndex = 4;
            label2.Text = "Unesite naziv novog grada:";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(219, 107);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(279, 27);
            tbNaziv.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(504, 107);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(71, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, btnPromjeni });
            dgvGradovi.Location = new Point(17, 148);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.Size = new Size(551, 188);
            dgvGradovi.TabIndex = 7;
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
            // btnPromjeni
            // 
            btnPromjeni.DataPropertyName = "btnPromjeni";
            btnPromjeni.HeaderText = "";
            btnPromjeni.MinimumWidth = 6;
            btnPromjeni.Name = "btnPromjeni";
            btnPromjeni.ReadOnly = true;
            btnPromjeni.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(15, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 205);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(204, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Aktivni";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 84);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(522, 115);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Broj gradova:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 27);
            textBox2.TabIndex = 5;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(286, 34);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(86, 29);
            btnGenerisi.TabIndex = 6;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            // 
            // frmGradoviIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 570);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(tbNaziv);
            Controls.Add(label2);
            Controls.Add(lblNaziv);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB210178";
            Text = "frmGradoviIB210178";
            Load += frmGradoviIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNaziv;
        private Label label2;
        private TextBox tbNaziv;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnPromjeni;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button btnGenerisi;
    }
}