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
    public partial class DisplayManagedRooms : Form
    {
        public DisplayManagedRooms()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void btnShowSessionWithRoom_Click(object sender, EventArgs e)
        {
            displaySessionsWithRooms1.Visible = true;
            displaySessionsWithRooms1.BringToFront();
            displayConsecutiveSessionWithRoom1.Visible = false;
            roomsWithNotAvailableTimeUserControl1.Visible = false;


            //Button colors
            btnShowSessionWithRoom.BackColor = Color.DarkOrange;
            btnShowConsecutiveSession.BackColor = Color.DimGray;
            btnNotAvailableTimeAllocation.BackColor = Color.DimGray;

            userControlType.Text = "Sessions With Allocated Rooms";

        }

        private void btnShowConsecutiveSession_Click(object sender, EventArgs e)
        {
            displaySessionsWithRooms1.Visible = false;
            displayConsecutiveSessionWithRoom1.BringToFront();
            displayConsecutiveSessionWithRoom1.Visible = true;
            roomsWithNotAvailableTimeUserControl1.Visible = false;


            //Button colors
            btnShowSessionWithRoom.BackColor = Color.DimGray;
            btnShowConsecutiveSession.BackColor = Color.DarkOrange;
            btnNotAvailableTimeAllocation.BackColor = Color.DimGray;

            userControlType.Text = "Consecutive Sessions With Allocated Rooms";
        }

        private void DisplayManagedRooms_Load(object sender, EventArgs e)
        {
            displaySessionsWithRooms1.Visible = true;
            displaySessionsWithRooms1.BringToFront();
            displayConsecutiveSessionWithRoom1.Visible = false;
            roomsWithNotAvailableTimeUserControl1.Visible = false;

            //Button colors
            btnShowSessionWithRoom.BackColor = Color.DarkOrange;
            btnShowConsecutiveSession.BackColor = Color.DimGray;
            btnNotAvailableTimeAllocation.BackColor = Color.DimGray;

            userControlType.Text = "Sessions With Allocated Rooms";
        }

        private void btnNotAvailableTimeAllocation_Click(object sender, EventArgs e)
        {

            displayConsecutiveSessionWithRoom1.Visible = true;
            displaySessionsWithRooms1.Visible = false;
            roomsWithNotAvailableTimeUserControl1.Visible = true;
            roomsWithNotAvailableTimeUserControl1.BringToFront();
            



            //Button colors
            btnShowSessionWithRoom.BackColor = Color.DimGray;
            btnShowConsecutiveSession.BackColor = Color.DimGray;
            btnNotAvailableTimeAllocation.BackColor = Color.DarkOrange;

            userControlType.Text = "Not Available Times";
        }
    }
}
