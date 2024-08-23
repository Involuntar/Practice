namespace Practice.Forms
{
    partial class AdminMenu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_Users = new System.Windows.Forms.Button();
            this.BTN_Volunteers = new System.Windows.Forms.Button();
            this.BTN_Charity = new System.Windows.Forms.Button();
            this.BTN_Inventory = new System.Windows.Forms.Button();
            this.LBL_AdminMenu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.LBL_TimeToStart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 46);
            this.panel3.TabIndex = 26;
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
            // BTN_Users
            // 
            this.BTN_Users.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Users.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Users.Location = new System.Drawing.Point(3, 3);
            this.BTN_Users.Name = "BTN_Users";
            this.BTN_Users.Size = new System.Drawing.Size(219, 66);
            this.BTN_Users.TabIndex = 27;
            this.BTN_Users.Text = "Пользователи";
            this.BTN_Users.UseVisualStyleBackColor = false;
            this.BTN_Users.Click += new System.EventHandler(this.BTN_Users_Click);
            // 
            // BTN_Volunteers
            // 
            this.BTN_Volunteers.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Volunteers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Volunteers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Volunteers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Volunteers.Location = new System.Drawing.Point(228, 3);
            this.BTN_Volunteers.Name = "BTN_Volunteers";
            this.BTN_Volunteers.Size = new System.Drawing.Size(220, 66);
            this.BTN_Volunteers.TabIndex = 28;
            this.BTN_Volunteers.Text = "Волонтёры";
            this.BTN_Volunteers.UseVisualStyleBackColor = false;
            // 
            // BTN_Charity
            // 
            this.BTN_Charity.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Charity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Charity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Charity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Charity.Location = new System.Drawing.Point(3, 75);
            this.BTN_Charity.Name = "BTN_Charity";
            this.BTN_Charity.Size = new System.Drawing.Size(219, 67);
            this.BTN_Charity.TabIndex = 29;
            this.BTN_Charity.Text = "Благотворительные \r\nорганизации";
            this.BTN_Charity.UseVisualStyleBackColor = false;
            // 
            // BTN_Inventory
            // 
            this.BTN_Inventory.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Inventory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Inventory.Location = new System.Drawing.Point(228, 75);
            this.BTN_Inventory.Name = "BTN_Inventory";
            this.BTN_Inventory.Size = new System.Drawing.Size(220, 67);
            this.BTN_Inventory.TabIndex = 30;
            this.BTN_Inventory.Text = "Инвентарь";
            this.BTN_Inventory.UseVisualStyleBackColor = false;
            // 
            // LBL_AdminMenu
            // 
            this.LBL_AdminMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_AdminMenu.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.LBL_AdminMenu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_AdminMenu.Location = new System.Drawing.Point(0, 79);
            this.LBL_AdminMenu.Name = "LBL_AdminMenu";
            this.LBL_AdminMenu.Size = new System.Drawing.Size(800, 51);
            this.LBL_AdminMenu.TabIndex = 31;
            this.LBL_AdminMenu.Text = "Меню администратора";
            this.LBL_AdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Users, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Volunteers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Charity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Inventory, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(175, 145);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 145);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // AdminMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LBL_AdminMenu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTN_Users;
        private System.Windows.Forms.Button BTN_Volunteers;
        private System.Windows.Forms.Button BTN_Charity;
        private System.Windows.Forms.Button BTN_Inventory;
        private System.Windows.Forms.Label LBL_AdminMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}