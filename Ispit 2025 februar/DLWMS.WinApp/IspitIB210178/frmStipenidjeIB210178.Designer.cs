namespace DLWMS.WinApp.IspitIB210178
{
    partial class frmStipenidjeIB210178
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
            cbGodina = new ComboBox();
            cbTip = new ComboBox();
            tbIznos = new TextBox();
            btnDodaj = new Button();
            dgvStipendije = new DataGridView();
            Godina = new DataGridViewTextBoxColumn();
            Stipendija = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Dodjeljivana = new DataGridViewCheckBoxColumn();
            btnGenerisi = new Button();
            tbInfo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Location = new Point(11, 35);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(191, 28);
            cbGodina.TabIndex = 0;
            // 
            // cbTip
            // 
            cbTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTip.FormattingEnabled = true;
            cbTip.Location = new Point(208, 35);
            cbTip.Name = "cbTip";
            cbTip.Size = new Size(191, 28);
            cbTip.TabIndex = 0;
            // 
            // tbIznos
            // 
            tbIznos.Location = new Point(405, 35);
            tbIznos.Name = "tbIznos";
            tbIznos.Size = new Size(125, 27);
            tbIznos.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(536, 34);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvStipendije
            // 
            dgvStipendije.AllowUserToAddRows = false;
            dgvStipendije.AllowUserToDeleteRows = false;
            dgvStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStipendije.Columns.AddRange(new DataGridViewColumn[] { Godina, Stipendija, Iznos, Dodjeljivana });
            dgvStipendije.Location = new Point(11, 69);
            dgvStipendije.Name = "dgvStipendije";
            dgvStipendije.ReadOnly = true;
            dgvStipendije.RowHeadersWidth = 51;
            dgvStipendije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStipendije.Size = new Size(796, 261);
            dgvStipendije.TabIndex = 3;
            dgvStipendije.CellDoubleClick += dgvStipendije_CellDoubleClick;
            // 
            // Godina
            // 
            Godina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Godina.DataPropertyName = "Godina";
            Godina.HeaderText = "Godina";
            Godina.MinimumWidth = 6;
            Godina.Name = "Godina";
            Godina.ReadOnly = true;
            // 
            // Stipendija
            // 
            Stipendija.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stipendija.DataPropertyName = "Stipendija";
            Stipendija.HeaderText = "Stipendija";
            Stipendija.MinimumWidth = 6;
            Stipendija.Name = "Stipendija";
            Stipendija.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Mjesečni iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Dodjeljivana
            // 
            Dodjeljivana.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dodjeljivana.DataPropertyName = "Dodjeljivana";
            Dodjeljivana.HeaderText = "Dodjeljivana";
            Dodjeljivana.MinimumWidth = 6;
            Dodjeljivana.Name = "Dodjeljivana";
            Dodjeljivana.ReadOnly = true;
            Dodjeljivana.Resizable = DataGridViewTriState.True;
            Dodjeljivana.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(12, 336);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(239, 29);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generiši stipendije >>>>>";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(12, 371);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(788, 203);
            tbInfo.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStipenidjeIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 586);
            Controls.Add(tbInfo);
            Controls.Add(btnGenerisi);
            Controls.Add(dgvStipendije);
            Controls.Add(btnDodaj);
            Controls.Add(tbIznos);
            Controls.Add(cbTip);
            Controls.Add(cbGodina);
            Name = "frmStipenidjeIB210178";
            Text = "frmStipenidjeIB210178";
            Load += frmStipenidjeIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGodina;
        private ComboBox cbTip;
        private TextBox tbIznos;
        private Button btnDodaj;
        private DataGridView dgvStipendije;
        private Button btnGenerisi;
        private TextBox tbInfo;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Godina;
        private DataGridViewTextBoxColumn Stipendija;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewCheckBoxColumn Dodjeljivana;
    }
}