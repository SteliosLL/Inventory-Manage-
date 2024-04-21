namespace Inventory_Manage
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentInventoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dummyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addItemBtn = new System.Windows.Forms.ToolStripButton();
            this.modifyBtn = new System.Windows.Forms.ToolStripButton();
            this.removeBtn = new System.Windows.Forms.ToolStripButton();
            this.searchItemTxtBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.filtersDropBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dummyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storedAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dummyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabOptionsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.saveBtn,
            this.toolStripSeparator1,
            this.addItemBtn,
            this.modifyBtn,
            this.removeBtn,
            this.searchItemTxtBox,
            this.toolStripLabel1,
            this.filtersDropBtn,
            this.toolStripSeparator2,
            this.tabOptionsBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.recentInventoriesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripButton1.Text = "File";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.box_add4;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.d8dc10fa_fece_432a_b49a_4fe991a2589d_0;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.old_save_single;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Enabled = false;
            this.saveAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAllToolStripMenuItem.Image")));
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // recentInventoriesToolStripMenuItem
            // 
            this.recentInventoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dummyToolStripMenuItem2});
            this.recentInventoriesToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources._267;
            this.recentInventoriesToolStripMenuItem.Name = "recentInventoriesToolStripMenuItem";
            this.recentInventoriesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.recentInventoriesToolStripMenuItem.Text = "Recent inventories";
            // 
            // dummyToolStripMenuItem2
            // 
            this.dummyToolStripMenuItem2.Name = "dummyToolStripMenuItem2";
            this.dummyToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.dummyToolStripMenuItem2.Text = "Empty";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Inventory_Manage.Properties.Resources.dabc12b4_3a6a_4be6_82ec_a279246c0ea8_0;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "About/Options";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.netshell_102;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = global::Inventory_Manage.Properties.Resources.old_save_single;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(23, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.ToolTipText = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // addItemBtn
            // 
            this.addItemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addItemBtn.Enabled = false;
            this.addItemBtn.ForeColor = System.Drawing.Color.Green;
            this.addItemBtn.Image = ((System.Drawing.Image)(resources.GetObject("addItemBtn.Image")));
            this.addItemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(33, 22);
            this.addItemBtn.Text = "Add";
            this.addItemBtn.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modifyBtn.Enabled = false;
            this.modifyBtn.Image = ((System.Drawing.Image)(resources.GetObject("modifyBtn.Image")));
            this.modifyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(49, 22);
            this.modifyBtn.Text = "Modify";
            this.modifyBtn.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeBtn.Enabled = false;
            this.removeBtn.ForeColor = System.Drawing.Color.Red;
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(54, 22);
            this.removeBtn.Text = "Remove";
            this.removeBtn.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // searchItemTxtBox
            // 
            this.searchItemTxtBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchItemTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchItemTxtBox.Enabled = false;
            this.searchItemTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchItemTxtBox.Name = "searchItemTxtBox";
            this.searchItemTxtBox.Size = new System.Drawing.Size(100, 25);
            this.searchItemTxtBox.TextChanged += new System.EventHandler(this.searchItemTxtBox_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Search Item:";
            // 
            // filtersDropBtn
            // 
            this.filtersDropBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.filtersDropBtn.BackColor = System.Drawing.SystemColors.Control;
            this.filtersDropBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.storedAtToolStripMenuItem,
            this.clearFiltersToolStripMenuItem});
            this.filtersDropBtn.Enabled = false;
            this.filtersDropBtn.Image = global::Inventory_Manage.Properties.Resources._1056;
            this.filtersDropBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtersDropBtn.Name = "filtersDropBtn";
            this.filtersDropBtn.Size = new System.Drawing.Size(67, 22);
            this.filtersDropBtn.Text = "Filters";
            this.filtersDropBtn.ToolTipText = "Filters";
            this.filtersDropBtn.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dummyToolStripMenuItem});
            this.categoryToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources._825;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // dummyToolStripMenuItem
            // 
            this.dummyToolStripMenuItem.Name = "dummyToolStripMenuItem";
            this.dummyToolStripMenuItem.Size = new System.Drawing.Size(466, 22);
            this.dummyToolStripMenuItem.Text = "DONT DRAG YOUR MOUSE OFF THE FILTERS BUTTON WHEN YOU CLICK IT";
            // 
            // storedAtToolStripMenuItem
            // 
            this.storedAtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dummyToolStripMenuItem1});
            this.storedAtToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.d8dc10fa_fece_432a_b49a_4fe991a2589d_0;
            this.storedAtToolStripMenuItem.Name = "storedAtToolStripMenuItem";
            this.storedAtToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.storedAtToolStripMenuItem.Text = "Stored at";
            // 
            // dummyToolStripMenuItem1
            // 
            this.dummyToolStripMenuItem1.Name = "dummyToolStripMenuItem1";
            this.dummyToolStripMenuItem1.Size = new System.Drawing.Size(466, 22);
            this.dummyToolStripMenuItem1.Text = "DONT DRAG YOUR MOUSE OFF THE FILTERS BUTTON WHEN YOU CLICK IT";
            // 
            // clearFiltersToolStripMenuItem
            // 
            this.clearFiltersToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.netshell_102;
            this.clearFiltersToolStripMenuItem.Name = "clearFiltersToolStripMenuItem";
            this.clearFiltersToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clearFiltersToolStripMenuItem.Text = "Clear Filters";
            this.clearFiltersToolStripMenuItem.Click += new System.EventHandler(this.clearFiltersToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabOptionsBtn
            // 
            this.tabOptionsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.openFileLocationToolStripMenuItem});
            this.tabOptionsBtn.Enabled = false;
            this.tabOptionsBtn.Image = global::Inventory_Manage.Properties.Resources._6979dc29_8c5f_4a36_bfd0_1ecd672a5b99_0;
            this.tabOptionsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tabOptionsBtn.Name = "tabOptionsBtn";
            this.tabOptionsBtn.Size = new System.Drawing.Size(131, 22);
            this.tabOptionsBtn.Text = "Inventory Options";
            this.tabOptionsBtn.ToolTipText = "Tab Settings";
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.netshell_102;
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeTabToolStripMenuItem.Text = "Close";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources.pages_x;
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Image = global::Inventory_Manage.Properties.Resources._468;
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openFileLocationToolStripMenuItem.Text = "Open file location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_selectedIndexChanged);
            this.tabControl1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl1_ctrlAdded);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inventory Manage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentInventoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripButton addItemBtn;
        private System.Windows.Forms.ToolStripButton removeBtn;
        private System.Windows.Forms.ToolStripTextBox searchItemTxtBox;
        private System.Windows.Forms.ToolStripDropDownButton filtersDropBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tabOptionsBtn;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem storedAtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dummyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dummyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dummyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton modifyBtn;
    }
}

