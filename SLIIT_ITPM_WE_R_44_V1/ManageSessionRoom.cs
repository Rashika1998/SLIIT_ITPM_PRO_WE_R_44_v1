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
    public partial class ManageSessionRoom : Form
    {
        public ManageSessionRoom()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void ManageSessionRoom_Load(object sender, EventArgs e)
        {
            setSessionComboBoxValues();
            setRoomComboBoxValues();


        }




        string sessionID = string.Empty;
        void setSessionComboBoxValues()
        {

            //Steps to create this function
            //read values
            //set a while statement to set values for combo box


            string selectSql = "select SessionID from AddSession";
            SqlCommand com = new SqlCommand(selectSql, con);

            try
            {
                con.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {

                        sessionID = (read["SessionID"].ToString());
                        selectSessionComboBox.Items.Add(sessionID);


                    }
                }
            }
            finally
            {
                con.Close();
            }



        }


            string roomID = string.Empty;
            void setRoomComboBoxValues()
            {

                //Steps to create this function
                //read values
                //set a while statement to set values for combo box

                string selectSql1 = "select LocationID from AddLocation";
                SqlCommand com1 = new SqlCommand(selectSql1, con);

                try
                {
                    con.Open();

                    using (SqlDataReader read = com1.ExecuteReader())
                    {
                        while (read.Read())
                        {

                            roomID = (read["LocationID"].ToString());
                            selectRoomComboBox.Items.Add(roomID);


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
