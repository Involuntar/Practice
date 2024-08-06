namespace Practice.Forms
{
    partial class RunnerRegistration
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
            this.LBL_RunnerRegister = new System.Windows.Forms.Label();
            this.LBL_RegisterDesc = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.LBL_RepPassword = new System.Windows.Forms.Label();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_Lastname = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LBL_Sex = new System.Windows.Forms.Label();
            this.LBL_BirthDate = new System.Windows.Forms.Label();
            this.LBL_Country = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_RunnerRegister
            // 
            this.LBL_RunnerRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_RunnerRegister.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_RunnerRegister.Location = new System.Drawing.Point(0, 79);
            this.LBL_RunnerRegister.Name = "LBL_RunnerRegister";
            this.LBL_RunnerRegister.Size = new System.Drawing.Size(912, 45);
            this.LBL_RunnerRegister.TabIndex = 0;
            this.LBL_RunnerRegister.Text = "Регистрация бегуна";
            this.LBL_RunnerRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_RegisterDesc
            // 
            this.LBL_RegisterDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_RegisterDesc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_RegisterDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_RegisterDesc.Location = new System.Drawing.Point(0, 124);
            this.LBL_RegisterDesc.Name = "LBL_RegisterDesc";
            this.LBL_RegisterDesc.Size = new System.Drawing.Size(912, 76);
            this.LBL_RegisterDesc.TabIndex = 1;
            this.LBL_RegisterDesc.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве \r\nбегуна" +
    "";
            this.LBL_RegisterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Email
            // 
            this.LBL_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Email.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Email.Location = new System.Drawing.Point(3, 0);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(213, 59);
            this.LBL_Email.TabIndex = 2;
            this.LBL_Email.Text = "Email:";
            this.LBL_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Password
            // 
            this.LBL_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Password.Location = new System.Drawing.Point(3, 59);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(213, 59);
            this.LBL_Password.TabIndex = 3;
            this.LBL_Password.Text = "Пароль:";
            this.LBL_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_RepPassword
            // 
            this.LBL_RepPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_RepPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_RepPassword.Location = new System.Drawing.Point(3, 118);
            this.LBL_RepPassword.Name = "LBL_RepPassword";
            this.LBL_RepPassword.Size = new System.Drawing.Size(213, 59);
            this.LBL_RepPassword.TabIndex = 4;
            this.LBL_RepPassword.Text = "Повторите пароль:";
            this.LBL_RepPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Name
            // 
            this.LBL_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Name.Location = new System.Drawing.Point(3, 177);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(213, 59);
            this.LBL_Name.TabIndex = 5;
            this.LBL_Name.Text = "Имя:";
            this.LBL_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Lastname
            // 
            this.LBL_Lastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Lastname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Lastname.Location = new System.Drawing.Point(3, 236);
            this.LBL_Lastname.Name = "LBL_Lastname";
            this.LBL_Lastname.Size = new System.Drawing.Size(213, 61);
            this.LBL_Lastname.TabIndex = 6;
            this.LBL_Lastname.Text = "Фамилия:";
            this.LBL_Lastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(660, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 31);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(660, 135);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(216, 31);
            this.comboBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(660, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // LBL_Sex
            // 
            this.LBL_Sex.AutoSize = true;
            this.LBL_Sex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Sex.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Sex.Location = new System.Drawing.Point(441, 0);
            this.LBL_Sex.Name = "LBL_Sex";
            this.LBL_Sex.Size = new System.Drawing.Size(213, 59);
            this.LBL_Sex.TabIndex = 10;
            this.LBL_Sex.Text = "Пол:";
            this.LBL_Sex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_BirthDate
            // 
            this.LBL_BirthDate.AutoSize = true;
            this.LBL_BirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_BirthDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_BirthDate.Location = new System.Drawing.Point(441, 59);
            this.LBL_BirthDate.Name = "LBL_BirthDate";
            this.LBL_BirthDate.Size = new System.Drawing.Size(213, 59);
            this.LBL_BirthDate.TabIndex = 11;
            this.LBL_BirthDate.Text = "Дата рождения:";
            this.LBL_BirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Country
            // 
            this.LBL_Country.AutoSize = true;
            this.LBL_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Country.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Country.Location = new System.Drawing.Point(441, 118);
            this.LBL_Country.Name = "LBL_Country";
            this.LBL_Country.Size = new System.Drawing.Size(213, 59);
            this.LBL_Country.TabIndex = 12;
            this.LBL_Country.Text = "Страна:";
            this.LBL_Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LBL_MarathonName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 79);
            this.panel1.TabIndex = 13;
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
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 46);
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(222, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 30);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(222, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 30);
            this.textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(222, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 30);
            this.textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(222, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 30);
            this.textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(222, 251);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 30);
            this.textBox5.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Country, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_BirthDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Sex, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Email, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_RepPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Name, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Lastname, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 215);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 297);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // RunnerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 641);
            this.Controls.Add(this.LBL_RegisterDesc);
            this.Controls.Add(this.LBL_RunnerRegister);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RunnerRegistration";
            this.Text = "RunnerRegistration";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_RunnerRegister;
        private System.Windows.Forms.Label LBL_RegisterDesc;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Label LBL_RepPassword;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_Lastname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LBL_Sex;
        private System.Windows.Forms.Label LBL_BirthDate;
        private System.Windows.Forms.Label LBL_Country;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}