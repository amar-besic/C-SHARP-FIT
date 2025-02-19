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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbDrzava = new ComboBox();
            cbUniverzitet = new ComboBox();
            tbECTS = new TextBox();
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
            dgvRazmjene.Location = new Point(12, 76);
            dgvRazmjene.Name = "dgvRazmjene";
            dgvRazmjene.ReadOnly = true;
            dgvRazmjene.RowHeadersWidth = 51;
            dgvRazmjene.Size = new Size(965, 188);
            dgvRazmjene.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 19);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Univerzitet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 19);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 1;
            label3.Text = "Broj kredita:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 19);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 1;
            label4.Text = "Početak razmjene:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(673, 19);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 1;
            label5.Text = "Kraj razmjene:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(12, 42);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(151, 28);
            cbDrzava.TabIndex = 2;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbUniverzitet
            // 
            cbUniverzitet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUniverzitet.FormattingEnabled = true;
            cbUniverzitet.Location = new Point(169, 42);
            cbUniverzitet.Name = "cbUniverzitet";
            cbUniverzitet.Size = new Size(151, 28);
            cbUniverzitet.TabIndex = 2;
            // 
            // tbECTS
            // 
            tbECTS.Location = new Point(326, 42);
            tbECTS.Name = "tbECTS";
            tbECTS.Size = new Size(71, 27);
            tbECTS.TabIndex = 3;
            // 
            // dtpOD
            // 
            dtpOD.Location = new Point(403, 42);
            dtpOD.Name = "dtpOD";
            dtpOD.Size = new Size(250, 27);
            dtpOD.TabIndex = 4;
            // 
            // dtpDO
            // 
            dtpDO.Location = new Point(659, 40);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(250, 27);
            dtpDO.TabIndex = 4;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(915, 38);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(74, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmRazmjeneIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(dtpDO);
            Controls.Add(dtpOD);
            Controls.Add(tbECTS);
            Controls.Add(cbUniverzitet);
            Controls.Add(cbDrzava);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbDrzava;
        private ComboBox cbUniverzitet;
        private TextBox tbECTS;
        private DateTimePicker dtpOD;
        private DateTimePicker dtpDO;
        private Button btnSacuvaj;
    }
}