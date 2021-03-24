using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIIT_ITPM_WE_R_44_V1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnSampleCrud_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void addStudentGroup_Click(object sender, EventArgs e)
        {
            AddStudentGroupInfo addStudentGroupInfo = new AddStudentGroupInfo();
            addStudentGroupInfo.ShowDialog();
        }

        private void addTagInfo_Click(object sender, EventArgs e)
        {
            AddTagInfo addTagInfo = new AddTagInfo();
            addTagInfo.ShowDialog();

        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            AddSessionInfo addSessionInfo = new AddSessionInfo();
            addSessionInfo.ShowDialog();
        }

        private void btnAddWorkingDays_Click(object sender, EventArgs e)
        {
            AddWorkingDaysAndHoursInfo addWorkingDaysAndHoursInfo = new AddWorkingDaysAndHoursInfo();
            addWorkingDaysAndHoursInfo.ShowDialog();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            AddLecturerInfo addLecturerInfo = new AddLecturerInfo();
            addLecturerInfo.ShowDialog();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectInfo addSubjectInfo = new AddSubjectInfo();
            addSubjectInfo.ShowDialog();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

            if (MessageBox.Show("Important Notice For Administrator To Guide, Please Accept...!", "Important Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GuideLines guideLines = new GuideLines();
                guideLines.ShowDialog();
            }
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            AddLocationInfo addLocationInfo = new AddLocationInfo();
            addLocationInfo.ShowDialog();
        }

        private void btnStatisticsView_Click(object sender, EventArgs e)
        {
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            statisticsDisplay.ShowDialog();
        }

        private void sessionAndNotAvailableTimeAllocation_Click(object sender, EventArgs e)
        {
            SessionsAndNotAvailableTimeAllocations sessionsAndNotAvailableTimeAllocations = new SessionsAndNotAvailableTimeAllocations();
            sessionsAndNotAvailableTimeAllocations.ShowDialog();
        }

        private void btnManageSession_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.ShowDialog();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void btnManageNotAvailableTimeAllocation_Click(object sender, EventArgs e)
        {
            DisplayNotAvailableTime displayNotAvailableTime = new DisplayNotAvailableTime();
            displayNotAvailableTime.ShowDialog();
        }

        private void btnGuideLine_Click(object sender, EventArgs e)
        {
            GuideLines guideLines = new GuideLines();
            guideLines.ShowDialog();
            
        }

    }
}
