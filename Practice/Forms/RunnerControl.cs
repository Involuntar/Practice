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
        public string FirstName, LastName, Status;
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
