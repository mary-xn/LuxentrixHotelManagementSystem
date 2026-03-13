namespace LuxentrixContentManagementSystem.UserControls.Log_In_Forms
{
    partial class LoadingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            overlayPanel = new Guna.UI2.WinForms.Guna2Panel();
            loadingLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            loader = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            overlayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // overlayPanel
            // 
            overlayPanel.Controls.Add(loadingLabel);
            overlayPanel.Controls.Add(loader);
            overlayPanel.CustomizableEdges = customizableEdges2;
            overlayPanel.Dock = DockStyle.Fill;
            overlayPanel.FillColor = Color.FromArgb(133, 102, 84);
            overlayPanel.Location = new Point(0, 0);
            overlayPanel.Name = "overlayPanel";
            overlayPanel.ShadowDecoration.CustomizableEdges = customizableEdges3;
            overlayPanel.Size = new Size(462, 542);
            overlayPanel.TabIndex = 0;
            overlayPanel.Paint += overlayPanel_Paint;
            // 
            // loadingLabel
            // 
            loadingLabel.BackColor = Color.Transparent;
            loadingLabel.Font = new Font("Alegre Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadingLabel.ForeColor = Color.White;
            loadingLabel.Location = new Point(146, 358);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(144, 28);
            loadingLabel.TabIndex = 1;
            loadingLabel.Text = "LOADING DASHBOARD...";
            loadingLabel.Click += loadingLabel_Click;
            // 
            // loader
            // 
            loader.AnimationSpeed = 0.8F;
            loader.FillColor = Color.Transparent;
            loader.Font = new Font("Segoe UI", 12F);
            loader.ForeColor = Color.White;
            loader.Location = new Point(121, 147);
            loader.Minimum = 0;
            loader.Name = "loader";
            loader.ProgressColor = Color.FromArgb(133, 102, 84);
            loader.ProgressColor2 = Color.FromArgb(208, 189, 172);
            loader.ShadowDecoration.CustomizableEdges = customizableEdges1;
            loader.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            loader.Size = new Size(184, 184);
            loader.TabIndex = 0;
            loader.Text = "guna2CircleProgressBar1";
            loader.ValueChanged += loader_ValueChanged;
            // 
            // LoadingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(overlayPanel);
            Name = "LoadingControl";
            Size = new Size(462, 542);
            Load += LoadingControl_Load;
            overlayPanel.ResumeLayout(false);
            overlayPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel overlayPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel loadingLabel;
        private Guna.UI2.WinForms.Guna2CircleProgressBar loader;
    }
}
