namespace DLWMS.WinApp.IspitIB210178
{
    partial class frmUvjerenjaIB210178
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
            btnZahtjev = new Button();
            dgvUvjernja = new DataGridView();
            Vrjeme = new DataGridViewTextBoxColumn();
            Vrsta = new DataGridViewTextBoxColumn();
            Svrha = new DataGridViewTextBoxColumn();
            Uplatnica = new DataGridViewImageColumn();
            Printano = new DataGridViewCheckBoxColumn();
            btnBriši = new DataGridViewButtonColumn();
            btnPrintaj = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUvjernja).BeginInit();
            SuspendLayout();
            // 
            // btnZahtjev
            // 
            btnZahtjev.Location = new Point(830, 12);
            btnZahtjev.Name = "btnZahtjev";
            btnZahtjev.Size = new Size(94, 29);
            btnZahtjev.TabIndex = 0;
            btnZahtjev.Text = "Zahtjev";
            btnZahtjev.UseVisualStyleBackColor = true;
            btnZahtjev.Click += btnZahtjev_Click;
            // 
            // dgvUvjernja
            // 
            dgvUvjernja.AllowUserToAddRows = false;
            dgvUvjernja.AllowUserToDeleteRows = false;
            dgvUvjernja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUvjernja.Columns.AddRange(new DataGridViewColumn[] { Vrjeme, Vrsta, Svrha, Uplatnica, Printano, btnBriši, btnPrintaj });
            dgvUvjernja.Location = new Point(12, 47);
            dgvUvjernja.Name = "dgvUvjernja";
            dgvUvjernja.ReadOnly = true;
            dgvUvjernja.RowHeadersWidth = 51;
            dgvUvjernja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUvjernja.Size = new Size(930, 174);
            dgvUvjernja.TabIndex = 1;
            dgvUvjernja.CellContentClick += dgvUvjernja_CellContentClick;
            // 
            // Vrjeme
            // 
            Vrjeme.DataPropertyName = "Vrjeme";
            Vrjeme.HeaderText = "Datum";
            Vrjeme.MinimumWidth = 6;
            Vrjeme.Name = "Vrjeme";
            Vrjeme.ReadOnly = true;
            Vrjeme.Width = 125;
            // 
            // Vrsta
            // 
            Vrsta.DataPropertyName = "Vrsta";
            Vrsta.HeaderText = "Vrsta";
            Vrsta.MinimumWidth = 6;
            Vrsta.Name = "Vrsta";
            Vrsta.ReadOnly = true;
            Vrsta.Width = 125;
            // 
            // Svrha
            // 
            Svrha.DataPropertyName = "Svrha";
            Svrha.HeaderText = "Svrha";
            Svrha.MinimumWidth = 6;
            Svrha.Name = "Svrha";
            Svrha.ReadOnly = true;
            Svrha.Width = 125;
            // 
            // Uplatnica
            // 
            Uplatnica.DataPropertyName = "Uplatnica";
            Uplatnica.HeaderText = "Uplatnica";
            Uplatnica.MinimumWidth = 6;
            Uplatnica.Name = "Uplatnica";
            Uplatnica.ReadOnly = true;
            Uplatnica.Width = 125;
            // 
            // Printano
            // 
            Printano.DataPropertyName = "Printano";
            Printano.HeaderText = "Printano";
            Printano.MinimumWidth = 6;
            Printano.Name = "Printano";
            Printano.ReadOnly = true;
            Printano.Width = 125;
            // 
            // btnBriši
            // 
            btnBriši.DataPropertyName = "btnBriši";
            btnBriši.HeaderText = "";
            btnBriši.MinimumWidth = 6;
            btnBriši.Name = "btnBriši";
            btnBriši.ReadOnly = true;
            btnBriši.Text = "Briši";
            btnBriši.UseColumnTextForButtonValue = true;
            btnBriši.Width = 125;
            // 
            // btnPrintaj
            // 
            btnPrintaj.DataPropertyName = "btnPrintaj";
            btnPrintaj.HeaderText = "";
            btnPrintaj.MinimumWidth = 6;
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.ReadOnly = true;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseColumnTextForButtonValue = true;
            btnPrintaj.Width = 125;
            // 
            // frmUvjerenjaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 450);
            Controls.Add(dgvUvjernja);
            Controls.Add(btnZahtjev);
            Name = "frmUvjerenjaIB210178";
            Text = "frmUvjerenjaIB210178";
            Load += frmUvjerenjaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUvjernja).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnZahtjev;
        private DataGridView dgvUvjernja;
        private DataGridViewTextBoxColumn Vrjeme;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn btnBriši;
        private DataGridViewButtonColumn btnPrintaj;
    }
}