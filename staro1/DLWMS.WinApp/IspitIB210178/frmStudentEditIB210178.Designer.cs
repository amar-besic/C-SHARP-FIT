namespace DLWMS.WinApp.IspitIB210178
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
            pbSlika = new PictureBox();
            btnUcitajSliku = new Button();
            btnSacuvaj = new Button();
            lblIme = new Label();
            lblIndex = new Label();
            label2 = new Label();
            label3 = new Label();
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            ofdSlika = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(10, 14);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(234, 263);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(12, 283);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(232, 33);
            btnUcitajSliku.TabIndex = 1;
            btnUcitajSliku.Text = "Učitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(508, 281);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 33);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIme.Location = new Point(250, 26);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(130, 54);
            lblIme.TabIndex = 2;
            lblIme.Text = "label1";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndex.Location = new Point(250, 80);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(130, 54);
            lblIndex.TabIndex = 2;
            lblIndex.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 144);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Država:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 183);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Grad:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(327, 141);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(275, 28);
            cbDrzava.TabIndex = 4;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(327, 175);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(275, 28);
            cbGrad.TabIndex = 4;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "ofdSlika";
            // 
            // frmStudentEditIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 326);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIndex);
            Controls.Add(lblIme);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnUcitajSliku);
            Controls.Add(pbSlika);
            Name = "frmStudentEditIB210178";
            Text = "Podaci o studentu";
            Load += frmStudentEditIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Button btnUcitajSliku;
        private Button btnSacuvaj;
        private Label lblIme;
        private Label lblIndex;
        private Label label2;
        private Label label3;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private OpenFileDialog ofdSlika;
    }
}