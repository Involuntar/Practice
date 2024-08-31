namespace Practice.Forms
{
    partial class CertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CertificateForm));
            this.PIC_Logo = new System.Windows.Forms.PictureBox();
            this.LBL_Congrats = new System.Windows.Forms.Label();
            this.PIC_Seal = new System.Windows.Forms.PictureBox();
            this.LBL_Certificate = new System.Windows.Forms.Label();
            this.LBL_CharityAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_Logout = new System.Windows.Forms.Button();
            this.LBL_MarathonName = new System.Windows.Forms.Label();
            this.BTN_Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Seal)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PIC_Logo
            // 
            this.PIC_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIC_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PIC_Logo.Image")));
            this.PIC_Logo.Location = new System.Drawing.Point(329, 3);
            this.PIC_Logo.Name = "PIC_Logo";
            this.PIC_Logo.Size = new System.Drawing.Size(320, 117);
            this.PIC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_Logo.TabIndex = 1;
            this.PIC_Logo.TabStop = false;
            // 
            // LBL_Congrats
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_Congrats, 3);
            this.LBL_Congrats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Congrats.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LBL_Congrats.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Congrats.Location = new System.Drawing.Point(3, 123);
            this.LBL_Congrats.Name = "LBL_Congrats";
            this.LBL_Congrats.Size = new System.Drawing.Size(973, 101);
            this.LBL_Congrats.TabIndex = 2;
            this.LBL_Congrats.Text = "Поздравляем Имя Фамилия с участием в 42km полном марафоне. Ваши\r\nрезультаты: врем" +
    "я 4:13:45 и занятое место 183!";
            this.LBL_Congrats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PIC_Seal
            // 
            this.PIC_Seal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PIC_Seal.Image = ((System.Drawing.Image)(resources.GetObject("PIC_Seal.Image")));
            this.PIC_Seal.Location = new System.Drawing.Point(655, 469);
            this.PIC_Seal.Name = "PIC_Seal";
            this.PIC_Seal.Size = new System.Drawing.Size(321, 151);
            this.PIC_Seal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_Seal.TabIndex = 3;
            this.PIC_Seal.TabStop = false;
            // 
            // LBL_Certificate
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.LBL_Certificate, 3);
            this.LBL_Certificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Certificate.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold);
            this.LBL_Certificate.Location = new System.Drawing.Point(3, 224);
            this.LBL_Certificate.Name = "LBL_Certificate";
            this.LBL_Certificate.Size = new System.Drawing.Size(973, 242);
            this.LBL_Certificate.TabIndex = 4;
            this.LBL_Certificate.Text = "Сертификат участника \r\nв\r\nMarathon Skills 2024\r\nНижний Тагил, Россия";
            this.LBL_Certificate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_CharityAmount
            // 
            this.LBL_CharityAmount.AutoSize = true;
            this.LBL_CharityAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_CharityAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CharityAmount.Location = new System.Drawing.Point(329, 466);
            this.LBL_CharityAmount.Name = "LBL_CharityAmount";
            this.LBL_CharityAmount.Size = new System.Drawing.Size(320, 157);
            this.LBL_CharityAmount.TabIndex = 5;
            this.LBL_CharityAmount.Text = "Вы также заработали $1,000\r\nдля вашей благотворительной организации";
            this.LBL_CharityAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel2.Size = new System.Drawing.Size(979, 79);
            this.panel2.TabIndex = 10;
            // 
            // BTN_Logout
            // 
            this.BTN_Logout.BackColor = System.Drawing.Color.DarkGray;
            this.BTN_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Logout.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.BTN_Logout.Location = new System.Drawing.Point(848, 0);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.PIC_Logo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PIC_Seal, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.LBL_CharityAmount, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.LBL_Congrats, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_Certificate, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.69407F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.21188F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.8443F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(979, 623);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // CertificateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(979, 702);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CertificateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CertificateForm";
            this.Load += new System.EventHandler(this.CertificateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Seal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PIC_Logo;
        private System.Windows.Forms.Label LBL_Congrats;
        private System.Windows.Forms.PictureBox PIC_Seal;
        private System.Windows.Forms.Label LBL_Certificate;
        private System.Windows.Forms.Label LBL_CharityAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_Logout;
        private System.Windows.Forms.Label LBL_MarathonName;
        private System.Windows.Forms.Button BTN_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}