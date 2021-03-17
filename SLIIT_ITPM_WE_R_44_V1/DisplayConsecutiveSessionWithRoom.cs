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
    public partial class DisplayConsecutiveSessionWithRoom : UserControl
    {
        public DisplayConsecutiveSessionWithRoom()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from ManageSessionRoom", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            consecutiveSessionWithRoomGridView.DataSource = dt;
        }

        void SearchBindData()
        {
            SqlCommand command = new SqlCommand("select * from ManageSessionRoom where Subject = '" + selectSubjectColumnComboBox.Text + "' ", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            consecutiveSessionWithRoomGridView.DataSource = dt;

        }


        private void DisplayConsecutiveSessionWithRoom_Load(object sender, EventArgs e)
        {
            BindData();
            setSubjectComboBoxValues();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.ShowDialog();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBindData();
        }


        string subject_name = string.Empty;
        void setSubjectComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select Subject from ManageSessionRoom";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        subject_name = (read["Subject"].ToString());
                        selectSubjectColumnComboBox.Items.Add(subject_name);

                    }
                }
            }
            finally
            {
                con.Close();
            }
        }




    }
}
