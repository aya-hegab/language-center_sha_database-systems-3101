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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    Form1 f = new Form1();
        //    f.Show();
        //    this.Dispose();
        //}

        private DataTable MyTeachers()
        {
            DataTable List = new DataTable();
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Languages_Center;Persist Security Info=True;User ID=sa;Password=admin123");

            using (con)

            {
                using (SqlCommand cmd = new SqlCommand("select tID,tFName,tLName,tGender,tAge,Salary,cName from Teacher, Course_Name where cId = Course", con))
                {
                    con.Open();
                    SqlDataReader R = cmd.ExecuteReader();
                    List.Load(R);
                }

            }

            return List;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MyTeachers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e);
        }

        //private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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
