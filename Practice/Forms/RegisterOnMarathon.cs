using MySql.Data.MySqlClient;
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
    public partial class RegisterOnMarathon : Form
    {
        public RegisterOnMarathon()
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

        private void RegisterOnMarathon_Load(object sender, EventArgs e)
        {
            Connection.SelectInComboBox("SELECT * FROM charity", CMBX_Fund, "CharityName", "CharityId");
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            RunnerMenu runnerMenu = new RunnerMenu();
            runnerMenu.Show();
        }

        private void BTN_Logout_Click(object sender, EventArgs e)
        {
            Marathon marathon = new Marathon();
            marathon.Show();
            this.Close();
        }

        private void PIC_FundInfo_Click(object sender, EventArgs e)
        {
            FundInfoForm infoform = new FundInfoForm();

            MySqlConnection con = Connection.GetConnection();
            string sql = "SELECT CONCAT(CharityName, '/', CharityDescription, '/',CharityLogo) FROM practice.charity WHERE CharityId = @CharityId";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@CharityId", MySqlDbType.VarChar).Value = CMBX_Fund.SelectedValue.ToString();
            infoform.Fund = cmd.ExecuteScalar().ToString().Split('/');

            infoform.ShowDialog();
            con.Close();
        }

        private void BTN_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                string strFeeAmount = MTBX_FeeSumm.Text.Replace("$", "").Trim();
                UInt16 feeAmount = Convert.ToUInt16(strFeeAmount);
                if ((ChBX_21km.Checked || ChBX_42km.Checked || ChBX_5km.Checked) &&
                    feeAmount >= Convert.ToUInt16(LBL_FeeAmount.Text.Trim().Split('$')[1]))
                {
                    this.Close();
                    RunnerConfirm runnerConfirm = new RunnerConfirm();
                    runnerConfirm.Show();
                }
                else
                {
                    MessageBox.Show("Информация", "Должен быть выбран хотя бы один вид марфона и\n" +
                        "сумма взноса превышать регистрационный взнос!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Информация", "Сумма взноса обязательна к заполнению!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void ChBX_42km_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBX_42km.Checked == true)
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) + 145);
            else
            {
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) - 145);
            }
        }

        private void ChBX_21km_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBX_21km.Checked == true)
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) + 75);
            else
            {
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) - 75);
            }
        }

        private void ChBX_5km_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBX_5km.Checked == true)
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) + 20);
            else
            {
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) - 20);
            }
        }

        private void RBtn_VariantB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_VariantB.Checked == true)
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) + 20);
            else
            {
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) - 20);
            }
        }

        private void RBtn_VariantC_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_VariantC.Checked == true)
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) + 45);
            else
            {
                LBL_FeeAmount.Text = "$" + (Convert.ToUInt16(LBL_FeeAmount.Text.Split('$')[1]) - 45);
            }
        }
    }
}
