namespace Practice.Forms
{
    partial class RunnerInfoControl
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
            this.BTN_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.LBL_RunnersControl = new System.Windows.Forms.Label();
            this.LBL_Sort = new System.Windows.Forms.Label();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.LBL_Distance = new System.Windows.Forms.Label();
            this.LBL_Load = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV_Runners = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_CSV = new System.Windows.Forms.Button();
            this.BTN_Email = new System.Windows.Forms.Button();
            this.CMBX_Status = new System.Windows.Forms.ComboBox();
            this.CMBX_Distance = new System.Windows.Forms.ComboBox();
            this.LBL_TotalRunners = new System.Windows.Forms.Label();
            this.LBL_AmountRunners = new System.Windows.Forms.Label();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Runners)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(916, 79);
            this.panel1.TabIndex = 9;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Logout.Location = new System.Drawing.Point(785, 0);
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
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 46);
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
            this.LBL_TimeToStart.Size = new System.Drawing.Size(916, 46);
            this.LBL_TimeToStart.TabIndex = 23;
            this.LBL_TimeToStart.Text = "Время до";
            this.LBL_TimeToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TimeToStart.Visible = false;
            // 
            // LBL_RunnersControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_RunnersControl, 4);
            this.LBL_RunnersControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_RunnersControl.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_RunnersControl.Location = new System.Drawing.Point(3, 0);
            this.LBL_RunnersControl.Name = "LBL_RunnersControl";
            this.LBL_RunnersControl.Size = new System.Drawing.Size(910, 57);
            this.LBL_RunnersControl.TabIndex = 28;
            this.LBL_RunnersControl.Text = "Управление бегунами";
            this.LBL_RunnersControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Sort
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_Sort, 2);
            this.LBL_Sort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Sort.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Sort.Location = new System.Drawing.Point(3, 57);
            this.LBL_Sort.Name = "LBL_Sort";
            this.LBL_Sort.Size = new System.Drawing.Size(452, 34);
            this.LBL_Sort.TabIndex = 29;
            this.LBL_Sort.Text = "Сортировка и фильтрация";
            this.LBL_Sort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Status.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Status.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Status.Location = new System.Drawing.Point(3, 91);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(223, 59);
            this.LBL_Status.TabIndex = 30;
            this.LBL_Status.Text = "Статус:";
            this.LBL_Status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Distance
            // 
            this.LBL_Distance.AutoSize = true;
            this.LBL_Distance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Distance.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Distance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Distance.Location = new System.Drawing.Point(3, 150);
            this.LBL_Distance.Name = "LBL_Distance";
            this.LBL_Distance.Size = new System.Drawing.Size(223, 56);
            this.LBL_Distance.TabIndex = 31;
            this.LBL_Distance.Text = "Дистанция:";
            this.LBL_Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Load
            // 
            this.LBL_Load.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Load.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Load.Location = new System.Drawing.Point(690, 57);
            this.LBL_Load.Name = "LBL_Load";
            this.LBL_Load.Size = new System.Drawing.Size(223, 34);
            this.LBL_Load.TabIndex = 33;
            this.LBL_Load.Text = "Выгрузка";
            this.LBL_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "label7";
            // 
            // DGV_Runners
            // 
            this.DGV_Runners.AllowUserToAddRows = false;
            this.DGV_Runners.AllowUserToDeleteRows = false;
            this.DGV_Runners.AllowUserToResizeColumns = false;
            this.DGV_Runners.AllowUserToResizeRows = false;
            this.DGV_Runners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Runners.ColumnHeadersHeight = 29;
            this.DGV_Runners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Runners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Email,
            this.Status,
            this.BTN_Edit});
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Runners, 4);
            this.DGV_Runners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Runners.Location = new System.Drawing.Point(3, 294);
            this.DGV_Runners.MultiSelect = false;
            this.DGV_Runners.Name = "DGV_Runners";
            this.DGV_Runners.RowHeadersVisible = false;
            this.DGV_Runners.RowHeadersWidth = 51;
            this.DGV_Runners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Runners.RowTemplate.Height = 24;
            this.DGV_Runners.ShowEditingIcon = false;
            this.DGV_Runners.Size = new System.Drawing.Size(910, 214);
            this.DGV_Runners.TabIndex = 35;
            this.DGV_Runners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Runners_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "RegistrationStatus";
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.HeaderText = "";
            this.BTN_Edit.MinimumWidth = 6;
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseColumnTextForButtonValue = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_Runners, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Load, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_RunnersControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Sort, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Status, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Distance, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BTN_CSV, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Email, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.CMBX_Status, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CMBX_Distance, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_TotalRunners, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LBL_AmountRunners, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Refresh, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.65362F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.54599F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9589F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.589041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.04501F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.46575F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 511);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // BTN_CSV
            // 
            this.BTN_CSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_CSV.AutoSize = true;
            this.BTN_CSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_CSV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_CSV.Location = new System.Drawing.Point(690, 94);
            this.BTN_CSV.Name = "BTN_CSV";
            this.BTN_CSV.Size = new System.Drawing.Size(223, 53);
            this.BTN_CSV.TabIndex = 38;
            this.BTN_CSV.Text = "Детальная информация\r\n(CSV)";
            this.BTN_CSV.UseVisualStyleBackColor = true;
            // 
            // BTN_Email
            // 
            this.BTN_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Email.AutoSize = true;
            this.BTN_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Email.Location = new System.Drawing.Point(735, 162);
            this.BTN_Email.Name = "BTN_Email";
            this.BTN_Email.Size = new System.Drawing.Size(132, 32);
            this.BTN_Email.TabIndex = 39;
            this.BTN_Email.Text = "E-mail список";
            this.BTN_Email.UseVisualStyleBackColor = true;
            // 
            // CMBX_Status
            // 
            this.CMBX_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBX_Status.FormattingEnabled = true;
            this.CMBX_Status.Items.AddRange(new object[] {
            ""});
            this.CMBX_Status.Location = new System.Drawing.Point(232, 108);
            this.CMBX_Status.Name = "CMBX_Status";
            this.CMBX_Status.Size = new System.Drawing.Size(223, 24);
            this.CMBX_Status.TabIndex = 41;
            this.CMBX_Status.SelectionChangeCommitted += new System.EventHandler(this.CMBX_Status_SelectionChangeCommitted);
            // 
            // CMBX_Distance
            // 
            this.CMBX_Distance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBX_Distance.FormattingEnabled = true;
            this.CMBX_Distance.Items.AddRange(new object[] {
            ""});
            this.CMBX_Distance.Location = new System.Drawing.Point(232, 166);
            this.CMBX_Distance.Name = "CMBX_Distance";
            this.CMBX_Distance.Size = new System.Drawing.Size(223, 24);
            this.CMBX_Distance.TabIndex = 42;
            this.CMBX_Distance.SelectionChangeCommitted += new System.EventHandler(this.CMBX_Distance_SelectionChangeCommitted);
            // 
            // LBL_TotalRunners
            // 
            this.LBL_TotalRunners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TotalRunners.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.LBL_TotalRunners.Location = new System.Drawing.Point(232, 255);
            this.LBL_TotalRunners.Name = "LBL_TotalRunners";
            this.LBL_TotalRunners.Size = new System.Drawing.Size(223, 36);
            this.LBL_TotalRunners.TabIndex = 37;
            this.LBL_TotalRunners.Text = "Всего бегунов:";
            this.LBL_TotalRunners.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_AmountRunners
            // 
            this.LBL_AmountRunners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_AmountRunners.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_AmountRunners.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_AmountRunners.Location = new System.Drawing.Point(461, 255);
            this.LBL_AmountRunners.Name = "LBL_AmountRunners";
            this.LBL_AmountRunners.Size = new System.Drawing.Size(223, 36);
            this.LBL_AmountRunners.TabIndex = 44;
            this.LBL_AmountRunners.Text = "Число";
            this.LBL_AmountRunners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Refresh.AutoSize = true;
            this.BTN_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Refresh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Refresh.Location = new System.Drawing.Point(751, 258);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(101, 30);
            this.BTN_Refresh.TabIndex = 40;
            this.BTN_Refresh.Text = "Обновить";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RunnerInfoControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 636);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RunnerInfoControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бегуны";
            this.Load += new System.EventHandler(this.RunnerInfoControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Runners)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Label LBL_RunnersControl;
        private System.Windows.Forms.Label LBL_Sort;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.Label LBL_Distance;
        private System.Windows.Forms.Label LBL_Load;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_Runners;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_TotalRunners;
        private System.Windows.Forms.Button BTN_CSV;
        private System.Windows.Forms.Button BTN_Email;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.ComboBox CMBX_Status;
        private System.Windows.Forms.ComboBox CMBX_Distance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_AmountRunners;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn BTN_Edit;
    }
}