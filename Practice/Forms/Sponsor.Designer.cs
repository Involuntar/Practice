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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_Donate = new System.Windows.Forms.Button();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LBL_MarathonName);
            this.panel1.Controls.Add(this.BTN_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 79);
            this.panel1.TabIndex = 0;
            // 
            // BTN_Back
            // 
            this.BTN_Back.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_Back.Location = new System.Drawing.Point(0, 0);
            this.BTN_Back.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.LBL_Charity.Location = new System.Drawing.Point(563, 268);
            this.LBL_Charity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_Charity.Name = "LBL_Charity";
            this.LBL_Charity.Size = new System.Drawing.Size(326, 32);
            this.LBL_Charity.TabIndex = 4;
            this.LBL_Charity.Text = "Благотворительность";
            this.LBL_Charity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CharitySumm
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_CharitySumm, 2);
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
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_CharityAmount, 2);
            this.LBL_CharityAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_CharityAmount.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CharityAmount.ForeColor = System.Drawing.SystemColors.ControlDark;
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
            this.LBL_SponsorName.Location = new System.Drawing.Point(104, 0);
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
            this.LBL_Runner.Location = new System.Drawing.Point(148, 44);
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
            this.LBL_CardOwner.Location = new System.Drawing.Point(21, 88);
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
            this.LBL_CardNumber.Location = new System.Drawing.Point(54, 132);
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
            this.LBL_CardDate.Location = new System.Drawing.Point(53, 176);
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
            this.LBL_CardCVC.Location = new System.Drawing.Point(115, 220);
            this.LBL_CardCVC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_CardCVC.Name = "LBL_CardCVC";
            this.LBL_CardCVC.Size = new System.Drawing.Size(114, 46);
            this.LBL_CardCVC.TabIndex = 12;
            this.LBL_CardCVC.Text = "CVC-код:";
            this.LBL_CardCVC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(239, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 34);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(239, 49);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 34);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(239, 93);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 34);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(239, 137);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(225, 34);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(239, 181);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(225, 34);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(239, 225);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(225, 34);
            this.textBox6.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(60, 137);
            this.button1.MaximumSize = new System.Drawing.Size(55, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(235, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 20;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTN_Donate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BTN_Donate, 2);
            this.BTN_Donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Donate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Donate.Location = new System.Drawing.Point(3, 201);
            this.BTN_Donate.Name = "BTN_Donate";
            this.BTN_Donate.Size = new System.Drawing.Size(344, 62);
            this.BTN_Donate.TabIndex = 22;
            this.BTN_Donate.Text = "Пожертвовать";
            this.BTN_Donate.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_SponsorName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Runner, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardOwner, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LBL_CardCVC, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 307);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 266);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Donate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CharitySumm, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CharityAmount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
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
            // Sponsor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(912, 641);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(930, 688);
            this.MinimumSize = new System.Drawing.Size(930, 688);
            this.Name = "Sponsor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спонсирование";
            this.Load += new System.EventHandler(this.Sponsor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label LBL_Charity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_Donate;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}