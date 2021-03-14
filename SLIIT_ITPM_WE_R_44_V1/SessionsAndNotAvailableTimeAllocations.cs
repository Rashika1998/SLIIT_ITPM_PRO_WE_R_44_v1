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
    public partial class SessionsAndNotAvailableTimeAllocations : Form
    {
        public SessionsAndNotAvailableTimeAllocations()
        {
            InitializeComponent();
        }

        private void btnAddConsecutiveSession_Click(object sender, EventArgs e)
        {

            parallelSessionUserControl1.Visible = false;
            nonOverlappingUserControl1.Visible = false;
            consecutiveSessionUserControl1.Visible = true;
            consecutiveSessionUserControl1.BringToFront();
            userControlType.Text = "Add Consecutive Sessions";

            //btn colors
            btnAddConsecutiveSession.BackColor = Color.DarkOrange;
            btnParallel.BackColor = Color.DimGray;
            btnNonOverlapping.BackColor = Color.DimGray;

        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            consecutiveSessionUserControl1.Visible = false;
            nonOverlappingUserControl1.Visible = false;
            parallelSessionUserControl1.Visible = true;
            parallelSessionUserControl1.BringToFront();
            userControlType.Text = "Add Parallel Sessions";

            //btn colors
            btnParallel.BackColor = Color.DarkOrange;
            btnAddConsecutiveSession.BackColor = Color.DimGray;
            btnNonOverlapping.BackColor = Color.DimGray;
        }

        private void SessionsAndNotAvailableTimeAllocations_Load(object sender, EventArgs e)
        {
            parallelSessionUserControl1.Visible = false;
            nonOverlappingUserControl1.Visible = false;
            consecutiveSessionUserControl1.Visible = true;
            consecutiveSessionUserControl1.BringToFront();
            userControlType.Text = "Add Consecutive Sessions";
            btnAddConsecutiveSession.BackColor = Color.DarkOrange;
        }

        private void btnNonOverlapping_Click(object sender, EventArgs e)
        {
            consecutiveSessionUserControl1.Visible = false;
            parallelSessionUserControl1.Visible = false;
            nonOverlappingUserControl1.Visible = true;
            nonOverlappingUserControl1.BringToFront();
            userControlType.Text = "Add Non Overlapping Sessions";

            //btn color
            btnNonOverlapping.BackColor = Color.DarkOrange;
            btnAddConsecutiveSession.BackColor = Color.DimGray;
            btnParallel.BackColor = Color.DimGray;
        }
    }
}
