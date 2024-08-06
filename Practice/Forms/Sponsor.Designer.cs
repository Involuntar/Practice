namespace Practice.Forms
{
    partial class Sponsor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sponsor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.LBL_Sponsor = new System.Windows.Forms.Label();
            this.LBL_Instruction = new System.Windows.Forms.Label();
            this.LBL_Sponsor_Info = new System.Windows.Forms.Label();
            this.LBL_Charity = new System.Windows.Forms.Label();
            this.LBL_CharitySumm = new System.Windows.Forms.Label();
            this.LBL_CharityAmount = new System.Windows.Forms.Label();
            this.LBL_SponsorName = new System.Windows.Forms.Label();
            this.LBL_Runner = new System.Windows.Forms.Label();
            this.LBL_CardOwner = new System.Windows.Forms.Label();
            this.LBL_CardNumber = new System.Windows.Forms.Label();
            this.LBL_CardDate = new System.Windows.Forms.Label();
            this.LBL_CardCVC = new System.Windows.Forms.Label();
            this.TBX_Name = new System.Windows.Forms.TextBox();
            this.TBX_CardOwner = new System.Windows.Forms.TextBox();
            this.TBX_CardNumber = new System.Windows.Forms.TextBox();
            this.TBX_CardCVC = new System.Windows.Forms.TextBox();
            this.BTN_DonateDecrease = new System.Windows.Forms.Button();
            this.BTN_DonateIncrease = new System.Windows.Forms.Button();
            this.BTN_Donate = new System.Windows.Forms.Button();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CMBX_Year = new System.Windows.Forms.ComboBox();
            this.CMBX_Month = new System.Windows.Forms.ComboBox();
            this.CMBX_Runner = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TBX_Charity = new System.Windows.Forms.TextBox();
            this.PIC_FundInfo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FundInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LBL_MarathonName);
            this.panel1.Controls.Add(this.BTN_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 79);
            this.panel1.TabIndex = 0;
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
            this.BTN_Back.Location = new System.Drawing.Point(0, 0);
            this.BTN_Back.Margin = new System.Windows.Forms.Padding(5);
            this.BTN_Back.Name = "BTN_Back";
            this.BTN_Back.Size = new System.Drawing.Size(131, 79);
            this.BTN_Back.TabIndex = 0;
            this.BTN_Back.Text = "Назад";
            this.BTN_Back.UseVisualStyleBackColor = false;
            this.BTN_Back.Click += new System.EventHandler(this.BTN_Back_Click);
            // 
            // LBL_Sponsor
            // 
            this.LBL_Sponsor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Sponsor.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Sponsor.Location = new System.Drawing.Point(0, 79);
            this.LBL_Sponsor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Sponsor.Name = "LBL_Sponsor";
            this.LBL_Sponsor.Size = new System.Drawing.Size(912, 73);
            this.LBL_Sponsor.TabIndex = 1;
            this.LBL_Sponsor.Text = "Спонсор бегуна";
            this.LBL_Sponsor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Instruction
            // 
            this.LBL_Instruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Instruction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Instruction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Instruction.Location = new System.Drawing.Point(0, 152);
            this.LBL_Instruction.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Instruction.Name = "LBL_Instruction";
            this.LBL_Instruction.Size = new System.Drawing.Size(912, 106);
            this.LBL_Instruction.TabIndex = 2;
            this.LBL_Instruction.Text = "Пожалуйста выберите бегуна, которого Вы хотели бы спонсировать и сумму,\r\nкоторую " +
    "Вы хотели бы спонсировать. Спасибо за Вашу поддержку бегунов и их\r\nблаготворител" +
    "ьных учреждений ";
            this.LBL_Instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Sponsor_Info
            // 
            this.LBL_Sponsor_Info.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Sponsor_Info.Location = new System.Drawing.Point(129, 268);
            this.LBL_Sponsor_Info.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Sponsor_Info.Name = "LBL_Sponsor_Info";
            this.LBL_Sponsor_Info.Size = new System.Drawing.Size(330, 32);
            this.LBL_Sponsor_Info.TabIndex = 3;
            this.LBL_Sponsor_Info.Text = "Информация о Спонсоре";
            // 
            // LBL_Charity
            // 
            this.LBL_Charity.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Charity.Location = new System.Drawing.Point(550, 268);
            this.LBL_Charity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Charity.Name = "LBL_Charity";
            this.LBL_Charity.Size = new System.Drawing.Size(315, 32);
            this.LBL_Charity.TabIndex = 4;
            this.LBL_Charity.Text = "Благотворительность";
            this.LBL_Charity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CharitySumm
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_CharitySumm, 3);
            this.LBL_CharitySumm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_CharitySumm.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CharitySumm.Location = new System.Drawing.Point(5, 0);
            this.LBL_CharitySumm.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_CharitySumm.Name = "LBL_CharitySumm";
            this.LBL_CharitySumm.Size = new System.Drawing.Size(340, 66);
            this.LBL_CharitySumm.TabIndex = 5;
            this.LBL_CharitySumm.Text = "Сумма пожертвования:";
            this.LBL_CharitySumm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CharityAmount
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_CharityAmount, 3);
            this.LBL_CharityAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_CharityAmount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CharityAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(29)))), ((int)(((byte)(112)))));
            this.LBL_CharityAmount.Location = new System.Drawing.Point(5, 66);
            this.LBL_CharityAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_CharityAmount.Name = "LBL_CharityAmount";
            this.LBL_CharityAmount.Size = new System.Drawing.Size(340, 66);
            this.LBL_CharityAmount.TabIndex = 6;
            this.LBL_CharityAmount.Text = "$50";
            this.LBL_CharityAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_SponsorName
            // 
            this.LBL_SponsorName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_SponsorName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_SponsorName.Location = new System.Drawing.Point(94, 0);
            this.LBL_SponsorName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_SponsorName.Name = "LBL_SponsorName";
            this.LBL_SponsorName.Size = new System.Drawing.Size(125, 44);
            this.LBL_SponsorName.TabIndex = 7;
            this.LBL_SponsorName.Text = "Ваше имя:";
            this.LBL_SponsorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Runner
            // 
            this.LBL_Runner.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_Runner.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Runner.Location = new System.Drawing.Point(138, 44);
            this.LBL_Runner.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Runner.Name = "LBL_Runner";
            this.LBL_Runner.Size = new System.Drawing.Size(81, 44);
            this.LBL_Runner.TabIndex = 8;
            this.LBL_Runner.Text = "Бегун:";
            this.LBL_Runner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_CardOwner
            // 
            this.LBL_CardOwner.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_CardOwner.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_CardOwner.Location = new System.Drawing.Point(11, 88);
            this.LBL_CardOwner.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_CardOwner.Name = "LBL_CardOwner";
            this.LBL_CardOwner.Size = new System.Drawing.Size(208, 44);
            this.LBL_CardOwner.TabIndex = 9;
            this.LBL_CardOwner.Text = "Держатель карты:";
            this.LBL_CardOwner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_CardNumber
            // 
            this.LBL_CardNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_CardNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_CardNumber.Location = new System.Drawing.Point(44, 132);
            this.LBL_CardNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_CardNumber.Name = "LBL_CardNumber";
            this.LBL_CardNumber.Size = new System.Drawing.Size(175, 44);
            this.LBL_CardNumber.TabIndex = 10;
            this.LBL_CardNumber.Text = "Номер карты#:";
            this.LBL_CardNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_CardDate
            // 
            this.LBL_CardDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_CardDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_CardDate.Location = new System.Drawing.Point(43, 176);
            this.LBL_CardDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_CardDate.Name = "LBL_CardDate";
            this.LBL_CardDate.Size = new System.Drawing.Size(176, 44);
            this.LBL_CardDate.TabIndex = 11;
            this.LBL_CardDate.Text = "Срок действия:";
            this.LBL_CardDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_CardCVC
            // 
            this.LBL_CardCVC.Dock = System.Windows.Forms.DockStyle.Right;
            this.LBL_CardCVC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_CardCVC.Location = new System.Drawing.Point(105, 220);
            this.LBL_CardCVC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_CardCVC.Name = "LBL_CardCVC";
            this.LBL_CardCVC.Size = new System.Drawing.Size(114, 46);
            this.LBL_CardCVC.TabIndex = 12;
            this.LBL_CardCVC.Text = "CVC-код:";
            this.LBL_CardCVC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBX_Name
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBX_Name, 2);
            this.TBX_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBX_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Name.Location = new System.Drawing.Point(229, 5);
            this.TBX_Name.Margin = new System.Windows.Forms.Padding(5);
            this.TBX_Name.Name = "TBX_Name";
            this.TBX_Name.Size = new System.Drawing.Size(238, 34);
            this.TBX_Name.TabIndex = 13;
            // 
            // TBX_CardOwner
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBX_CardOwner, 2);
            this.TBX_CardOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBX_CardOwner.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_CardOwner.Location = new System.Drawing.Point(229, 93);
            this.TBX_CardOwner.Margin = new System.Windows.Forms.Padding(5);
            this.TBX_CardOwner.Name = "TBX_CardOwner";
            this.TBX_CardOwner.Size = new System.Drawing.Size(238, 34);
            this.TBX_CardOwner.TabIndex = 15;
            // 
            // TBX_CardNumber
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBX_CardNumber, 2);
            this.TBX_CardNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBX_CardNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_CardNumber.Location = new System.Drawing.Point(229, 137);
            this.TBX_CardNumber.Margin = new System.Windows.Forms.Padding(5);
            this.TBX_CardNumber.MaxLength = 16;
            this.TBX_CardNumber.Name = "TBX_CardNumber";
            this.TBX_CardNumber.Size = new System.Drawing.Size(238, 34);
            this.TBX_CardNumber.TabIndex = 16;
            // 
            // TBX_CardCVC
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBX_CardCVC, 2);
            this.TBX_CardCVC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBX_CardCVC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_CardCVC.Location = new System.Drawing.Point(229, 225);
            this.TBX_CardCVC.Margin = new System.Windows.Forms.Padding(5);
            this.TBX_CardCVC.MaxLength = 3;
            this.TBX_CardCVC.Name = "TBX_CardCVC";
            this.TBX_CardCVC.Size = new System.Drawing.Size(238, 34);
            this.TBX_CardCVC.TabIndex = 18;
            // 
            // BTN_DonateDecrease
            // 
            this.BTN_DonateDecrease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_DonateDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DonateDecrease.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DonateDecrease.Location = new System.Drawing.Point(29, 137);
            this.BTN_DonateDecrease.MaximumSize = new System.Drawing.Size(55, 55);
            this.BTN_DonateDecrease.Name = "BTN_DonateDecrease";
            this.BTN_DonateDecrease.Size = new System.Drawing.Size(55, 55);
            this.BTN_DonateDecrease.TabIndex = 19;
            this.BTN_DonateDecrease.Text = "-";
            this.BTN_DonateDecrease.UseVisualStyleBackColor = true;
            this.BTN_DonateDecrease.Click += new System.EventHandler(this.BTN_DonateDecrease_Click);
            // 
            // BTN_DonateIncrease
            // 
            this.BTN_DonateIncrease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_DonateIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_DonateIncrease.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.BTN_DonateIncrease.Location = new System.Drawing.Point(260, 137);
            this.BTN_DonateIncrease.MaximumSize = new System.Drawing.Size(55, 55);
            this.BTN_DonateIncrease.Name = "BTN_DonateIncrease";
            this.BTN_DonateIncrease.Size = new System.Drawing.Size(55, 55);
            this.BTN_DonateIncrease.TabIndex = 20;
            this.BTN_DonateIncrease.Text = "+";
            this.BTN_DonateIncrease.UseVisualStyleBackColor = true;
            this.BTN_DonateIncrease.Click += new System.EventHandler(this.BTN_DonateIncrease_Click);
            // 
            // BTN_Donate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BTN_Donate, 3);
            this.BTN_Donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Donate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Donate.Location = new System.Drawing.Point(3, 201);
            this.BTN_Donate.Name = "BTN_Donate";
            this.BTN_Donate.Size = new System.Drawing.Size(344, 62);
            this.BTN_Donate.TabIndex = 22;
            this.BTN_Donate.Text = "Пожертвовать";
            this.BTN_Donate.UseVisualStyleBackColor = true;
            this.BTN_Donate.Click += new System.EventHandler(this.BTN_Donate_Click);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LBL_TimeToStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 46);
            this.panel2.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.39554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.60446F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.CMBX_Year, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.LBL_SponsorName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CMBX_Month, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Runner, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardOwner, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBX_CardCVC, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardCVC, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TBX_CardNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBX_CardOwner, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CMBX_Runner, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 307);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 266);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // CMBX_Year
            // 
            this.CMBX_Year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMBX_Year.FormattingEnabled = true;
            this.CMBX_Year.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2029",
            "2030",
            "2031",
            "2032",
            "2034",
            "2035"});
            this.CMBX_Year.Location = new System.Drawing.Point(364, 181);
            this.CMBX_Year.Margin = new System.Windows.Forms.Padding(5);
            this.CMBX_Year.Name = "CMBX_Year";
            this.CMBX_Year.Size = new System.Drawing.Size(103, 33);
            this.CMBX_Year.TabIndex = 28;
            // 
            // CMBX_Month
            // 
            this.CMBX_Month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMBX_Month.FormattingEnabled = true;
            this.CMBX_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CMBX_Month.Location = new System.Drawing.Point(229, 181);
            this.CMBX_Month.Margin = new System.Windows.Forms.Padding(5);
            this.CMBX_Month.Name = "CMBX_Month";
            this.CMBX_Month.Size = new System.Drawing.Size(125, 33);
            this.CMBX_Month.TabIndex = 27;
            // 
            // CMBX_Runner
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CMBX_Runner, 2);
            this.CMBX_Runner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CMBX_Runner.FormattingEnabled = true;
            this.CMBX_Runner.Location = new System.Drawing.Point(227, 47);
            this.CMBX_Runner.Name = "CMBX_Runner";
            this.CMBX_Runner.Size = new System.Drawing.Size(242, 33);
            this.CMBX_Runner.TabIndex = 28;
            this.CMBX_Runner.SelectionChangeCommitted += new System.EventHandler(this.CMBX_Runner_SelectionChangeCommitted);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Donate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CharitySumm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CharityAmount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_DonateDecrease, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BTN_DonateIncrease, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.TBX_Charity, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(550, 307);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 266);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // TBX_Charity
            // 
            this.TBX_Charity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBX_Charity.Location = new System.Drawing.Point(119, 148);
            this.TBX_Charity.Margin = new System.Windows.Forms.Padding(5);
            this.TBX_Charity.Name = "TBX_Charity";
            this.TBX_Charity.Size = new System.Drawing.Size(100, 34);
            this.TBX_Charity.TabIndex = 23;
            this.TBX_Charity.TextChanged += new System.EventHandler(this.TBX_Charity_TextChanged);
            // 
            // PIC_FundInfo
            // 
            this.PIC_FundInfo.Image = ((System.Drawing.Image)(resources.GetObject("PIC_FundInfo.Image")));
            this.PIC_FundInfo.Location = new System.Drawing.Point(868, 268);
            this.PIC_FundInfo.Name = "PIC_FundInfo";
            this.PIC_FundInfo.Size = new System.Drawing.Size(32, 32);
            this.PIC_FundInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_FundInfo.TabIndex = 27;
            this.PIC_FundInfo.TabStop = false;
            this.PIC_FundInfo.Click += new System.EventHandler(this.PIC_FundInfo_Click);
            // 
            // Sponsor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(912, 641);
            this.Controls.Add(this.PIC_FundInfo);
            this.Controls.Add(this.LBL_Charity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LBL_Sponsor_Info);
            this.Controls.Add(this.LBL_Instruction);
            this.Controls.Add(this.LBL_Sponsor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(930, 688);
            this.MinimumSize = new System.Drawing.Size(930, 688);
            this.Name = "Sponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sponsor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FundInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.Label LBL_Sponsor;
        private System.Windows.Forms.Label LBL_Instruction;
        private System.Windows.Forms.Label LBL_Sponsor_Info;
        private System.Windows.Forms.Label LBL_CharitySumm;
        private System.Windows.Forms.Label LBL_CharityAmount;
        private System.Windows.Forms.Label LBL_SponsorName;
        private System.Windows.Forms.Label LBL_Runner;
        private System.Windows.Forms.Label LBL_CardOwner;
        private System.Windows.Forms.Label LBL_CardNumber;
        private System.Windows.Forms.Label LBL_CardDate;
        private System.Windows.Forms.Label LBL_CardCVC;
        private System.Windows.Forms.TextBox TBX_Name;
        private System.Windows.Forms.TextBox TBX_CardOwner;
        private System.Windows.Forms.TextBox TBX_CardNumber;
        private System.Windows.Forms.TextBox TBX_CardCVC;
        private System.Windows.Forms.Label LBL_Charity;
        private System.Windows.Forms.Button BTN_DonateDecrease;
        private System.Windows.Forms.Button BTN_DonateIncrease;
        private System.Windows.Forms.Button BTN_Donate;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox CMBX_Runner;
        private System.Windows.Forms.ComboBox CMBX_Month;
        private System.Windows.Forms.ComboBox CMBX_Year;
        private System.Windows.Forms.TextBox TBX_Charity;
        private System.Windows.Forms.PictureBox PIC_FundInfo;
    }
}