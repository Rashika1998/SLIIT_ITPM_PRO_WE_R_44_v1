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
    public partial class AddStudentGroupInfoDisplay : Form
    {
        public AddStudentGroupInfoDisplay()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");


        private void AddStudentGroupInfoDisplay_Load(object sender, EventArgs e)
        {
            BindData();
            studentGroupDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //Bind data to a gridview
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddStudentGroup", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            studentGroupDataGridView.DataSource = dt;

        }


        //Bind data to a gridview by searching
        void SearchBindData()
        {
            SqlCommand command = new SqlCommand("select * from AddStudentGroup where " + selectColumnComboBox.Text + " like '" + textSearchBox.Text + "%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            studentGroupDataGridView.DataSource = dt;

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBindData();
        }


        private void btnAddNewSession_Click(object sender, EventArgs e)
        {
            AddStudentGroupInfo addStudentGroupInfo = new AddStudentGroupInfo();
            addStudentGroupInfo.ShowDialog();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
