using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace Inventory_Manage
{
    public partial class moreItemInfoForm : Form
    {
        Form1 mainFrm;
        public moreItemInfoForm(Form1 frm)
        {
            mainFrm = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            mainFrm.modifyBtn.PerformClick();
        }

        private void moreItemInfoForm_Load(object sender, EventArgs e)
        {
            notesTxtBox.BackColor = SystemColors.Window;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(mainFrm.Location.X + mainFrm.Width /2 - this.Width/2, mainFrm.Location.Y + mainFrm.Height/ 2 - this.Height / 2);
       }

        private void notesTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
