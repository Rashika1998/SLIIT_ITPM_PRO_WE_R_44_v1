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
    public partial class AddTagInfoDisplay : Form
    {
        public AddTagInfoDisplay()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ITPM_Y3S2_WE_R_44;User ID=sa;Password=rashika1998");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database_we_r_44_v1.mdf;Integrated Security=True");


        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from AddTag", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            addTagGridView.DataSource = dt;
        }

        void SearchBindData()
        {
            SqlCommand command = new SqlCommand("select * from AddTag where " + selectColumnComboBox.Text + " like '" + textSearchBox.Text + "%'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            addTagGridView.DataSource = dt;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBindData();
        }

        private void AddTagInfoDisplay_Load(object sender, EventArgs e)
        {
            addTagGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BindData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddTagInfo addTagInfo = new AddTagInfo();
            addTagInfo.ShowDialog();
        }
    }
}
