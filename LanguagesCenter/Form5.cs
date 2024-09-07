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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text== "" || comboBox2.Text == "" || comboBox3.Text == "")
                {
                    MessageBox.Show("Enter All Required Data");

                }
                else
                {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Languages_Center;Persist Security Info=True;User ID=sa;Password=admin123");
                con.Open();

                string q = "insert into Student(sFName,sLName,Gender,Age,CoursePrice,Paid,Teacher) " +
                    "values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "')";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";

            }
               
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            
        }
    }
}
