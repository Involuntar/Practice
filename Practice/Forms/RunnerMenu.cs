﻿using Practice.Data;
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
    public partial class RunnerMenu : Form
    {
        public string UserEmail;
        public RunnerMenu()
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

        private void BTN_Contacts_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.ShowDialog();
        }

        private void BTN_EditProfile_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.formName = "Редактирование профиля";
            editProfile.adminFuncs = false;
            editProfile.userFuncs = true;
            editProfile.ShowDialog();
        }

        private void BTN_Results_Click(object sender, EventArgs e)
        {
            this.Close();
            MyResultsForm resultsForm = new MyResultsForm();
            resultsForm.Show();
        }

        private void BTN_RegMar_Click(object sender, EventArgs e)
        {
            RegisterOnMarathon registerOnMarathon = new RegisterOnMarathon();
            registerOnMarathon.Show();
            this.Close();
        }

        private void BTN_Sponsor_Click(object sender, EventArgs e)
        {
            MySponsor sponsor = new MySponsor();
            sponsor.Show();
            this.Close();
        }
    }
}
