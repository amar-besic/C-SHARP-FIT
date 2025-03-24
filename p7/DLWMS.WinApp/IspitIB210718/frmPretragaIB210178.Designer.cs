namespace DLWMS.WinApp.IspitIB210718
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
            tbImePrezime = new TextBox();
            cbDrzava = new ComboBox();
            cbSpol = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IndexImePrezime = new DataGridViewTextBoxColumn();
            ImeDrzave = new DataGridViewTextBoxColumn();
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
            dgvStudenti.Columns.AddRange(new DataGridViewColumn[] { IndexImePrezime, ImeDrzave, Grad, Spol, Aktivan, btnRazmjene });
            dgvStudenti.Location = new Point(11, 73);
            dgvStudenti.Name = "dgvStudenti";
            dgvStudenti.ReadOnly = true;
            dgvStudenti.RowHeadersWidth = 51;
            dgvStudenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudenti.Size = new Size(1020, 365);
            dgvStudenti.TabIndex = 0;
            dgvStudenti.CellContentClick += dgvStudenti_CellContentClick;
            dgvStudenti.CellDoubleClick += dgvStudenti_CellDoubleClick;
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(11, 31);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.Size = new Size(204, 27);
            tbImePrezime.TabIndex = 1;
            tbImePrezime.TextChanged += tbImePrezime_TextChanged;
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(221, 30);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(188, 28);
            cbDrzava.TabIndex = 2;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbSpol
            // 
            cbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpol.FormattingEnabled = true;
            cbSpol.Location = new Point(415, 30);
            cbSpol.Name = "cbSpol";
            cbSpol.Size = new Size(174, 28);
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
            label2.Location = new Point(221, 7);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Država:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 7);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 3;
            label3.Text = "Spol:";
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
            ImeDrzave.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ImeDrzave.DataPropertyName = "ImeDrzave";
            ImeDrzave.HeaderText = "Drzava";
            ImeDrzave.MinimumWidth = 6;
            ImeDrzave.Name = "ImeDrzave";
            ImeDrzave.ReadOnly = true;
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
            Aktivan.Width = 90;
            // 
            // btnRazmjene
            // 
            btnRazmjene.DataPropertyName = "btnRazmjene";
            btnRazmjene.HeaderText = "btnRazmjene";
            btnRazmjene.MinimumWidth = 6;
            btnRazmjene.Name = "btnRazmjene";
            btnRazmjene.ReadOnly = true;
            btnRazmjene.Text = "Razmjene";
            btnRazmjene.UseColumnTextForButtonValue = true;
            btnRazmjene.Width = 125;
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSpol);
            Controls.Add(cbDrzava);
            Controls.Add(tbImePrezime);
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
        private TextBox tbImePrezime;
        private ComboBox cbDrzava;
        private ComboBox cbSpol;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn IndexImePrezime;
        private DataGridViewTextBoxColumn ImeDrzave;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn Spol;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn btnRazmjene;
    }
}