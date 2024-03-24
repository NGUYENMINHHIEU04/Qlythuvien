using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp3
{
    public partial class ManagementForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        int choosenId;


        public ManagementForm()
        {
            InitializeComponent();
            createConnection();
            getAID();
            getCID();
            getUser();
            getStore();
            getBookID();
            getOdrerID();
            getBID();
            getLID();
        }
        private void ManagementForm_Load(object sender, EventArgs e)
        {
            displayData();
            displayData1();
            displayData2();
            displayData3();
            displayData4();
            displayData5();
            displayData6();
            displayData7();
            displayData8();
        }
        private void createConnection()
        {
            try
            {

                String stringConnection = "Server=MSI;Database=BookManagement;Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                cmd = new SqlCommand();
                cmd.Connection = conn;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra trong qua trinh ket noi " + ex.Message);
            }
        }
        private void displayData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Admins ORDER BY Admin_ID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }
        private void displayData1()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Users ORDER BY UserID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv1.DataSource = dt;
            conn.Close();
        }
        private void displayData2()
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
            dgv2.DataSource = dt;
            conn.Close();
        }
        private void displayData3()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Categories ORDER BY ID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv3.DataSource = dt;
            conn.Close();
        }
        private void displayData4()
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
            dgv4.DataSource = dt;
            conn.Close();
        }
        private void displayData5()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM orders ORDER BY Order_id DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv5.DataSource = dt;
            conn.Close();
        }
        private void displayData6()
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
            dgv6.DataSource = dt;
            conn.Close();
        }
        private void displayData7()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Libraries ORDER BY ID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv7.DataSource = dt;
            conn.Close();
        }
        private void displayData8()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Quantities ORDER BY ID DESC";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv8.DataSource = dt;
            conn.Close();
        }





        private void clearFormLibr()
        {
            tbNLibr.Text = "";
            tbAdd.Text = "";
        }
        private void clearFormAu()
        {
            tbNAu.Text = "";
            tbDob.Text = "";
            tbHometown.Text = "";
        }
        private void clearFormUser()
        {
            tbC.Text = "";
            tbZC.Text = "";
            tbE.Text = "";
            tbS.Text = "";
            tbP.Text = "";
            tbFN.Text = "";
            tbLN.Text = "";
        }
        private void createNewAdmin()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO Admins (first_name, last_name, email, phone , ID_library , Password )"
                    + " VALUES (@first_name, @last_name, @email, @phone, @ID_library, @Password )";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@first_name", SqlDbType.VarChar);
                cmd.Parameters["@first_name"].Value = tbFirstname.Text.ToString();

                cmd.Parameters.Add("@last_name", SqlDbType.VarChar);
                cmd.Parameters["@last_name"].Value = tbLastname.Text.ToString();

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbEmail.Text.ToString();

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = tbPhone.Text.ToString();

                cmd.Parameters.Add("@ID_library", SqlDbType.VarChar);
                cmd.Parameters["@ID_library"].Value = tbLID.Text.ToString();

                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                cmd.Parameters["@Password"].Value = tbPass.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }
        private void createNewBooks()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO Books (Name,CategoryID, AuthorID, LishPrice)"
                    + " VALUES (@name, @CategoryID, @AuthorID, @LishPrice)";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@Name"].Value = tbName.Text.ToString();


                cmd.Parameters.Add("@CategoryID", SqlDbType.VarChar);
                cmd.Parameters["@CategoryID"].Value = cbCID.Text.ToString();

                cmd.Parameters.Add("@AuthorID", SqlDbType.VarChar);
                cmd.Parameters["@AuthorID"].Value = cbAID.Text.ToString();

                cmd.Parameters.Add("@LishPrice", SqlDbType.VarChar);
                cmd.Parameters["@LishPrice"].Value = tbLP.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }
        private void createNewUser()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO Users (first_name, last_name, email, phone, city, state, zip_code)"
                    + " VALUES (@first_name, @last_name, @email, @phone, @city, @state , @zip_code)";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@first_name", SqlDbType.VarChar);
                cmd.Parameters["@first_name"].Value = tbFN.Text.ToString();

                cmd.Parameters.Add("@last_name", SqlDbType.VarChar);
                cmd.Parameters["@last_name"].Value = tbLN.Text.ToString();

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbE.Text.ToString();

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = tbP.Text.ToString();

                cmd.Parameters.Add("@city", SqlDbType.VarChar);
                cmd.Parameters["@city"].Value = tbC.Text.ToString();

                cmd.Parameters.Add("@state", SqlDbType.VarChar);
                cmd.Parameters["@state"].Value = tbS.Text.ToString();

                cmd.Parameters.Add("@zip_code", SqlDbType.VarChar);
                cmd.Parameters["@zip_code"].Value = tbZC.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }
        private void createNewCategory()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO Categories (Name)"
                    + " VALUES (@Name)";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@Name"].Value = tbN.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }
        private void clearFormCate()
        {
            tbN.Text = "";
        }
        private void createNewAuthor()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO Authors (Name,DoB,Hometown)"
                    + " VALUES (@Name,@DoB,@Hometown)";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@Name"].Value = tbNAu.Text.ToString();

                cmd.Parameters.Add("@DoB", SqlDbType.DateTime).Value = DateTime.Parse(tbDob.Text);

                cmd.Parameters.Add("@Hometown", SqlDbType.VarChar);
                cmd.Parameters["@Hometown"].Value = tbHometown.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }
        private void createNewOrder()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO orders (USERID, browsed_date , return_date , LibraryID,Order_status )"
                    + " VALUES (@USERID, @browsed_date , @return_date , @LibraryID,@Order_status)";

                cmd.CommandText = sql;

                cmd.Parameters.Add("@USERID", SqlDbType.VarChar);
                cmd.Parameters["@USERID"].Value = cbUID.Text.ToString();

                cmd.Parameters.Add("@LibraryID", SqlDbType.VarChar);
                cmd.Parameters["@LibraryID"].Value = cbLID.Text.ToString();

                cmd.Parameters.Add("@browsed_date", SqlDbType.DateTime).Value = DateTime.Parse(tbBD.Text);

                cmd.Parameters.Add("@return_date", SqlDbType.DateTime).Value = DateTime.Parse(tbRD.Text);

                cmd.Parameters.Add("@Order_status", SqlDbType.VarChar);
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
        }
        private void createNewLibrary()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO Libraries (Name,Address)"
                    + " VALUES (@Name,@Address)";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@Name"].Value = tbNLibr.Text.ToString();

                cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                cmd.Parameters["@Address"].Value = tbAdd.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }
        private void createNewOrder_item()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO order_items (Order_id,Book_ID,Quantity,total_price)"
                    + " VALUES (@Order_id,@Book_ID,@quantity,@total_price )";

                cmd.CommandText = sql;

                cmd.Parameters.Add("@Order_id", SqlDbType.VarChar);
                cmd.Parameters["@Order_id"].Value = cbOID.Text.ToString();

                cmd.Parameters.Add("@Book_ID", SqlDbType.VarChar);
                cmd.Parameters["@Book_ID"].Value = cbBookID.Text.ToString();

                cmd.Parameters.Add("@quantity", SqlDbType.VarChar);
                cmd.Parameters["@quantity"].Value = tbQ.Text.ToString();

                cmd.Parameters.Add("@total_price", SqlDbType.VarChar);
                cmd.Parameters["@total_price"].Value = tbTP.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }
        private void createNewQuantity()
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "INSERT INTO Quantities (BookID,LibraryID,Quantity)"
                    + " VALUES (@BookID,@LibraryID,@Quantity )";

                cmd.CommandText = sql;

                cmd.Parameters.Add("@BookID", SqlDbType.Int);
                cmd.Parameters["@BookID"].Value = cbBID1.Text.ToString();

                cmd.Parameters.Add("@LibraryID", SqlDbType.Int);
                cmd.Parameters["@LibraryID"].Value = cbLID1.Text.ToString();

                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters["@Quantity"].Value = tbQ1.Text.ToString();

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed  " + ex.Message);
            }
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            createNewAdmin();
            displayData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE Admins " +
                    "SET first_name = @first_name, last_name = @last_name, email = @email, phone = @phone, ID_library = @ID_library , Password = @Password WHERE Admin_ID = @choosenId";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@first_name", SqlDbType.VarChar);
                cmd.Parameters["@first_name"].Value = tbFirstname.Text.ToString();

                cmd.Parameters.Add("@last_name", SqlDbType.VarChar);
                cmd.Parameters["@last_name"].Value = tbLastname.Text.ToString();

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbEmail.Text.ToString();

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = tbPhone.Text.ToString();

                cmd.Parameters.Add("@ID_library", SqlDbType.VarChar);
                cmd.Parameters["@ID_library"].Value = tbLID.Text.ToString();

                cmd.Parameters.Add("@Password", SqlDbType.VarChar);
                cmd.Parameters["@Password"].Value = tbPass.Text.ToString();


                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Thanh Cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra " + ex.Message);
            }
            displayData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM Admins WHERE Admin_ID = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["Admin_ID"].Value.ToString());
                tbFirstname.Text = row.Cells["first_name"].Value.ToString();
                tbLastname.Text = row.Cells["last_name"].Value.ToString();
                tbPhone.Text = row.Cells["phone"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
                tbLID.Text = row.Cells["ID_library"].Value.ToString();
                tbPass.Text = row.Cells["Password"].Value.ToString();
                lbChoosenId.Text = "You choose AdminId = " + choosenId;
            }
        }





        private void btnAdduser_Click(object sender, EventArgs e)
        {
            createNewUser();
            displayData1();
        }
        private void btnDeleteuser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM Users WHERE UserID = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData1();
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE Users " +
                    "SET first_name = @first_name, last_name = @last_name, email = @email, phone = @phone, city = @city, state = @state, zip_code = @zip_code WHERE UserID = @choosenId";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@first_name", SqlDbType.VarChar);
                cmd.Parameters["@first_name"].Value = tbFN.Text.ToString();

                cmd.Parameters.Add("@last_name", SqlDbType.VarChar);
                cmd.Parameters["@last_name"].Value = tbLN.Text.ToString();

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = tbE.Text.ToString();

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = tbP.Text.ToString();

                cmd.Parameters.Add("@city", SqlDbType.VarChar);
                cmd.Parameters["@city"].Value = tbC.Text.ToString();

                cmd.Parameters.Add("@state", SqlDbType.VarChar);
                cmd.Parameters["@state"].Value = tbS.Text.ToString();

                cmd.Parameters.Add("@zip_code", SqlDbType.VarChar);
                cmd.Parameters["@zip_code"].Value = tbZC.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Thanh Cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra " + ex.Message);
            }
            displayData1();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            clearFormUser();
            displayData1();
        }





        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv1.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["UserID"].Value.ToString());
                tbFN.Text = row.Cells["first_name"].Value.ToString();
                tbLN.Text = row.Cells["last_name"].Value.ToString();
                tbP.Text = row.Cells["phone"].Value.ToString();
                tbE.Text = row.Cells["email"].Value.ToString();
                tbC.Text = row.Cells["city"].Value.ToString();
                tbS.Text = row.Cells["state"].Value.ToString();
                tbZC.Text = row.Cells["zip_code"].Value.ToString();
                lbChoosenID1.Text = "Ban da chon UserId = " + choosenId;
            }
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            createNewBooks();
            displayData2();
        }
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE Books " +
                    "SET Name = @name, CategoryID= @CategoryID, AuthorID= @AuthorID, LishPrice=@LishPrice WHERE ID = @choosenId";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = tbName.Text.ToString();

                cmd.Parameters.Add("@CategoryID", SqlDbType.VarChar);
                cmd.Parameters["@CategoryID"].Value = cbCID.Text.ToString();

                cmd.Parameters.Add("@AuthorID", SqlDbType.VarChar);
                cmd.Parameters["@AuthorID"].Value = cbAID.Text.ToString();

                cmd.Parameters.Add("@LishPrice", SqlDbType.VarChar);
                cmd.Parameters["@LishPrice"].Value = tbLP.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Thanh Cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi xay ra " + ex.Message);
            }
            displayData2();
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM Books WHERE ID = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData2();
        }






        private void getAID()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Authors";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbAID.Items.Add(productId);
            }
            conn.Close();
        }
        private void getCID()
        {
            conn.Open();
            //TODO: get toan bo thong tin nguoi dung
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Categories";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            // gan du lieu vao combo box
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbCID.Items.Add(productId);
            }
            conn.Close();
        }
        private void getUser()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Users";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
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
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Libraries";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbLID.Items.Add(productId);
            }
            conn.Close();
        }
        private void getBookID()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Books";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbBookID.Items.Add(productId);
            }
            conn.Close();
        }
        private void getOdrerID()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM orders";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["Order_id"].ToString());
                cbOID.Items.Add(productId);
            }
            conn.Close();
        }
        private void getLID()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Libraries";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbLID1.Items.Add(productId);
            }
            conn.Close();
        }
        private void getBID()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sqlQuery = "SELECT * FROM Books";
            cmd.CommandText = sqlQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int productId = Int32.Parse(reader["ID"].ToString());
                cbBID1.Items.Add(productId);
            }
            conn.Close();
        }





        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv2.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                tbName.Text = row.Cells["Name"].Value.ToString();
                cbCID.Text = row.Cells["CategoryID"].Value.ToString();
                cbAID.Text = row.Cells["AuthorID"].Value.ToString();
                tbLP.Text = row.Cells["LishPrice"].Value.ToString();
                lbIDbook.Text = "Ban da chon BookID = " + choosenId;
            }
        }
        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv3.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                tbN.Text = row.Cells["Name"].Value.ToString();
                lbIDcate.Text = "Ban da chon CategoryID = " + choosenId;
            }
        }
        private void btnDC_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    SqlCommand cmd = conn.CreateCommand();
                    String sql = "DELETE FROM Categories WHERE ID = @choosenId";
                    cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                    cmd.Parameters["@choosenId"].Value = choosenId;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed " + ex.Message);
                }
            }
            displayData3();
        }
        private void btnEditC_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE Categories " +
                    "SET Name = @name WHERE ID = @choosenId";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = tbN.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred!" + ex.Message);
            }
            displayData3();
        }
        private void btnCleanC_Click(object sender, EventArgs e)
        {
            clearFormCate();
            displayData3();
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            createNewCategory();
            displayData3();
        }





        private void dgv4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv4.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                tbNAu.Text = row.Cells["Name"].Value.ToString();
                tbDob.Text = row.Cells["DoB"].Value.ToString();
                tbHometown.Text = row.Cells["Hometown"].Value.ToString();
                lbIDAu.Text = "You choose AuthorId = " + choosenId;
            }
        }
        private void btnCleanAu_Click(object sender, EventArgs e)
        {
            clearFormAu();
            displayData4();
        }
        private void btnAddAu_Click(object sender, EventArgs e)
        {
            createNewAuthor();  
            displayData4();
        }
        private void btnEditAu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE Authors " +
                    "SET Name=@Name,DoB=@DoB,Hometown=@Hometown WHERE ID = @choosenId";

                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@Name"].Value = tbNAu.Text.ToString();

                cmd.Parameters.Add("@DoB", SqlDbType.DateTime).Value = tbDob.Text;

                cmd.Parameters.Add("@Hometown", SqlDbType.VarChar);
                cmd.Parameters["@Hometown"].Value = tbHometown.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred! " + ex.Message);
            }
            displayData4();
        }
        private void btnDeleteAu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM Authors WHERE ID = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                // chay query
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData4();
        }





        private void dgv5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv5.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["Order_id"].Value.ToString());
                cbUID.Text = row.Cells["USERID"].Value.ToString();
                tbBD.Text = row.Cells["browsed_date"].Value.ToString();
                tbRD.Text = row.Cells["return_date"].Value.ToString();
                cbLID.Text = row.Cells["LibraryID"].Value.ToString();
                tbOs.Text = row.Cells["Order_status"].Value.ToString();
                lbIDorder.Text = "You choose Order_id = " + choosenId;
            }
        }
        private void btnEditOr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE orders " +
                    "SET USERID= @USERID , browsed_date=@browsed_date , return_date= @return_date , LibraryID=@LibraryID , Order_status = @Order_status WHERE Order_id = @choosenId";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@USERID", SqlDbType.VarChar);
                cmd.Parameters["@USERID"].Value = cbUID.Text.ToString();


                cmd.Parameters.Add("@browsed_date", SqlDbType.DateTime).Value = DateTime.Parse(tbBD.Text);

                cmd.Parameters.Add("@return_date", SqlDbType.DateTime).Value = DateTime.Parse(tbRD.Text);

                cmd.Parameters.Add("@LibraryID", SqlDbType.VarChar);
                cmd.Parameters["@LibraryID"].Value = cbLID.Text.ToString();

                cmd.Parameters.Add("@Order_status", SqlDbType.VarChar);
                cmd.Parameters["@Order_status"].Value = tbOs.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred" + ex.Message);
            }
            displayData5();
        }
        private void btnDeleteOr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM orders WHERE  Order_id = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData5();
        }
        private void btnAddOr_Click(object sender, EventArgs e)
        {
            createNewOrder();
            displayData5();
        }





        private void dgv7_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv7.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                tbNLibr.Text = row.Cells["Name"].Value.ToString();
                tbAdd.Text = row.Cells["Address"].Value.ToString();
                lbIDL.Text = "You choose LibraryID = " + choosenId;
            }
        }
        private void btnAddLibr_Click(object sender, EventArgs e)
        {
            createNewLibrary();
            displayData7();
        }
        private void btnEditLibr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE Libraries " +
                    "SET Name = @name, Address = @Address WHERE ID = @choosenId";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = tbNLibr.Text.ToString();

                cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                cmd.Parameters["@Address"].Value = tbAdd.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }
            displayData7();
        }
        private void btnDeleteLibr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM Libraries WHERE ID = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData7();
        }
        private void btnCleanLibr_Click(object sender, EventArgs e)
        {
            clearFormLibr();
            displayData7();   
        }






        private void dgv6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv6.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                cbOID.Text = row.Cells["Order_id"].Value.ToString();
                cbBookID.Text = row.Cells["Book_ID"].Value.ToString();
                tbQ.Text = row.Cells["quantity"].Value.ToString();
                tbTP.Text = row.Cells["total_price"].Value.ToString();
                lbIDOrI.Text = "You choose ID = " + choosenId;
            }
        }
        private void btnAddOI_Click(object sender, EventArgs e)
        {
            createNewOrder_item();
            displayData6();
        }
        private void btnEditOI_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE order_items " +
                    "SET Order_id = @order_id , Book_ID = @Book_ID , Quantity = @Quantity , total_price = @total_price  WHERE ID = @choosenId";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@Order_id", SqlDbType.Int);
                cmd.Parameters["@Order_id"].Value = cbOID.Text.ToString();

                cmd.Parameters.Add("@Book_ID", SqlDbType.Int);
                cmd.Parameters["@Book_ID"].Value = cbBookID.Text.ToString();

                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters["@Quantity"].Value = tbQ.Text.ToString();

                cmd.Parameters.Add("@total_price", SqlDbType.Decimal);
                cmd.Parameters["@total_price"].Value = tbTP.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }
            displayData6();
        }
        private void btnDeleteOI_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM order_items WHERE ID = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData6();
        }




        private void dgv8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv8.Rows[e.RowIndex];
                choosenId = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                cbBID1.Text = row.Cells["BookID"].Value.ToString();
                cbLID1.Text = row.Cells["LibraryID"].Value.ToString();
                tbQ1.Text = row.Cells["Quantity"].Value.ToString();
                lbIDQ.Text = "You choose ID = " + choosenId;
            }
        }
        private void btnAddQ_Click(object sender, EventArgs e)
        {
            createNewQuantity();
            displayData8();
        }
        private void btnEditQ_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "UPDATE Quantities " +
                    "SET BookID=@BookID, LibraryID=@LibraryID, Quantity=@Quantity WHERE ID = @choosenId";
                cmd.CommandText = sql;

                cmd.Parameters.Add("@BookID", SqlDbType.Int);
                cmd.Parameters["@BookID"].Value = cbBID1.Text.ToString();

                cmd.Parameters.Add("@LibraryID", SqlDbType.Int);
                cmd.Parameters["@LibraryID"].Value = cbLID1.Text.ToString();

                cmd.Parameters.Add("@Quantity", SqlDbType.Int);
                cmd.Parameters["@Quantity"].Value = tbQ1.Text.ToString();

                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }
            displayData8();
        }
        private void btnDeleteQ_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                String sql = "DELETE FROM Quantities WHERE ID = @choosenId";
                cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@choosenId", SqlDbType.Int);
                cmd.Parameters["@choosenId"].Value = choosenId;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed " + ex.Message);
            }
            displayData6();
        }
    }
}
