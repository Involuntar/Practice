namespace Practice.Forms
{
    partial class LoginForm
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
            this.LBL_LoginForm = new System.Windows.Forms.Label();
            this.LBL_LoginDesc = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TBX_Email = new System.Windows.Forms.TextBox();
            this.TBX_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_LoginForm
            // 
            this.LBL_LoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_LoginForm.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_LoginForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_LoginForm.Location = new System.Drawing.Point(0, 79);
            this.LBL_LoginForm.Name = "LBL_LoginForm";
            this.LBL_LoginForm.Size = new System.Drawing.Size(800, 50);
            this.LBL_LoginForm.TabIndex = 0;
            this.LBL_LoginForm.Text = "Форма авторизации";
            this.LBL_LoginForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LBL_LoginDesc
            // 
            this.LBL_LoginDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_LoginDesc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_LoginDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_LoginDesc.Location = new System.Drawing.Point(0, 129);
            this.LBL_LoginDesc.Name = "LBL_LoginDesc";
            this.LBL_LoginDesc.Size = new System.Drawing.Size(800, 59);
            this.LBL_LoginDesc.TabIndex = 1;
            this.LBL_LoginDesc.Text = "Пожалуйста, авторизуйтесь в системе, используя Ваш адрес электронной почты \r\nи па" +
    "роль.";
            this.LBL_LoginDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Email.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Email.Location = new System.Drawing.Point(3, 0);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(117, 49);
            this.LBL_Email.TabIndex = 2;
            this.LBL_Email.Text = "Email";
            this.LBL_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Password.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Password.Location = new System.Drawing.Point(3, 49);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(117, 50);
            this.LBL_Password.TabIndex = 3;
            this.LBL_Password.Text = "Password";
            this.LBL_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Login.AutoSize = true;
            this.BTN_Login.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BTN_Login.Location = new System.Drawing.Point(168, 108);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(75, 32);
            this.BTN_Login.TabIndex = 4;
            this.BTN_Login.Text = "Войти";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_Cancel.AutoSize = true;
            this.BTN_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.BTN_Cancel.Location = new System.Drawing.Point(249, 108);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(85, 32);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "Отмена";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // TBX_Email
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBX_Email, 3);
            this.TBX_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBX_Email.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TBX_Email.Location = new System.Drawing.Point(133, 10);
            this.TBX_Email.Margin = new System.Windows.Forms.Padding(10);
            this.TBX_Email.Name = "TBX_Email";
            this.TBX_Email.Size = new System.Drawing.Size(351, 30);
            this.TBX_Email.TabIndex = 6;
            // 
            // TBX_Password
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBX_Password, 3);
            this.TBX_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBX_Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TBX_Password.Location = new System.Drawing.Point(133, 59);
            this.TBX_Password.Margin = new System.Windows.Forms.Padding(10);
            this.TBX_Password.Name = "TBX_Password";
            this.TBX_Password.Size = new System.Drawing.Size(351, 30);
            this.TBX_Password.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LBL_MarathonName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 8;
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
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 46);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_Email, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Email, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBX_Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Cancel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Login, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 191);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 150);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_LoginDesc);
            this.Controls.Add(this.LBL_LoginForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_LoginForm;
        private System.Windows.Forms.Label LBL_LoginDesc;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TBX_Email;
        private System.Windows.Forms.TextBox TBX_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}