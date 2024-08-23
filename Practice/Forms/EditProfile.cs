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
    public partial class EditProfile : Form
    {
        public bool adminFuncs, userFuncs;
        public bool passwordChanging = true;
        public string formName;
        public string passwordChange = "Смена пароля";
        public string FirstName, LastName, Country, Status, Gender, BirthDate;
        public EditProfile()
        {
            InitializeComponent();
            timer1.Start();
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

        private void EditProfile_Load(object sender, EventArgs e)
        {
            LBL_RunnerEdit.Text = formName;
            Connection.SelectInComboBox("SELECT * FROM gender", CMBX_Sex, "Gender", "Gender");
            Connection.SelectInComboBox("SELECT * FROM country", CMBX_Country, "CountryName", "CountryCode");
            Connection.SelectInComboBox("SELECT * FROM registrationstatus", CMBX_Status, "RegistrationStatus", "RegistrationStatusId");
            Connection.SelectInComboBox("SELECT * FROM role", CMBX_Role, "RoleName", "RoleId");

            LBL_PasswordChange.Text = passwordChange;
            LBL_PasswordDecision.Visible = passwordChanging;

            LBL_Sex.Visible = !adminFuncs;
            CMBX_Sex.Visible = !adminFuncs;

            LBL_BirthDate.Visible = !adminFuncs;
            DtPck_BirthDate.Visible = !adminFuncs;

            LBL_Country.Visible = !adminFuncs;
            CMBX_Country.Visible = !adminFuncs;

            LBL_Role.Visible = adminFuncs;
            CMBX_Role.Visible = adminFuncs;

            LBL_Status.Visible = !adminFuncs;
            CMBX_Status.Visible = !adminFuncs;

            if (userFuncs)
            {
                LBL_Status.Visible = !userFuncs;
                CMBX_Status.Visible = !userFuncs;
            }

            LBL_UserEmail.Text = Runner.UserEmail;
            TBX_Name.Text = FirstName;
            TBX_Lastname.Text = LastName;
            CMBX_Country.Text = Country;
            CMBX_Status.Text = Status;
            CMBX_Sex.Text = Gender;
            DtPck_BirthDate.Text = BirthDate;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            TimeSpan AcceptableAge = new TimeSpan(3650, 0, 0, 0);
            string DateOfBirth = DtPck_BirthDate.Value.ToString().Replace('.', '-').Split(' ')[0];
            string Year = DateOfBirth.Substring(6);
            string Day = DateOfBirth.Substring(0, 2);
            string Month = DateOfBirth.Substring(3, 2);
            DateOfBirth = Year + "-" + Month + "-" + Day + " 00:00:00";
            string PasswordPattern = @"(.*[A-Z]+.*\d+.*[!@#$%^]+.*)|(.*\d+.*[A-Z]+.*[!@#$%^]+.*)|(.*\d+.*[!@#$%^]+.*[A-Z]+.*)|(.*[A-Z]+.*[!@#$%^]+.*\d+.*)|(.*[!@#$%^]+.*[A-Z]+.*\d+.*)|(.*[!@#$%^]+.*\d+.*[A-Z]+.*)";
            Regex rg_password = new Regex(PasswordPattern);

            TimeSpan Age = DateTime.Now - Convert.ToDateTime(DtPck_BirthDate.Value.ToString());
            if (TBX_Password.Text.Trim() == String.Empty)
            {
                if (TBX_Name.Text.Trim() != String.Empty)
                {
                    if (TBX_Lastname.Text.Trim() != String.Empty)
                    {
                        if (Age >= AcceptableAge)
                        {
                            Runner runner_edit = new Runner(LBL_UserEmail.Text, TBX_Password.Text.Trim(), TBX_Name.Text.Trim(),
                                TBX_Lastname.Text.Trim(), CMBX_Sex.SelectedValue.ToString(), DateOfBirth, 
                                CMBX_Country.SelectedValue.ToString(), CMBX_Status.SelectedValue.ToString(), CMBX_Role.SelectedValue.ToString());
                            Connection.UserEdit(runner_edit);
                            this.Close();
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
                if (TBX_Password.Text.Trim() == TBX_RepPassword.Text.Trim() &&
                    TBX_Password.Text.Trim().Length >= 6 && (rg_password.Matches(TBX_Password.Text.Trim())).Count != 0)
                {
                    if (TBX_Name.Text.Trim() != String.Empty)
                    {
                        if (TBX_Lastname.Text.Trim() != String.Empty)
                        {
                            if (Age >= AcceptableAge)
                            {
                                Runner runner_edit = new Runner(LBL_UserEmail.Text, TBX_Password.Text.Trim(), TBX_Name.Text.Trim(),
                                TBX_Lastname.Text.Trim(), CMBX_Sex.SelectedValue.ToString(), DateOfBirth,
                                CMBX_Country.SelectedValue.ToString(), CMBX_Status.SelectedValue.ToString(), CMBX_Role.SelectedValue.ToString());
                                Connection.UserEdit(runner_edit);
                                this.Close();
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
                    MessageBox.Show("Пароль должен быть быть минимум 6 символов, \n" +
                        "содержать 1 прописную букву, \n" +
                        "1 цифру и по крайней мере один спецсимвол, \n" +
                        "а также пароли должны совпадать!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void CLear()
        {
            TBX_Password.Text = TBX_Name.Text = TBX_Lastname.Text = String.Empty;
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
