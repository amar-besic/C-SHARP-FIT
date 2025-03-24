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
            dgvStipendije = new DataGridView();
            Student = new DataGridViewTextBoxColumn();
            StipendijaGodina = new DataGridViewTextBoxColumn();
            mjesecniIznos = new DataGridViewTextBoxColumn();
            Ukupno = new DataGridViewTextBoxColumn();
            btnUkloni = new DataGridViewButtonColumn();
            cbGodina = new ComboBox();
            cbStipendija = new ComboBox();
            btnDodaj = new Button();
            btnStipendijePoGodinama = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).BeginInit();
            SuspendLayout();
            // 
            // dgvStipendije
            // 
            dgvStipendije.AllowUserToAddRows = false;
            dgvStipendije.AllowUserToDeleteRows = false;
            dgvStipendije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStipendije.Columns.AddRange(new DataGridViewColumn[] { Student, StipendijaGodina, mjesecniIznos, Ukupno, btnUkloni });
            dgvStipendije.Location = new Point(7, 66);
            dgvStipendije.Name = "dgvStipendije";
            dgvStipendije.ReadOnly = true;
            dgvStipendije.RowHeadersWidth = 51;
            dgvStipendije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStipendije.Size = new Size(776, 290);
            dgvStipendije.TabIndex = 0;
            dgvStipendije.CellContentClick += dgvStipendije_CellContentClick;
            dgvStipendije.CellDoubleClick += dgvStipendije_CellDoubleClick;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // StipendijaGodina
            // 
            StipendijaGodina.DataPropertyName = "StipendijaGodina";
            StipendijaGodina.HeaderText = "Godina";
            StipendijaGodina.MinimumWidth = 6;
            StipendijaGodina.Name = "StipendijaGodina";
            StipendijaGodina.ReadOnly = true;
            StipendijaGodina.Width = 80;
            // 
            // mjesecniIznos
            // 
            mjesecniIznos.DataPropertyName = "mjesecniIznos";
            mjesecniIznos.HeaderText = "Mjesečni iznos";
            mjesecniIznos.MinimumWidth = 6;
            mjesecniIznos.Name = "mjesecniIznos";
            mjesecniIznos.ReadOnly = true;
            mjesecniIznos.Width = 125;
            // 
            // Ukupno
            // 
            Ukupno.DataPropertyName = "Ukupno";
            Ukupno.HeaderText = "Ukupno";
            Ukupno.MinimumWidth = 6;
            Ukupno.Name = "Ukupno";
            Ukupno.ReadOnly = true;
            Ukupno.Width = 125;
            // 
            // btnUkloni
            // 
            btnUkloni.DataPropertyName = "btnUkloni";
            btnUkloni.HeaderText = "";
            btnUkloni.MinimumWidth = 6;
            btnUkloni.Name = "btnUkloni";
            btnUkloni.ReadOnly = true;
            btnUkloni.Text = "Ukloni";
            btnUkloni.UseColumnTextForButtonValue = true;
            btnUkloni.Width = 125;
            // 
            // cbGodina
            // 
            cbGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGodina.FormattingEnabled = true;
            cbGodina.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020" });
            cbGodina.Location = new Point(7, 32);
            cbGodina.Name = "cbGodina";
            cbGodina.Size = new Size(151, 28);
            cbGodina.TabIndex = 1;
            cbGodina.SelectedIndexChanged += cbGodina_SelectedIndexChanged;
            // 
            // cbStipendija
            // 
            cbStipendija.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStipendija.FormattingEnabled = true;
            cbStipendija.Location = new Point(164, 32);
            cbStipendija.Name = "cbStipendija";
            cbStipendija.Size = new Size(175, 28);
            cbStipendija.TabIndex = 1;
            cbStipendija.SelectedIndexChanged += cbStipendija_SelectedIndexChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(448, 32);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(130, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj stipendiju";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnStipendijePoGodinama
            // 
            btnStipendijePoGodinama.Location = new Point(584, 32);
            btnStipendijePoGodinama.Name = "btnStipendijePoGodinama";
            btnStipendijePoGodinama.Size = new Size(195, 29);
            btnStipendijePoGodinama.TabIndex = 2;
            btnStipendijePoGodinama.Text = "Stipendije po godinama";
            btnStipendijePoGodinama.UseVisualStyleBackColor = true;
            btnStipendijePoGodinama.Click += btnStipendijePoGodinama_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Godina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 9);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Stipendija";
            // 
            // frmPretragaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStipendijePoGodinama);
            Controls.Add(btnDodaj);
            Controls.Add(cbStipendija);
            Controls.Add(cbGodina);
            Controls.Add(dgvStipendije);
            Name = "frmPretragaIB210178";
            Text = "frmPretragaIB210178";
            Load += frmPretragaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStipendije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStipendije;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn StipendijaGodina;
        private DataGridViewTextBoxColumn mjesecniIznos;
        private DataGridViewTextBoxColumn Ukupno;
        private DataGridViewButtonColumn btnUkloni;
        private ComboBox cbGodina;
        private ComboBox cbStipendija;
        private Button btnDodaj;
        private Button btnStipendijePoGodinama;
        private Label label1;
        private Label label2;
    }
}