using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Practice.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class MySponsor : Form
    {
        public MySponsor()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Marathon marathon = new Marathon();
            marathon.Show();
            this.Close();
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

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
            this.Close();
        }

        private void MySponsor_Load(object sender, EventArgs e)
        {
            Connection.Display($"SELECT COALESCE(SponsorName, 'Нет спонсора') AS CharityName, " +
                $"COALESCE(Amount, 'Нет пожертвований') AS Charity FROM sponsorship " +
                $"JOIN registration ON registration.RegistrationId = sponsorship.RegistrationId " +
                $"JOIN runner ON runner.RunnerId = registration.RunnerId " +
                $"WHERE Email = '{Runner.UserEmail}';", DGV_Sponsors);

            MySqlConnection con = Connection.GetConnection();
            string sponsors_sql = $"SELECT CONCAT(CharityName, '/', CharityDescription, '/', CharityLogo, '/', SUM(Amount)) AS SponsorInfo " +
                $"FROM practice.charity " +
                $"JOIN registration ON registration.CharityId = charity.CharityId " +
                $"JOIN runner ON runner.RunnerId = registration.RunnerId " +
                $"JOIN sponsorship ON sponsorship.RegistrationId = registration.RegistrationId " +
                $"WHERE Email = '{Runner.UserEmail}' " +
                $"GROUP BY CharityName, CharityDescription, CharityLogo;";
            MySqlCommand cmd = new MySqlCommand(sponsors_sql, con);
            cmd.CommandType = CommandType.Text;

            string sponsorInfo = cmd.ExecuteScalar().ToString();

            LBL_FundName.Text = sponsorInfo.Split('/')[0];
            LBL_FundDesc.Text = sponsorInfo.Split('/')[1];
            PIC_FundLogo.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"marathon-skills-2016-charity-data/{sponsorInfo.Split('/')[2]}")); ;
            LBL_AmountFee.Text = "$" + sponsorInfo.Split('/')[3];
            con.Close();
        }
    }
}
