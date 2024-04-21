using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Manage
{
    public partial class addItemFrm : Form
    {
        public addItemFrm(Form1 frm)
        {
            InitializeComponent();
            mainFrm = frm;
        }
        Form1 mainFrm;
        ToolTip toolTip1 = new ToolTip();
        private void addItemFrm_Load(object sender, EventArgs e)
        {
            createDropDown(selectCategoryBtn, mainFrm.categories[mainFrm.selectedTabIndex]);
            createDropDown(selectStoredAtBtn, mainFrm.storedAt[mainFrm.selectedTabIndex]);
            toolTip1.IsBalloon = true;
            toolTip1.InitialDelay = 0;
            toolTip1.AutoPopDelay = 15000;
            toolTip1.SetToolTip(infoBtn, "NOTE: You don't need to click OK and create an item in order to\r\ncreate or modify categories and store locations");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name for the item", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void addItemFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void qtyTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createDropDown(ToolStripDropDownButton btn, List<Tuple<string, Color>> list)
        {
            btn.DropDownItems.Clear();
            ToolStripTextBox txtbox = new ToolStripTextBox();
            txtbox.Font = new Font(txtbox.Font, FontStyle.Italic); txtbox.Text = "Search...";
            txtbox.Click += (_, _2) => { txtbox.Clear(); };
            txtbox.Leave += (_, _2) => { txtbox.Font = new Font(txtbox.Font, FontStyle.Bold); txtbox.Text = "Search..."; };
            txtbox.Tag = "nope";
            txtbox.TextChanged += (_, _2) => { };
            btn.DropDownItems.Add(txtbox);
            btn.DropDownItems.Add(new ToolStripSeparator());
            ToolStripItem unspecifiedBtn = btn.DropDownItems.Add("Unspecified");
            if (btn.Tag.ToString() == "category")
            {
                unspecifiedBtn.Click += (_, _2) =>
                {
                    resetDropDownBtn(btn);
                    modifyCategoryBtn.Enabled = false;
                    removeCategoryBtn.Enabled = false;
                };
            }
            else if (btn.Tag.ToString() == "storedat")
            {
                unspecifiedBtn.Click += (_, _2) =>
                {
                    resetDropDownBtn(btn);
                    modifyStoredAtBtn.Enabled = false;
                    removeStoreAtBtn.Enabled = false;
                };
            }
            unspecifiedBtn.Tag = "nope";
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Tuple<string, Color> tup = list[i];
                    ToolStripItem item = btn.DropDownItems.Add(tup.Item1);
                    item.BackColor = tup.Item2;
                    item.Tag = i;
                    if (btn.Tag.ToString() == "category")
                    {
                        item.Click += (_, _2) =>
                        {
                            resetDropDownBtn(btn);
                            modifyCategoryBtn.Enabled = true;
                            removeCategoryBtn.Enabled = true;
                        };
                    }
                    else if (btn.Tag.ToString() == "storedat")
                    {
                        item.Click += (_, _2) =>
                        {
                            resetDropDownBtn(btn);
                            modifyStoredAtBtn.Enabled = true;
                            removeStoreAtBtn.Enabled = true;
                        };
                    }
                    item.Click += (_, _2) =>
                    {
                        btn.Tag = item.Tag;
                        btn.Text = tup.Item1;
                        btn.BackColor = tup.Item2;

                    };
                }
            }
            catch { }//lists probably empty

        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void newCategoryBtn_Click(object sender, EventArgs e)
        {
            newFilterForm filterFrm = new newFilterForm();
            filterFrm.Text = "Create new category";
            if (filterFrm.ShowDialog() == DialogResult.OK)
            {
                Tuple<string, Color> categ = new Tuple<string, Color>(filterFrm.nameTxtBox.Text, filterFrm.colorPnl.BackColor);
                foreach (Tuple<string, Color> tuple in mainFrm.categories[mainFrm.selectedTabIndex])
                {
                    if (tuple.Item1 == categ.Item1)
                    {
                        MessageBox.Show("A category with the same name already exists!", "Create new category error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                mainFrm.categories[mainFrm.selectedTabIndex].Add(categ);
                mainFrm.categories[mainFrm.selectedTabIndex].Sort();
                Debug.WriteLine("-------------");             
                createDropDown(selectCategoryBtn, mainFrm.categories[mainFrm.selectedTabIndex]);
                selectCategoryBtn.Text = categ.Item1;
                selectCategoryBtn.BackColor = categ.Item2;
                modifyCategoryBtn.Enabled = true;
                removeCategoryBtn.Enabled = true;
            }
        }

        private void modifyCategoryBtn_Click(object sender, EventArgs e)
        {
            newFilterForm filterFrm = new newFilterForm();
            filterFrm.Text = "Modify category";
            filterFrm.nameTxtBox.Text = selectCategoryBtn.Text;
            filterFrm.colorPnl.BackColor = selectCategoryBtn.BackColor;
            filterFrm.colorDialog1.Color = selectCategoryBtn.BackColor;
            filterFrm.createBtn.Text = "Apply";
            if (filterFrm.ShowDialog() == DialogResult.OK)
            {
                Tuple<string, Color> categ = new Tuple<string, Color>(filterFrm.nameTxtBox.Text, filterFrm.colorPnl.BackColor);
                for (int i = 0; i < mainFrm.categories[mainFrm.selectedTabIndex].Count; i++)
                {
                    if (mainFrm.categories[mainFrm.selectedTabIndex][i].Item1 == selectCategoryBtn.Text && mainFrm.categories[mainFrm.selectedTabIndex][i].Item2 == selectCategoryBtn.BackColor)
                    {
                        mainFrm.categories[mainFrm.selectedTabIndex][i] = categ;
                        break;
                    }
                }
                // mainFrm.categories[mainFrm.selectedTabIndex].Add(categ);
                mainFrm.categories[mainFrm.selectedTabIndex].Sort();
                createDropDown(selectCategoryBtn, mainFrm.categories[mainFrm.selectedTabIndex]);
                selectCategoryBtn.Text = categ.Item1;
                selectCategoryBtn.BackColor = categ.Item2;
            }
        }
        private void resetDropDownBtn(ToolStripDropDownButton btn)
        {
            btn.Text = "Select...";
            btn.BackColor = DefaultBackColor;
        }
        private void removeCategoryBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Remove category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index;
                int.TryParse(selectCategoryBtn.Tag.ToString(), out index);
                mainFrm.categories[mainFrm.selectedTabIndex].RemoveAt(index);
                mainFrm.categories[mainFrm.selectedTabIndex].Sort();
                resetDropDownBtn(selectCategoryBtn);
                createDropDown(selectCategoryBtn, mainFrm.categories[mainFrm.selectedTabIndex]);
                if (mainFrm.categories[mainFrm.selectedTabIndex].Count <= 0)
                {
                    removeCategoryBtn.Enabled = false;
                    modifyCategoryBtn.Enabled = false;
                }
            }
        }

        private void newStoredAtBtn_Click(object sender, EventArgs e)
        {
            newFilterForm filterFrm = new newFilterForm();
            filterFrm.Text = "Create new store location";
            if (filterFrm.ShowDialog() == DialogResult.OK)
            {
                Tuple<string, Color> categ = new Tuple<string, Color>(filterFrm.nameTxtBox.Text, filterFrm.colorPnl.BackColor);
                foreach (Tuple<string, Color> tuple in mainFrm.storedAt[mainFrm.selectedTabIndex])
                {
                    if (tuple.Item1 == categ.Item1)
                    {
                        MessageBox.Show("A store location with the same name already exists!", "Create new store location error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                mainFrm.storedAt[mainFrm.selectedTabIndex].Add(categ);
                mainFrm.storedAt[mainFrm.selectedTabIndex].Sort();
                createDropDown(selectStoredAtBtn, mainFrm.storedAt[mainFrm.selectedTabIndex]);
                selectStoredAtBtn.Text = categ.Item1;
                selectStoredAtBtn.BackColor = categ.Item2;
                modifyStoredAtBtn.Enabled = true;
                removeStoreAtBtn.Enabled = true;
            }
        }

        private void modifyStoredAtBtn_Click(object sender, EventArgs e)
        {
            newFilterForm filterFrm = new newFilterForm();
            filterFrm.Text = "Modify store location";
            filterFrm.nameTxtBox.Text = selectStoredAtBtn.Text;
            filterFrm.colorPnl.BackColor = selectStoredAtBtn.BackColor;
            filterFrm.colorDialog1.Color = selectStoredAtBtn.BackColor;
            filterFrm.createBtn.Text = "Apply";
            if (filterFrm.ShowDialog() == DialogResult.OK)
            {
                Tuple<string, Color> categ = new Tuple<string, Color>(filterFrm.nameTxtBox.Text, filterFrm.colorPnl.BackColor);
                for (int i = 0; i < mainFrm.storedAt[mainFrm.selectedTabIndex].Count; i++)
                {
                    if (mainFrm.storedAt[mainFrm.selectedTabIndex][i].Item1 == selectStoredAtBtn.Text && mainFrm.storedAt[mainFrm.selectedTabIndex][i].Item2 == selectStoredAtBtn.BackColor)
                    {
                        mainFrm.storedAt[mainFrm.selectedTabIndex][i] = categ;
                        break;
                    }
                }
                mainFrm.storedAt[mainFrm.selectedTabIndex].Sort();
                createDropDown(selectStoredAtBtn, mainFrm.storedAt[mainFrm.selectedTabIndex]);
                selectStoredAtBtn.Text = categ.Item1;
                selectStoredAtBtn.BackColor = categ.Item2;
            }
        }

        private void removeStoreAtBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Remove store location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index;
                int.TryParse(selectStoredAtBtn.Tag.ToString(), out index);
                mainFrm.storedAt[mainFrm.selectedTabIndex].RemoveAt(index);
                mainFrm.storedAt[mainFrm.selectedTabIndex].Sort();
                resetDropDownBtn(selectStoredAtBtn);
                createDropDown(selectStoredAtBtn, mainFrm.storedAt[mainFrm.selectedTabIndex]);
                if (mainFrm.storedAt[mainFrm.selectedTabIndex].Count <= 0)
                {
                    removeStoreAtBtn.Enabled = false;
                    modifyStoredAtBtn.Enabled = false;
                }
            }
        }
        private void selectStoredAtBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(infoBtn, "NOTE: You don't need to click OK and create an item in order to\r\ncreate new categories and store locations");
        }

        int normalWidth = 390;
        private void categoryToolStrip_SizeChanged(object sender, EventArgs e)
        {
            int widest = Math.Max(categoryToolStrip.Width, storedAtMenuStrip.Width);
            if (widest > 296)
            {
                this.Width = normalWidth + widest - 296;
            }
            else { this.Width = normalWidth;  }
            //this.Refresh();
        }
    }
}
