namespace Practice.Forms
{
    partial class MyResultsForm
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
            this.LBL_MyResultsHeader = new System.Windows.Forms.Label();
            this.LBL_MyResultsDesc = new System.Windows.Forms.Label();
            this.LBL_Sex = new System.Windows.Forms.Label();
            this.LBL_RunnerSex = new System.Windows.Forms.Label();
            this.LBL_Age = new System.Windows.Forms.Label();
            this.LBL_RunnerAge = new System.Windows.Forms.Label();
            this.DGV_Results = new System.Windows.Forms.DataGridView();
            this.BTN_ShowAllResults = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Marathon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commonPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_MyResultsHeader
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_MyResultsHeader, 4);
            this.LBL_MyResultsHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_MyResultsHeader.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_MyResultsHeader.Location = new System.Drawing.Point(3, 0);
            this.LBL_MyResultsHeader.Name = "LBL_MyResultsHeader";
            this.LBL_MyResultsHeader.Size = new System.Drawing.Size(919, 71);
            this.LBL_MyResultsHeader.TabIndex = 0;
            this.LBL_MyResultsHeader.Text = "Мои результаты";
            this.LBL_MyResultsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_MyResultsDesc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_MyResultsDesc, 4);
            this.LBL_MyResultsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_MyResultsDesc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_MyResultsDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_MyResultsDesc.Location = new System.Drawing.Point(3, 71);
            this.LBL_MyResultsDesc.Name = "LBL_MyResultsDesc";
            this.LBL_MyResultsDesc.Size = new System.Drawing.Size(919, 71);
            this.LBL_MyResultsDesc.TabIndex = 1;
            this.LBL_MyResultsDesc.Text = "Это список всех Ваших прошлых результатов гонки для Marathon Skills.\r\nОбщее место" +
    " сравнивает всех бегунов.\r\nМесто по категории сравнивает бегунов по тому же полу" +
    " и возрасту.";
            this.LBL_MyResultsDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Sex
            // 
            this.LBL_Sex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Sex.Location = new System.Drawing.Point(3, 142);
            this.LBL_Sex.Name = "LBL_Sex";
            this.LBL_Sex.Size = new System.Drawing.Size(326, 72);
            this.LBL_Sex.TabIndex = 2;
            this.LBL_Sex.Text = "Пол:";
            this.LBL_Sex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_RunnerSex
            // 
            this.LBL_RunnerSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_RunnerSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RunnerSex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_RunnerSex.Location = new System.Drawing.Point(335, 142);
            this.LBL_RunnerSex.Name = "LBL_RunnerSex";
            this.LBL_RunnerSex.Size = new System.Drawing.Size(98, 72);
            this.LBL_RunnerSex.TabIndex = 3;
            this.LBL_RunnerSex.Text = "мужской";
            this.LBL_RunnerSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_Age
            // 
            this.LBL_Age.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Age.Location = new System.Drawing.Point(439, 142);
            this.LBL_Age.Name = "LBL_Age";
            this.LBL_Age.Size = new System.Drawing.Size(268, 72);
            this.LBL_Age.TabIndex = 4;
            this.LBL_Age.Text = "Возрастная категория:";
            this.LBL_Age.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_RunnerAge
            // 
            this.LBL_RunnerAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_RunnerAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RunnerAge.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_RunnerAge.Location = new System.Drawing.Point(713, 142);
            this.LBL_RunnerAge.Name = "LBL_RunnerAge";
            this.LBL_RunnerAge.Size = new System.Drawing.Size(209, 72);
            this.LBL_RunnerAge.TabIndex = 5;
            this.LBL_RunnerAge.Text = "18-29";
            this.LBL_RunnerAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGV_Results
            // 
            this.DGV_Results.AllowUserToAddRows = false;
            this.DGV_Results.AllowUserToDeleteRows = false;
            this.DGV_Results.AllowUserToResizeColumns = false;
            this.DGV_Results.AllowUserToResizeRows = false;
            this.DGV_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Results.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_Results.ColumnHeadersHeight = 29;
            this.DGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marathon,
            this.Distance,
            this.Time,
            this.commonPlace,
            this.categoryPlace});
            this.DGV_Results.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Results.GridColor = System.Drawing.Color.White;
            this.DGV_Results.Location = new System.Drawing.Point(0, 293);
            this.DGV_Results.MultiSelect = false;
            this.DGV_Results.Name = "DGV_Results";
            this.DGV_Results.RowHeadersVisible = false;
            this.DGV_Results.RowHeadersWidth = 51;
            this.DGV_Results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Results.RowTemplate.Height = 24;
            this.DGV_Results.ShowEditingIcon = false;
            this.DGV_Results.Size = new System.Drawing.Size(925, 179);
            this.DGV_Results.TabIndex = 6;
            // 
            // BTN_ShowAllResults
            // 
            this.BTN_ShowAllResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ShowAllResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_ShowAllResults.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_ShowAllResults.Location = new System.Drawing.Point(326, 478);
            this.BTN_ShowAllResults.Name = "BTN_ShowAllResults";
            this.BTN_ShowAllResults.Size = new System.Drawing.Size(252, 38);
            this.BTN_ShowAllResults.TabIndex = 7;
            this.BTN_ShowAllResults.Text = "Показать все результаты";
            this.BTN_ShowAllResults.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(925, 79);
            this.panel1.TabIndex = 8;
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
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 46);
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
            this.LBL_TimeToStart.Size = new System.Drawing.Size(925, 46);
            this.LBL_TimeToStart.TabIndex = 23;
            this.LBL_TimeToStart.Text = "Время до";
            this.LBL_TimeToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TimeToStart.Visible = false;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Logout.Location = new System.Drawing.Point(794, 0);
            this.BTN_Logout.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Logout.Name = "BTN_Logout";
            this.BTN_Logout.Size = new System.Drawing.Size(131, 79);
            this.BTN_Logout.TabIndex = 27;
            this.BTN_Logout.Text = "Logout";
            this.BTN_Logout.UseVisualStyleBackColor = false;
            this.BTN_Logout.Click += new System.EventHandler(this.BTN_Logout_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Marathon
            // 
            this.Marathon.HeaderText = "Марафон";
            this.Marathon.MinimumWidth = 6;
            this.Marathon.Name = "Marathon";
            // 
            // Distance
            // 
            this.Distance.HeaderText = "Дистанция";
            this.Distance.MinimumWidth = 6;
            this.Distance.Name = "Distance";
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // commonPlace
            // 
            this.commonPlace.HeaderText = "Общее место";
            this.commonPlace.MinimumWidth = 6;
            this.commonPlace.Name = "commonPlace";
            // 
            // categoryPlace
            // 
            this.categoryPlace.HeaderText = "Место в категории";
            this.categoryPlace.MinimumWidth = 6;
            this.categoryPlace.Name = "categoryPlace";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.01398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.30536F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.72028F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.19347F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_MyResultsHeader, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_MyResultsDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Sex, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_RunnerSex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Age, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_RunnerAge, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(925, 214);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // MyResultsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 579);
            this.Controls.Add(this.DGV_Results);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_ShowAllResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyResultsForm";
            this.Text = "MyResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_MyResultsHeader;
        private System.Windows.Forms.Label LBL_MyResultsDesc;
        private System.Windows.Forms.Label LBL_Sex;
        private System.Windows.Forms.Label LBL_RunnerSex;
        private System.Windows.Forms.Label LBL_Age;
        private System.Windows.Forms.Label LBL_RunnerAge;
        private System.Windows.Forms.DataGridView DGV_Results;
        private System.Windows.Forms.Button BTN_ShowAllResults;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marathon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn commonPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryPlace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}