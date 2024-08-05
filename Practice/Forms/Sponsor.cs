using MySql.Data.MySqlClient;
using Practice.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class Sponsor : Form
    {
        public Sponsor()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            Marathon marathon = new Marathon();
            this.Close();
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

        private void Sponsor_Load(object sender, EventArgs e)
        {
            Connection.SeelectInComboBox("SELECT CONCAT(FirstName, ' ', LastName, ' - ', RunnerId, ' ', '(', CountryName, ')') as Runner, RunnerId FROM user " +
                "JOIN runner ON user.Email = runner.Email " +
                "JOIN country ON country.CountryCode = runner.CountryCode", CMBX_Runner, "Runner", "RunnerId");
            //DateTime DateToday = DateTime.Now;
            //DateTime DateEnd = DateToday.AddYears(15);
            //while (DateEnd > DateToday)
            //{
            //    CMBX_Year.Items.Add(Convert.ToString(DateEnd.Year));
            //    DateEnd.AddYears(-1);
            //}
            //CMBX_Month.Items.Add(Convert.ToString(DateToday.Month));
        }

        private void BTN_Donate_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DonateIncrease_Click(object sender, EventArgs e)
        {
            UInt32 IncreasedSumm = Convert.ToUInt32(LBL_CharityAmount.Text.Substring(1)) + 10;
            if (IncreasedSumm > 10)
                LBL_CharityAmount.Text = "$" + Convert.ToString(IncreasedSumm);
            LBL_CharityAmount.ForeColor = Color.FromArgb(100, 36, 29, 112);
        }

        private void BTN_DonateDecrease_Click(object sender, EventArgs e)
        {
            UInt32 DecreasedSumm = Convert.ToUInt32(LBL_CharityAmount.Text.Substring(1)) - 10;
            if (DecreasedSumm > 0)
                LBL_CharityAmount.Text = "$" + Convert.ToString(DecreasedSumm);
            else
            {
                LBL_CharityAmount.Text = "$10";
            }
            if (DecreasedSumm == 10)
                LBL_CharityAmount.ForeColor = Color.Red;
        }

        private void TBX_Charity_TextChanged(object sender, EventArgs e)
        {
            if (TBX_Charity.Text == String.Empty){
                LBL_CharityAmount.Text = "$10";
            }
            else if (Convert.ToUInt16(TBX_Charity.Text) > 10){
                LBL_CharityAmount.Text = "$" + TBX_Charity.Text;
                LBL_CharityAmount.ForeColor = Color.FromArgb(100, 36, 29, 112);
            }
            else
            {
                LBL_CharityAmount.Text = "$10";
                LBL_CharityAmount.ForeColor = Color.Red;
            }
        }
    }
}
