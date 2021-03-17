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
        }

        private void btnShowConsecutiveSession_Click(object sender, EventArgs e)
        {
            displaySessionsWithRooms1.Visible = false;
            displayConsecutiveSessionWithRoom1.BringToFront();
            displayConsecutiveSessionWithRoom1.Visible = true;
        }

        private void DisplayManagedRooms_Load(object sender, EventArgs e)
        {
            displaySessionsWithRooms1.Visible = true;
            displaySessionsWithRooms1.BringToFront();
            displayConsecutiveSessionWithRoom1.Visible = false;
        }
    }
}
