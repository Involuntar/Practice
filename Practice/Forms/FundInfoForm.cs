using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class FundInfoForm : Form
    {
        public string[] Fund;

        private void FundInfoForm_Load(object sender, EventArgs e)
        {
            LBL_CharityName.Text = Fund[0];
            RTBX_FundDesc.Text = Fund[1];
            PIC_FundLogo.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"marathon-skills-2016-charity-data/{Fund.Last()}"));
        }

        public FundInfoForm()
        {
            InitializeComponent();
        }
    }
}
