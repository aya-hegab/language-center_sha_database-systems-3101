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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    Form1 f = new Form1();
        //    f.Show();
        //    this.Dispose();
        //}

        private DataTable MyStudents()
        {
            DataTable List = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Languages_Center;Persist Security Info=True;User ID=sa;Password=admin123");

            using (con)

            {
                using (SqlCommand cmd = new SqlCommand("select sFName,sLName,Gender,Age,CoursePrice,Paid,tFName,tLName,Course from Student, Teacher where tID = Teacher", con))
                {
                    con.Open();
                    SqlDataReader R = cmd.ExecuteReader();
                    List.Load(R);
                }

            }

            return List;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyStudents();
        }

        //private void Form4_FormClosing(object sender, FormClosingEventArgs e)
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
