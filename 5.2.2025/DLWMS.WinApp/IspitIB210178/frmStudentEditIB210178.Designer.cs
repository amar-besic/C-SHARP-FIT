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
            components = new System.ComponentModel.Container();
            pbSlika = new PictureBox();
            btnUcitaj = new Button();
            lblImePrezime = new Label();
            lblIndex = new Label();
            label1 = new Label();
            label2 = new Label();
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            ofdSlika = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(217, 231);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // btnUcitaj
            // 
            btnUcitaj.Location = new Point(12, 249);
            btnUcitaj.Name = "btnUcitaj";
            btnUcitaj.Size = new Size(217, 29);
            btnUcitaj.TabIndex = 1;
            btnUcitaj.Text = "Učitaj sliku";
            btnUcitaj.UseVisualStyleBackColor = true;
            btnUcitaj.Click += btnUcitaj_Click;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImePrezime.Location = new Point(247, 31);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(171, 38);
            lblImePrezime.TabIndex = 2;
            lblImePrezime.Text = "Ime Prezime";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndex.Location = new Point(247, 69);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(84, 38);
            lblIndex.TabIndex = 2;
            lblIndex.Text = "Index";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 132);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 170);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Grad:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(306, 132);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(295, 28);
            cbDrzava.TabIndex = 4;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(306, 166);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(295, 28);
            cbGrad.TabIndex = 4;
            cbGrad.SelectedIndexChanged += cbGrad_SelectedIndexChanged;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(500, 243);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "openFileDialog1";
            // 
            // frmStudentEditIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 285);
            Controls.Add(btnSacuvaj);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblIndex);
            Controls.Add(lblImePrezime);
            Controls.Add(btnUcitaj);
            Controls.Add(pbSlika);
            Name = "frmStudentEditIB210178";
            Text = "frmStudentEditIB210178";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Button btnUcitaj;
        private Label lblImePrezime;
        private Label lblIndex;
        private Label label1;
        private Label label2;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private Button btnSacuvaj;
        private ErrorProvider err;
        private OpenFileDialog ofdSlika;
    }
}