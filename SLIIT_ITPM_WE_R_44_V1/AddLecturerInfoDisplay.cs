using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SLIIT_ITPM_WE_R_44_V1
{
    public partial class AddLecturerInfoDisplay : Form
    {
        public AddLecturerInfoDisplay()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddLecturer", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            addLecturerDataGridView.DataSource = dt;
        }


        private void AddLecturerInfoDisplay_Load(object sender, EventArgs e)
        {
            addLecturerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            AddLecturerInfo addLecturerInfo = new AddLecturerInfo();
            addLecturerInfo.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
