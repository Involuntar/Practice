namespace Practice.Forms
{
    partial class RunnerConfirm
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
            this.LBL_ThanksWordsHeader = new System.Windows.Forms.Label();
            this.LBL_ThanksWordsPar = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_ThanksWordsHeader
            // 
            this.LBL_ThanksWordsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_ThanksWordsHeader.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_ThanksWordsHeader.Location = new System.Drawing.Point(0, 79);
            this.LBL_ThanksWordsHeader.Name = "LBL_ThanksWordsHeader";
            this.LBL_ThanksWordsHeader.Size = new System.Drawing.Size(870, 131);
            this.LBL_ThanksWordsHeader.TabIndex = 0;
            this.LBL_ThanksWordsHeader.Text = "Спасибо за Вашу регистрацю в качестве \r\nбегуна!";
            this.LBL_ThanksWordsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_ThanksWordsPar
            // 
            this.LBL_ThanksWordsPar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_ThanksWordsPar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_ThanksWordsPar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_ThanksWordsPar.Location = new System.Drawing.Point(0, 210);
            this.LBL_ThanksWordsPar.Name = "LBL_ThanksWordsPar";
            this.LBL_ThanksWordsPar.Size = new System.Drawing.Size(870, 80);
            this.LBL_ThanksWordsPar.TabIndex = 1;
            this.LBL_ThanksWordsPar.Text = "Спасибо за вашу регистрацию в качестве бегуна в Marathon Skills 2024!\r\nС Вами свя" +
    "жутся по поводу оплаты.";
            this.LBL_ThanksWordsPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_OK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_OK.Location = new System.Drawing.Point(391, 313);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(101, 52);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.BTN_Logout);
            this.panel1.Controls.Add(this.LBL_MarathonName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 79);
            this.panel1.TabIndex = 18;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Logout.Location = new System.Drawing.Point(740, 0);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(130, 79);
            this.BTN_Logout.TabIndex = 24;
            this.BTN_Logout.Text = "Logout";
            this.BTN_Logout.UseVisualStyleBackColor = false;
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // LBL_MarathonName
            // 
            this.LBL_MarathonName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBL_MarathonName.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.LBL_MarathonName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_MarathonName.Location = new System.Drawing.Point(0, 0);
            this.LBL_MarathonName.Name = "LBL_MarathonName";
            this.LBL_MarathonName.Size = new System.Drawing.Size(481, 79);
            this.LBL_MarathonName.TabIndex = 23;
            this.LBL_MarathonName.Text = "Marathon Skills 2024";
            this.LBL_MarathonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LBL_TimeToStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 46);
            this.panel2.TabIndex = 27;
            // 
            // LBL_TimeToStart
            // 
            this.LBL_TimeToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.LBL_TimeToStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TimeToStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeToStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_TimeToStart.Location = new System.Drawing.Point(0, 0);
            this.LBL_TimeToStart.Name = "LBL_TimeToStart";
            this.LBL_TimeToStart.Size = new System.Drawing.Size(870, 46);
            this.LBL_TimeToStart.TabIndex = 23;
            this.LBL_TimeToStart.Text = "Время до";
            this.LBL_TimeToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TimeToStart.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RunnerConfirm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.LBL_ThanksWordsPar);
            this.Controls.Add(this.LBL_ThanksWordsHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RunnerConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunnerConfirm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_ThanksWordsHeader;
        private System.Windows.Forms.Label LBL_ThanksWordsPar;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
    }
}