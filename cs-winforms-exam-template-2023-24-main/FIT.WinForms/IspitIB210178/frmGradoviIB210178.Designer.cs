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
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnPromjeniStatus = new DataGridViewButtonColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            btnDodaj = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(162, 80);
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNaziv.Location = new Point(180, 25);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(239, 46);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv Države";
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Status, btnPromjeniStatus });
            dgvGradovi.Location = new Point(12, 151);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGradovi.Size = new Size(479, 131);
            dgvGradovi.TabIndex = 2;
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
            btnPromjeniStatus.Text = "PromjeniStatus";
            btnPromjeniStatus.UseColumnTextForButtonValue = true;
            btnPromjeniStatus.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 3;
            label1.Text = "Unesite naziv novog grada:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 27);
            textBox1.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(432, 116);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(59, 29);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(23, 317);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 144);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 57);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(456, 81);
            textBox2.TabIndex = 0;
            // 
            // frmGradoviIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 473);
            Controls.Add(groupBox1);
            Controls.Add(btnDodaj);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dgvGradovi);
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
        private DataGridView dgvGradovi;
        private Label label1;
        private TextBox textBox1;
        private Button btnDodaj;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnPromjeniStatus;
        private GroupBox groupBox1;
        private TextBox textBox2;
    }
}