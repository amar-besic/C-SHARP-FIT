namespace FIT.WinForms.IspitIB210178
{
    partial class frmNovaDržavaIB210178
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
            label1 = new Label();
            label2 = new Label();
            btnSacuvaj = new Button();
            chbAktivan = new CheckBox();
            tbNazivDrzave = new TextBox();
            pbZastava = new PictureBox();
            ofdZastava = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 202);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Naziv:";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(267, 274);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(109, 29);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(16, 258);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(80, 24);
            chbAktivan.TabIndex = 2;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            // 
            // tbNazivDrzave
            // 
            tbNazivDrzave.Location = new Point(16, 225);
            tbNazivDrzave.Name = "tbNazivDrzave";
            tbNazivDrzave.Size = new Size(360, 27);
            tbNazivDrzave.TabIndex = 3;
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(16, 36);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(360, 163);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 4;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // ofdZastava
            // 
            ofdZastava.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaDržavaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 311);
            Controls.Add(pbZastava);
            Controls.Add(tbNazivDrzave);
            Controls.Add(chbAktivan);
            Controls.Add(btnSacuvaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaDržavaIB210178";
            Text = "Podaci o državi";
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSacuvaj;
        private CheckBox chbAktivan;
        private TextBox tbNazivDrzave;
        private PictureBox pbZastava;
        private OpenFileDialog ofdZastava;
        private ErrorProvider err;
    }
}