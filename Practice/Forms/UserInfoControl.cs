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
    public partial class UserInfoControl : Form
    {
        public UserInfoControl()
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

        private void UserInfoControl_Load(object sender, EventArgs e)
        {
            Connection.SelectInComboBox("SELECT * FROM role ORDER BY RoleId DESC", CMBX_RoleFilter, "RoleName", "RoleId");
            Connection.Display("SELECT FirstName, LastName, Email, RoleId FROM user WHERE RoleId = 'R'", DGV_Users);
            LBL_UsersAmount.Text = DGV_Users.RowCount.ToString();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            Connection.Display($"SELECT FirstName, LastName, Email, RoleId FROM `user` WHERE RoleId = '{CMBX_RoleFilter.SelectedValue.ToString()}'", DGV_Users);
        }

        private void TBX_Search_TextChanged(object sender, EventArgs e)
        {
            Connection.Display($"SELECT FirstName, LastName, Email, RoleId FROM `user` " +
                $"WHERE (FirstName LIKE '" + TBX_Search.Text.Trim().ToString() + "%' " +
                $"OR LastName LIKE '" + TBX_Search.Text.Trim().ToString() + "%' " +
                $"OR Email LIKE '" + TBX_Search.Text.Trim().ToString() + "%') " +
                $"AND RoleId = '{CMBX_RoleFilter.SelectedValue.ToString()}'", DGV_Users);
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Close();
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Marathon marathon = new Marathon();
            marathon.Show();
            this.Close();
        }

        private void DGV_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.adminFuncs = true;
            editProfile.userFuncs = false;
            editProfile.formName = "Редактирование пользователя";
            Runner.UserEmail = DGV_Users.Rows[e.RowIndex].Cells[3].Value.ToString();
            editProfile.ShowDialog();
        }

        private void BTN_AddNew_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.passwordChanging = false;
            editProfile.adminFuncs = true;
            editProfile.userFuncs = false;
            editProfile.passwordChange = "Новый пароль";
            editProfile.formName = "Добавление пользователя";
            editProfile.ShowDialog();
        }
    }
}
