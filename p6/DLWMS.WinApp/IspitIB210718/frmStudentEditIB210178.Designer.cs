namespace DLWMS.WinApp.IspitIB210718
{
    partial class frmStudentEditIB210178
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
            pbSlika = new PictureBox();
            btnUcitajSliku = new Button();
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            lblIme = new Label();
            label2 = new Label();
            label3 = new Label();
            lblIndex = new Label();
            btnSacuvaj = new Button();
            errorProvider1 = new ErrorProvider(components);
            ofdSlika = new OpenFileDialog();
            komentar = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(20, 9);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(235, 271);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(20, 286);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(235, 29);
            btnUcitajSliku.TabIndex = 1;
            btnUcitajSliku.Text = "Učitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(353, 124);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(239, 28);
            cbDrzava.TabIndex = 2;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(353, 158);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(239, 28);
            cbGrad.TabIndex = 2;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIme.Location = new Point(261, 9);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(224, 50);
            lblIme.TabIndex = 3;
            lblIme.Text = "Ime prezime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 127);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Država:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 161);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Grad:";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndex.Location = new Point(261, 59);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(111, 50);
            lblIndex.TabIndex = 3;
            lblIndex.Text = "Index";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(612, 286);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(112, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "openFileDialog1";
            // 
            // komentar
            // 
            komentar.AutoSize = true;
            komentar.ForeColor = Color.DarkGreen;
            komentar.Location = new Point(261, 198);
            komentar.Name = "komentar";
            komentar.Size = new Size(409, 20);
            komentar.TabIndex = 4;
            komentar.Text = "//po defaultu se selektuju studentovi podaci u comboboxu :)";
            // 
            // frmStudentEditIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 333);
            Controls.Add(komentar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIndex);
            Controls.Add(lblIme);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnUcitajSliku);
            Controls.Add(pbSlika);
            Name = "frmStudentEditIB210178";
            Text = "frmStudentEditIB210178";
            Load += frmStudentEditIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Button btnUcitajSliku;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private Label lblIme;
        private Label label2;
        private Label label3;
        private Label lblIndex;
        private Button btnSacuvaj;
        private ErrorProvider errorProvider1;
        private OpenFileDialog ofdSlika;
        private Label komentar;
    }
}