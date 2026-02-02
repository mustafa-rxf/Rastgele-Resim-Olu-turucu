using System;
using System.Net;
using System.Windows.Forms;

namespace rastgeleresimv2
{
    public partial class Form1 : Form
    {
        private bool sunumModu = false;
        private int fadeAlpha = 0;
        private bool fadingIn = true;

        public Form1()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RastgeleResimYukle(false);
        }

        private void btnYeniResim_Click(object sender, EventArgs e)
        {
            RastgeleResimYukle(true);
        }

        private void RastgeleResimYukle(bool normalMod)
        {
            if (normalMod && !sunumModu)
            {
                progressBar1.Visible = true;
                lblLoading.Visible = true;
            }

            string url = "https://picsum.photos/1920/1080?random=" + Guid.NewGuid();
            pictureBox1.LoadAsync(url);

            if (sunumModu)
                fadeTimer.Start();
        }

        private void btnSunumModu_Click(object sender, EventArgs e)
        {
            sunumModu = true;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            pictureBox1.Dock = DockStyle.Fill;

            btnYeniResim.Visible = false;
            btnSunumModu.Visible = false;
            progressBar1.Visible = false;
            lblLoading.Visible = false;

            slideTimer.Start();
        }

        private void slideTimer_Tick(object sender, EventArgs e)
        {
            fadingIn = true;
            fadeAlpha = 0;
            fadePanel.Visible = true;
            fadeTimer.Start();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadingIn)
            {
                fadeAlpha += 20;
                fadePanel.BackColor = System.Drawing.Color.FromArgb(fadeAlpha, 0, 0, 0);
                if (fadeAlpha >= 200)
                {
                    fadingIn = false;
                    RastgeleResimYukle(false);
                }
            }
            else
            {
                fadeAlpha -= 20;
                fadePanel.BackColor = System.Drawing.Color.FromArgb(fadeAlpha, 0, 0, 0);
                if (fadeAlpha <= 0)
                {
                    fadeTimer.Stop();
                    fadePanel.Visible = false;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && sunumModu)
            {
                slideTimer.Stop();
                fadeTimer.Stop();
                sunumModu = false;

                FormBorderStyle = FormBorderStyle.FixedSingle;
                WindowState = FormWindowState.Normal;
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.SetBounds(12, 12, 600, 400);

                btnYeniResim.Visible = true;
                btnSunumModu.Visible = true;
            }
        }
    }
}
