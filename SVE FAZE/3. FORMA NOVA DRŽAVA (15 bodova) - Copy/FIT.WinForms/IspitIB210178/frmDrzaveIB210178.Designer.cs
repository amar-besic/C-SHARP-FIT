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
            btnNovaDrzava = new Button();
            statusStrip1 = new StatusStrip();
            tsslVrjeme = new ToolStripStatusLabel();
            sat = new System.Windows.Forms.Timer(components);
            btnPrintaj = new Button();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnGradovi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Naziv, BrojGradova, Status, btnGradovi });
            dgvDrzave.Location = new Point(12, 58);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 29;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzave.Size = new Size(776, 281);
            dgvDrzave.TabIndex = 0;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(659, 23);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(129, 29);
            btnNovaDrzava.TabIndex = 1;
            btnNovaDrzava.Text = "Nova država";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslVrjeme });
            statusStrip1.Location = new Point(0, 389);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslVrjeme
            // 
            tsslVrjeme.Name = "tsslVrjeme";
            tsslVrjeme.Size = new Size(76, 20);
            tsslVrjeme.Text = "tsslVrjeme";
            // 
            // sat
            // 
            sat.Enabled = true;
            sat.Interval = 1000;
            sat.Tick += sat_Tick;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(659, 345);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(129, 29);
            btnPrintaj.TabIndex = 1;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
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
            BrojGradova.HeaderText = "Broj gradova";
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
            // frmDrzaveIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(statusStrip1);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            Controls.Add(dgvDrzave);
            Name = "frmDrzaveIB210178";
            Text = "frmDrzaveIB210178";
            Load += frmDrzaveIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrzave;
        private Button btnNovaDrzava;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslVrjeme;
        private System.Windows.Forms.Timer sat;
        private Button btnPrintaj;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnGradovi;
    }
}