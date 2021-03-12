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
    public partial class ParallelSessionUserControl : UserControl
    {

        public string sampleValueForID = "null";
        public ParallelSessionUserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void ParallelSessionUserControl_Load(object sender, EventArgs e)
        {
            parallelSessionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        void BindData()
        {
            con.Open();
            SqlCommand command = new SqlCommand("select * from ProductInfo_Tab", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            parallelSessionDataGridView.DataSource = dt;

            DataGridViewCheckBoxColumn dataCheckBox = new DataGridViewCheckBoxColumn();
            dataCheckBox.HeaderText = "Select";
            dataCheckBox.Width = 30;
            dataCheckBox.Name = "Checkbox";
            parallelSessionDataGridView.Columns.Insert(0, dataCheckBox);

            con.Close();

        }


        void insertData()
        {
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO AddConsecutiveSession VALUES ('" + sampleValueForID + "' , '" + ids + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted.");
            con.Close();
            this.Refresh();
        }



        string ids = string.Empty;
        private void btnSave_Click(object sender, EventArgs e)
        {
            //string ids = string.Empty;
            int i = 0;

            foreach (DataGridViewRow row in parallelSessionDataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Checkbox"].Value);

                if (isSelected)
                {

                    //ids += Environment.NewLine;
                    if(i == 0)
                    {
                        ids += Convert.ToString(row.Cells["ProductID"].Value);
                        i++;
                    }
                    else
                    {
                        ids += "," + Convert.ToString(row.Cells["ProductID"].Value);
                    }

                    
                }
            }
            MessageBox.Show(ids);

            if(ids != "")
            {
                insertData();
            }
            else
            {
                MessageBox.Show("Select Session IDs.");
            }


        }
    }
}
