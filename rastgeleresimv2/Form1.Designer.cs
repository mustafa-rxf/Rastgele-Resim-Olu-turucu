namespace rastgeleresimv2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYeniResim;
        private System.Windows.Forms.Button btnSunumModu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer slideTimer;
        private System.Windows.Forms.Panel fadePanel;
        private System.Windows.Forms.Timer fadeTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYeniResim = new System.Windows.Forms.Button();
            this.btnSunumModu = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.slideTimer = new System.Windows.Forms.Timer(this.components);
            this.fadePanel = new System.Windows.Forms.Panel();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // btnYeniResim
            // 
            this.btnYeniResim.Location = new System.Drawing.Point(12, 420);
            this.btnYeniResim.Size = new System.Drawing.Size(295, 35);
            this.btnYeniResim.Text = "Yeni Resim";
            this.btnYeniResim.Click += new System.EventHandler(this.btnYeniResim_Click);
            // 
            // btnSunumModu
            // 
            this.btnSunumModu.Location = new System.Drawing.Point(317, 420);
            this.btnSunumModu.Size = new System.Drawing.Size(295, 35);
            this.btnSunumModu.Text = "Sunum Modu";
            this.btnSunumModu.Click += new System.EventHandler(this.btnSunumModu_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(162, 190);
            this.progressBar1.Size = new System.Drawing.Size(300, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(245, 170);
            this.lblLoading.Text = "Fotoğraf yükleniyor...";
            this.lblLoading.Visible = false;
            // 
            // fadePanel
            // 
            this.fadePanel.BackColor = System.Drawing.Color.Black;
            this.fadePanel.Visible = false;
            this.fadePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // slideTimer
            // 
            this.slideTimer.Interval = 6000;
            this.slideTimer.Tick += new System.EventHandler(this.slideTimer_Tick);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 30;
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(624, 470);
            this.Controls.Add(this.fadePanel);
            this.Controls.Add(this.btnSunumModu);
            this.Controls.Add(this.btnYeniResim);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Text = "Rastgele Resim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
