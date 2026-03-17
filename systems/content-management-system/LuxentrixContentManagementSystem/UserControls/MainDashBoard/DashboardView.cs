using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using LuxentrixContentManagementSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Text;

namespace LuxentrixContentManagementSystem.Forms
{
    public partial class DashboardView : UserControl
    {
        private DataTable logsTable;

        private PrintDocument reportDocument = new PrintDocument();
        private string reportText;
        public DashboardView()
        {
            InitializeComponent();
            this.Load += DashboardView_Load;

        }



        public void DashboardView_Load(object sender, EventArgs e)
        {
            StyleLogsGrid();
            LoadSampleActivityLogs();
            CenterProgressBar();


        }

        private void CenterLabelInCircle()
        {
            //revenueLabel.Left =
            //    (revenueCircleProgressBar.Width - guna2HtmlLabel1.Width) / 2;

            //revenueLabel.Top =
            //    (revenueCircleProgressBar.Height - guna2HtmlLabel1.Height) / 2;
        }

        private void CenterProgressBar()
        {
            //revenueCircleProgressBar.Left =
            //    (revenuProgressBarPanel.Width - revenueCircleProgressBar.Width) / 2;

            //revenueCircleProgressBar.Top =
            //    (revenuProgressBarPanel.Height - revenueCircleProgressBar.Height) / 2;
        }

        private void LoadSampleActivityLogs()
        {
            logsTable = new DataTable();

            logsTable.Columns.Add("Time", typeof(string));
            logsTable.Columns.Add("User");
            logsTable.Columns.Add("Action");
            logsTable.Columns.Add("Module");
            logsTable.Columns.Add("Status");

            logsTable.Rows.Add("09:12 AM", "Admin", "Logged in", "Authentication", "Success");
            logsTable.Rows.Add("09:18 AM", "Admin", "Viewed Rooms", "Rooms", "Success");
            logsTable.Rows.Add("09:25 AM", "FrontDesk01", "Checked-in Guest (Room 203)", "Rooms", "Success");
            logsTable.Rows.Add("09:40 AM", "KitchenStaff", "Updated Food Stock", "Food Menu", "Success");
            logsTable.Rows.Add("10:05 AM", "Admin", "Updated Room Status", "Rooms", "Success");
            logsTable.Rows.Add("10:22 AM", "Admin", "Viewed Activity Logs", "Dashboard", "Success");
            logsTable.Rows.Add("10:45 AM", "FrontDesk01", "Check-out Guest (Room 101)", "Rooms", "Success");
            logsTable.Rows.Add("11:03 AM", "System", "Auto Backup Completed", "System", "Success");

        }


        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel19_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recentLogsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StyleLogsGrid()
        {
            //var grid = recentLogsDataGrid;

            // grid.Dock = DockStyle.Fill;
            //  grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  grid.RowTemplate.Height = 38;

            ////  grid.ThemeStyle.HeaderStyle.Height = 40;
            //  grid.ThemeStyle.HeaderStyle.Font =
            new Font("Segoe UI", 10F, FontStyle.Bold);
            //  grid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(133, 102, 84);
            //  grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;

            // grid.ThemeStyle.RowsStyle.SelectionBackColor =
            //     Color.FromArgb(208, 189, 172);

            // grid.RowHeadersVisible = false;
            // grid.ReadOnly = true;
            // grid.AllowUserToAddRows = false;

            // typeof(DataGridView)
            //   .GetProperty("DoubleBuffered",
            //       System.Reflection.BindingFlags.Instance |
            //       System.Reflection.BindingFlags.NonPublic)!
            //  .SetValue(grid, true, null);
        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel22_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ProgressBar3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel56_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {

            BuildReport();

            reportDocument.PrintPage -= ReportDocument_PrintPage;
            reportDocument.PrintPage += ReportDocument_PrintPage;

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = reportDocument;
                printDialog.AllowSomePages = true;
                printDialog.AllowSelection = false;
                printDialog.AllowPrintToFile = true;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Optional: show preview AFTER choosing settings
                    PrintPreviewDialog preview = new PrintPreviewDialog
                    {
                        Document = reportDocument,
                        Width = 1000,
                        Height = 700
                    };

                    preview.ShowDialog();
                }
            }
        }

        private void BuildReport()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LUXENTRIX HOTEL");
            sb.AppendLine("REVENUE REPORT");
            sb.AppendLine($"Generated on: {DateTime.Now:MMMM dd, yyyy}");
            sb.AppendLine(new string('=', 50));

            sb.AppendLine("\nROOM SALES");
            sb.AppendLine("----------------------------------------------");
            sb.AppendLine("Standard Room      ₱240,000");
            sb.AppendLine("Deluxe Room        ₱310,000");
            sb.AppendLine("Premium Room       ₱290,000");
            sb.AppendLine("Executive Room     ₱210,000");

            sb.AppendLine("----------------------------------------------");
            sb.AppendLine("Room Revenue Total ₱1,050,000");

            sb.AppendLine("\nAMENITIES SALES");
            sb.AppendLine("----------------------------------------------");
            sb.AppendLine("Bottled Water      ₱16,000");
            sb.AppendLine("Snacks             ₱31,500");
            sb.AppendLine("Laundry            ₱30,000");

            sb.AppendLine("----------------------------------------------");
            sb.AppendLine("Amenities Total    ₱77,500");

            sb.AppendLine("\n==============================================");
            sb.AppendLine("GRAND TOTAL        ₱1,127,500");
            sb.AppendLine("==============================================");

            sb.AppendLine("\nPrepared by:");
            sb.AppendLine(Core.UserSession.FullName);
            sb.AppendLine(Core.UserSession.Role);

            reportText = sb.ToString();
        }

        private void ReportDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font bodyFont = new Font("Consolas", 10);
            float y = 40;

            e.Graphics.DrawString("LUXENTRIX HOTEL", headerFont, Brushes.Black, 40, y);
            y += 30;

            e.Graphics.DrawString("REVENUE REPORT", headerFont, Brushes.Black, 40, y);
            y += 40;

            foreach (string line in reportText.Split('\n'))
            {
                e.Graphics.DrawString(line, bodyFont, Brushes.Black, 40, y);
                y += 18;
            }
        }

        private void generateReportButton_Click_1(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin, Roles.Manager))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            BuildReport();

            string tempPdf = Path.Combine(
                Path.GetTempPath(),
                $"Luxentrix_Report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            );

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += ReportDocument_PrintPage;

            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            doc.PrinterSettings.PrintToFile = true;
            doc.PrinterSettings.PrintFileName = tempPdf;

            doc.Print(); // generates the PDF silently

            OpenPdfInMicrosoftPreview(tempPdf);
        }

        private void OpenPdfInMicrosoftPreview(string filePath)
        {
            if (!File.Exists(filePath)) return;

            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true // IMPORTANT
            });
        }

    }
}
