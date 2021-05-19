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
    public partial class AddSubjectInfoDisplay : Form
    {
        public AddSubjectInfoDisplay()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectInfo addSubjectInfo = new AddSubjectInfo();
            addSubjectInfo.ShowDialog();
        }

        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddSubject", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            addSubjectDataGridView.DataSource = dt;
        }

        void SearchBindData()
        {
            SqlCommand command = new SqlCommand("select * from AddSubject where " + selectColumnComboBox.Text + " like '" + textSearchBox.Text + "%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            addSubjectDataGridView.DataSource = dt;

        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBindData();

        }
    }
}
