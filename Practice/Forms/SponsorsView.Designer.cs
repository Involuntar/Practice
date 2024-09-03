namespace Practice.Forms
{
    partial class SponsorsView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.LBL_SponsorsView = new System.Windows.Forms.Label();
            this.LBL_Funds = new System.Windows.Forms.Label();
            this.LBL_Charity = new System.Windows.Forms.Label();
            this.LBL_FundsAmount = new System.Windows.Forms.Label();
            this.LBL_CharityAmount = new System.Windows.Forms.Label();
            this.DGV_Sponsors = new System.Windows.Forms.DataGridView();
            this.Logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.FundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sponsors)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.BTN_Logout);
            this.panel2.Controls.Add(this.LBL_MarathonName);
            this.panel2.Controls.Add(this.BTN_Back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 79);
            this.panel2.TabIndex = 11;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Logout.Location = new System.Drawing.Point(759, 0);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LBL_TimeToStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 46);
            this.panel1.TabIndex = 25;
            // 
            // LBL_TimeToStart
            // 
            this.LBL_TimeToStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.LBL_TimeToStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TimeToStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeToStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_TimeToStart.Location = new System.Drawing.Point(0, 0);
            this.LBL_TimeToStart.Name = "LBL_TimeToStart";
            this.LBL_TimeToStart.Size = new System.Drawing.Size(890, 46);
            this.LBL_TimeToStart.TabIndex = 23;
            this.LBL_TimeToStart.Text = "Время до";
            this.LBL_TimeToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TimeToStart.Visible = false;
            // 
            // LBL_SponsorsView
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LBL_SponsorsView, 2);
            this.LBL_SponsorsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_SponsorsView.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_SponsorsView.Location = new System.Drawing.Point(3, 0);
            this.LBL_SponsorsView.Name = "LBL_SponsorsView";
            this.LBL_SponsorsView.Size = new System.Drawing.Size(884, 83);
            this.LBL_SponsorsView.TabIndex = 26;
            this.LBL_SponsorsView.Text = "Просмотр спонсоров";
            this.LBL_SponsorsView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Funds
            // 
            this.LBL_Funds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Funds.AutoSize = true;
            this.LBL_Funds.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Funds.Location = new System.Drawing.Point(3, 93);
            this.LBL_Funds.Name = "LBL_Funds";
            this.LBL_Funds.Size = new System.Drawing.Size(439, 22);
            this.LBL_Funds.TabIndex = 27;
            this.LBL_Funds.Text = "Благотворительные организации:";
            this.LBL_Funds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Charity
            // 
            this.LBL_Charity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Charity.AutoSize = true;
            this.LBL_Charity.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Charity.Location = new System.Drawing.Point(3, 136);
            this.LBL_Charity.Name = "LBL_Charity";
            this.LBL_Charity.Size = new System.Drawing.Size(439, 22);
            this.LBL_Charity.TabIndex = 28;
            this.LBL_Charity.Text = "Всего спонсорских взносов:";
            this.LBL_Charity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_FundsAmount
            // 
            this.LBL_FundsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_FundsAmount.AutoSize = true;
            this.LBL_FundsAmount.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_FundsAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_FundsAmount.Location = new System.Drawing.Point(448, 93);
            this.LBL_FundsAmount.Name = "LBL_FundsAmount";
            this.LBL_FundsAmount.Size = new System.Drawing.Size(439, 22);
            this.LBL_FundsAmount.TabIndex = 29;
            this.LBL_FundsAmount.Text = "10";
            this.LBL_FundsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_CharityAmount
            // 
            this.LBL_CharityAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_CharityAmount.AutoSize = true;
            this.LBL_CharityAmount.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_CharityAmount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_CharityAmount.Location = new System.Drawing.Point(448, 136);
            this.LBL_CharityAmount.Name = "LBL_CharityAmount";
            this.LBL_CharityAmount.Size = new System.Drawing.Size(439, 22);
            this.LBL_CharityAmount.TabIndex = 30;
            this.LBL_CharityAmount.Text = "$94,450";
            this.LBL_CharityAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Logo,
            this.FundName,
            this.Summ});
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Sponsors, 2);
            this.DGV_Sponsors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Sponsors.Location = new System.Drawing.Point(3, 172);
            this.DGV_Sponsors.MultiSelect = false;
            this.DGV_Sponsors.Name = "DGV_Sponsors";
            this.DGV_Sponsors.RowHeadersVisible = false;
            this.DGV_Sponsors.RowHeadersWidth = 51;
            this.DGV_Sponsors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Sponsors.RowTemplate.Height = 24;
            this.DGV_Sponsors.ShowEditingIcon = false;
            this.DGV_Sponsors.Size = new System.Drawing.Size(884, 341);
            this.DGV_Sponsors.TabIndex = 31;
            // 
            // Logo
            // 
            this.Logo.DataPropertyName = "CharityLogo";
            this.Logo.HeaderText = "Логотип";
            this.Logo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Logo.MinimumWidth = 6;
            this.Logo.Name = "Logo";
            this.Logo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FundName
            // 
            this.FundName.DataPropertyName = "CharityName";
            this.FundName.HeaderText = "Наименование организации";
            this.FundName.MinimumWidth = 6;
            this.FundName.Name = "FundName";
            // 
            // Summ
            // 
            this.Summ.DataPropertyName = "Amount";
            this.Summ.HeaderText = "Сумма";
            this.Summ.MinimumWidth = 6;
            this.Summ.Name = "Summ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DGV_Sponsors, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_SponsorsView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_FundsAmount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Charity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Funds, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CharityAmount, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 516);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SponsorsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(890, 641);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SponsorsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спонсоры";
            this.Load += new System.EventHandler(this.SponsorsView_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sponsors)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Label LBL_SponsorsView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGV_Sponsors;
        private System.Windows.Forms.Label LBL_FundsAmount;
        private System.Windows.Forms.Label LBL_Charity;
        private System.Windows.Forms.Label LBL_Funds;
        private System.Windows.Forms.Label LBL_CharityAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn Logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
    }
}