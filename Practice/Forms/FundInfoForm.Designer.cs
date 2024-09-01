namespace Practice.Forms
{
    partial class FundInfoForm
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
            this.LBL_CharityName = new System.Windows.Forms.Label();
            this.PIC_FundLogo = new System.Windows.Forms.PictureBox();
            this.RTBX_FundDesc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FundLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_CharityName
            // 
            this.LBL_CharityName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(62)))));
            this.LBL_CharityName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_CharityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CharityName.Location = new System.Drawing.Point(0, 0);
            this.LBL_CharityName.Name = "LBL_CharityName";
            this.LBL_CharityName.Size = new System.Drawing.Size(467, 76);
            this.LBL_CharityName.TabIndex = 0;
            this.LBL_CharityName.Text = "Наименование фонда";
            this.LBL_CharityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PIC_FundLogo
            // 
            this.PIC_FundLogo.BackColor = System.Drawing.Color.White;
            this.PIC_FundLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PIC_FundLogo.Location = new System.Drawing.Point(0, 76);
            this.PIC_FundLogo.Name = "PIC_FundLogo";
            this.PIC_FundLogo.Size = new System.Drawing.Size(467, 140);
            this.PIC_FundLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PIC_FundLogo.TabIndex = 2;
            this.PIC_FundLogo.TabStop = false;
            // 
            // RTBX_FundDesc
            // 
            this.RTBX_FundDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RTBX_FundDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RTBX_FundDesc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RTBX_FundDesc.Location = new System.Drawing.Point(0, 222);
            this.RTBX_FundDesc.Name = "RTBX_FundDesc";
            this.RTBX_FundDesc.ReadOnly = true;
            this.RTBX_FundDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTBX_FundDesc.Size = new System.Drawing.Size(467, 127);
            this.RTBX_FundDesc.TabIndex = 3;
            this.RTBX_FundDesc.Text = "";
            // 
            // FundInfoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(467, 349);
            this.Controls.Add(this.PIC_FundLogo);
            this.Controls.Add(this.LBL_CharityName);
            this.Controls.Add(this.RTBX_FundDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FundInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о фонде";
            this.Load += new System.EventHandler(this.FundInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_FundLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_CharityName;
        private System.Windows.Forms.PictureBox PIC_FundLogo;
        private System.Windows.Forms.RichTextBox RTBX_FundDesc;
    }
}