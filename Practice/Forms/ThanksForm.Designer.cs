namespace Practice.Forms
{
    partial class ThanksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_HeaderThanks = new System.Windows.Forms.Label();
            this.LBL_ThanksPar = new System.Windows.Forms.Label();
            this.LBL_Runner = new System.Windows.Forms.Label();
            this.LBL_RunnerFund = new System.Windows.Forms.Label();
            this.LBL_CharityAmount = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_MarathonName
            // 
            this.LBL_MarathonName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBL_MarathonName.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.LBL_MarathonName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_MarathonName.Location = new System.Drawing.Point(0, 0);
            this.LBL_MarathonName.Name = "LBL_MarathonName";
            this.LBL_MarathonName.Size = new System.Drawing.Size(559, 79);
            this.LBL_MarathonName.TabIndex = 23;
            this.LBL_MarathonName.Text = "Marathon Skills 2024";
            this.LBL_MarathonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LBL_MarathonName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 79);
            this.panel1.TabIndex = 1;
            // 
            // LBL_TimeToStart
            // 
            this.LBL_TimeToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.LBL_TimeToStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TimeToStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeToStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_TimeToStart.Location = new System.Drawing.Point(0, 0);
            this.LBL_TimeToStart.Name = "LBL_TimeToStart";
            this.LBL_TimeToStart.Size = new System.Drawing.Size(912, 46);
            this.LBL_TimeToStart.TabIndex = 23;
            this.LBL_TimeToStart.Text = "Время до";
            this.LBL_TimeToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TimeToStart.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LBL_TimeToStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 46);
            this.panel2.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBL_HeaderThanks
            // 
            this.LBL_HeaderThanks.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_HeaderThanks.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_HeaderThanks.Location = new System.Drawing.Point(0, 79);
            this.LBL_HeaderThanks.Name = "LBL_HeaderThanks";
            this.LBL_HeaderThanks.Size = new System.Drawing.Size(912, 93);
            this.LBL_HeaderThanks.TabIndex = 26;
            this.LBL_HeaderThanks.Text = "Спасибо за Вашу спонсорскую поддержку!";
            this.LBL_HeaderThanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_ThanksPar
            // 
            this.LBL_ThanksPar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_ThanksPar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_ThanksPar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_ThanksPar.Location = new System.Drawing.Point(0, 172);
            this.LBL_ThanksPar.Name = "LBL_ThanksPar";
            this.LBL_ThanksPar.Size = new System.Drawing.Size(912, 69);
            this.LBL_ThanksPar.TabIndex = 27;
            this.LBL_ThanksPar.Text = "Спасибо за поддержку бегуна в Marathon Skills 2024!\r\nВаше пожертвование пойдёт в " +
    "его благотворительную организацию";
            this.LBL_ThanksPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Runner
            // 
            this.LBL_Runner.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Runner.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Runner.Location = new System.Drawing.Point(0, 241);
            this.LBL_Runner.Name = "LBL_Runner";
            this.LBL_Runner.Size = new System.Drawing.Size(912, 61);
            this.LBL_Runner.TabIndex = 28;
            this.LBL_Runner.Text = "ФИО Бегуна";
            this.LBL_Runner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_RunnerFund
            // 
            this.LBL_RunnerFund.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_RunnerFund.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_RunnerFund.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_RunnerFund.Location = new System.Drawing.Point(0, 302);
            this.LBL_RunnerFund.Name = "LBL_RunnerFund";
            this.LBL_RunnerFund.Size = new System.Drawing.Size(912, 63);
            this.LBL_RunnerFund.TabIndex = 29;
            this.LBL_RunnerFund.Text = "Фонд бегуна";
            this.LBL_RunnerFund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CharityAmount
            // 
            this.LBL_CharityAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_CharityAmount.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CharityAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_CharityAmount.Location = new System.Drawing.Point(0, 365);
            this.LBL_CharityAmount.Name = "LBL_CharityAmount";
            this.LBL_CharityAmount.Size = new System.Drawing.Size(912, 142);
            this.LBL_CharityAmount.TabIndex = 30;
            this.LBL_CharityAmount.Text = "$50";
            this.LBL_CharityAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Back
            // 
            this.BTN_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Back.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Back.Location = new System.Drawing.Point(390, 510);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(131, 79);
            this.BTN_Back.TabIndex = 31;
            this.BTN_Back.Text = "Назад";
            this.BTN_Back.UseVisualStyleBackColor = true;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // ThanksForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 641);
            this.Controls.Add(this.BTN_Back);
            this.Controls.Add(this.LBL_CharityAmount);
            this.Controls.Add(this.LBL_RunnerFund);
            this.Controls.Add(this.LBL_Runner);
            this.Controls.Add(this.LBL_ThanksPar);
            this.Controls.Add(this.LBL_HeaderThanks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(930, 688);
            this.MinimumSize = new System.Drawing.Size(930, 688);
            this.Name = "ThanksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanksForm";
            this.Load += new System.EventHandler(this.ThanksForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_HeaderThanks;
        private System.Windows.Forms.Label LBL_ThanksPar;
        private System.Windows.Forms.Label LBL_Runner;
        private System.Windows.Forms.Label LBL_RunnerFund;
        private System.Windows.Forms.Label LBL_CharityAmount;
        private System.Windows.Forms.Button BTN_Back;
    }
}