using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.Location = new Point(mainFrm.Location.X + mainFrm.Width / 2 - this.Width / 2, mainFrm.Location.Y + mainFrm.Height / 2 - this.Height / 2);
            categListView.Items.Add(qtyListView.Items[0].Clone() as ListViewItem);
            storedAtListView.Items.Add(qtyListView.Items[0].Clone() as ListViewItem);
        }


        private void categListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex != 2) e.Cancel = true;

        }


        private void storedAtListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex != 3) e.Cancel = true;
        }
        private void qtyListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex != 1) e.Cancel = true;
        }
        private void categListView_ColumnWidthChanged_1(object sender, ColumnWidthChangedEventArgs e)
        {
            if (e.ColumnIndex != 2 && categListView.Columns[e.ColumnIndex].Width != 0)
            {
                categListView.Columns[e.ColumnIndex].Width = 0;
            }
        }

        private void storedAtListView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (e.ColumnIndex != 3 && storedAtListView.Columns[e.ColumnIndex].Width != 0)
            {
                storedAtListView.Columns[e.ColumnIndex].Width = 0;
            }
        }

        private void qtyListView_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (e.ColumnIndex != 1 && qtyListView.Columns[e.ColumnIndex].Width != 0)
            {
                qtyListView.Columns[e.ColumnIndex].Width = 0;
            }
        }

    }
}
