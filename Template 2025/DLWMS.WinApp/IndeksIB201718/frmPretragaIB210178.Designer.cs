namespace DLWMS.WinApp.IndeksIB201718
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
            dgvStudenti = new DataGridView();
            tbIMePrezime = new TextBox();
            cbDrzava = new ComboBox();
            cbSpol = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            indeksImePrezime = new DataGridViewTextBoxColumn();
            imeDrzave = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            Spol = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjene = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { indeksImePrezime, imeDrzave, Grad, Spol, Aktivan, btnRazmjene });
            dgvStudenti.Location = new Point(14, 68);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(1046, 370);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            dgvStudenti.CellDoubleClick += dgvStudenti_CellDoubleClick;
            // 
            // tbIMePrezime
            // 
            tbIMePrezime.Location = new Point(14, 34);
            tbIMePrezime.Name = "tbIMePrezime";
            tbIMePrezime.Size = new Size(195, 27);
            tbIMePrezime.TabIndex = 1;
            tbIMePrezime.TextChanged += tbIMePrezime_TextChanged;
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(230, 34);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(208, 28);
            cbDrzava.TabIndex = 2;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(456, 34);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(151, 28);
            cbSpol.TabIndex = 2;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 3;
            label1.Text = "Ime ili prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Država:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(456, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 3;
            label3.Text = "Spol:";
            // 
            // indeksImePrezime
            // 
            indeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            indeksImePrezime.DataPropertyName = "indeksImePrezime";
            indeksImePrezime.HeaderText = "(Indeks) Ime prezime";
            indeksImePrezime.MinimumWidth = 6;
            indeksImePrezime.Name = "indeksImePrezime";
            indeksImePrezime.ReadOnly = true;
            // 
            // imeDrzave
            // 
            imeDrzave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imeDrzave.DataPropertyName = "imeDrzave";
            imeDrzave.HeaderText = "Dežava";
            imeDrzave.MinimumWidth = 6;
            imeDrzave.Name = "imeDrzave";
            imeDrzave.ReadOnly = true;
            // 
            // Grad
            // 
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 6;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            Grad.Width = 125;
            // 
            // Spol
            // 
            Spol.DataPropertyName = "Spol";
            Spol.HeaderText = "Spol";
            Spol.MinimumWidth = 6;
            Spol.Name = "Spol";
            Spol.ReadOnly = true;
            Spol.Width = 125;
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
            // btnRazmjene
            // 
            btnRazmjene.DataPropertyName = "btnRazmjene";
            btnRazmjene.HeaderText = "";
            btnRazmjene.MinimumWidth = 6;
            btnRazmjene.Name = "btnRazmjene";
            btnRazmjene.ReadOnly = true;
            btnRazmjene.Resizable = DataGridViewTriState.True;
            btnRazmjene.Text = "Razmjene";
            btnRazmjene.UseColumnTextForButtonValue = true;
            btnRazmjene.Width = 125;
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSpol);
            Controls.Add(cbDrzava);
            Controls.Add(tbIMePrezime);
            Controls.Add(dgvStudenti);
            Name = "frmPretragaIB210178";
            Text = "frmPretragaIB210178";
            Load += frmPretragaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudenti;
        private TextBox tbIMePrezime;
        private ComboBox cbDrzava;
        private ComboBox cbSpol;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn indeksImePrezime;
        private DataGridViewTextBoxColumn imeDrzave;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjene;
    }
}