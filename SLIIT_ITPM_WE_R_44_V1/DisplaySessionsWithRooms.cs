using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIIT_ITPM_WE_R_44_V1
{
    public partial class DisplaySessionsWithRooms : UserControl
    {
        public DisplaySessionsWithRooms()
        {
            InitializeComponent();
        }


        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");



        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from ManageSessionRoom", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            sessionWithRoomGridView.DataSource = dt;
        }


        private void DisplaySessionsWithRooms_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.ShowDialog();
        }
    }
}
