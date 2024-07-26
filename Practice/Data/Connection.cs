using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            string sql = "datasource=127.0.0.1;port=3306;username=root;password=Nyp1809!pyN51;database=practice";
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
    }
}
