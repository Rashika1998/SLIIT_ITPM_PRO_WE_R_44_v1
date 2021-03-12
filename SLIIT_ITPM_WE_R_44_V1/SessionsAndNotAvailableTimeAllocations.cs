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
            consecutiveSessionUserControl1.Visible = true;
            consecutiveSessionUserControl1.BringToFront();

        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            consecutiveSessionUserControl1.Visible = false;
            parallelSessionUserControl1.Visible = true;
            parallelSessionUserControl1.BringToFront();
        }

        private void SessionsAndNotAvailableTimeAllocations_Load(object sender, EventArgs e)
        {
            parallelSessionUserControl1.Visible = false;
            consecutiveSessionUserControl1.Visible = true;
            consecutiveSessionUserControl1.BringToFront();
        }
    }
}
