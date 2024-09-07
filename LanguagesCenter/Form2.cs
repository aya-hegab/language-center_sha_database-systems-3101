using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LanguagesCenter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    Form1 f = new Form1();
        //    f.Show();
        //    this.Hide();
        //}

        private DataTable MyCourse()
        {
            DataTable DbCourse = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Languages_Center;Persist Security Info=True;User ID=sa;Password=admin123");

            using (con)

            {
                using (SqlCommand cmd = new SqlCommand("select cID,cName,cPrice from Course_Name", con))
                {
                    con.Open();
                    SqlDataReader R = cmd.ExecuteReader();
                    DbCourse.Load(R);
                }

            }

            return DbCourse;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyCourse();
        }

        //private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void Button2_Click(object sender, EventArgs e)
        //{
        //    Form5 f = new Form5();
        //    f.Show();
        //    this.Hide();
        //}
    }
}
