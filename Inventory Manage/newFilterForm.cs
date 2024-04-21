using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Manage
{
    public partial class newFilterForm : Form
    {
        public newFilterForm()
        {
            InitializeComponent();
        }

        private void newFilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult = DialogResult.OK;
            // this.Close();
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color result = colorDialog1.Color;
            colorPnl.BackColor = result;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            colorPnl.BackColor = SystemColors.Window;
            colorDialog1.Color = SystemColors.Window; 
        }
    }
}
