using Practice.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class MyResultsForm : Form
    {
        public MyResultsForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Marathon marathon = new Marathon();
            marathon.Show();
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
            this.Close();
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
        }
        public void Display_Results()
        {
            string[] runnerData = Connection.Display("SELECT MarathonName AS marathon, EventTypeName AS distance, RaceTime as time, row_number() OVER (ORDER BY RaceTime) as commonplace FROM event " +
                "JOIN marathon ON marathon.MarathonId = event.MarathonId " +
                "JOIN eventtype ON eventtype.EventTypeId = event.EventTypeId " +
                "JOIN registrationevent ON registrationevent.EventId = event.EventId " +
                "JOIN registration ON registration.RegistrationId = registrationevent.RegistrationId " +
                "JOIN runner ON runner.RunnerId = registration.RunnerId " +
                "WHERE Email = @Email " +
                "LIMIT 4", "SELECT CONCAT(Gender, '/', DateOfBirth) FROM runner WHERE Email = @Email;", DGV_Results);
            LBL_RunnerSex.Text = runnerData[0];
            int runnerAge = Convert.ToUInt16(runnerData[1].Split('-')[0]);
            LBL_RunnerAge.Text = Convert.ToString(DateTime.Now.Year - runnerAge);
        }

        private void MyResultsForm_Load(object sender, EventArgs e)
        {
            Display_Results();
        }
    }
}
