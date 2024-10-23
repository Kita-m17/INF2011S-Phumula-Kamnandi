using Phumla_Kamnandi_project.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_project.Presentation
{
    public partial class SummaryReport : Form
    {
        public SummaryReport()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            reportPanel.Visible = true;
            DateTime startDate = startDateTimePicker.Value;
            SummaryReportClass summaryReport = new SummaryReportClass(startDate);
            reportIDLabel.Text = summaryReport.ReportId;
            dateLabel.Text = DateTime.Now.ToString();
            startDateLabel.Text = startDate.ToString("d");

            //align headings
            summaryRichTextBox.Clear();
            summaryRichTextBox.SelectionTabs = new int[] { 130, 150, 150, 150 };
            summaryRichTextBox.AppendText("Booking ID\tDuration of stay\t\tRevenue forecast\tDeposit\n\n");

            summaryRichTextBox.AppendText(summaryReport.printSummary());
            totalBookingsTextBox.Text = summaryReport.printNumBookings().ToString();
            revForecastTextBox.Text = summaryReport.printRevenue();
            depositsForcast.Text = summaryReport.printDeposits();
            aveRevForcastTextBox.Text = summaryReport.printAverage();
        }
    }
}
