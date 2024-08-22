using MySql.Data.MySqlClient;
using Practice.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class CertificateForm : Form
    {
        public string DISTANCE = "FM";
        public string FIRSTNAME, LASTNAME, STATUS;
        public CertificateForm()
        {
            InitializeComponent();
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            RunnerControl runnerControl = new RunnerControl();
            runnerControl.FirstName = FIRSTNAME;
            runnerControl.LastName = LASTNAME;
            runnerControl.Distance = DISTANCE;
            runnerControl.Status = STATUS;
            runnerControl.Show();
            this.Close();
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Marathon marathon = new Marathon();
            marathon.Show();
            this.Close();
        }

        private void CertificateForm_Load(object sender, EventArgs e)
        {
            RunnerInfo();
        }
        public void RunnerInfo()
        {
            MySqlConnection con = Connection.GetConnection();

            string sql = "SELECT DISTINCT CONCAT(FirstName, '/', LastName, '/', COALESCE(RaceTime, 0), '/', " +
                "'$', COALESCE((SELECT SUM(`Amount`) FROM sponsorship " +
                "JOIN registration ON registration.RegistrationId = sponsorship.RegistrationId " +
                "JOIN runner ON runner.RunnerId = registration.RunnerId " +
                "WHERE Email = @Email), 0), '/', EventTypeName, '/', eventtype.EventTypeId) " +
                "FROM `user` JOIN runner ON runner.Email = `user`.Email " +
                "JOIN registration ON registration.RunnerId = runner.RunnerId " +
                "JOIN registrationevent ON registration.RegistrationId = registrationevent.RegistrationId " +
                "JOIN sponsorship ON sponsorship.RegistrationId = registration.RegistrationId " +
                "JOIN `event` ON `event`.EventId = registrationevent.EventId " +
                "JOIN eventtype ON eventtype.EventTypeId = `event`.EventTypeId " +
                "WHERE `runner`.Email = @Email AND eventtype.EventTypeId = @EventType;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Runner.UserEmail;
            cmd.Parameters.Add("@EventType", MySqlDbType.VarChar).Value = DISTANCE;

            object runnerCertificate = cmd.ExecuteScalar();
            con.Close();
            if (runnerCertificate != null)
            {
                string runnerCertificateString = runnerCertificate.ToString();
                
                string Time = runnerCertificateString.Split('/')[2];
                if (Time != "0")
                {
                    int intTime = Convert.ToInt32(Time);
                    int h = 0;
                    int m = 0;
                    int s = 0;
                    while (intTime / 216000 != 0)
                    {
                        h += 1;
                        intTime /= 216000;
                    }
                    while (intTime / 3660 != 0)
                    {
                        m += 1;
                        intTime /= 3600;
                    }
                    while (intTime / 60 != 0)
                    {
                        s += 1;
                        intTime /= 60;
                    }
                    Time = h + ":" + m + ":" + s;

                    PIC_Logo.Visible = true;
                    PIC_Seal.Visible = true;

                    string FirstName = FIRSTNAME = runnerCertificateString.Split('/')[0];
                    string LastName = LASTNAME = runnerCertificateString.Split('/')[1];
                    string Charity = runnerCertificateString.Split('/')[3];
                    string EventType = runnerCertificateString.Split('/')[4];
                    DISTANCE = runnerCertificateString.Split('/')[5];
                    LBL_Congrats.Text = $"Поздравляем {FirstName} {LastName} с участием в {EventType}. Ваши\r\nрезультаты: время {Time} и занятое место 183!";
                    LBL_CharityAmount.Text = $"Вы также заработали {Charity}\r\nдля вашей благотворительной организации";
                    LBL_Certificate.Text = "Сертификат участника \r\nв\r\nMarathon Skills 2024\r\nНижний Тагил, Россия";
                }
                else
                {
                    LBL_Congrats.Text = LBL_CharityAmount.Text = String.Empty;
                    LBL_Certificate.Text = "Этот бегун не участвовал \r\nв беге на данной дистанции";
                    PIC_Logo.Visible = false;
                    PIC_Seal.Visible = false;
                }
            }
        }
    }
}
