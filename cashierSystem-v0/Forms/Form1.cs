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
using static System.Configuration.ConfigurationManager;
using Microsoft.VisualBasic;

namespace cashierSystem_v0
{
    public partial class loginForm : Form
    { 
        //Constructor
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM users;", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    username.Items.Add(reader["username"]);
                }
                reader.Close();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message, "message");
            }
            finally 
            { 
                con.Close();
            }
            
            con.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectionString);
            con.Open();

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = '" + username.Text + "';", con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (password.Text == Convert.ToString(reader["passwordDigest"]))
                    {
                        //setting public static variables username & Role
                        Program.PuserID = Convert.ToInt32(reader["id"] is null ? 0 : reader["id"]);
                        Program.Prole = (reader["role"] is null ? "" : reader["role"]).ToString();

                        //opening the main form
                        this.Hide();
                        username.Text = password.Text = "";
                        mainForm mainForm = new();
                        mainForm.Show();
                    }
                    else
                        MessageBox.Show("خطأ فى تسجيل الدخول .. من فضلك تأكد من البيانات المدخلة", "message");
                }
                reader.Close();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message, "message");
            }
            finally
            {
                con.Close();
            }

            
        }
    }
}
