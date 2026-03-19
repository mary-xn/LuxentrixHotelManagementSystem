namespace LuxentrixContentManagementSystem.Forms
{
    partial class RoomForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            gridPanel = new Guna.UI2.WinForms.Guna2Panel();
            roomsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            headerTableLayoutPanel = new TableLayoutPanel();
            searchButton = new Guna.UI2.WinForms.Guna2Button();
            roomTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            searchRoomTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            addRoomBtn = new Guna.UI2.WinForms.Guna2Button();
            statusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            mainPanel.SuspendLayout();
            gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).BeginInit();
            headerPanel.SuspendLayout();
            headerTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(gridPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.CustomizableEdges = customizableEdges15;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            mainPanel.Size = new Size(1407, 761);
            mainPanel.TabIndex = 8;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // gridPanel
            // 
            gridPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gridPanel.BackColor = Color.White;
            gridPanel.BorderColor = Color.FromArgb(208, 189, 172);
            gridPanel.BorderRadius = 15;
            gridPanel.BorderThickness = 2;
            gridPanel.Controls.Add(roomsDataGridView);
            gridPanel.CustomizableEdges = customizableEdges1;
            gridPanel.Dock = DockStyle.Fill;
            gridPanel.Location = new Point(20, 102);
            gridPanel.Name = "gridPanel";
            gridPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gridPanel.Size = new Size(1367, 639);
            gridPanel.TabIndex = 7;
            // 
            // roomsDataGridView
            // 
            roomsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(208, 189, 172);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            roomsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(133, 102, 84);
            dataGridViewCellStyle2.Font = new Font("Aksioma DEMO", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(133, 102, 84);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            roomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            roomsDataGridView.ColumnHeadersHeight = 4;
            roomsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Aksioma DEMO", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(208, 189, 172);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            roomsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            roomsDataGridView.Dock = DockStyle.Fill;
            roomsDataGridView.GridColor = Color.FromArgb(133, 102, 84);
            roomsDataGridView.Location = new Point(0, 0);
            roomsDataGridView.Margin = new Padding(0, 20, 0, 0);
            roomsDataGridView.Name = "roomsDataGridView";
            roomsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Aksioma DEMO", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            roomsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            roomsDataGridView.RowHeadersVisible = false;
            roomsDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            roomsDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Aksioma DEMO", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            roomsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(208, 189, 172);
            roomsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            roomsDataGridView.Size = new Size(1367, 639);
            roomsDataGridView.TabIndex = 6;
            roomsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(133, 102, 84);
            roomsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Aksioma DEMO", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            roomsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            roomsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            roomsDataGridView.ThemeStyle.BackColor = Color.White;
            roomsDataGridView.ThemeStyle.GridColor = Color.FromArgb(133, 102, 84);
            roomsDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(133, 102, 84);
            roomsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            roomsDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Aksioma DEMO", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomsDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            roomsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            roomsDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            roomsDataGridView.ThemeStyle.ReadOnly = false;
            roomsDataGridView.ThemeStyle.RowsStyle.BackColor = Color.WhiteSmoke;
            roomsDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            roomsDataGridView.ThemeStyle.RowsStyle.Font = new Font("Aksioma DEMO", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomsDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            roomsDataGridView.ThemeStyle.RowsStyle.Height = 25;
            roomsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(208, 189, 172);
            roomsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            roomsDataGridView.CellContentClick += roomsDataGridView_CellContentClick_1;
            // 
            // headerPanel
            // 
            headerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            headerPanel.Controls.Add(headerTableLayoutPanel);
            headerPanel.CustomizableEdges = customizableEdges13;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(20, 20);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges14;
            headerPanel.Size = new Size(1367, 82);
            headerPanel.TabIndex = 6;
            // 
            // headerTableLayoutPanel
            // 
            headerTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerTableLayoutPanel.ColumnCount = 5;
            headerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4121475F));
            headerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.58785F));
            headerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 330F));
            headerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            headerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 229F));
            headerTableLayoutPanel.Controls.Add(searchButton, 0, 0);
            headerTableLayoutPanel.Controls.Add(roomTypeComboBox, 3, 0);
            headerTableLayoutPanel.Controls.Add(searchRoomTxtBox, 1, 0);
            headerTableLayoutPanel.Controls.Add(addRoomBtn, 4, 0);
            headerTableLayoutPanel.Controls.Add(statusComboBox, 2, 0);
            headerTableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            headerTableLayoutPanel.Location = new Point(0, 0);
            headerTableLayoutPanel.Name = "headerTableLayoutPanel";
            headerTableLayoutPanel.Padding = new Padding(3);
            headerTableLayoutPanel.RowCount = 1;
            headerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            headerTableLayoutPanel.Size = new Size(1367, 82);
            headerTableLayoutPanel.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Left;
            searchButton.BorderRadius = 5;
            searchButton.CustomizableEdges = customizableEdges3;
            searchButton.DisabledState.BorderColor = Color.DarkGray;
            searchButton.DisabledState.CustomBorderColor = Color.DarkGray;
            searchButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            searchButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            searchButton.FillColor = Color.FromArgb(208, 189, 172);
            searchButton.Font = new Font("Aksioma DEMO", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.Black;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.ImageAlign = HorizontalAlignment.Left;
            searchButton.Location = new Point(6, 24);
            searchButton.Name = "searchButton";
            searchButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            searchButton.Size = new Size(42, 34);
            searchButton.TabIndex = 1;
            searchButton.Click += searchButton_Click_1;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            roomTypeComboBox.BackColor = Color.Transparent;
            roomTypeComboBox.BorderRadius = 5;
            roomTypeComboBox.CustomizableEdges = customizableEdges5;
            roomTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            roomTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roomTypeComboBox.FillColor = Color.FromArgb(208, 189, 172);
            roomTypeComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            roomTypeComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            roomTypeComboBox.Font = new Font("Segoe UI", 10F);
            roomTypeComboBox.ForeColor = Color.Black;
            roomTypeComboBox.ItemHeight = 30;
            roomTypeComboBox.Location = new Point(797, 23);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            roomTypeComboBox.Size = new Size(334, 36);
            roomTypeComboBox.TabIndex = 4;
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // searchRoomTxtBox
            // 
            searchRoomTxtBox.Anchor = AnchorStyles.Left;
            searchRoomTxtBox.BorderRadius = 5;
            searchRoomTxtBox.CustomizableEdges = customizableEdges7;
            searchRoomTxtBox.DefaultText = "";
            searchRoomTxtBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchRoomTxtBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchRoomTxtBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchRoomTxtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchRoomTxtBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchRoomTxtBox.Font = new Font("Aksioma DEMO", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchRoomTxtBox.ForeColor = Color.Black;
            searchRoomTxtBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchRoomTxtBox.Location = new Point(53, 24);
            searchRoomTxtBox.Margin = new Padding(2, 3, 2, 3);
            searchRoomTxtBox.Name = "searchRoomTxtBox";
            searchRoomTxtBox.PlaceholderText = "Search Room";
            searchRoomTxtBox.SelectedText = "";
            searchRoomTxtBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            searchRoomTxtBox.Size = new Size(409, 34);
            searchRoomTxtBox.TabIndex = 2;
            searchRoomTxtBox.TextChanged += searchRoomTxtBox_TextChanged;
            // 
            // addRoomBtn
            // 
            addRoomBtn.Anchor = AnchorStyles.None;
            addRoomBtn.BackColor = Color.Transparent;
            addRoomBtn.BorderRadius = 5;
            addRoomBtn.CustomizableEdges = customizableEdges9;
            addRoomBtn.DisabledState.BorderColor = Color.DarkGray;
            addRoomBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            addRoomBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addRoomBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addRoomBtn.FillColor = Color.FromArgb(208, 189, 172);
            addRoomBtn.Font = new Font("Aksioma DEMO", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRoomBtn.ForeColor = Color.Black;
            addRoomBtn.Image = (Image)resources.GetObject("addRoomBtn.Image");
            addRoomBtn.ImageAlign = HorizontalAlignment.Left;
            addRoomBtn.Location = new Point(1177, 24);
            addRoomBtn.Name = "addRoomBtn";
            addRoomBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            addRoomBtn.Size = new Size(144, 34);
            addRoomBtn.TabIndex = 0;
            addRoomBtn.Text = "Add Room";
            addRoomBtn.Click += addRoomBtn_Click_1;
            // 
            // statusComboBox
            // 
            statusComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            statusComboBox.BackColor = Color.Transparent;
            statusComboBox.BorderRadius = 5;
            statusComboBox.CustomizableEdges = customizableEdges11;
            statusComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FillColor = Color.FromArgb(208, 189, 172);
            statusComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            statusComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            statusComboBox.Font = new Font("Segoe UI", 10F);
            statusComboBox.ForeColor = Color.Black;
            statusComboBox.ItemHeight = 30;
            statusComboBox.Location = new Point(467, 23);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.ShadowDecoration.CustomizableEdges = customizableEdges12;
            statusComboBox.Size = new Size(324, 36);
            statusComboBox.TabIndex = 3;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged_1;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1407, 761);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomForm";
            Text = "RoomForm";
            mainPanel.ResumeLayout(false);
            gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).EndInit();
            headerPanel.ResumeLayout(false);
            headerTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private TableLayoutPanel headerTableLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2ComboBox roomTypeComboBox;
        private Guna.UI2.WinForms.Guna2TextBox searchRoomTxtBox;
        private Guna.UI2.WinForms.Guna2Button addRoomBtn;
        private Guna.UI2.WinForms.Guna2ComboBox statusComboBox;
        private Guna.UI2.WinForms.Guna2Panel gridPanel;
        private Guna.UI2.WinForms.Guna2DataGridView roomsDataGridView;
    }
}