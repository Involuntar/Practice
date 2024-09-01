namespace Practice.Forms
{
    partial class CoordMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_Runners = new System.Windows.Forms.Button();
            this.BTN_Sponsors = new System.Windows.Forms.Button();
            this.LBL_CoordMenu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 2;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_Logout.Location = new System.Drawing.Point(670, 0);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(130, 79);
            this.BTN_Logout.TabIndex = 2;
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
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 26;
            // 
            // LBL_TimeToStart
            // 
            this.LBL_TimeToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.LBL_TimeToStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TimeToStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeToStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_TimeToStart.Location = new System.Drawing.Point(0, 0);
            this.LBL_TimeToStart.Name = "LBL_TimeToStart";
            this.LBL_TimeToStart.Size = new System.Drawing.Size(800, 46);
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
            // BTN_Runners
            // 
            this.BTN_Runners.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Runners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Runners.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Runners.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Runners.Location = new System.Drawing.Point(5, 5);
            this.BTN_Runners.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Runners.Name = "BTN_Runners";
            this.BTN_Runners.Size = new System.Drawing.Size(199, 66);
            this.BTN_Runners.TabIndex = 27;
            this.BTN_Runners.Text = "Бегуны";
            this.BTN_Runners.UseVisualStyleBackColor = false;
            this.BTN_Runners.Click += new System.EventHandler(this.BTN_Runners_Click);
            // 
            // BTN_Sponsors
            // 
            this.BTN_Sponsors.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Sponsors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Sponsors.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Sponsors.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Sponsors.Location = new System.Drawing.Point(214, 5);
            this.BTN_Sponsors.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Sponsors.Name = "BTN_Sponsors";
            this.BTN_Sponsors.Size = new System.Drawing.Size(200, 66);
            this.BTN_Sponsors.TabIndex = 28;
            this.BTN_Sponsors.Text = "Спонсоры";
            this.BTN_Sponsors.UseVisualStyleBackColor = false;
            this.BTN_Sponsors.Click += new System.EventHandler(this.BTN_Sponsors_Click);
            // 
            // LBL_CoordMenu
            // 
            this.LBL_CoordMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_CoordMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.LBL_CoordMenu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_CoordMenu.Location = new System.Drawing.Point(0, 79);
            this.LBL_CoordMenu.Name = "LBL_CoordMenu";
            this.LBL_CoordMenu.Size = new System.Drawing.Size(800, 60);
            this.LBL_CoordMenu.TabIndex = 29;
            this.LBL_CoordMenu.Text = "Меню координатора";
            this.LBL_CoordMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Runners, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Sponsors, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(192, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 76);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // CoordMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LBL_CoordMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CoordMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню координатора";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTN_Runners;
        private System.Windows.Forms.Button BTN_Sponsors;
        private System.Windows.Forms.Label LBL_CoordMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}