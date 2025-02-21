namespace DLWMS.WinApp.IndeksIB201718
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
            btnSacuvaj = new Button();
            lblIme = new Label();
            lblIndex = new Label();
            asgfsafa = new Label();
            label4 = new Label();
            cbDrzava = new ComboBox();
            cbGrad = new ComboBox();
            ofdSlika = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(16, 39);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(242, 264);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // btnUcitaj
            // 
            btnUcitaj.Location = new Point(16, 320);
            btnUcitaj.Name = "btnUcitaj";
            btnUcitaj.Size = new Size(242, 29);
            btnUcitaj.TabIndex = 1;
            btnUcitaj.Text = "Učitaj sliku";
            btnUcitaj.UseVisualStyleBackColor = true;
            btnUcitaj.Click += btnUcitaj_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(600, 320);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIme.Location = new Point(301, 47);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(130, 54);
            lblIme.TabIndex = 2;
            lblIme.Text = "label1";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndex.Location = new Point(301, 101);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(130, 54);
            lblIndex.TabIndex = 2;
            lblIndex.Text = "label1";
            // 
            // asgfsafa
            // 
            asgfsafa.AutoSize = true;
            asgfsafa.Location = new Point(301, 188);
            asgfsafa.Name = "asgfsafa";
            asgfsafa.Size = new Size(58, 20);
            asgfsafa.TabIndex = 3;
            asgfsafa.Text = "Država:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 223);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "Grad:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(357, 180);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(151, 28);
            cbDrzava.TabIndex = 4;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(357, 214);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(151, 28);
            cbGrad.TabIndex = 4;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmStudentEditIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(label4);
            Controls.Add(asgfsafa);
            Controls.Add(lblIndex);
            Controls.Add(lblIme);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnUcitaj);
            Controls.Add(pbSlika);
            Name = "frmStudentEditIB210178";
            Text = "Podaci o studentu";
            Load += frmStudentEditIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Button btnUcitaj;
        private Button btnSacuvaj;
        private Label lblIme;
        private Label lblIndex;
        private Label asgfsafa;
        private Label label4;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private OpenFileDialog ofdSlika;
        private ErrorProvider err;
    }
}