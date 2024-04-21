using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Inventory_Manage
{
    public partial class aboutFrm : Form
    {
        Form1 mainFrm;
        public aboutFrm(Form1 frm)
        {
            InitializeComponent();
            mainFrm = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SteliosLL");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void aboutFrm_Load(object sender, EventArgs e)
        {
            normalHeight = 220;
            this.Height = normalHeight;
            switch (mainFrm.data[2] as string)
            {
                case "1":
                    normalRadioBtn.Checked = true;
                    break;
                case "2":
                    classicNormalRadioBtn.Checked = true;
                    break;
                case "3":
                    fullClassicRadioBtn.Checked = true;
                    break;
            }
        }

        int normalHeight;
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Height > normalHeight)
            {
                this.Height = normalHeight;
                moreOptionsBtn.Text = "Options ▼";
            }
            else
            {
                this.Height = normalHeight + 90;
                moreOptionsBtn.Text = "Options ▲";
            }
        }

        private void normalRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) {
                mainFrm.enableVisuals();
                mainFrm.Invalidate(true);
                mainFrm.data[2] = "1";
            }        
        }

        private void classicNormalRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                mainFrm.disableVisuals();
                mainFrm.Invalidate(true);
                mainFrm.data[2] = "2";
            }
        }

        private void fullClassicRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                mainFrm.disableVisuals(true);
                mainFrm.Invalidate(true);
                mainFrm.data[2] = "3";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.VisualStyleState = VisualStyleState.NonClientAreaEnabled;
            this.Invalidate(true);
        }
    }
}
