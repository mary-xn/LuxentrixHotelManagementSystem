using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.UserControls.Log_In_Forms
{
    public partial class LoadingControl : UserControl
    {
        private System.Windows.Forms.Timer spinTimer;
        public LoadingControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Visible = false;
            this.BackColor = Color.White;
            SetupLoader();
        }

        private void SetupLoader()
        {
            this.Dock = DockStyle.Fill;
            this.Visible = false;

            spinTimer = new System.Windows.Forms.Timer();
            spinTimer.Interval = 50;
            spinTimer.Tick += (s, e) =>
            {
                loader.Value += 5;
                if (loader.Value >= 100)
                    loader.Value = 0;
            };
        }

        private void LoadingControl_Load(object sender, EventArgs e)
        {

        }

        private void loader_ValueChanged(object sender, EventArgs e)
        {

        }

        private void overlayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadingLabel_Click(object sender, EventArgs e)
        {

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            loader.Left = (this.Width - loader.Width) / 2;
            loader.Top = (this.Height - loader.Height) / 2 - 10;

            loadingLabel.Left = (this.Width - loadingLabel.Width) / 2;
            loadingLabel.Top = loader.Bottom + 10;
        }

        public void ShowLoading(string text = "Loading...")
        {
            loadingLabel.Text = text;
            this.BringToFront();
            this.Visible = true;
            spinTimer.Start();
        }

        public void HideLoading()
        {
            spinTimer.Stop();
            this.Visible = false;
        }

    }
}
