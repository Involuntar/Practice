using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Practice.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class SponsorsView : Form
    {
        public SponsorsView()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void SponsorsView_Load(object sender, EventArgs e)
        {
            uint fundsAmount = 0;
            uint charityAmount = 0;
            MySqlConnection con = Connection.GetConnection();
            string sqlFunds = "SELECT DISTINCT CharityLogo, CharityName, SUM(Amount) AS Summ FROM charity " +
                "JOIN registration ON registration.CharityId = charity.CharityId " +
                "JOIN sponsorship ON sponsorship.RegistrationId = registration.RegistrationId " +
                "GROUP BY CharityLogo, CharityName;";
            MySqlCommand cmdFunds = new MySqlCommand(sqlFunds, con);
            cmdFunds.CommandType = CommandType.Text;

            MySqlDataReader reader = cmdFunds.ExecuteReader();
            while (reader.Read())
            {
                int rowNumber = DGV_Sponsors.Rows.Add();
                DGV_Sponsors.Rows[rowNumber].Cells[0].Value = Image.FromFile
                    (Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), 
                    $"marathon-skills-2016-charity-data/{reader.GetValue(0)}"));
                DGV_Sponsors.Rows[rowNumber].Cells[1].Value = reader.GetValue(1).ToString();
                DGV_Sponsors.Rows[rowNumber].Cells[2].Value = "$" + Convert.ToUInt32(reader.GetValue(2)).ToString("#,#", new CultureInfo("de-DE"));
                charityAmount += Convert.ToUInt32(reader.GetValue(2));
                fundsAmount++;
            }
            con.Close();

            LBL_FundsAmount.Text = fundsAmount.ToString();
            LBL_CharityAmount.Text = "$" + charityAmount.ToString("#,#", new CultureInfo("de-DE"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string StringTimeToStart = "До начала марафона ";
            DateTime DateNow = DateTime.Now;
            DateTime DateStart = new DateTime(2024, 09, 14, 12, 00, 00);
            TimeToStart[] ObjectTime = new TimeToStart[4];
            ObjectTime[0] = new TimeToStart("день", "дней", "дня");
            ObjectTime[1] = new TimeToStart("час", "часов", "часа");
            ObjectTime[2] = new TimeToStart("минута", "минут", "минуты");
            ObjectTime[3] = new TimeToStart("секунда", "секунд", "секунды");
            ObjectTime[0].value = (DateStart - DateNow).Days;
            ObjectTime[1].value = (DateStart - DateNow).Hours;
            ObjectTime[2].value = (DateStart - DateNow).Minutes;
            ObjectTime[3].value = (DateStart - DateNow).Seconds;
            for (int i = 0; i < ObjectTime.Length; i++)
            {
                if (ObjectTime[i].value > 0)
                    StringTimeToStart = StringTimeToStart + ObjectTime[i].value + ObjectTime[i].ChangeValue();
            }
            LBL_TimeToStart.Text = StringTimeToStart + "!";
            LBL_TimeToStart.Show();
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Marathon marathon = new Marathon();
            marathon.Show();
            this.Close();
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            CoordMenu coordMenu = new CoordMenu();
            coordMenu.Show();
            this.Close();
        }
    }
}
