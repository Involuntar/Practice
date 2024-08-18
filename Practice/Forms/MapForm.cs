using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Forms
{
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
        }

        private void PIC_MainStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Начало марафона", "Начало марафона", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PIC_HalfStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Начало полумарафона", "Начало марафона", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PIC_ShortStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Начало короткой дистанции", "Начало марафона", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PIC_Checkpoint2_Click(object sender, EventArgs e)
        {
            PANEL_Features.Visible = true;

            PIC_Energy.Visible=false;
            LBL_Energy.Visible=false;

            PIC_Toilet.Visible=false;
            LBL_Toilet.Visible=false;

            PIC_Drinks.Visible = true;
            LBL_Drinks.Visible = true;

            PIC_Med.Visible = true;
            LBL_Med.Visible = true;
        }

        private void BTN_CloseFeatures_Click(object sender, EventArgs e)
        {
            PANEL_Features.Visible=false;
            PIC_Drinks.Visible=false;
            PIC_Med.Visible=false;
            PIC_Toilet.Visible=false;
            PIC_Energy.Visible=false;

            LBL_Toilet.Visible=false;
            LBL_Energy.Visible=false;
            LBL_Drinks.Visible=false;
            LBL_Med.Visible=false;
        }

        private void PIC_Checkpoint1_Click(object sender, EventArgs e)
        {
            PANEL_Features.Visible=true;

            PIC_Med.Visible=false;
            LBL_Med.Visible=false;

            PIC_Drinks.Visible = false;
            LBL_Drinks.Visible=false;

            PIC_Toilet.Visible=true;
            LBL_Toilet.Visible=true;

            PIC_Energy.Visible=true;
            LBL_Energy.Visible=true;
        }

        private void PIC_Checkpoint3_Click(object sender, EventArgs e)
        {
            PANEL_Features.Visible=true;

            PIC_Med.Visible=false;
            LBL_Med.Visible=false;

            PIC_Energy.Visible=false;
            LBL_Energy.Visible=false;

            PIC_Toilet.Visible=true;
            LBL_Toilet.Visible=true;

            PIC_Drinks.Visible=true;
            LBL_Drinks.Visible=true;
        }

        private void PIC_Checkpoint4_Click(object sender, EventArgs e)
        {
            PANEL_Features.Visible=true;

            PIC_Energy.Visible=false;
            LBL_Energy.Visible=false;

            PIC_Toilet.Visible=true;
            LBL_Toilet.Visible=true;

            PIC_Drinks.Visible=true;
            LBL_Drinks.Visible=true;

            PIC_Med.Visible=true;
            LBL_Med.Visible=true;
        }

        private void BTN_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
