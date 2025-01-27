namespace FIT.WinForms.IspitIB210178
{
    partial class frmDrzaveIB210178
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
            dgvDrzave = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnGradovi = new DataGridViewButtonColumn();
            btnNovaDrzava = new Button();
            btnPrintaj = new Button();
            sat = new System.Windows.Forms.Timer(components);
            tsslVrjeme = new StatusStrip();
            tsslVrjeme2 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            tsslVrjeme.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Naziv, BrojGradova, Status, btnGradovi });
            dgvDrzave.Location = new Point(12, 83);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 29;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzave.Size = new Size(776, 325);
            dgvDrzave.TabIndex = 0;
            // 
            // Zastava
            // 
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            Zastava.Width = 80;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Država";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj Gradova";
            BrojGradova.MinimumWidth = 6;
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            BrojGradova.Width = 125;
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
            // btnGradovi
            // 
            btnGradovi.DataPropertyName = "btnGradovi";
            btnGradovi.HeaderText = "";
            btnGradovi.MinimumWidth = 6;
            btnGradovi.Name = "btnGradovi";
            btnGradovi.ReadOnly = true;
            btnGradovi.Text = "Gradovi";
            btnGradovi.UseColumnTextForButtonValue = true;
            btnGradovi.Width = 125;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(653, 48);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(135, 29);
            btnNovaDrzava.TabIndex = 1;
            btnNovaDrzava.Text = "Nova drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(653, 414);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(135, 29);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // sat
            // 
            sat.Interval = 1000;
            sat.Tick += sat_Ticking;
            // 
            // tsslVrjeme
            // 
            tsslVrjeme.ImageScalingSize = new Size(20, 20);
            tsslVrjeme.Items.AddRange(new ToolStripItem[] { tsslVrjeme2 });
            tsslVrjeme.Location = new Point(0, 446);
            tsslVrjeme.Name = "tsslVrjeme";
            tsslVrjeme.Size = new Size(800, 26);
            tsslVrjeme.TabIndex = 3;
            tsslVrjeme.Text = "statusStrip1";
            // 
            // tsslVrjeme2
            // 
            tsslVrjeme2.Name = "tsslVrjeme2";
            tsslVrjeme2.Size = new Size(151, 20);
            tsslVrjeme2.Text = "toolStripStatusLabel1";
            // 
            // frmDrzaveIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(tsslVrjeme);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            Controls.Add(dgvDrzave);
            Name = "frmDrzaveIB210178";
            Text = "Države";
            Load += frmDrzaveIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            tsslVrjeme.ResumeLayout(false);
            tsslVrjeme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrzave;
        private Button btnNovaDrzava;
        private Button btnPrintaj;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnGradovi;
        private System.Windows.Forms.Timer sat;
        private StatusStrip tsslVrjeme;
        private ToolStripStatusLabel tsslVrjeme2;
    }
}