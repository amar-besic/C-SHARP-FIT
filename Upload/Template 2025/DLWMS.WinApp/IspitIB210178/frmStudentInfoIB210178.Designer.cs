namespace DLWMS.WinApp.IspitIB210178
{
    partial class frmStudentInfoIB210178
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
            imageList1 = new ImageList(components);
            pbSlika = new PictureBox();
            lblimePrezime = new Label();
            lblGrad = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(319, 288);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblimePrezime
            // 
            lblimePrezime.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblimePrezime.Location = new Point(12, 303);
            lblimePrezime.Name = "lblimePrezime";
            lblimePrezime.Size = new Size(319, 46);
            lblimePrezime.TabIndex = 1;
            lblimePrezime.Text = "Ime Prezime";
            lblimePrezime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGrad
            // 
            lblGrad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrad.Location = new Point(12, 349);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(319, 28);
            lblGrad.TabIndex = 2;
            lblGrad.Text = "Grad";
            lblGrad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudentInfoIB210178
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 405);
            Controls.Add(lblGrad);
            Controls.Add(lblimePrezime);
            Controls.Add(pbSlika);
            Name = "frmStudentInfoIB210178";
            Text = "brojIndexa";
            Load += frmStudentInfoIB210178_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pbSlika;
        private Label lblimePrezime;
        private Label lblGrad;
    }
}