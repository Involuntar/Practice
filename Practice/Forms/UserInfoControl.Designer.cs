namespace Practice.Forms
{
    partial class UserInfoControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.DGV_Users = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_UserInfoControl = new System.Windows.Forms.Label();
            this.LBL_RoleFilter = new System.Windows.Forms.Label();
            this.LBL_Search = new System.Windows.Forms.Label();
            this.LBL_Users = new System.Windows.Forms.Label();
            this.LBL_UsersAmount = new System.Windows.Forms.Label();
            this.BTN_AddNew = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.CMBX_RoleFilter = new System.Windows.Forms.ComboBox();
            this.TBX_Search = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.BTN_Logout);
            this.panel1.Controls.Add(this.LBL_MarathonName);
            this.panel1.Controls.Add(this.BTN_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 10;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Logout.Location = new System.Drawing.Point(669, 0);
            this.BTN_Logout.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(131, 79);
            this.BTN_Logout.TabIndex = 27;
            this.BTN_Logout.Text = "Logout";
            this.BTN_Logout.UseVisualStyleBackColor = false;
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // LBL_MarathonName
            // 
            this.LBL_MarathonName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBL_MarathonName.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.LBL_MarathonName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_MarathonName.Location = new System.Drawing.Point(131, 0);
            this.LBL_MarathonName.Name = "LBL_MarathonName";
            this.LBL_MarathonName.Size = new System.Drawing.Size(481, 79);
            this.LBL_MarathonName.TabIndex = 23;
            this.LBL_MarathonName.Text = "Marathon Skills 2024";
            this.LBL_MarathonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Back
            // 
            this.BTN_Back.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Back.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Back.Location = new System.Drawing.Point(0, 0);
            this.BTN_Back.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(131, 79);
            this.BTN_Back.TabIndex = 0;
            this.BTN_Back.Text = "Назад";
            this.BTN_Back.UseVisualStyleBackColor = false;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LBL_TimeToStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
            this.panel2.TabIndex = 28;
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
            // DGV_Users
            // 
            this.DGV_Users.AllowUserToAddRows = false;
            this.DGV_Users.AllowUserToDeleteRows = false;
            this.DGV_Users.AllowUserToResizeColumns = false;
            this.DGV_Users.AllowUserToResizeRows = false;
            this.DGV_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Users.ColumnHeadersHeight = 29;
            this.DGV_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.Role,
            this.BTN_Edit});
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Users, 4);
            this.DGV_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGV_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Users.Location = new System.Drawing.Point(3, 255);
            this.DGV_Users.MultiSelect = false;
            this.DGV_Users.Name = "DGV_Users";
            this.DGV_Users.RowHeadersVisible = false;
            this.DGV_Users.RowHeadersWidth = 51;
            this.DGV_Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Users.RowTemplate.Height = 24;
            this.DGV_Users.ShowEditingIcon = false;
            this.DGV_Users.Size = new System.Drawing.Size(794, 166);
            this.DGV_Users.TabIndex = 36;
            this.DGV_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Users_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.LastName.DefaultCellStyle = dataGridViewCellStyle2;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Email.DefaultCellStyle = dataGridViewCellStyle3;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Role
            // 
            this.Role.DataPropertyName = "RoleId";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Role.DefaultCellStyle = dataGridViewCellStyle4;
            this.Role.HeaderText = "Роль";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            // 
            // BTN_Edit
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Edit.DefaultCellStyle = dataGridViewCellStyle5;
            this.BTN_Edit.HeaderText = "";
            this.BTN_Edit.MinimumWidth = 6;
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseColumnTextForButtonValue = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBL_UserInfoControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_UserInfoControl, 4);
            this.LBL_UserInfoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_UserInfoControl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_UserInfoControl.Location = new System.Drawing.Point(3, 0);
            this.LBL_UserInfoControl.Name = "LBL_UserInfoControl";
            this.LBL_UserInfoControl.Size = new System.Drawing.Size(794, 53);
            this.LBL_UserInfoControl.TabIndex = 37;
            this.LBL_UserInfoControl.Text = "Управление пользователями";
            this.LBL_UserInfoControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_RoleFilter
            // 
            this.LBL_RoleFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_RoleFilter.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_RoleFilter.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_RoleFilter.Location = new System.Drawing.Point(403, 53);
            this.LBL_RoleFilter.Name = "LBL_RoleFilter";
            this.LBL_RoleFilter.Size = new System.Drawing.Size(194, 59);
            this.LBL_RoleFilter.TabIndex = 38;
            this.LBL_RoleFilter.Text = "Фильтр по ролям:";
            this.LBL_RoleFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Search
            // 
            this.LBL_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Search.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Search.Location = new System.Drawing.Point(403, 112);
            this.LBL_Search.Name = "LBL_Search";
            this.LBL_Search.Size = new System.Drawing.Size(194, 47);
            this.LBL_Search.TabIndex = 40;
            this.LBL_Search.Text = "Поиск:";
            this.LBL_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Users
            // 
            this.LBL_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Users.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Users.Location = new System.Drawing.Point(3, 224);
            this.LBL_Users.Name = "LBL_Users";
            this.LBL_Users.Size = new System.Drawing.Size(194, 28);
            this.LBL_Users.TabIndex = 41;
            this.LBL_Users.Text = "Всего пользователей:";
            this.LBL_Users.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_UsersAmount
            // 
            this.LBL_UsersAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_UsersAmount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UsersAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_UsersAmount.Location = new System.Drawing.Point(203, 224);
            this.LBL_UsersAmount.Name = "LBL_UsersAmount";
            this.LBL_UsersAmount.Size = new System.Drawing.Size(194, 28);
            this.LBL_UsersAmount.TabIndex = 42;
            this.LBL_UsersAmount.Text = "123";
            this.LBL_UsersAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_AddNew
            // 
            this.BTN_AddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_AddNew.AutoSize = true;
            this.BTN_AddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_AddNew.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_AddNew.Location = new System.Drawing.Point(23, 56);
            this.BTN_AddNew.Name = "BTN_AddNew";
            this.BTN_AddNew.Size = new System.Drawing.Size(153, 53);
            this.BTN_AddNew.TabIndex = 43;
            this.BTN_AddNew.Text = "+ Добавление \r\nнового";
            this.BTN_AddNew.UseVisualStyleBackColor = true;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Refresh.AutoSize = true;
            this.BTN_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Refresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Refresh.Location = new System.Drawing.Point(645, 162);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(110, 32);
            this.BTN_Refresh.TabIndex = 44;
            this.BTN_Refresh.Text = "Обновить";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // CMBX_RoleFilter
            // 
            this.CMBX_RoleFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBX_RoleFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CMBX_RoleFilter.FormattingEnabled = true;
            this.CMBX_RoleFilter.Location = new System.Drawing.Point(603, 70);
            this.CMBX_RoleFilter.Name = "CMBX_RoleFilter";
            this.CMBX_RoleFilter.Size = new System.Drawing.Size(194, 24);
            this.CMBX_RoleFilter.TabIndex = 45;
            // 
            // TBX_Search
            // 
            this.TBX_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Search.Location = new System.Drawing.Point(603, 124);
            this.TBX_Search.Name = "TBX_Search";
            this.TBX_Search.Size = new System.Drawing.Size(194, 22);
            this.TBX_Search.TabIndex = 47;
            this.TBX_Search.TextChanged += new System.EventHandler(this.TBX_Search_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_AddNew, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_RoleFilter, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_UserInfoControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CMBX_RoleFilter, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_UsersAmount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Users, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Users, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Search, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Search, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Refresh, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91509F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.08491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.198113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.603774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.33019F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 424);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // UserInfoControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserInfoControl";
            this.Text = "UserInfoControl";
            this.Load += new System.EventHandler(this.UserInfoControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.DataGridView DGV_Users;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_UserInfoControl;
        private System.Windows.Forms.Label LBL_RoleFilter;
        private System.Windows.Forms.Label LBL_Search;
        private System.Windows.Forms.Label LBL_Users;
        private System.Windows.Forms.Label LBL_UsersAmount;
        private System.Windows.Forms.Button BTN_AddNew;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.ComboBox CMBX_RoleFilter;
        private System.Windows.Forms.TextBox TBX_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewButtonColumn BTN_Edit;
    }
}