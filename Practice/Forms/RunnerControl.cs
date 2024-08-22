using MySql.Data.MySqlClient;
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
    public partial class RunnerControl : Form
    {
        public string FirstName, LastName, Status, Distance;
        public RunnerControl()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void RunnerControl_Load(object sender, EventArgs e)
        {
            LBL_UserFirstName.Text = FirstName;
            LBL_UserLastName.Text = LastName;
            LBL_UserEmail.Text = Runner.UserEmail;

            MySqlConnection con = Connection.GetConnection();
            string sql_runnerInfo = "SELECT CONCAT(`Gender`, '/' ,`DateOfBirth`, '/' ,`CountryName`, '/' ,`CharityName`, '/' , " +
                "'$', COALESCE((SELECT SUM(`Amount`) FROM sponsorship " +
                "JOIN registration ON registration.RegistrationId = sponsorship.RegistrationId " +
                "JOIN runner ON runner.RunnerId = registration.RunnerId " +
                "WHERE Email = @Email), 0), '/' , " +
                "`RaceKitOption`, '/' , `EventTypeName`) FROM practice.runner " +
                "JOIN country ON country.CountryCode = runner.CountryCode " +
                "JOIN registration ON registration.RunnerId = runner.RunnerId " +
                "JOIN charity ON charity.CharityId = registration.CharityId " +
                "JOIN racekitoption ON racekitoption.RaceKitOptionId = registration.RaceKitOptionId " +
                "JOIN registrationevent ON registration.RegistrationId = registrationevent.RegistrationId " +
                "JOIN `event` ON `event`.EventId = registrationevent.EventId " +
                "JOIN eventtype ON eventtype.EventTypeId = `event`.EventTypeId " +
                "WHERE runner.Email = @Email AND eventtype.EventTypeId = @EventType;";
            MySqlCommand cmd_runnerInfo = new MySqlCommand(sql_runnerInfo, con);
            cmd_runnerInfo.CommandType = CommandType.Text;

            cmd_runnerInfo.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Runner.UserEmail;
            cmd_runnerInfo.Parameters.Add("@EventType", MySqlDbType.VarChar).Value = Distance;

            string runnerInfo = cmd_runnerInfo.ExecuteScalar().ToString();
            LBL_UserGender.Text = runnerInfo.Split('/')[0];
            LBL_UserBirthDate.Text = runnerInfo.Split('/')[1];
            LBL_UserCountry.Text = runnerInfo.Split('/')[2];
            LBL_UserFund.Text = runnerInfo.Split('/')[3];
            LBL_UserCharity.Text = runnerInfo.Split('/')[4];
            LBL_UserSet.Text = runnerInfo.Split('/')[5];
            LBL_UserDistance.Text = runnerInfo.Split('/')[6];

            con.Close();

            if (Status == "Race Attended")
            {
                PIC_Registered.Image = PIC_PaymentConfirm.Image = PIC_SetGiven.Image = PIC_OnStart.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tick-icon.png"));
            }
            else if (Status == "Race Kit Sent")
            {
                PIC_Registered.Image = PIC_PaymentConfirm.Image = PIC_SetGiven.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tick-icon.png"));
            }
            else if (Status == "Payment Confirmed")
            {
                PIC_Registered.Image = PIC_PaymentConfirm.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tick-icon.png"));
            }
            else if (Status == "Registered")
            {
                PIC_Registered.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "tick-icon.png"));
            }
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            RunnerInfoControl runnerInfoControl = new RunnerInfoControl();
            runnerInfoControl.Show();
            this.Close();
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

        private void BTN_EditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.ShowDialog();
        }
    }
}
