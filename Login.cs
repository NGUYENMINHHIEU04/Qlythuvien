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

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public bool isLogin = true;
        
        public Login()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {
                String strConnection = "Server=MSI;Database=BookManagement;Integrated Security = true";
                conn = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi SQL " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String email = tbEmailuser.Text;
                String password = tbPassworduser.Text;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sqlQuery = "SELECT * FROM Users WHERE email = @email AND Password = @password";
                cmd.CommandText = sqlQuery;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = password;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    AppData.fullname = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    AppData.email = reader["email"].ToString();
                    AppData.password = reader["password"].ToString();
                    AppData.UserID = Convert.ToInt32(reader["UserID"].ToString());
                    AppData.isLoginUser = true;
                    MessageBox.Show("Welcome UserID:" + reader["UserID"].ToString()+ " " +reader["first_name"].ToString() + " " + reader["last_name"].ToString());
                    Close();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Login faill!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void btnExitAdmin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnExitUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                String email = tbEmail.Text;
                String password = tbPassword.Text;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sqlQuery = "SELECT * FROM Admins WHERE email = @email AND password = @password";
                cmd.CommandText = sqlQuery;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = password;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    AppData.fullname = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    AppData.email = reader["email"].ToString();
                    AppData.password = reader["password"].ToString();
                    AppData.Admin_id = Convert.ToInt32(reader["Admin_id"].ToString());
                    AppData.isLoginAdmin = true;
                    MessageBox.Show("Welcome Admin:  " + reader["first_name"].ToString() + " " + reader["last_name"].ToString());
                    Close();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Login faill !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
