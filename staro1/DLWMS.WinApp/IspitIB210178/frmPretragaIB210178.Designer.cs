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
            label2 = new Label();
            label3 = new Label();
            cbDrzava = new ComboBox();
            cbSpol = new ComboBox();
            tbImePrezime = new TextBox();
            dgvStudenti = new DataGridView();
            IndexImePrezime = new DataGridViewTextBoxColumn();
            ImeDrzave = new DataGridViewTextBoxColumn();
            ImeGrada = new DataGridViewTextBoxColumn();
            ImeSpola = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjena = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime ili prezime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 11);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Država:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 11);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 0;
            label3.Text = "Spol:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(177, 31);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(151, 28);
            cbDrzava.TabIndex = 1;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(336, 31);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(151, 28);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbSpol_SelectedIndexChanged;
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(12, 32);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.PasswordChar = '?';
            tbImePrezime.Size = new Size(159, 27);
            tbImePrezime.TabIndex = 2;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { IndexImePrezime, ImeDrzave, ImeGrada, ImeSpola, Aktivan, btnRazmjena });
            dgvStudenti.Location = new Point(11, 68);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(891, 352);
            dgvStudenti.TabIndex = 3;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            dgvStudenti.CellDoubleClick += dgvStudenti_CellDoubleClick;
            // 
            // IndexImePrezime
            // 
            IndexImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndexImePrezime.DataPropertyName = "IndexImePrezime";
            IndexImePrezime.HeaderText = "(Indeks) Ime prezime";
            IndexImePrezime.MinimumWidth = 6;
            IndexImePrezime.Name = "IndexImePrezime";
            IndexImePrezime.ReadOnly = true;
            // 
            // ImeDrzave
            // 
            ImeDrzave.DataPropertyName = "ImeDrzave";
            ImeDrzave.HeaderText = "Država";
            ImeDrzave.MinimumWidth = 6;
            ImeDrzave.Name = "ImeDrzave";
            ImeDrzave.ReadOnly = true;
            ImeDrzave.Width = 160;
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
            ImeSpola.Width = 110;
            // 
            // Aktivan
            // 
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Width = 80;
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
            btnRazmjena.Width = 90;
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 431);
            Controls.Add(dgvStudenti);
            Controls.Add(tbImePrezime);
            Controls.Add(cbSpol);
            Controls.Add(cbDrzava);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB210178";
            Text = "frmPretragaIB210178";
            Load += frmPretragaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbDrzava;
        private ComboBox cbSpol;
        private TextBox tbImePrezime;
        private DataGridView dgvStudenti;
        private DataGridViewTextBoxColumn IndexImePrezime;
        private DataGridViewTextBoxColumn ImeDrzave;
        private DataGridViewTextBoxColumn ImeGrada;
        private DataGridViewTextBoxColumn ImeSpola;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjena;
    }
}