using Guna.UI2.WinForms;
using LuxentrixContentManagementSystem.Core;
using LuxentrixContentManagementSystem.UserControls.Loyalty_Rewards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.UserControls.Loyalty_Rewards
{
    public partial class LoyaltyRewards : UserControl
    {
        private DataTable loyaltyTable = new DataTable();

        private DataView loyaltyView;
        private string currentView = "";
        public LoyaltyRewards()
        {
            InitializeComponent();
            StyleRoomsGrid();
            LoadVouchers();
        }

        private void ResetGrid()
        {
            loyaltyDataGridView.DataSource = null;
            loyaltyDataGridView.Columns.Clear();
            loyaltyTable.Clear();
            loyaltyTable.Columns.Clear();
        }
        private void ResetButtons()
        {
            foreach (Control ctrl in tagsPanel.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.FillColor = Color.FromArgb(208, 189, 172);
                    btn.ForeColor = Color.Black;
                }
            }
        }


        private void LoadVouchers()
        {
            currentView = "VOUCHERS";
            ResetGrid();

            loyaltyView = new DataView(Core.LoyaltyStore.Vouchers);
            loyaltyDataGridView.DataSource = loyaltyView;
        }


        private void LoadGiftCertificates()
        {
            currentView = "GIFTS";
            ResetGrid();

            loyaltyView = new DataView(Core.LoyaltyStore.GiftCodes);
            loyaltyDataGridView.DataSource = loyaltyView;


        }

        private void LoadLoyaltyRewards()
        {
            currentView = "REWARDS";
            ResetGrid();

            loyaltyView = new DataView(Core.LoyaltyStore.Rewards);
            loyaltyDataGridView.DataSource = loyaltyView;
        }


        private void LoadLoyaltyCards()
        {
            currentView = "CARDS";
            ResetGrid();

            loyaltyTable.Columns.Add("CardNumber");
            loyaltyTable.Columns.Add("Tier");
            loyaltyTable.Columns.Add("Points");
            loyaltyTable.Columns.Add("Status");
            loyaltyTable.Columns.Add("LastTransaction");
            loyaltyTable.Columns.Add("IssuedDate");

            loyaltyTable.Rows.Add(
                "LC-0001",
                "Silver",
                "1,250",
                "Active",
                "2026-01-20",
                "2025-06-15"
            );

            loyaltyTable.Rows.Add(
                "LC-0002",
                "Gold",
                "5,600",
                "Active",
                "2026-01-25",
                "2024-11-02"
            );

            loyaltyTable.Rows.Add(
                "LC-0003",
                "Platinum",
                "12,300",
                "Suspended",
                "2026-02-01",
                "2023-08-10"
            );

            loyaltyDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CardNumber",
                HeaderText = "Card Number"
            });

            loyaltyDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Tier",
                HeaderText = "Tier"
            });

            loyaltyDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Points",
                HeaderText = "Points"
            });

            loyaltyDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status"
            });

            loyaltyDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastTransaction",
                HeaderText = "Last Transaction"
            });

            loyaltyDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IssuedDate",
                HeaderText = "Issued Date"
            });

            loyaltyView = new DataView(loyaltyTable);
            loyaltyDataGridView.DataSource = loyaltyView;
        }




        private void StyleRoomsGrid()
        {
            var grid = loyaltyDataGridView;

            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowTemplate.Height = 38;

            grid.ThemeStyle.HeaderStyle.Height = 40;
            grid.ThemeStyle.HeaderStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(133, 102, 84);
            grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;

            grid.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(208, 189, 172);

            grid.RowHeadersVisible = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;

            typeof(DataGridView)
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic)!
                .SetValue(grid, true, null);
        }
        private void vouchersBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            LoadVouchers();
            addButton.Text = "Add Voucher";
            vouchersBtn.FillColor = Color.FromArgb(133, 102, 84);
            vouchersBtn.ForeColor = Color.White;
        }

        private void giftCertificatesBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            LoadGiftCertificates();
            addButton.Text = "Add Gift Code";
            giftCertificatesBtn.FillColor = Color.FromArgb(133, 102, 84);
            giftCertificatesBtn.ForeColor = Color.White;
        }

        private void loyaltyRewardsBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            LoadLoyaltyRewards();
            addButton.Text = "Add Reward";
            loyaltyRewardsBtn.FillColor = Color.FromArgb(133, 102, 84);
            loyaltyRewardsBtn.ForeColor = Color.White;
        }

        private void loyaltyCardsBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            LoadLoyaltyCards();
            addButton.Visible = false;
            loyaltyCardsBtn.FillColor = Color.FromArgb(133, 102, 84);
            loyaltyCardsBtn.ForeColor = Color.White;

        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void loyaltyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApplyFilter()
        {
            if (loyaltyView == null)
                return;

            string search = searchTxtBox.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(search))
            {
                loyaltyView.RowFilter = string.Empty;
                return;
            }

            List<string> filters = new List<string>();

            switch (currentView)
            {
                case "VOUCHERS":
                    filters.Add($@"
                VoucherCode LIKE '%{search}%'
                OR RoomType LIKE '%{search}%'
                OR Discount LIKE '%{search}%'
            ");
                    break;

                case "GIFTS":
                    filters.Add($@"
                GiftCode LIKE '%{search}%'
                OR RoomType LIKE '%{search}%'
                OR HoursStay LIKE '%{search}%'
                OR Discount LIKE '%{search}%'
            ");
                    break;

                case "REWARDS":
                    filters.Add($@"
                PointsRequired LIKE '%{search}%'
                OR Discount LIKE '%{search}%'
                OR AppliesTo LIKE '%{search}%'
                OR UsageType LIKE '%{search}%'
                OR Conditions LIKE '%{search}%'
            ");
                    break;

                case "CARDS":
                    filters.Add($@"
                CardNumber LIKE '%{search}%'
                OR Tier LIKE '%{search}%'
                OR Points LIKE '%{search}%'
                OR Status LIKE '%{search}%'
            ");
                    break;
            }

            loyaltyView.RowFilter = string.Join(" AND ", filters);
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            switch (currentView)
            {
                case "VOUCHERS":
                    using (var form = new AddVoucherForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            Core.LoyaltyStore.Vouchers.Rows.Add(
                                form.VoucherCode,
                                "Standard",
                                form.Discount,
                                form.Stocks,
                                0
                            );

                            loyaltyView = new DataView(Core.LoyaltyStore.Vouchers);
                            loyaltyDataGridView.DataSource = loyaltyView;
                        }
                    }
                    break;


                case "GIFTS":
                    using (var form = new AddGiftCodeForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            Core.LoyaltyStore.GiftCodes.Rows.Add(
                                form.GiftCode,
                                form.RoomType,
                                form.Duration,
                                "100%",
                                form.Stocks,
                                0
                            );

                            loyaltyView = new DataView(Core.LoyaltyStore.GiftCodes);
                            loyaltyDataGridView.DataSource = loyaltyView;
                        }
                    }
                    break;

                case "REWARDS":
                    using (var form = new AddLoyaltyRewardsForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            Core.LoyaltyStore.Rewards.Rows.Add(
                                form.PointsRequired.ToString(),
                                form.Discount,
                                form.Description
                            );

                            loyaltyView = new DataView(Core.LoyaltyStore.Rewards);
                            loyaltyDataGridView.DataSource = loyaltyView;
                        }
                    }
                    break;
            }
        }

    }
}
