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
    public partial class Search : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        int choosenId;
        public Search()
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
        private void displayData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Books ORDER BY ID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void displayData1()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Authors ORDER BY ID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }
        private void displayData2()
        {
            conn.Open();
            // khoi tao command tu SQL Server connection 
            SqlCommand cmd = conn.CreateCommand();
            // Khai bao loai command
            cmd.CommandType = System.Data.CommandType.Text;
            // khai bao cau query 
            String sql = "SELECT * FROM Categories ORDER BY ID DESC";
            // Gan query cho command
            cmd.CommandText = sql;
            // chay command
            cmd.ExecuteNonQuery();
            // Khoi tao datatable de hien thi du lieu
            DataTable dt = new DataTable();
            // gan data vao sql Adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // day du lieu vao data grid view
            dataGridView6.DataSource = dt;
            conn.Close();
        }
        private void displayData3()
        {
            // Mo ket noi
            conn.Open();
            // khoi tao command tu SQL Server connection 
            SqlCommand cmd = conn.CreateCommand();
            // Khai bao loai command
            cmd.CommandType = System.Data.CommandType.Text;
            // khai bao cau query 
            String sql = "SELECT * FROM Libraries ORDER BY ID DESC";
            // Gan query cho command
            cmd.CommandText = sql;
            // chay command
            cmd.ExecuteNonQuery();
            // Khoi tao datatable de hien thi du lieu
            DataTable dt = new DataTable();
            // gan data vao sql Adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // day du lieu vao data grid view
            dataGridView8.DataSource = dt;
            conn.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                String sql = "SELECT * FROM Books WHERE Name LIKE '" + textBox1.Text + "%'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            displayData();
            displayData1();
            displayData2();
            displayData3();
            displayData4();
            displayData5();
            getUser();
            getStore();
            getBookID();
            getOID();
        }
        private void createNewOrder_item()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO order_items (Order_id,Book_ID,Quantity,total_price)"
                    + " VALUES (@Order_id,@Book_ID,@quantity,@total_price )";

                cmd.CommandText = sql;

                cmd.Parameters.Add("@Order_id", SqlDbType.Int);
                cmd.Parameters["@Order_id"].Value = cbOID.Text.ToString();

                cmd.Parameters.Add("@Book_ID", SqlDbType.Int);
                cmd.Parameters["@Book_ID"].Value = cbBookID.Text.ToString();

                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters["@quantity"].Value = tbQ.Text.ToString();

                cmd.Parameters.Add("@total_price", SqlDbType.Decimal);
                cmd.Parameters["@total_price"].Value = tbP.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
            displayData5();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                String sql = "SELECT * FROM Authors WHERE Name LIKE '" + textBox2.Text + "%'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                String sql = "SELECT * FROM Categories WHERE Name LIKE '" + textBox3.Text + "%'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                String sql = "SELECT * FROM  Libraries WHERE Name LIKE '" + textBox4.Text + "%'";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView7.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
        private void displayData5()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM order_items ORDER BY ID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView9.DataSource = dt;
            conn.Close();
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv2.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["Order_id"].Value.ToString());
                cbUID.Text = row.Cells["USERID"].Value.ToString();
                tbBD.Text = row.Cells["browsed_date"].Value.ToString();
                tbRD.Text = row.Cells["return_date"].Value.ToString();
                cbLID.Text = row.Cells["LibraryID"].Value.ToString();
                tbOs.Text = row.Cells["Order_status"].Value.ToString();
                lbChoosenId.Text = "Ban da chon Order_id = " + choosenId;
            }
        }
        private void displayData4()
        {
            // Mo ket noi
            conn.Open();
            // khoi tao command tu SQL Server connection 
            SqlCommand cmd = conn.CreateCommand();
            // Khai bao loai command
            cmd.CommandType = System.Data.CommandType.Text;
            // khai bao cau query 
            String sql = "SELECT * FROM orders ORDER BY Order_id DESC";
            // Gan query cho command
            cmd.CommandText = sql;
            // chay command
            cmd.ExecuteNonQuery();
            // Khoi tao datatable de hien thi du lieu
            DataTable dt = new DataTable();
            // gan data vao sql Adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // day du lieu vao data grid view
            dgv2.DataSource = dt;
            conn.Close();
        }
        private void createNewOrder()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO orders (USERID, browsed_date , return_date , LibraryID,Order_status )"
                    + " VALUES (@USERID, @browsed_date , @return_date , @LibraryID,@Order_status)  ";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@USERID", SqlDbType.Int);
                cmd.Parameters["@USERID"].Value = cbUID.Text.ToString();

                cmd.Parameters.Add("@LibraryID", SqlDbType.Int);
                cmd.Parameters["@LibraryID"].Value = cbLID.Text.ToString();

                cmd.Parameters.Add("@browsed_date", SqlDbType.DateTime).Value = DateTime.Parse(tbBD.Text);
                cmd.Parameters.Add("@return_date", SqlDbType.DateTime).Value = DateTime.Parse(tbRD.Text);

                cmd.Parameters.Add("@Order_status", SqlDbType.Int);
                cmd.Parameters["@Order_status"].Value = tbOs.Text.ToString();
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
            displayData4();
        }
        private void getUser()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Users";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["UserID"].ToString());
                cbUID.Items.Add(productId);
            }
            conn.Close();
        }
        private void getStore()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Libraries";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbLID.Items.Add(productId);
            }
            conn.Close();
        }
        private void getOID()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Orders";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["Order_id"].ToString());
                cbOID.Items.Add(productId);
            }
            conn.Close();
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv2.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["Order_id"].Value.ToString());
                cbUID.Text = row.Cells["USERID"].Value.ToString();
                tbBD.Text = row.Cells["browsed_date"].Value.ToString();
                tbRD.Text = row.Cells["return_date"].Value.ToString();
                cbLID.Text = row.Cells["LibraryID"].Value.ToString();
                tbOs.Text = row.Cells["Order_status"].Value.ToString();
                lbChoosenId.Text = "Ban da chon Order_id = " + choosenId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewOrder();
            displayData4();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            createNewOrder_item();
            displayData5();
        }
        private void getBookID()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Books";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbBookID.Items.Add(productId);
            }
            conn.Close();
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView9.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                cbOID.Text = row.Cells["Order_id"].Value.ToString();
                cbBookID.Text = row.Cells["Book_ID"].Value.ToString();
                tbQ.Text = row.Cells["quantity"].Value.ToString();
                tbP.Text = row.Cells["total_price"].Value.ToString();
                lbIDOB.Text = "Ban da chon ID = " + choosenId;
            }
        }


    }
}
