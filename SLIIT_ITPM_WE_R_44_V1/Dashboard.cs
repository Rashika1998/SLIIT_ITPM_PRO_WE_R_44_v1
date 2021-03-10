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
    }
}
