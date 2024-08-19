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
    public partial class RunnerInfoControl : Form
    {
        public string STATUS = "1";
        public string DISTANCE = "FM";
        public string FILTREDSQL = "SELECT FirstName, LastName, user.Email, registrationstatus.RegistrationStatus FROM runner " +
                "JOIN user ON user.Email = runner.Email " +
                "JOIN registration ON runner.RunnerId = registration.RunnerId " +
                "JOIN registrationstatus ON registrationstatus.RegistrationStatusId = registration.RegistrationStatusId " +
                "JOIN registrationevent ON registrationevent.RegistrationId = registration.RegistrationId " +
                "JOIN event ON event.EventId = registrationevent.EventId " +
                "JOIN eventtype ON eventtype.EventTypeId = event.EventTypeId " +
                "WHERE (registration.RegistrationStatusId = @Status) AND (event.EventTypeId = @Distance)";
        public RunnerInfoControl()
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
            CoordMenu coordMenu = new CoordMenu();
            coordMenu.Show();
            this.Close();
        }

        private void DGV_Runners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RunnerControl runnerControl = new RunnerControl();
            runnerControl.FirstName = DGV_Runners.Rows[e.RowIndex].Cells[1].Value.ToString();
            runnerControl.LastName = DGV_Runners.Rows[e.RowIndex].Cells[2].Value.ToString();

            Runner.UserEmail = DGV_Runners.Rows[e.RowIndex].Cells[3].Value.ToString();
            runnerControl.Status = DGV_Runners.Rows[e.RowIndex].Cells[4].Value.ToString();

            this.Close();
            runnerControl.Show();
        }

        private void RunnerInfoControl_Load(object sender, EventArgs e)
        {
            Connection.Display("SELECT FirstName, LastName, user.Email, registrationstatus.RegistrationStatus FROM runner " +
                "JOIN user ON user.Email = runner.Email " +
                "JOIN registration ON runner.RunnerId = registration.RunnerId " +
                "JOIN registrationstatus ON registrationstatus.RegistrationStatusId = registration.RegistrationStatusId " +
                "JOIN registrationevent ON registrationevent.RegistrationId = registration.RegistrationId " +
                "JOIN event ON event.EventId = registrationevent.EventId " +
                "JOIN eventtype ON eventtype.EventTypeId = event.EventTypeId", DGV_Runners);

            Connection.SelectInComboBox("SELECT * FROM registrationstatus", CMBX_Status, "RegistrationStatus", "RegistrationStatusId");
            Connection.SelectInComboBox("SELECT * FROM eventtype", CMBX_Distance, "EventTypeName", "EventTypeId");
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            Connection.DisplayFiltredRunners(FILTREDSQL, DGV_Runners, DISTANCE, STATUS);
        }

        private void CMBX_Status_SelectionChangeCommitted(object sender, EventArgs e)
        {
            STATUS = CMBX_Status.SelectedValue.ToString();
        }

        private void CMBX_Distance_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DISTANCE = CMBX_Distance.SelectedValue.ToString();
        }
    }
}
