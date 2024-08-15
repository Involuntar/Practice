namespace Practice.Forms
{
    partial class RunnerMenu
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
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_RunnerMenu = new System.Windows.Forms.Label();
            this.BTN_RegMar = new System.Windows.Forms.Button();
            this.BTN_Results = new System.Windows.Forms.Button();
            this.BTN_EditProfile = new System.Windows.Forms.Button();
            this.BTN_Sponsor = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Contacts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.LBL_MarathonName.Size = new System.Drawing.Size(481, 79);
            this.LBL_MarathonName.TabIndex = 23;
            this.LBL_MarathonName.Text = "Marathon Skills 2024";
            this.LBL_MarathonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Size = new System.Drawing.Size(923, 79);
            this.panel1.TabIndex = 1;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Logout.Location = new System.Drawing.Point(793, 0);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(130, 79);
            this.BTN_Logout.TabIndex = 2;
            this.BTN_Logout.Text = "Logout";
            this.BTN_Logout.UseVisualStyleBackColor = false;
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // LBL_RunnerMenu
            // 
            this.LBL_RunnerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_RunnerMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RunnerMenu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_RunnerMenu.Location = new System.Drawing.Point(0, 79);
            this.LBL_RunnerMenu.Name = "LBL_RunnerMenu";
            this.LBL_RunnerMenu.Size = new System.Drawing.Size(923, 57);
            this.LBL_RunnerMenu.TabIndex = 2;
            this.LBL_RunnerMenu.Text = "Меню бегуна";
            this.LBL_RunnerMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_RegMar
            // 
            this.BTN_RegMar.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_RegMar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_RegMar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RegMar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_RegMar.Location = new System.Drawing.Point(10, 10);
            this.BTN_RegMar.Margin = new System.Windows.Forms.Padding(10);
            this.BTN_RegMar.Name = "BTN_RegMar";
            this.BTN_RegMar.Size = new System.Drawing.Size(251, 60);
            this.BTN_RegMar.TabIndex = 3;
            this.BTN_RegMar.Text = "Регистрация на \r\nмарафон";
            this.BTN_RegMar.UseVisualStyleBackColor = false;
            this.BTN_RegMar.Click += new System.EventHandler(this.BTN_RegMar_Click);
            // 
            // BTN_Results
            // 
            this.BTN_Results.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Results.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Results.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Results.Location = new System.Drawing.Point(281, 10);
            this.BTN_Results.Margin = new System.Windows.Forms.Padding(10);
            this.BTN_Results.Name = "BTN_Results";
            this.BTN_Results.Size = new System.Drawing.Size(251, 60);
            this.BTN_Results.TabIndex = 4;
            this.BTN_Results.Text = "Мои результаты";
            this.BTN_Results.UseVisualStyleBackColor = false;
            this.BTN_Results.Click += new System.EventHandler(this.BTN_Results_Click);
            // 
            // BTN_EditProfile
            // 
            this.BTN_EditProfile.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_EditProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EditProfile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_EditProfile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_EditProfile.Location = new System.Drawing.Point(10, 90);
            this.BTN_EditProfile.Margin = new System.Windows.Forms.Padding(10);
            this.BTN_EditProfile.Name = "BTN_EditProfile";
            this.BTN_EditProfile.Size = new System.Drawing.Size(251, 60);
            this.BTN_EditProfile.TabIndex = 5;
            this.BTN_EditProfile.Text = "Редактирование \r\nпрофиля";
            this.BTN_EditProfile.UseVisualStyleBackColor = false;
            this.BTN_EditProfile.Click += new System.EventHandler(this.BTN_EditProfile_Click);
            // 
            // BTN_Sponsor
            // 
            this.BTN_Sponsor.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Sponsor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Sponsor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Sponsor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Sponsor.Location = new System.Drawing.Point(281, 90);
            this.BTN_Sponsor.Margin = new System.Windows.Forms.Padding(10);
            this.BTN_Sponsor.Name = "BTN_Sponsor";
            this.BTN_Sponsor.Size = new System.Drawing.Size(251, 60);
            this.BTN_Sponsor.TabIndex = 6;
            this.BTN_Sponsor.Text = "Мой спонсор";
            this.BTN_Sponsor.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Sponsor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Contacts, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Results, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_RegMar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_EditProfile, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(185, 139);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 241);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BTN_Contacts
            // 
            this.BTN_Contacts.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Contacts.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Contacts.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Contacts.Location = new System.Drawing.Point(10, 170);
            this.BTN_Contacts.Margin = new System.Windows.Forms.Padding(10);
            this.BTN_Contacts.Name = "BTN_Contacts";
            this.BTN_Contacts.Size = new System.Drawing.Size(251, 61);
            this.BTN_Contacts.TabIndex = 7;
            this.BTN_Contacts.Text = "Контакты";
            this.BTN_Contacts.UseVisualStyleBackColor = false;
            this.BTN_Contacts.Click += new System.EventHandler(this.BTN_Contacts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LBL_TimeToStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 46);
            this.panel2.TabIndex = 25;
            // 
            // LBL_TimeToStart
            // 
            this.LBL_TimeToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.LBL_TimeToStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TimeToStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeToStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_TimeToStart.Location = new System.Drawing.Point(0, 0);
            this.LBL_TimeToStart.Name = "LBL_TimeToStart";
            this.LBL_TimeToStart.Size = new System.Drawing.Size(923, 46);
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
            // RunnerMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LBL_RunnerMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RunnerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunnerMenu";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_RunnerMenu;
        private System.Windows.Forms.Button BTN_RegMar;
        private System.Windows.Forms.Button BTN_Results;
        private System.Windows.Forms.Button BTN_EditProfile;
        private System.Windows.Forms.Button BTN_Sponsor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTN_Contacts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
    }
}