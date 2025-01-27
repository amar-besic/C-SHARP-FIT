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
            tbNaziv = new TextBox();
            pbZastava = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            chbAktivan = new CheckBox();
            btnSacuvaj = new Button();
            err = new ErrorProvider(components);
            ofdZastava = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(15, 255);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(378, 27);
            tbNaziv.TabIndex = 0;
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(15, 32);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(378, 186);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 232);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Naziv:";
            // 
            // chbAktivan
            // 
            chbAktivan.AutoSize = true;
            chbAktivan.Location = new Point(12, 288);
            chbAktivan.Name = "chbAktivan";
            chbAktivan.Size = new Size(80, 24);
            chbAktivan.TabIndex = 4;
            chbAktivan.Text = "Aktivan";
            chbAktivan.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(299, 312);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 5;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // ofdZastava
            // 
            ofdZastava.FileName = "openFileDialog1";
            // 
            // frmNovaDržavaIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 349);
            Controls.Add(btnSacuvaj);
            Controls.Add(chbAktivan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbZastava);
            Controls.Add(tbNaziv);
            Name = "frmNovaDržavaIB210178";
            Text = "frmNovaDržavaIB210178";
            Load += frmNovaDržavaIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNaziv;
        private PictureBox pbZastava;
        private Label label1;
        private Label label2;
        private CheckBox chbAktivan;
        private Button btnSacuvaj;
        private ErrorProvider err;
        private OpenFileDialog ofdZastava;
    }
}