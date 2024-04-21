using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Inventory_Manage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            referenceEmbedder refEm = new referenceEmbedder();
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(refEm.CurrentDomain_AssemblyResolve);
            InitializeComponent();
        }
        public void enableVisuals()
        {
            toolStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
            this.Invalidate(true);
            // tabControl1.Appearance = TabAppearance.Normal;
            //tabControl2.Appearance = TabAppearance.Normal;
        }

        public void disableVisuals(bool all = false)
        {
            if (all)
            {
                Application.VisualStyleState = VisualStyleState.NoneEnabled;
            }
            else
            {
                Application.VisualStyleState = VisualStyleState.NonClientAreaEnabled;
            }
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            this.Invalidate(true);
            //   tabControl1.Appearance = TabAppearance.Buttons;
            //  tabControl2.Appearance = TabAppearance.Buttons;
        }

        //holds general info/settings about the program.
        public List<object> data = new List<object>();
        //categories, store locations etc for each tab
        public List<List<Tuple<string, Color>>> categories = new List<List<Tuple<string, Color>>>();
        public List<List<Tuple<string, Color>>> storedAt = new List<List<Tuple<string, Color>>>();
        public List<List<ListViewItem>> items = new List<List<ListViewItem>>();
        private void Form1_Load(object sender, EventArgs e)
        {
            data.Add(new List<string>());//index 0. stores last opened inventories
            data.Add(new List<string>());//index 1. stores recently opened inventories
            data.Add("1");//index 2. stores visual style
            if (System.IO.File.Exists(Application.StartupPath + @"\progData.dat"))
            {
                FileStream FS = new FileStream(Application.StartupPath + @"\progData.dat", FileMode.Open);
                List<object> desdata = DeserializeDATA(FS);
                FS.Close();
                if (desdata != null)
                {
                    data = desdata;
                    try
                    {
                        foreach (string str in data[0] as List<string>)
                        {
                            if (System.IO.File.Exists(str)) openInvFromFile(str);
                        }
                    }
                    catch { }
                }
            }
            if (tabControl1.TabPages.Count <= 0)
            {
                newToolStripMenuItem.PerformClick();
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            switch (data[2] as string)
            {
                case "1":
                    enableVisuals();
                    break;
                case "2":
                    disableVisuals();
                    break;
                case "3":
                    disableVisuals(true);
                    break;
            }
        }
        public ListView currentListView = null;
        public int selectedTabIndex = -1;
        List<bool> inventoryModified = new List<bool>();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = openInvDialog();
            if (path.Trim() == "") return;
            openInvFromFile(path);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentListView.SelectedItems.Count <= 0)
            {
                modifyBtn.Enabled = false;
                removeBtn.Enabled = false;
                // currentShowExtraInfBtn.Enabled = false;
            }
            else
            {
                modifyBtn.Enabled = true;
                removeBtn.Enabled = true;
                // currentShowExtraInfBtn.Enabled = true;
            }
        }
        ListViewItem makeItem(addItemFrm frm)
        {
            ListViewItem item = new ListViewItem(frm.nameTxtBox.Text);
            item.UseItemStyleForSubItems = false;
            ListViewItem.ListViewSubItem qty = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem category = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem storedAt = new ListViewItem.ListViewSubItem();
            ListViewItem.ListViewSubItem notes = new ListViewItem.ListViewSubItem();

            qty.Text = frm.qtyTxtBox.Text;
            notes.Text = frm.notesTxtBox.Text;
            if (frm.selectCategoryBtn.Text != "Select...")
            {
                category.Text = frm.selectCategoryBtn.Text;
                category.BackColor = frm.selectCategoryBtn.BackColor;
            }
            else
            {
                category.Text = "";
                category.BackColor = SystemColors.Window;
            }
            if (frm.selectStoredAtBtn.Text != "Select...")
            {
                storedAt.Text = frm.selectStoredAtBtn.Text;
                storedAt.BackColor = frm.selectStoredAtBtn.BackColor;
            }
            else
            {
                storedAt.Text = "";
                storedAt.BackColor = SystemColors.Window;
            }
            item.SubItems.Add(qty);
            item.SubItems.Add(category);
            item.SubItems.Add(storedAt);
            item.SubItems.Add(notes);
            return item;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (currentListView == null) return;
            inventoryModified[selectedTabIndex] = true;
            addItemFrm addItemForm = new addItemFrm(this);
            addItemForm.Text = "Add Item";
            if (addItemForm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = makeItem(addItemForm);
                addtoInv(item);
                reloadListView(true);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (currentListView == null) return;
            inventoryModified[selectedTabIndex] = true;
            addItemFrm addItemForm = new addItemFrm(this);
            addItemForm.Text = "Modify Item";
            addItemForm.nameTxtBox.Text = currentListView.SelectedItems[0].Text;
            addItemForm.qtyTxtBox.Text = currentListView.SelectedItems[0].SubItems[1].Text;
            addItemForm.notesTxtBox.Text = currentListView.SelectedItems[0].SubItems[4].Text;
            if (currentListView.SelectedItems[0].SubItems[2].Text.Trim() != "")
            {
                addItemForm.modifyCategoryBtn.Enabled = true;
                addItemForm.removeCategoryBtn.Enabled = true;
                addItemForm.selectCategoryBtn.Text = currentListView.SelectedItems[0].SubItems[2].Text;
            }
            if (currentListView.SelectedItems[0].SubItems[2].BackColor != SystemColors.Window)
            {
                addItemForm.selectCategoryBtn.BackColor = currentListView.SelectedItems[0].SubItems[2].BackColor;
            }
            else if (currentListView.SelectedItems[0].SubItems[2].Text.Trim() != "")
            {
                addItemForm.selectCategoryBtn.BackColor = SystemColors.Window;
            }
            if (currentListView.SelectedItems[0].SubItems[3].Text.Trim() != "")
            {
                addItemForm.modifyStoredAtBtn.Enabled = true;
                addItemForm.removeStoreAtBtn.Enabled = true;
                addItemForm.selectStoredAtBtn.Text = currentListView.SelectedItems[0].SubItems[3].Text;
            }
            if (currentListView.SelectedItems[0].SubItems[3].BackColor != SystemColors.Window)
            {
                addItemForm.selectStoredAtBtn.BackColor = currentListView.SelectedItems[0].SubItems[3].BackColor;
            }
            else if (currentListView.SelectedItems[0].SubItems[3].Text.Trim() != "")
            {
                addItemForm.selectStoredAtBtn.BackColor = SystemColors.Window;
            }
            addItemForm.ShowDialog();
            if (addItemForm.DialogResult == DialogResult.OK)
            {
                items[selectedTabIndex].Remove(currentListView.SelectedItems[0]);
                ListViewItem it = makeItem(addItemForm);
                addtoInv(it);
                reloadListView(true);
                try
                {
                    currentListView.Items[currentListView.Items.IndexOf(it)].Selected = true;
                }
                catch { }
                currentListView.Select();
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int deletedItemIndex = 0;
                int i = 0;
                foreach (ListViewItem item in currentListView.SelectedItems)
                {
                    i++;
                    deletedItemIndex = item.Index;
                    items[selectedTabIndex].Remove(item);
                }
                inventoryModified[selectedTabIndex] = true;
                reloadListView(true);
                if (i == 1)
                {
                    try
                    {
                        currentListView.Items[deletedItemIndex].Selected = true;
                        currentListView.Select();
                    }
                    catch { }
                }

            }
        }

        private void addtoInv(ListViewItem it)
        {
            items[selectedTabIndex].Add(it);
            items[selectedTabIndex] = bubbleSortList(items[selectedTabIndex]);
            inventoryModified[selectedTabIndex] = true;
        }
        private List<ListViewItem> bubbleSortList(List<ListViewItem> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (String.Compare(list[j].Text, list[j + 1].Text) == 1) // compare returns 1 if string2 comes before string1
                    {
                        ListViewItem it = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = it;
                    }
                }
            }
            return list;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                int size = currentListView.Width / 3;
                if (this.Width < 500)
                {
                    currentListView.Columns[1].Width = 30;
                    size += 8;
                }
                else currentListView.Columns[1].Width = 55;
                currentListView.Columns[0].Width = size + 56;
                currentListView.Columns[2].Width = size - 36 - 30;
                currentListView.Columns[3].Width = size - 36 - 30;
            }
            catch { }

        }
        private void createTab(string tabTitle, bool autoSelect = true)
        {
            ListView lst = new ListView();
            lst.MultiSelect = true;
            lst.GridLines = true;
            lst.FullRowSelect = true;
            lst.View = View.Details;
            lst.Dock = DockStyle.Fill;
            lst.Columns.Add("Item Name");
            lst.Columns.Add("Quantity");
            lst.Columns.Add("Category");
            lst.Columns.Add("Stored at");
            lst.SelectedIndexChanged += new EventHandler(listView1_SelectedIndexChanged);
            lst.DoubleClick += (_, _2) =>
            {
                moreItemInfoForm moreFrm = new moreItemInfoForm(this);
                moreFrm.namtxtbox.Text = currentListView.SelectedItems[0].Text;
                moreFrm.Text = "More info about item: " + currentListView.SelectedItems[0].Text;
                moreFrm.qtyListView.Items.Add(currentListView.SelectedItems[0].Clone() as ListViewItem);//its added to the other listviews automatically
                moreFrm.notesTxtBox.Text = currentListView.SelectedItems[0].SubItems[4].Text;
                moreFrm.Show();
            };
            TabPage tp = new TabPage();
            // tp.Click += (_, _2) => currentListView = lst;
            tp.Text = tabTitle;
            tp.Controls.Add(lst);
            tabControl1.TabPages.Add(tp);
            if (autoSelect) tabControl1.SelectedTab = tp;
            lst.SendToBack();
            Form1_SizeChanged(null, null);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categories.Add(new List<Tuple<string, Color>>());
            storedAt.Add(new List<Tuple<string, Color>>());
            items.Add(new List<ListViewItem>());
            categorySearchFilters.Add(new List<Tuple<string, Color>>());
            storedAtSearchFilters.Add(new List<Tuple<string, Color>>());
            textSearchFilters.Add("");
            inventoryModified.Add(false);
            createTab("new.inv");
        }

        public void showMenuStripAtBtn(ContextMenuStrip menuStrip, Button btn)
        {
            menuStrip.Show(btn, new Point(btn.Width - btn.Width, btn.Height));
        }
        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (inventoryModified[selectedTabIndex])
            {
                DialogResult result = MessageBox.Show("Do you want to save any changes to the inventory file before closing?", "Close " + tabControl1.SelectedTab.Text + " inventory Tab", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveBtn.PerformClick();
                }
                else if (result == DialogResult.Cancel) return;
            }
            try
            {
                items.RemoveAt(selectedTabIndex);
                categories.RemoveAt(selectedTabIndex);
                storedAt.RemoveAt(selectedTabIndex);
                categorySearchFilters.RemoveAt(selectedTabIndex);
                storedAtSearchFilters.RemoveAt(selectedTabIndex);
                textSearchFilters.RemoveAt(selectedTabIndex);
                inventoryModified.RemoveAt(selectedTabIndex);
            }
            catch { }//lists probably empty

            tabControl1.TabPages.RemoveAt(selectedTabIndex);
        }

        private void tabControl1_selectedIndexChanged(object sender, EventArgs e)
        {
            // searchItemTxtBox.Clear();
            if (tabControl1.TabCount <= 0)
            {
                selectedTabIndex = -1;
                filtersDropBtn.Enabled = false;
                searchItemTxtBox.Enabled = false;
                addItemBtn.Enabled = false;
                modifyBtn.Enabled = false;
                removeBtn.Enabled = false;
                tabOptionsBtn.Enabled = false;
                saveAllToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                saveBtn.Enabled = false;
                currentListView = null;
            }
            else
            {
                selectedTabIndex = tabControl1.SelectedIndex;
                filtersDropBtn.Enabled = true;
                searchItemTxtBox.Enabled = true;
                addItemBtn.Enabled = true;
                tabOptionsBtn.Enabled = true;
                saveAllToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
                saveBtn.Enabled = true;
                foreach (Control ctrl in tabControl1.SelectedTab.Controls)
                {
                    if (ctrl is ListView)
                    {
                        currentListView = ctrl as ListView;
                        break;
                    }
                }
            }
            try
            {
                if (currentListView.SelectedItems.Count <= 0)
                {
                    modifyBtn.Enabled = false;
                    removeBtn.Enabled = false;
                }
                else
                {
                    modifyBtn.Enabled = true;
                    removeBtn.Enabled = true;
                }
                //reloadListView(true);
                searchItemTxtBox.Text = textSearchFilters[selectedTabIndex];
            }
            catch { }
        }

        private void tabControl1_ctrlAdded(object sender, ControlEventArgs e)
        {
            tabControl1_selectedIndexChanged(null, null);
        }


        private void renameTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter a new name:", "Rename Inventory", "Default", this.Location.X + this.Width / 2 - 180, this.Location.Y + this.Height / 2 - 60);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl1.TabPages.Count > 0 && inventoryModified[selectedTabIndex])
            {
                DialogResult res = MessageBox.Show("Do you want to save any changes to the inventory files before exiting?", "Exit program", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    saveAllToolStripMenuItem.PerformClick();
                }
                else if (res == DialogResult.Cancel) e.Cancel = true;
            }
            //SAVE LAST OPENED INVENTORIES
            FileStream FS = new FileStream(Application.StartupPath + @"\progData.dat", FileMode.Create);
            List<string> prevSession = new List<string>();
            foreach (TabPage tab in tabControl1.TabPages)
            {
                string path;
                try
                {
                    path = tab.Tag.ToString().Trim();
                }
                catch { path = ""; }
                if (path == "") continue;
                prevSession.Add(tab.Tag.ToString());
            }
            data[0] = prevSession;
            SerializeDATA(data, FS);
            FS.Flush();
            FS.Close();
        }
        private void openInvFromFile(string filePath)
        {
            FileStream FS = new FileStream(filePath, FileMode.Open);
            List<object> invData = Deserialize(FS);
            items.Add(invData[0] as List<ListViewItem>);
            categories.Add(invData[1] as List<Tuple<string, Color>>);
            storedAt.Add(invData[2] as List<Tuple<string, Color>>);
            FS.Close();
            categorySearchFilters.Add(new List<Tuple<string, Color>>());
            storedAtSearchFilters.Add(new List<Tuple<string, Color>>());
            textSearchFilters.Add("");
            inventoryModified.Add(false);
            createTab(Path.GetFileName(filePath));
            reloadListView();
            tabControl1.SelectedTab.Tag = filePath;
            addToRecentlyOpened(filePath);
        }
        private void saveInvToFile(string filePath, ListView lst)
        {
            FileStream FS = new FileStream(filePath, FileMode.Create);
            List<object> invData = new List<object>();
            invData.Add(items[selectedTabIndex]);
            invData.Add(categories[selectedTabIndex]);
            invData.Add(storedAt[selectedTabIndex]);
            Serialize(invData, FS);
            FS.Flush();
            FS.Close();
            tabControl1.SelectedTab.Tag = filePath;
            inventoryModified[selectedTabIndex] = false;
            addToRecentlyOpened(filePath);
        }
        private void Serialize(List<object> invData, FileStream fs)
        {
            BinaryFormatter BF = new BinaryFormatter();
            try
            {
                BF.Serialize(fs, invData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Serialize from binary format");
                Console.WriteLine(ex.Message);
            }
        }
        private List<object> Deserialize(FileStream fs)
        {
            BinaryFormatter BF = new BinaryFormatter();
            List<object> invData = null;
            try
            {
                invData = (List<object>)BF.Deserialize(fs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Deserialize from binary format");
                Console.WriteLine(ex.Message);
            }
            return invData;
        }
        private List<object> DeserializeDATA(FileStream fs)
        {
            BinaryFormatter BF = new BinaryFormatter();
            List<object> LS = null;
            try
            {
                LS = (List<object>)BF.Deserialize(fs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Deserialize from binary format");
                Console.WriteLine(ex.Message);
            }
            return LS;
        }
        private void SerializeDATA(List<object> list, FileStream fs)
        {
            BinaryFormatter BF = new BinaryFormatter();
            try
            {
                BF.Serialize(fs, list);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Serialize from binary format");
                Console.WriteLine(ex.Message);
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string path;
            try
            {
                path = tabControl1.SelectedTab.Tag.ToString().Trim();
            }
            catch { path = ""; }
            if (path == "")
            {
                path = saveInvDialog();
                if (path.Trim() == "") return;
            }
            saveInvToFile(path, currentListView);
            tabControl1.SelectedTab.Text = Path.GetFileName(path);
        }
        private string openInvDialog(string initialDir = "default")
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Title = "Select an inventory file...";
            diag.Filter = "Inventory Files|*.inv";
            if (initialDir == "default")
            {
                diag.InitialDirectory = Application.StartupPath;
            }
            else
            {
                diag.InitialDirectory = initialDir;
            }
            DialogResult result = diag.ShowDialog();
            if (result == DialogResult.OK) return diag.FileName;
            else return "";
        }
        private string saveInvDialog(string initialDir = "default")
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Title = "Select a location to save inventory file...";
            diag.FileName = Path.GetFileNameWithoutExtension(tabControl1.SelectedTab.Text);
            diag.Filter = "Inventory Files|*.inv";
            if (initialDir == "default")
            {
                diag.InitialDirectory = Application.StartupPath;
            }
            else
            {
                diag.InitialDirectory = initialDir;
            }
            DialogResult result = diag.ShowDialog();
            if (result == DialogResult.OK) return diag.FileName;
            else return "";
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string initialDir;
            try
            {
                initialDir = tabControl1.SelectedTab.Tag.ToString().Trim();
            }
            catch { initialDir = ""; }
            if (initialDir == "")
            {
                initialDir = "default";
            }
            string path = saveInvDialog(initialDir);
            if (path.Trim() == "") return;
            saveInvToFile(path, currentListView);
            tabControl1.SelectedTab.Text = Path.GetFileName(path);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabControl1.SelectedTab = tab;
                saveBtn.PerformClick();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            loadRecentlyOpenedFiles();
        }

        List<List<Tuple<string, Color>>> categorySearchFilters = new List<List<Tuple<string, Color>>>();
        List<List<Tuple<string, Color>>> storedAtSearchFilters = new List<List<Tuple<string, Color>>>();
        List<string> textSearchFilters = new List<string>();

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            categoryToolStripMenuItem.DropDownItems.Clear();
            storedAtToolStripMenuItem.DropDownItems.Clear();

            //CATEGORIES
            //search implementation
            ToolStripTextBox searchtxtbox = new ToolStripTextBox();
            searchtxtbox.Font = new Font(searchtxtbox.Font, FontStyle.Italic); searchtxtbox.Text = "Search...";
            searchtxtbox.Click += (_, _2) => { searchtxtbox.Clear(); searchtxtbox.Font = new Font(searchtxtbox.Font, FontStyle.Regular); };
            searchtxtbox.Leave += (_, _2) => { searchtxtbox.Font = new Font(searchtxtbox.Font, FontStyle.Italic); searchtxtbox.Text = "Search..."; };
            searchtxtbox.TextChanged += (_, _2) =>
            {
                foreach (ToolStripItem item in categoryToolStripMenuItem.DropDownItems)
                {
                    if (item.Text.ToLower().Contains(searchtxtbox.Text.Trim().ToLower()))
                    {
                        item.Visible = true;
                    }
                    else item.Visible = false;
                }
            };
            categoryToolStripMenuItem.DropDownItems.Add(searchtxtbox);
            //
            categoryToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            ToolStripMenuItem unspecifiedBtn = new ToolStripMenuItem();
            unspecifiedBtn.Text = "Unspecified";
            unspecifiedBtn.CheckOnClick = true;
            unspecifiedBtn.Click += (_, _2) =>
            {
                if (unspecifiedBtn.Checked)
                {
                    categorySearchFilters[selectedTabIndex].Add(new Tuple<string, Color>("", SystemColors.Window));
                    reloadListView(true);
                }
                else
                {
                    categorySearchFilters[selectedTabIndex].Remove(new Tuple<string, Color>("", SystemColors.Window));
                    reloadListView(true);
                }
            };
            if (categorySearchFilters[selectedTabIndex].Contains(new Tuple<string, Color>("", SystemColors.Window)))
            {
                unspecifiedBtn.Checked = true;
                categoryToolStripMenuItem.DropDownItems.Insert(1, unspecifiedBtn);
            }
            else
            {
                categoryToolStripMenuItem.DropDownItems.Add(unspecifiedBtn);
            }
            try
            {
                for (int i = 0; i < categories[selectedTabIndex].Count; i++)
                {
                    Tuple<string, Color> tup = categories[selectedTabIndex][i];
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = tup.Item1;
                    item.BackColor = tup.Item2;
                    // item.Tag = i;
                    item.CheckOnClick = true;
                    if (categorySearchFilters[selectedTabIndex].Contains(tup))
                    {
                        item.Checked = true;
                    }
                    item.Click += (_, _2) =>
                    {
                        if (item.Checked)
                        {
                            categorySearchFilters[selectedTabIndex].Add(tup);
                            reloadListView(true);
                        }
                        else
                        {
                            categorySearchFilters[selectedTabIndex].Remove(tup);
                            reloadListView(true);
                        }
                    };
                    if (item.Checked == true)
                    {
                        categoryToolStripMenuItem.DropDownItems.Insert(1, item);
                    }
                    else
                    {
                        categoryToolStripMenuItem.DropDownItems.Add(item);
                    }
                }
            }
            catch { }
            //stored at 
            //search implementation
            ToolStripTextBox searchtxtboxStoredAt = new ToolStripTextBox();
            searchtxtboxStoredAt.Font = new Font(searchtxtboxStoredAt.Font, FontStyle.Italic); searchtxtboxStoredAt.Text = "Search...";
            searchtxtboxStoredAt.Click += (_, _2) => { searchtxtboxStoredAt.Clear(); searchtxtboxStoredAt.Font = new Font(searchtxtboxStoredAt.Font, FontStyle.Regular); };
            searchtxtboxStoredAt.Leave += (_, _2) => { searchtxtboxStoredAt.Font = new Font(searchtxtboxStoredAt.Font, FontStyle.Italic); searchtxtboxStoredAt.Text = "Search..."; };
            searchtxtboxStoredAt.TextChanged += (_, _2) =>
            {
                foreach (ToolStripItem item in storedAtToolStripMenuItem.DropDownItems)
                {
                    if (item.Text.ToLower().Contains(searchtxtboxStoredAt.Text.Trim().ToLower()))
                    {
                        item.Visible = true;
                    }
                    else item.Visible = false;
                }
            };
            storedAtToolStripMenuItem.DropDownItems.Add(searchtxtboxStoredAt);
            //
            storedAtToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            ToolStripMenuItem unspecifiedStoredAtBtn = new ToolStripMenuItem();
            unspecifiedStoredAtBtn.Text = "Unspecified";
            unspecifiedStoredAtBtn.CheckOnClick = true;
            unspecifiedStoredAtBtn.Click += (_, _2) =>
            {
                if (unspecifiedStoredAtBtn.Checked)
                {
                    storedAtSearchFilters[selectedTabIndex].Add(new Tuple<string, Color>("", SystemColors.Window));
                    reloadListView(true);
                }
                else
                {
                    storedAtSearchFilters[selectedTabIndex].Remove(new Tuple<string, Color>("", SystemColors.Window));
                    reloadListView(true);
                }
            };
            if (storedAtSearchFilters[selectedTabIndex].Contains(new Tuple<string, Color>("", SystemColors.Window)))
            {
                unspecifiedStoredAtBtn.Checked = true;
                storedAtToolStripMenuItem.DropDownItems.Insert(1, unspecifiedStoredAtBtn);
            }
            else
            {
                storedAtToolStripMenuItem.DropDownItems.Add(unspecifiedStoredAtBtn);
            }
            try
            {
                for (int i = 0; i < storedAt[selectedTabIndex].Count; i++)
                {
                    Tuple<string, Color> tup = storedAt[selectedTabIndex][i];
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = tup.Item1;
                    item.BackColor = tup.Item2;
                    // item.Tag = i;
                    item.CheckOnClick = true;
                    if (storedAtSearchFilters[selectedTabIndex].Contains(tup))
                    {
                        item.Checked = true;
                    }
                    item.Click += (_, _2) =>
                    {
                        if (item.Checked)
                        {
                            storedAtSearchFilters[selectedTabIndex].Add(tup);
                            reloadListView(true);
                        }
                        else
                        {
                            storedAtSearchFilters[selectedTabIndex].Remove(tup);
                            reloadListView(true);
                        }
                    };
                    if (item.Checked == true)
                    {
                        storedAtToolStripMenuItem.DropDownItems.Insert(1, item);
                    }
                    else
                    {
                        storedAtToolStripMenuItem.DropDownItems.Add(item);
                    }
                }
            }
            catch { }
        }
        private void clearSearchFilters()
        {
            categorySearchFilters[selectedTabIndex].Clear();
            storedAtSearchFilters[selectedTabIndex].Clear();
            filtersDropBtn.BackColor = DefaultBackColor;
            searchItemTxtBox.Clear();
        }
        private void reloadListView(bool withFilters = false)
        {
            currentListView.Items.Clear();
            if (withFilters)
            {
                if (categorySearchFilters[selectedTabIndex].Count <= 0 && storedAtSearchFilters[selectedTabIndex].Count <= 0)
                {
                    filtersDropBtn.BackColor = DefaultBackColor;
                    foreach (ListViewItem item in items[selectedTabIndex])
                    {
                        currentListView.Items.Add(item);
                    }
                    return;
                }
                filtersDropBtn.BackColor = Color.PaleTurquoise;
                foreach (ListViewItem it in items[selectedTabIndex])
                {
                    //apply filters
                    string categoryItemTxt = it.SubItems[2].Text.Trim();
                    Color categoryItemColor = it.SubItems[2].BackColor;
                    if (categoryItemTxt == "")
                    {
                        categoryItemColor = SystemColors.Window;
                    }
                    string storedAtItemTxt = it.SubItems[3].Text.Trim();
                    Color storedAtItemColor = it.SubItems[3].BackColor;
                    if (storedAtItemTxt == "")
                    {
                        storedAtItemColor = SystemColors.Window;
                    }

                    bool isInCategoryFilters = false;
                    bool isInStoredAtFilters = false;
                    if (categorySearchFilters[selectedTabIndex].Count <= 0)
                    {
                        isInCategoryFilters = true;
                    }
                    else
                    {
                        foreach (Tuple<string, Color> tup in categorySearchFilters[selectedTabIndex])
                        {
                            if (tup.Item1 == categoryItemTxt && tup.Item2 == categoryItemColor)
                            {
                                isInCategoryFilters = true;
                                break;
                            }
                        }
                    }
                    if (storedAtSearchFilters[selectedTabIndex].Count <= 0)
                    {
                        isInStoredAtFilters = true;
                    }
                    else
                    {
                        foreach (Tuple<string, Color> tup in storedAtSearchFilters[selectedTabIndex])
                        {
                            if (tup.Item1 == storedAtItemTxt && tup.Item2 == storedAtItemColor)
                            {
                                isInStoredAtFilters = true;
                                break;
                            }
                        }
                    }
                    if (isInCategoryFilters && isInStoredAtFilters)
                    {
                        if (it.Text.Trim() == "")
                        {
                            currentListView.Items.Add(it);
                        }
                        else
                        {
                            if (it.Text.Trim().ToLower().Contains(searchItemTxtBox.Text.Trim().ToLower()))
                            {
                                currentListView.Items.Add(it);
                            }
                        }
                    }
                }
            }
            else
            {
                clearSearchFilters();
                currentListView.Items.Clear();
                foreach (ListViewItem item in items[selectedTabIndex])
                {
                    currentListView.Items.Add(item);
                }
            }
        }

        private void clearFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reloadListView();
        }

        private void searchItemTxtBox_TextChanged(object sender, EventArgs e)
        {
            textSearchFilters[selectedTabIndex] = searchItemTxtBox.Text.Trim();
            reloadListView(true);
            if (searchItemTxtBox.Text.Trim() != "")
            {
                foreach (ListViewItem item in currentListView.Items)
                {
                    if (!item.Text.ToLower().Contains(searchItemTxtBox.Text.Trim().ToLower()))
                    {
                        currentListView.Items.Remove(item);
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutFrm aboutForm = new aboutFrm(this);
            aboutForm.ShowDialog();
        }

        private void loadRecentlyOpenedFiles()
        {
            //LOAD RECENTLY OPENED FILES
            if ((data[1] as List<string>).Count <= 0) return;
            recentInventoriesToolStripMenuItem.DropDownItems.Clear();
            try
            {
                foreach (string str in data[1] as List<string>)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(Path.GetFileName(str));
                    //item.Tag = str;
                    item.ToolTipText = str;
                    item.Click += (_, _2) =>
                    {
                        if (!File.Exists(str))
                        {
                            MessageBox.Show("File could at" + str + " could not be found!", "Open recent inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            // (data[1] as List<string>).Remove(str);
                            return;
                        }
                        for (int i = 0; i < tabControl1.TabPages.Count; i++)
                        {
                            try
                            {
                                if (tabControl1.TabPages[i].Tag.ToString().Trim() == str)
                                {
                                    tabControl1.SelectTab(i);
                                    return;
                                }
                            }
                            catch { }

                        }
                        openInvFromFile(str);
                    };
                    recentInventoriesToolStripMenuItem.DropDownItems.Add(item);
                }
            }
            catch { }
        }
        private void addToRecentlyOpened(string filePath)
        {
            if ((data[1] as List<string>).Contains(filePath))
            {
                (data[1] as List<string>).Remove(filePath);
            }
            else if ((data[1] as List<string>).Count > 10)
            {
                (data[1] as List<string>).RemoveAt((data[1] as List<string>).Count - 1);
            }
            (data[1] as List<string>).Insert(0, filePath);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Close all tabs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    tabControl1.SelectedTab = tab;
                    closeTabToolStripMenuItem.PerformClick();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("---SUS---");
            foreach (Tuple<string, Color> tup in categorySearchFilters[selectedTabIndex])
            {
                Debug.WriteLine(tup.ToString());
            }
        }

        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string argument = "/select, \"" + tabControl1.SelectedTab.Tag.ToString() + "\"";
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
            catch
            {

            }
        }

    }
}
