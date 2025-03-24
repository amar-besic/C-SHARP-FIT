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
            btnUcitajSliku = new Button();
            lblIme = new Label();
            lblIndex = new Label();
            pbSacuvaj = new Button();
            label1 = new Label();
            label2 = new Label();
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
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(264, 320);
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // btnUcitajSliku
            // 
            btnUcitajSliku.Location = new Point(12, 338);
            btnUcitajSliku.Name = "btnUcitajSliku";
            btnUcitajSliku.Size = new Size(262, 29);
            btnUcitajSliku.TabIndex = 1;
            btnUcitajSliku.Text = "Učitaj sliku";
            btnUcitajSliku.UseVisualStyleBackColor = true;
            btnUcitajSliku.Click += btnUcitajSliku_Click;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIme.Location = new Point(299, 36);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(130, 54);
            lblIme.TabIndex = 2;
            lblIme.Text = "label1";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndex.Location = new Point(299, 103);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(130, 54);
            lblIndex.TabIndex = 2;
            lblIndex.Text = "label1";
            // 
            // pbSacuvaj
            // 
            pbSacuvaj.Location = new Point(585, 338);
            pbSacuvaj.Name = "pbSacuvaj";
            pbSacuvaj.Size = new Size(132, 29);
            pbSacuvaj.TabIndex = 1;
            pbSacuvaj.Text = "Sačuvaj";
            pbSacuvaj.UseVisualStyleBackColor = true;
            pbSacuvaj.Click += pbSacuvaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 178);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Država:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 220);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Grad:";
            // 
            // cbDrzava
            // 
            cbDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDrzava.FormattingEnabled = true;
            cbDrzava.Location = new Point(374, 178);
            cbDrzava.Name = "cbDrzava";
            cbDrzava.Size = new Size(343, 28);
            cbDrzava.TabIndex = 4;
            cbDrzava.SelectedIndexChanged += cbDrzava_SelectedIndexChanged;
            // 
            // cbGrad
            // 
            cbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrad.FormattingEnabled = true;
            cbGrad.Location = new Point(374, 212);
            cbGrad.Name = "cbGrad";
            cbGrad.Size = new Size(343, 28);
            cbGrad.TabIndex = 4;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "ofdSlika";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmStudentEditIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 387);
            Controls.Add(cbGrad);
            Controls.Add(cbDrzava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblIndex);
            Controls.Add(lblIme);
            Controls.Add(pbSacuvaj);
            Controls.Add(btnUcitajSliku);
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
        private Button btnUcitajSliku;
        private Label lblIme;
        private Label lblIndex;
        private Button pbSacuvaj;
        private Label label1;
        private Label label2;
        private ComboBox cbDrzava;
        private ComboBox cbGrad;
        private OpenFileDialog ofdSlika;
        private ErrorProvider err;
    }
}