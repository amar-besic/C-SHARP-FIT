namespace DLWMS.WinApp.IspitIB210178
{
    partial class frmRazmjeneIB210178
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
            dgvRazmjene = new DataGridView();
            UnDrz = new DataGridViewTextBoxColumn();
            cbDržava = new ComboBox();
            cbUniverzitet = new ComboBox();
            tbKredit = new TextBox();
            dtpOD = new DateTimePicker();
            dtpDO = new DateTimePicker();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).BeginInit();
            SuspendLayout();
            // 
            // dgvRazmjene
            // 
            dgvRazmjene.AllowUserToAddRows = false;
            dgvRazmjene.AllowUserToDeleteRows = false;
            dgvRazmjene.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRazmjene.Columns.AddRange(new DataGridViewColumn[] { UnDrz });
            dgvRazmjene.Location = new Point(12, 165);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.Size = new Size(1091, 188);
            dgvRazmjene.TabIndex = 0;
            // 
            // UnDrz
            // 
            UnDrz.DataPropertyName = "UnDrz";
            UnDrz.HeaderText = "Univerzitet";
            UnDrz.MinimumWidth = 6;
            UnDrz.Name = "UnDrz";
            UnDrz.ReadOnly = true;
            UnDrz.Width = 125;
            // 
            // cbDržava
            // 
            cbDržava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDržava.FormattingEnabled = true;
            cbDržava.Location = new Point(12, 86);
            cbDržava.Name = "cbDržava";
            cbDržava.Size = new Size(216, 28);
            cbDržava.TabIndex = 1;
            cbDržava.SelectedIndexChanged += cbDržava_SelectedIndexChanged;
            // 
            // cbUniverzitet
            // 
            cbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet.FormattingEnabled = true;
            cbUniverzitet.Location = new Point(234, 86);
            cbUniverzitet.Name = "cbUniverzitet";
            cbUniverzitet.Size = new Size(202, 28);
            cbUniverzitet.TabIndex = 1;
            // 
            // tbKredit
            // 
            tbKredit.Location = new Point(442, 86);
            tbKredit.Name = "tbKredit";
            tbKredit.Size = new Size(72, 27);
            tbKredit.TabIndex = 2;
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(520, 84);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(250, 27);
            dtpOD.TabIndex = 3;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(776, 84);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(250, 27);
            dtpDO.TabIndex = 3;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(1032, 82);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmRazmjeneIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(tbKredit);
            Controls.Add(cbUniverzitet);
            Controls.Add(cbDržava);
            Controls.Add(dgvRazmjene);
            Name = "frmRazmjeneIB210178";
            Text = "frmRazmjeneIB210178";
            Load += frmRazmjeneIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRazmjene).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRazmjene;
        private DataGridViewTextBoxColumn UnDrz;
        private ComboBox cbDržava;
        private ComboBox cbUniverzitet;
        private TextBox tbKredit;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private Button btnSacuvaj;
    }
}