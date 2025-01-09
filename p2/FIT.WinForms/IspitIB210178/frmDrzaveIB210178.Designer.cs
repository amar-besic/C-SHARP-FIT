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
            btnNovaDrzava = new Button();
            btnPrintaj = new Button();
            dgvDrzava = new DataGridView();
            Sat = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Status = new DataGridViewCheckBoxColumn();
            btnGradovi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDrzava).BeginInit();
            SuspendLayout();
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(662, 36);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(126, 29);
            btnNovaDrzava.TabIndex = 0;
            btnNovaDrzava.Text = "Nova država";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(662, 376);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(126, 29);
            btnPrintaj.TabIndex = 0;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // dgvDrzava
            // 
            dgvDrzava.AllowUserToAddRows = false;
            dgvDrzava.AllowUserToDeleteRows = false;
            dgvDrzava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzava.Columns.AddRange(new DataGridViewColumn[] { Zastava, Naziv, BrojGradova, Status, btnGradovi });
            dgvDrzava.Location = new Point(12, 73);
            dgvDrzava.Name = "dgvDrzava";
            dgvDrzava.ReadOnly = true;
            dgvDrzava.RowHeadersWidth = 51;
            dgvDrzava.RowTemplate.Height = 29;
            dgvDrzava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrzava.Size = new Size(776, 297);
            dgvDrzava.TabIndex = 1;
            // 
            // Sat
            // 
            Sat.Interval = 1000;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
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
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(dgvDrzava);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            Name = "frmDrzaveIB210178";
            Text = "frmDrzaveIB210178";
            Load += frmDrzaveIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaDrzava;
        private Button btnPrintaj;
        private DataGridView dgvDrzava;
        private System.Windows.Forms.Timer Sat;
        private StatusStrip statusStrip1;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewButtonColumn btnGradovi;
    }
}