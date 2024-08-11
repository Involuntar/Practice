﻿namespace Practice.Forms
{
    partial class EditProfile
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
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.TBX_RepPassword = new System.Windows.Forms.TextBox();
            this.TBX_Name = new System.Windows.Forms.TextBox();
            this.LBL_Country = new System.Windows.Forms.Label();
            this.TBX_Lastname = new System.Windows.Forms.TextBox();
            this.CMBX_Country = new System.Windows.Forms.ComboBox();
            this.LBL_BirthDate = new System.Windows.Forms.Label();
            this.DtPck_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.LBL_Sex = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.LBL_RepPassword = new System.Windows.Forms.Label();
            this.CMBX_Sex = new System.Windows.Forms.ComboBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_Lastname = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_RegisterDesc = new System.Windows.Forms.Label();
            this.LBL_RunnerRegister = new System.Windows.Forms.Label();
            this.LBL_UserEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Cancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Cancel.Location = new System.Drawing.Point(510, 535);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(20);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(127, 38);
            this.BTN_Cancel.TabIndex = 40;
            this.BTN_Cancel.Text = "Отмена";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_Email, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_UserEmail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Lastname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Sex, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_BirthDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Country, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Lastname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CMBX_Sex, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DtPck_BirthDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CMBX_Country, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Password, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_RepPassword, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Password, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBX_RepPassword, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 215);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 297);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // TBX_Password
            // 
            this.TBX_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Password.Location = new System.Drawing.Point(660, 107);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.Size = new System.Drawing.Size(216, 30);
            this.TBX_Password.TabIndex = 27;
            // 
            // TBX_RepPassword
            // 
            this.TBX_RepPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_RepPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_RepPassword.Location = new System.Drawing.Point(660, 156);
            this.TBX_RepPassword.Name = "TBX_RepPassword";
            this.TBX_RepPassword.Size = new System.Drawing.Size(216, 30);
            this.TBX_RepPassword.TabIndex = 28;
            // 
            // TBX_Name
            // 
            this.TBX_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Name.Location = new System.Drawing.Point(222, 58);
            this.TBX_Name.Name = "TBX_Name";
            this.TBX_Name.Size = new System.Drawing.Size(213, 30);
            this.TBX_Name.TabIndex = 29;
            // 
            // LBL_Country
            // 
            this.LBL_Country.AutoSize = true;
            this.LBL_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Country.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Country.Location = new System.Drawing.Point(3, 245);
            this.LBL_Country.Name = "LBL_Country";
            this.LBL_Country.Size = new System.Drawing.Size(213, 52);
            this.LBL_Country.TabIndex = 12;
            this.LBL_Country.Text = "Страна:";
            this.LBL_Country.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBX_Lastname
            // 
            this.TBX_Lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX_Lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Lastname.Location = new System.Drawing.Point(222, 107);
            this.TBX_Lastname.Name = "TBX_Lastname";
            this.TBX_Lastname.Size = new System.Drawing.Size(213, 30);
            this.TBX_Lastname.TabIndex = 30;
            // 
            // CMBX_Country
            // 
            this.CMBX_Country.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBX_Country.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBX_Country.FormattingEnabled = true;
            this.CMBX_Country.Location = new System.Drawing.Point(222, 255);
            this.CMBX_Country.Name = "CMBX_Country";
            this.CMBX_Country.Size = new System.Drawing.Size(213, 31);
            this.CMBX_Country.TabIndex = 8;
            // 
            // LBL_BirthDate
            // 
            this.LBL_BirthDate.AutoSize = true;
            this.LBL_BirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_BirthDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_BirthDate.Location = new System.Drawing.Point(3, 196);
            this.LBL_BirthDate.Name = "LBL_BirthDate";
            this.LBL_BirthDate.Size = new System.Drawing.Size(213, 49);
            this.LBL_BirthDate.TabIndex = 11;
            this.LBL_BirthDate.Text = "Дата рождения:";
            this.LBL_BirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DtPck_BirthDate
            // 
            this.DtPck_BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtPck_BirthDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtPck_BirthDate.Location = new System.Drawing.Point(222, 205);
            this.DtPck_BirthDate.Name = "DtPck_BirthDate";
            this.DtPck_BirthDate.Size = new System.Drawing.Size(213, 30);
            this.DtPck_BirthDate.TabIndex = 9;
            this.DtPck_BirthDate.Value = new System.DateTime(2024, 8, 6, 21, 56, 22, 0);
            // 
            // LBL_Sex
            // 
            this.LBL_Sex.AutoSize = true;
            this.LBL_Sex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Sex.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Sex.Location = new System.Drawing.Point(3, 147);
            this.LBL_Sex.Name = "LBL_Sex";
            this.LBL_Sex.Size = new System.Drawing.Size(213, 49);
            this.LBL_Sex.TabIndex = 10;
            this.LBL_Sex.Text = "Пол:";
            this.LBL_Sex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Email
            // 
            this.LBL_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Email.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Email.Location = new System.Drawing.Point(3, 0);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(213, 49);
            this.LBL_Email.TabIndex = 2;
            this.LBL_Email.Text = "Email:";
            this.LBL_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Password
            // 
            this.LBL_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Password.Location = new System.Drawing.Point(441, 98);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(213, 49);
            this.LBL_Password.TabIndex = 3;
            this.LBL_Password.Text = "Пароль:";
            this.LBL_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_RepPassword
            // 
            this.LBL_RepPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_RepPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_RepPassword.Location = new System.Drawing.Point(441, 147);
            this.LBL_RepPassword.Name = "LBL_RepPassword";
            this.LBL_RepPassword.Size = new System.Drawing.Size(213, 49);
            this.LBL_RepPassword.TabIndex = 4;
            this.LBL_RepPassword.Text = "Повторите пароль:";
            this.LBL_RepPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CMBX_Sex
            // 
            this.CMBX_Sex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBX_Sex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBX_Sex.FormattingEnabled = true;
            this.CMBX_Sex.Location = new System.Drawing.Point(222, 156);
            this.CMBX_Sex.Name = "CMBX_Sex";
            this.CMBX_Sex.Size = new System.Drawing.Size(213, 31);
            this.CMBX_Sex.TabIndex = 7;
            // 
            // LBL_Name
            // 
            this.LBL_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Name.Location = new System.Drawing.Point(3, 49);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(213, 49);
            this.LBL_Name.TabIndex = 5;
            this.LBL_Name.Text = "Имя:";
            this.LBL_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_Lastname
            // 
            this.LBL_Lastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Lastname.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Lastname.Location = new System.Drawing.Point(3, 98);
            this.LBL_Lastname.Name = "LBL_Lastname";
            this.LBL_Lastname.Size = new System.Drawing.Size(213, 49);
            this.LBL_Lastname.TabIndex = 6;
            this.LBL_Lastname.Text = "Фамилия:";
            this.LBL_Lastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LBL_TimeToStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 46);
            this.panel2.TabIndex = 37;
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
            // BTN_Register
            // 
            this.BTN_Register.BackColor = System.Drawing.SystemColors.Menu;
            this.BTN_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic);
            this.BTN_Register.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Register.Location = new System.Drawing.Point(316, 535);
            this.BTN_Register.Margin = new System.Windows.Forms.Padding(20);
            this.BTN_Register.Name = "BTN_Register";
            this.BTN_Register.Size = new System.Drawing.Size(138, 38);
            this.BTN_Register.TabIndex = 39;
            this.BTN_Register.Text = "Регистрация";
            this.BTN_Register.UseVisualStyleBackColor = false;
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
            this.panel1.TabIndex = 36;
            // 
            // LBL_RegisterDesc
            // 
            this.LBL_RegisterDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_RegisterDesc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_RegisterDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_RegisterDesc.Location = new System.Drawing.Point(0, 124);
            this.LBL_RegisterDesc.Name = "LBL_RegisterDesc";
            this.LBL_RegisterDesc.Size = new System.Drawing.Size(912, 76);
            this.LBL_RegisterDesc.TabIndex = 35;
            this.LBL_RegisterDesc.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве \r\nбегуна" +
    "";
            this.LBL_RegisterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_RunnerRegister
            // 
            this.LBL_RunnerRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_RunnerRegister.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_RunnerRegister.Location = new System.Drawing.Point(0, 79);
            this.LBL_RunnerRegister.Name = "LBL_RunnerRegister";
            this.LBL_RunnerRegister.Size = new System.Drawing.Size(912, 45);
            this.LBL_RunnerRegister.TabIndex = 34;
            this.LBL_RunnerRegister.Text = "Регистрация бегуна";
            this.LBL_RunnerRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_UserEmail
            // 
            this.LBL_UserEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_UserEmail.AutoSize = true;
            this.LBL_UserEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_UserEmail.Location = new System.Drawing.Point(222, 11);
            this.LBL_UserEmail.Name = "LBL_UserEmail";
            this.LBL_UserEmail.Size = new System.Drawing.Size(213, 26);
            this.LBL_UserEmail.TabIndex = 31;
            this.LBL_UserEmail.Text = "email@email.email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(441, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 49);
            this.label2.TabIndex = 32;
            this.label2.Text = "Смена пароля";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(441, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 49);
            this.label3.TabIndex = 33;
            this.label3.Text = "Оставьте эти поля, незаполненными, \r\nесли Вы не хотите изменять пароль.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 641);
            this.Controls.Add(this.LBL_RegisterDesc);
            this.Controls.Add(this.LBL_RunnerRegister);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BTN_Register);
            this.Controls.Add(this.panel1);
            this.Name = "EditProfile";
            this.Text = "EditForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.TextBox TBX_RepPassword;
        private System.Windows.Forms.TextBox TBX_Name;
        private System.Windows.Forms.Label LBL_Country;
        private System.Windows.Forms.TextBox TBX_Lastname;
        private System.Windows.Forms.ComboBox CMBX_Country;
        private System.Windows.Forms.Label LBL_BirthDate;
        private System.Windows.Forms.DateTimePicker DtPck_BirthDate;
        private System.Windows.Forms.Label LBL_Sex;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Label LBL_RepPassword;
        private System.Windows.Forms.ComboBox CMBX_Sex;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_Lastname;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Button BTN_Register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_RegisterDesc;
        private System.Windows.Forms.Label LBL_RunnerRegister;
        private System.Windows.Forms.Label LBL_UserEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}