namespace Practice
{
    partial class Marathon
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBL_TimeToStart = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBL_MarathonPlace = new System.Windows.Forms.Label();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Runner = new System.Windows.Forms.Button();
            this.BTN_Sponsor = new System.Windows.Forms.Button();
            this.BTN_About_event = new System.Windows.Forms.Button();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_TimeToStart
            // 
            this.LBL_TimeToStart.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TimeToStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_TimeToStart.Location = new System.Drawing.Point(0, 0);
            this.LBL_TimeToStart.Name = "LBL_TimeToStart";
            this.LBL_TimeToStart.Size = new System.Drawing.Size(947, 46);
            this.LBL_TimeToStart.TabIndex = 0;
            this.LBL_TimeToStart.Text = "Время до";
            this.LBL_TimeToStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_TimeToStart.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LBL_TimeToStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 46);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.LBL_MarathonPlace);
            this.panel2.Controls.Add(this.LBL_MarathonName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 201);
            this.panel2.TabIndex = 2;
            // 
            // LBL_MarathonPlace
            // 
            this.LBL_MarathonPlace.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_MarathonPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MarathonPlace.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LBL_MarathonPlace.Location = new System.Drawing.Point(0, 106);
            this.LBL_MarathonPlace.Name = "LBL_MarathonPlace";
            this.LBL_MarathonPlace.Size = new System.Drawing.Size(947, 49);
            this.LBL_MarathonPlace.TabIndex = 1;
            this.LBL_MarathonPlace.Text = "Нижний Тагил, Россия\r\n14 сентября 2024";
            this.LBL_MarathonPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_MarathonName
            // 
            this.LBL_MarathonName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_MarathonName.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MarathonName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LBL_MarathonName.Location = new System.Drawing.Point(0, 0);
            this.LBL_MarathonName.Name = "LBL_MarathonName";
            this.LBL_MarathonName.Size = new System.Drawing.Size(947, 106);
            this.LBL_MarathonName.TabIndex = 0;
            this.LBL_MarathonName.Text = "Marathon Skills 2024";
            this.LBL_MarathonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Runner
            // 
            this.BTN_Runner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Runner.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Runner.Location = new System.Drawing.Point(290, 209);
            this.BTN_Runner.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Runner.Name = "BTN_Runner";
            this.BTN_Runner.Size = new System.Drawing.Size(365, 80);
            this.BTN_Runner.TabIndex = 3;
            this.BTN_Runner.Text = "Я хочу стать бегуном";
            this.BTN_Runner.UseVisualStyleBackColor = true;
            // 
            // BTN_Sponsor
            // 
            this.BTN_Sponsor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sponsor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Sponsor.Location = new System.Drawing.Point(290, 299);
            this.BTN_Sponsor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_Sponsor.Name = "BTN_Sponsor";
            this.BTN_Sponsor.Size = new System.Drawing.Size(365, 80);
            this.BTN_Sponsor.TabIndex = 4;
            this.BTN_Sponsor.Text = "Я хочу стать спонсором бегуна";
            this.BTN_Sponsor.UseVisualStyleBackColor = true;
            this.BTN_Sponsor.Click += new System.EventHandler(this.BTN_Sponsor_Click);
            // 
            // BTN_About_event
            // 
            this.BTN_About_event.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_About_event.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_About_event.Location = new System.Drawing.Point(290, 389);
            this.BTN_About_event.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BTN_About_event.Name = "BTN_About_event";
            this.BTN_About_event.Size = new System.Drawing.Size(365, 80);
            this.BTN_About_event.TabIndex = 5;
            this.BTN_About_event.Text = "Я хочу узнать больше о событии";
            this.BTN_About_event.UseVisualStyleBackColor = true;
            // 
            // BTN_Login
            // 
            this.BTN_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Login.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(812, 470);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(107, 31);
            this.BTN_Login.TabIndex = 6;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            // 
            // Marathon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 553);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.BTN_About_event);
            this.Controls.Add(this.BTN_Sponsor);
            this.Controls.Add(this.BTN_Runner);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(965, 600);
            this.Name = "Marathon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Марафон";
            this.Load += new System.EventHandler(this.Marathon_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_TimeToStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Runner;
        private System.Windows.Forms.Button BTN_Sponsor;
        private System.Windows.Forms.Button BTN_About_event;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Label LBL_MarathonPlace;
        private System.Windows.Forms.Label LBL_MarathonName;
    }
}

