using Practice.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class RunnerRegistration : Form
    {
        public RunnerRegistration()
        {
            InitializeComponent();
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

        private void RunnerRegistration_Load(object sender, EventArgs e)
        {
            Connection.SelectInComboBox("SELECT * FROM country", CMBX_Country, "CountryName", "CountryCode");
            Connection.SelectInComboBox("SELECT * FROM gender", CMBX_Sex, "Gender", "Gender");
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Marathon marathon = new Marathon();
            marathon.Show();
        }

        private void BTN_Register_Click(object sender, EventArgs e)
        {
            TimeSpan AcceptableAge = new TimeSpan(10);
            string DateOfBirth = DtPck_BirthDate.Value.ToString().Replace('.', '-').Split(' ')[0];
            string Year = DateOfBirth.Substring(6);
            string Day = DateOfBirth.Substring(6, 2);
            string Month = DateOfBirth.Substring(0, 2);
            DateOfBirth = Year + "-" + Month + "-" + Day + " 00:00:00";
            string PasswordPattern = @"(.*[A-Z]+.*\d+.*[!@#$%^]+.*)|(.*\d+.*[A-Z]+.*[!@#$%^]+.*)|(.*\d+.*[!@#$%^]+.*[A-Z]+.*)|(.*[A-Z]+.*[!@#$%^]+.*\d+.*)|(.*[!@#$%^]+.*[A-Z]+.*\d+.*)|(.*[!@#$%^]+.*\d+.*[A-Z]+.*)";
            Regex rg = new Regex(PasswordPattern);
            if (TBX_Email.Text.Trim() != String.Empty) {
                if (TBX_Password.Text.Trim() != String.Empty && TBX_Password.Text.Trim() == TBX_RepPassword.Text.Trim() && 
                    TBX_Password.Text.Trim().Length >= 6 && (rg.Matches(TBX_Password.Text.Trim())).Count != 0) {
                    if (TBX_Name.Text.Trim() != String.Empty) {
                        if (TBX_Lastname.Text.Trim() != String.Empty) {
                            if (DateTime.Now - Convert.ToDateTime(DtPck_BirthDate.Value.ToString()) >= AcceptableAge) {
                                Runner runner = new Runner(TBX_Email.Text.Trim(), TBX_Password.Text.Trim(), TBX_Name.Text.Trim(),
                                    TBX_Lastname.Text.Trim(), CMBX_Sex.SelectedValue.ToString(), DateOfBirth, CMBX_Country.SelectedValue.ToString());
                                Connection.RunnerRegister(runner);
                                CLear();
                            }
                            else
                            {
                                MessageBox.Show("Вы должны быть не младше 10 лет!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите фамилию!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите имя!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Пароль должен быть быть минимум 6 символов, " +
                        "\nсодержать 1 прописную букву," +
                        "\n1 цифру и по крайней мере один спецсимвол, " +
                        "\nа также пароли должны совпадать!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Адрес электронной почты не может быть пустым!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void CLear()
        {
            TBX_Email.Text = TBX_Password.Text = TBX_Name.Text = TBX_Lastname.Text = String.Empty;
        }
    }
}
