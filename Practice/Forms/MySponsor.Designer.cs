namespace Practice.Forms
{
    partial class MySponsor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.LBL_MySponsors = new System.Windows.Forms.Label();
            this.LBL_MySponsorsDesc = new System.Windows.Forms.Label();
            this.LBL_FundName = new System.Windows.Forms.Label();
            this.PIC_FundLogo = new System.Windows.Forms.PictureBox();
            this.LBL_FundDesc = new System.Windows.Forms.Label();
            this.DGV_Sponsors = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_Amount = new System.Windows.Forms.Label();
            this.LBL_AmountFee = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FundLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sponsors)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(908, 79);
            this.panel1.TabIndex = 29;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Logout.Location = new System.Drawing.Point(777, 0);
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
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 46);
            this.panel2.TabIndex = 30;
            // 
            // LBL_TimeToStart
            // 
            this.LBL_TimeToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.LBL_TimeToStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TimeToStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeToStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_TimeToStart.Location = new System.Drawing.Point(0, 0);
            this.LBL_TimeToStart.Name = "LBL_TimeToStart";
            this.LBL_TimeToStart.Size = new System.Drawing.Size(908, 46);
            this.LBL_TimeToStart.TabIndex = 23;
            this.LBL_TimeToStart.Text = "Время до";
            this.LBL_TimeToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TimeToStart.Visible = false;
            // 
            // LBL_MySponsors
            // 
            this.LBL_MySponsors.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_MySponsors, 3);
            this.LBL_MySponsors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_MySponsors.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_MySponsors.Location = new System.Drawing.Point(3, 0);
            this.LBL_MySponsors.Name = "LBL_MySponsors";
            this.LBL_MySponsors.Size = new System.Drawing.Size(902, 86);
            this.LBL_MySponsors.TabIndex = 31;
            this.LBL_MySponsors.Text = "Мои спонсоры";
            this.LBL_MySponsors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_MySponsorsDesc
            // 
            this.LBL_MySponsorsDesc.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_MySponsorsDesc, 3);
            this.LBL_MySponsorsDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_MySponsorsDesc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_MySponsorsDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_MySponsorsDesc.Location = new System.Drawing.Point(3, 86);
            this.LBL_MySponsorsDesc.Name = "LBL_MySponsorsDesc";
            this.LBL_MySponsorsDesc.Size = new System.Drawing.Size(902, 51);
            this.LBL_MySponsorsDesc.TabIndex = 32;
            this.LBL_MySponsorsDesc.Text = "Здесь показаны все Ваши спонсоры в Marathon Skills 2024";
            this.LBL_MySponsorsDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_FundName
            // 
            this.LBL_FundName.AutoSize = true;
            this.LBL_FundName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_FundName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.LBL_FundName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_FundName.Location = new System.Drawing.Point(3, 137);
            this.LBL_FundName.Name = "LBL_FundName";
            this.LBL_FundName.Size = new System.Drawing.Size(388, 79);
            this.LBL_FundName.TabIndex = 33;
            this.LBL_FundName.Text = "Наименование \r\nорганизации";
            this.LBL_FundName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PIC_FundLogo
            // 
            this.PIC_FundLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIC_FundLogo.Location = new System.Drawing.Point(3, 219);
            this.PIC_FundLogo.Name = "PIC_FundLogo";
            this.PIC_FundLogo.Size = new System.Drawing.Size(388, 142);
            this.PIC_FundLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_FundLogo.TabIndex = 34;
            this.PIC_FundLogo.TabStop = false;
            // 
            // LBL_FundDesc
            // 
            this.LBL_FundDesc.AutoSize = true;
            this.LBL_FundDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_FundDesc.Location = new System.Drawing.Point(3, 364);
            this.LBL_FundDesc.Name = "LBL_FundDesc";
            this.LBL_FundDesc.Size = new System.Drawing.Size(388, 68);
            this.LBL_FundDesc.TabIndex = 35;
            this.LBL_FundDesc.Text = "Описание организации";
            // 
            // DGV_Sponsors
            // 
            this.DGV_Sponsors.AllowUserToAddRows = false;
            this.DGV_Sponsors.AllowUserToDeleteRows = false;
            this.DGV_Sponsors.AllowUserToResizeColumns = false;
            this.DGV_Sponsors.AllowUserToResizeRows = false;
            this.DGV_Sponsors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Sponsors.ColumnHeadersHeight = 29;
            this.DGV_Sponsors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_Sponsors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName});
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Sponsors, 2);
            this.DGV_Sponsors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Sponsors.Location = new System.Drawing.Point(3, 3);
            this.DGV_Sponsors.MultiSelect = false;
            this.DGV_Sponsors.Name = "DGV_Sponsors";
            this.DGV_Sponsors.RowHeadersVisible = false;
            this.DGV_Sponsors.RowHeadersWidth = 51;
            this.DGV_Sponsors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Sponsors.RowTemplate.Height = 24;
            this.DGV_Sponsors.ShowEditingIcon = false;
            this.DGV_Sponsors.Size = new System.Drawing.Size(292, 233);
            this.DGV_Sponsors.TabIndex = 36;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "CharityName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FirstName.HeaderText = "Спонсор";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Charity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LastName.DefaultCellStyle = dataGridViewCellStyle2;
            this.LastName.HeaderText = "Взнос";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // LBL_Amount
            // 
            this.LBL_Amount.AutoSize = true;
            this.LBL_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Amount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_Amount.Location = new System.Drawing.Point(3, 239);
            this.LBL_Amount.Name = "LBL_Amount";
            this.LBL_Amount.Size = new System.Drawing.Size(143, 50);
            this.LBL_Amount.TabIndex = 37;
            this.LBL_Amount.Text = "Всего:";
            this.LBL_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_AmountFee
            // 
            this.LBL_AmountFee.AutoSize = true;
            this.LBL_AmountFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_AmountFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.LBL_AmountFee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_AmountFee.Location = new System.Drawing.Point(152, 239);
            this.LBL_AmountFee.Name = "LBL_AmountFee";
            this.LBL_AmountFee.Size = new System.Drawing.Size(143, 50);
            this.LBL_AmountFee.TabIndex = 38;
            this.LBL_AmountFee.Text = "$150";
            this.LBL_AmountFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_Sponsors, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_AmountFee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Amount, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(607, 140);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.93651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.06349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 289);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.39207F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.12775F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_MySponsors, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_MySponsorsDesc, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_FundDesc, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.LBL_FundName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.PIC_FundLogo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.80556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.28704F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.25926F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.27778F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(908, 432);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MySponsor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(908, 557);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MySponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой спонсор";
            this.Load += new System.EventHandler(this.MySponsor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FundLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sponsors)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Label LBL_MySponsors;
        private System.Windows.Forms.Label LBL_MySponsorsDesc;
        private System.Windows.Forms.Label LBL_FundName;
        private System.Windows.Forms.PictureBox PIC_FundLogo;
        private System.Windows.Forms.Label LBL_FundDesc;
        private System.Windows.Forms.DataGridView DGV_Sponsors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_AmountFee;
        private System.Windows.Forms.Label LBL_Amount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    }
}