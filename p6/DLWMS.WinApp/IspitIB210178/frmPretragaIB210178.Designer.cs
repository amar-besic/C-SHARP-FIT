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
            dgvStudenti = new DataGridView();
            IndeksImePrezime = new DataGridViewTextBoxColumn();
            imeDrzave = new DataGridViewTextBoxColumn();
            imeGrada = new DataGridViewTextBoxColumn();
            imeSpola = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjena = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbImePrezime = new TextBox();
            cbDrzava = new ComboBox();
            cbSpol = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { IndeksImePrezime, imeDrzave, imeGrada, imeSpola, Aktivan, btnRazmjena });
            dgvStudenti.Location = new Point(12, 68);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(1185, 366);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            dgvStudenti.CellDoubleClick += dgvStudenti_CellDoubleClick;
            // 
            // IndeksImePrezime
            // 
            IndeksImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndeksImePrezime.DataPropertyName = "IndeksImePrezime";
            IndeksImePrezime.HeaderText = "(Indeks) Ime prezime";
            IndeksImePrezime.MinimumWidth = 6;
            IndeksImePrezime.Name = "IndeksImePrezime";
            IndeksImePrezime.ReadOnly = true;
            // 
            // imeDrzave
            // 
            imeDrzave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imeDrzave.DataPropertyName = "imeDrzave";
            imeDrzave.HeaderText = "Država";
            imeDrzave.MinimumWidth = 6;
            imeDrzave.Name = "imeDrzave";
            imeDrzave.ReadOnly = true;
            // 
            // imeGrada
            // 
            imeGrada.DataPropertyName = "imeGrada";
            imeGrada.HeaderText = "Grad";
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
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 125;
            // 
            // btnRazmjena
            // 
            btnRazmjena.DataPropertyName = "btnRazmjena";
            btnRazmjena.HeaderText = "";
            btnRazmjena.MinimumWidth = 6;
            btnRazmjena.Name = "btnRazmjena";
            btnRazmjena.ReadOnly = true;
            btnRazmjena.Text = "Razmjene";
            btnRazmjena.UseColumnTextForButtonValue = true;
            btnRazmjena.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Ime ili prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Država:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "Spol:";
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(12, 33);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(279, 27);
            tbImePrezime.TabIndex = 2;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(297, 33);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(226, 28);
            cbDrzava.TabIndex = 3;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(529, 34);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(224, 28);
            cbSpol.TabIndex = 3;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 446);
            Controls.Add(cbSpol);
            Controls.Add(cbDrzava);
            Controls.Add(tbImePrezime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbImePrezime;
        private ComboBox cbDrzava;
        private ComboBox cbSpol;
        private DataGridViewTextBoxColumn IndeksImePrezime;
        private DataGridViewTextBoxColumn imeDrzave;
        private DataGridViewTextBoxColumn imeGrada;
        private DataGridViewTextBoxColumn imeSpola;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjena;
    }
}