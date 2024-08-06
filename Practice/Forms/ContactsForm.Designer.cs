namespace Practice.Forms
{
    partial class ContactsForm
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
            this.LBL_Contacts = new System.Windows.Forms.Label();
            this.LBL_ContactsDesc = new System.Windows.Forms.Label();
            this.LBL_Phone = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Contacts
            // 
            this.LBL_Contacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Contacts.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.LBL_Contacts.Location = new System.Drawing.Point(0, 0);
            this.LBL_Contacts.Name = "LBL_Contacts";
            this.LBL_Contacts.Size = new System.Drawing.Size(603, 70);
            this.LBL_Contacts.TabIndex = 0;
            this.LBL_Contacts.Text = "Контакты";
            this.LBL_Contacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_ContactsDesc
            // 
            this.LBL_ContactsDesc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ContactsDesc.Location = new System.Drawing.Point(24, 80);
            this.LBL_ContactsDesc.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.LBL_ContactsDesc.Name = "LBL_ContactsDesc";
            this.LBL_ContactsDesc.Size = new System.Drawing.Size(555, 66);
            this.LBL_ContactsDesc.TabIndex = 1;
            this.LBL_ContactsDesc.Text = "Для получения дополнительной информации \r\nпожалуйста свяжитесь с координаторами";
            // 
            // LBL_Phone
            // 
            this.LBL_Phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LBL_Phone.AutoSize = true;
            this.LBL_Phone.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Phone.Location = new System.Drawing.Point(6, 9);
            this.LBL_Phone.Name = "LBL_Phone";
            this.LBL_Phone.Size = new System.Drawing.Size(130, 32);
            this.LBL_Phone.TabIndex = 2;
            this.LBL_Phone.Text = "Телефон:";
            // 
            // LBL_Email
            // 
            this.LBL_Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Email.Location = new System.Drawing.Point(42, 59);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(94, 32);
            this.LBL_Email.TabIndex = 3;
            this.LBL_Email.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "+55 11 9988 7766";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "coordinators@marathonskills.org";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.04505F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.95496F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_Phone, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Email, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 167);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 316);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LBL_ContactsDesc);
            this.Controls.Add(this.LBL_Contacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_Contacts;
        private System.Windows.Forms.Label LBL_ContactsDesc;
        private System.Windows.Forms.Label LBL_Phone;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}