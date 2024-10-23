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
    public partial class OccupancyReport : Form
    {
        public OccupancyReport()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //go to menu page
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //show panel
            reportPanel.Visible = true;
            PictureBox[,] blocks = populatePictureBox(); // create the 2d array
            // colour all blocks grey
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    blocks[i, j].BackColor = Color.Gainsboro;
                }
            }
            // create a report object
            DateTime startDate = startDateTimePicker.Value;
            OccupancyReportClass occReport = new OccupancyReportClass(startDate);
            dateLabel.Text = DateTime.Now.ToString();
            startDateLabel.Text = startDate.ToString("d");
            reportIDLabel.Text = occReport.ReportId;
            //PictureBox[,] blocks = populatePictureBox(); // create the 2d array
            Label[] datelabels = { date1, date2, date3, date4, date5, date6, date7 }; //array of labels
            populateLabels(datelabels, startDate);
            occReport.colourInBlocks(blocks);
        }

        private PictureBox[,] populatePictureBox()
        {
            //2D array of pictureBoxes for histogram
            PictureBox[,] pictureBoxes = new PictureBox[7, 5];
            pictureBoxes[0, 0] = pb11;
            pictureBoxes[0, 1] = pb12;
            pictureBoxes[0, 2] = pb13;
            pictureBoxes[0, 3] = pb14;
            pictureBoxes[0, 4] = pb15;
            pictureBoxes[1, 0] = pb21;
            pictureBoxes[1, 1] = pb22;
            pictureBoxes[1, 2] = pb23;
            pictureBoxes[1, 3] = pb24;
            pictureBoxes[1, 4] = pb25;
            pictureBoxes[2, 0] = pb31;
            pictureBoxes[2, 1] = pb32;
            pictureBoxes[2, 2] = pb33;
            pictureBoxes[2, 3] = pb34;
            pictureBoxes[2, 4] = pb35;
            pictureBoxes[3, 0] = pb41;
            pictureBoxes[3, 1] = pb42;
            pictureBoxes[3, 2] = pb43;
            pictureBoxes[3, 3] = pb44;
            pictureBoxes[3, 4] = pb45;
            pictureBoxes[4, 0] = pb51;
            pictureBoxes[4, 1] = pb52;
            pictureBoxes[4, 2] = pb53;
            pictureBoxes[4, 3] = pb54;
            pictureBoxes[4, 4] = pb55;
            pictureBoxes[5, 0] = pb61;
            pictureBoxes[5, 1] = pb62;
            pictureBoxes[5, 2] = pb63;
            pictureBoxes[5, 3] = pb64;
            pictureBoxes[5, 4] = pb65;
            pictureBoxes[6, 0] = pb71;
            pictureBoxes[6, 1] = pb72;
            pictureBoxes[6, 2] = pb73;
            pictureBoxes[6, 3] = pb74;
            pictureBoxes[6, 4] = pb75;
            return pictureBoxes;
        }

        private void populateLabels(Label[] labels, DateTime start)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = start.AddDays(i).ToString("dd/MM"); // print labels starting from start day
            }
        }
    }
}
