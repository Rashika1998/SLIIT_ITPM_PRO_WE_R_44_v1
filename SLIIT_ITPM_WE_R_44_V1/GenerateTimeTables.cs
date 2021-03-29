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
    public partial class GenerateTimeTables : Form
    {
        public GenerateTimeTables()
        {
            InitializeComponent();
        }

        //Get session details 
        //check starting time of the session
        //check date that lecturer is working
        //use if else and a switch to addign values to lables
        private void GenerateTimeTables_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            
        }


        public void getSessionDetails()
        {
            //Get session details : Program, Lecturer 1 & 2, starting and ending time, Room
        }




    }
}
