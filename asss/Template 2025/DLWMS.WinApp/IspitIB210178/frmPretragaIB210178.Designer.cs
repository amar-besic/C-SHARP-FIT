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
            cbDrzava = new ComboBox();
            cbSpol = new ComboBox();
            dgvStudenti = new DataGridView();
            IndexImePrezime = new DataGridViewTextBoxColumn();
            imeDrzave = new DataGridViewTextBoxColumn();
            imeGrada = new DataGridViewTextBoxColumn();
            imeSpola = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            btnRazmjene = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudenti).BeginInit();
            SuspendLayout();
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(12, 33);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(125, 27);
            tbImePrezime.TabIndex = 0;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // cbDrzava
            // 
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(226, 33);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(151, 28);
            cbDrzava.TabIndex = 1;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbSpol
            // 
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(485, 32);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(151, 28);
            cbSpol.TabIndex = 1;
            cbSpol.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // dgvStudenti
            // 
            dgvStudenti.AllowUserToAddRows = false;
            dgvStudenti.AllowUserToDeleteRows = false;
            dgvStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { IndexImePrezime, imeDrzave, imeGrada, imeSpola, Aktivan, btnRazmjene });
            dgvStudenti.Location = new Point(12, 66);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(943, 311);
            dgvStudenti.TabIndex = 2;
            // 
            // IndexImePrezime
            // 
            IndexImePrezime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IndexImePrezime.DataPropertyName = "IndexImePrezime";
            IndexImePrezime.HeaderText = "(Indeks) Ime Prezime";
            IndexImePrezime.MinimumWidth = 6;
            IndexImePrezime.Name = "IndexImePrezime";
            IndexImePrezime.ReadOnly = true;
            // 
            // imeDrzave
            // 
            imeDrzave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            imeDrzave.DataPropertyName = "imeDrzave";
            imeDrzave.HeaderText = "Država:";
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
            // btnRazmjene
            // 
            btnRazmjene.DataPropertyName = "btnRazmjene";
            btnRazmjene.HeaderText = "";
            btnRazmjene.MinimumWidth = 6;
            btnRazmjene.Name = "btnRazmjene";
            btnRazmjene.ReadOnly = true;
            btnRazmjene.Width = 125;
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
            label2.Location = new Point(217, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Države:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Spol:";
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 389);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudenti);
            Controls.Add(cbSpol);
            Controls.Add(cbDrzava);
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
        private ComboBox cbDrzava;
        private ComboBox cbSpol;
        private DataGridView dgvStudenti;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn IndexImePrezime;
        private DataGridViewTextBoxColumn imeDrzave;
        private DataGridViewTextBoxColumn imeGrada;
        private DataGridViewTextBoxColumn imeSpola;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjene;
    }
}