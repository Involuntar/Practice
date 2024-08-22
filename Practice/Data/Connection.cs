using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Practice.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    internal class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=127.0.0.1;port=3306;username=root;Password=Nyp1809!pyN51;database=practice";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }
        public static string[] Display_Runner(string displayQuery, string runnerData, DataGridView dgv)
        {
            string sqlResult = displayQuery;
            string sqlData = runnerData;
            MySqlConnection con = GetConnection();

            MySqlCommand cmdResult = new MySqlCommand(sqlResult, con);
            MySqlCommand cmdData = new MySqlCommand(sqlData, con);

            cmdResult.CommandType = CommandType.Text;
            cmdResult.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Runner.UserEmail;

            cmdData.CommandType = CommandType.Text;
            cmdData.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Runner.UserEmail;

            string[] data = cmdData.ExecuteScalar().ToString().Split('/');

            MySqlDataAdapter adp = new MySqlDataAdapter(cmdResult);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
            return data;
        }
        public static void DisplayFunds(string displayQuery, DataGridView dgv)
        {
            string sql = displayQuery;
            MySqlConnection con = GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        public static void Display(string displayQuery, DataGridView dgv)
        {
            string sql = displayQuery;
            MySqlConnection con = GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        public static void DisplayFiltredRunners(string displayQuery, DataGridView dgv, string distance, string status)
        {
            string sql = displayQuery;
            MySqlConnection con = GetConnection();

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Distance", MySqlDbType.VarChar).Value = distance;
            cmd.Parameters.Add("@Status", MySqlDbType.VarChar).Value = status;

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
        public static void SelectInComboBox(string query, ComboBox cb, string DM, string VM)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adp.Fill(ds);
            cb.DataSource = ds;
            cb.DisplayMember = DM;
            cb.ValueMember = VM;

            con.Close();
        }
        public static string LoginCheck(string Login, string Password)
        {
            string sql_user_check = "SELECT RoleId FROM user WHERE Email LIKE @Login AND Password LIKE @Password";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql_user_check, con);

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password;

            if (cmd.ExecuteScalar() != null) {
                string result = cmd.ExecuteScalar().ToString();
                con.Close();
                return result;
            }
            else {
                con.Close();
                return null;
            }
        }
        public static void RunnerRegister(Runner runner)
        {
            MySqlConnection conn = GetConnection();
            string sql_runner = "INSERT INTO runner (Email, Gender, DateOfBirth, CountryCode) VALUES (@Email, @Gender, @DateOfBirth, @CountryCode)";
            string sql_user = "INSERT INTO user (Email, Password, FirstName, LastName, RoleId) VALUES (@Email, @Password, @FirstName, @LastName, 'R')";

            MySqlCommand cmd_user = new MySqlCommand(sql_user, conn);
            MySqlCommand cmd_runner = new MySqlCommand(sql_runner, conn);

            cmd_user.CommandType = CommandType.Text;
            cmd_runner.CommandType = CommandType.Text;

            cmd_user.Parameters.Add("@Email", MySqlDbType.VarChar).Value = runner.Email;
            cmd_user.Parameters.Add("@Password", MySqlDbType.VarChar).Value = runner.Password;
            cmd_user.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = runner.FirstName;
            cmd_user.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = runner.Lastname;

            cmd_runner.Parameters.Add("@Email", MySqlDbType.VarChar).Value = runner.Email;
            cmd_runner.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = runner.Sex;
            cmd_runner.Parameters.Add("@DateOfBirth", MySqlDbType.VarChar).Value = runner.DateOfBirth;
            cmd_runner.Parameters.Add("CountryCode", MySqlDbType.VarChar).Value = runner.CountryCode;

            try
            {
                cmd_user.ExecuteNonQuery();
                cmd_runner.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void UserEdit(Runner runner)
        {
            MySqlConnection conn = GetConnection();
            string sql_runner = "UPDATE runner SET Gender = @Gender, DateOfBirth = @DateOfBirth, CountryCode = @CountryCode";
            if (runner.Password != String.Empty)
            {
                string sql_user = "UPDATE user Password = @Password, FirstName = @FirstName, LastName = @LastName";
                MySqlCommand cmd_user = new MySqlCommand(sql_user, conn);
                cmd_user.CommandType = CommandType.Text;

                cmd_user.Parameters.Add("@Password", MySqlDbType.VarChar).Value = runner.Password;
                cmd_user.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = runner.FirstName;
                cmd_user.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = runner.Lastname;

                try
                {
                    cmd_user.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string sql_user = "UPDATE user FirstName = @FirstName, LastName = @LastName";
                MySqlCommand cmd_user = new MySqlCommand(sql_user, conn);
                cmd_user.CommandType = CommandType.Text;

                cmd_user.Parameters.Add("@Password", MySqlDbType.VarChar).Value = runner.Password;
                cmd_user.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = runner.FirstName;
                cmd_user.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = runner.Lastname;

                try
                {
                    cmd_user.ExecuteNonQuery();
                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MySqlCommand cmd_runner = new MySqlCommand(sql_runner, conn);

            cmd_runner.CommandType = CommandType.Text;

            cmd_runner.Parameters.Add("@Gender", MySqlDbType.VarChar).Value = runner.Sex;
            cmd_runner.Parameters.Add("@DateOfBirth", MySqlDbType.VarChar).Value = runner.DateOfBirth;
            cmd_runner.Parameters.Add("CountryCode", MySqlDbType.VarChar).Value = runner.CountryCode;

            try
            {
                cmd_runner.ExecuteNonQuery();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Ошибка: {ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
