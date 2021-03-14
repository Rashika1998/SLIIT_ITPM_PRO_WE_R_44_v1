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
    public partial class NonOverlappingUserControl : UserControl
    {
        public NonOverlappingUserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        void BindData()
        {
            con.Open();
            SqlCommand command = new SqlCommand("select * from AddSession", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            nonOverlappingSessionDataGridView.DataSource = dt;

            DataGridViewCheckBoxColumn dataCheckBox = new DataGridViewCheckBoxColumn();
            dataCheckBox.HeaderText = "Select";
            dataCheckBox.Width = 30;
            dataCheckBox.Name = "Checkbox";
            nonOverlappingSessionDataGridView.Columns.Insert(0, dataCheckBox);

            con.Close();

        }


        void insertData()
        {

            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO AddNonOverlappingSession VALUES ('" + int.Parse(textNonOverlappingSessionID.Text) + "' , '" + ids + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();

        }



        string ids = string.Empty;
        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;

            foreach (DataGridViewRow row in nonOverlappingSessionDataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Checkbox"].Value);

                if (isSelected)
                {

                    if (i == 0)
                    {

                        ids += Convert.ToString(row.Cells["SessionID"].Value);
                        i++;

                    }
                    else
                    {
                        ids += "," + Convert.ToString(row.Cells["SessionID"].Value);

                    }

                }

            }


            if (ids != "")
            {
                if (MessageBox.Show("Selected Session(s) : " + ids, "Add Selected Session(s)...?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    insertData();
                }
            }
            else
            {
                MessageBox.Show("Select Session IDs.");
            }

            //Most important thing I have found
            ids = "";
        }

        private void NonOverlappingUserControl_Load(object sender, EventArgs e)
        {
            nonOverlappingSessionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }
    }
}
