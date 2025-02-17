namespace DLWMS.WinApp.IspitIB210178
{
    partial class frmNovoUvjerenjeIB210178
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
            cbVrsta = new ComboBox();
            tbSvrha = new TextBox();
            ofdUplatnica = new OpenFileDialog();
            err = new ErrorProvider(components);
            pbUplatnica = new PictureBox();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).BeginInit();
            SuspendLayout();
            // 
            // cbVrsta
            // 
            cbVrsta.FormattingEnabled = true;
            cbVrsta.Items.AddRange(new object[] { "Uvjerenje o statusu studenta", "Uvjerenje o polzenim predmetima" });
            cbVrsta.Location = new Point(12, 12);
            cbVrsta.Name = "cbVrsta";
            cbVrsta.Size = new Size(250, 28);
            cbVrsta.TabIndex = 0;
            // 
            // tbSvrha
            // 
            tbSvrha.Location = new Point(12, 66);
            tbSvrha.Multiline = true;
            tbSvrha.Name = "tbSvrha";
            tbSvrha.Size = new Size(250, 255);
            tbSvrha.TabIndex = 1;
            // 
            // ofdUplatnica
            // 
            ofdUplatnica.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // pbUplatnica
            // 
            pbUplatnica.Location = new Point(300, 12);
            pbUplatnica.Name = "pbUplatnica";
            pbUplatnica.Size = new Size(470, 241);
            pbUplatnica.TabIndex = 2;
            pbUplatnica.TabStop = false;
            pbUplatnica.DoubleClick += pbUplatnica_DoubleClick;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(633, 264);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmNovoUvjerenjeIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbUplatnica);
            Controls.Add(tbSvrha);
            Controls.Add(cbVrsta);
            Name = "frmNovoUvjerenjeIB210178";
            Text = "frmNovoUvjerenjeIB210178";
            Load += frmNovoUvjerenjeIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUplatnica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbVrsta;
        private TextBox tbSvrha;
        private OpenFileDialog ofdUplatnica;
        private ErrorProvider err;
        private PictureBox pbUplatnica;
        private Button btnSacuvaj;
    }
}