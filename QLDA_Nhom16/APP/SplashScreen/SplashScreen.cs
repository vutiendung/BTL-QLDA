using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2.APP.SplashScreen
{
    public partial class SplashScreen : Form
    {

        private Timer _timer;
        public SplashScreen()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 10;
            _timer.Tick += timer1_Tick;
            _timer.Enabled = true;
            _timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _progressBar.Value++;
            this.Opacity = (float)_progressBar.Value / 5;
            if (_progressBar.Value == _progressBar.Maximum)
            {
                _timer.Stop();
                _timer.Dispose();
                FrmMain main = new FrmMain();
                this.ShowInTaskbar = false;
                this.Hide();
                main.ShowDialog();
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // WS_EX_COMPOSITED
                cp.ExStyle |= 0x00080000;  // WS_EX_LAYERED
                return cp;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
