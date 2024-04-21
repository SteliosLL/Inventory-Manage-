namespace Inventory_Manage
{
    partial class addItemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addItemFrm));
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qtyTxtBox = new System.Windows.Forms.TextBox();
            this.categoryToolStrip = new System.Windows.Forms.ToolStrip();
            this.storedAtMenuStrip = new System.Windows.Forms.ToolStrip();
            this.noteslbl = new System.Windows.Forms.Label();
            this.notesTxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.selectStoredAtBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.newStoredAtBtn = new System.Windows.Forms.ToolStripButton();
            this.modifyStoredAtBtn = new System.Windows.Forms.ToolStripButton();
            this.removeStoreAtBtn = new System.Windows.Forms.ToolStripButton();
            this.selectCategoryBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.newCategoryBtn = new System.Windows.Forms.ToolStripButton();
            this.modifyCategoryBtn = new System.Windows.Forms.ToolStripButton();
            this.removeCategoryBtn = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoBtn = new System.Windows.Forms.Button();
            this.categoryToolStrip.SuspendLayout();
            this.storedAtMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(121, 12);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(157, 20);
            this.nameTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(308, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stored at:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            // 
            // qtyTxtBox
            // 
            this.qtyTxtBox.Location = new System.Drawing.Point(294, 19);
            this.qtyTxtBox.Name = "qtyTxtBox";
            this.qtyTxtBox.Size = new System.Drawing.Size(30, 20);
            this.qtyTxtBox.TabIndex = 10;
            this.qtyTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyTxtBox_KeyPress);
            // 
            // categoryToolStrip
            // 
            this.categoryToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.categoryToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.categoryToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.categoryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCategoryBtn,
            this.newCategoryBtn,
            this.modifyCategoryBtn,
            this.removeCategoryBtn});
            this.categoryToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.categoryToolStrip.Location = new System.Drawing.Point(134, 47);
            this.categoryToolStrip.Margin = new System.Windows.Forms.Padding(2);
            this.categoryToolStrip.Name = "categoryToolStrip";
            this.categoryToolStrip.Size = new System.Drawing.Size(132, 25);
            this.categoryToolStrip.TabIndex = 11;
            this.categoryToolStrip.Text = "toolStrip1";
            // 
            // storedAtMenuStrip
            // 
            this.storedAtMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.storedAtMenuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.storedAtMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.storedAtMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectStoredAtBtn,
            this.newStoredAtBtn,
            this.modifyStoredAtBtn,
            this.removeStoreAtBtn});
            this.storedAtMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.storedAtMenuStrip.Location = new System.Drawing.Point(134, 73);
            this.storedAtMenuStrip.Margin = new System.Windows.Forms.Padding(2);
            this.storedAtMenuStrip.Name = "storedAtMenuStrip";
            this.storedAtMenuStrip.Size = new System.Drawing.Size(132, 25);
            this.storedAtMenuStrip.TabIndex = 12;
            this.storedAtMenuStrip.Text = "toolStrip1";
            // 
            // noteslbl
            // 
            this.noteslbl.AutoSize = true;
            this.noteslbl.Location = new System.Drawing.Point(83, 98);
            this.noteslbl.Name = "noteslbl";
            this.noteslbl.Size = new System.Drawing.Size(38, 13);
            this.noteslbl.TabIndex = 14;
            this.noteslbl.Text = "Notes:";
            // 
            // notesTxtBox
            // 
            this.notesTxtBox.Location = new System.Drawing.Point(86, 114);
            this.notesTxtBox.Multiline = true;
            this.notesTxtBox.Name = "notesTxtBox";
            this.notesTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTxtBox.Size = new System.Drawing.Size(294, 115);
            this.notesTxtBox.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Inventory_Manage.Properties.Resources.cubeAdd2;
            this.pictureBox2.Location = new System.Drawing.Point(22, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 35);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // selectStoredAtBtn
            // 
            this.selectStoredAtBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectStoredAtBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectStoredAtBtn.Image")));
            this.selectStoredAtBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectStoredAtBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 4);
            this.selectStoredAtBtn.Name = "selectStoredAtBtn";
            this.selectStoredAtBtn.Size = new System.Drawing.Size(60, 20);
            this.selectStoredAtBtn.Tag = "storedat";
            this.selectStoredAtBtn.Text = "Select...";
            this.selectStoredAtBtn.Click += new System.EventHandler(this.selectStoredAtBtn_Click);
            // 
            // newStoredAtBtn
            // 
            this.newStoredAtBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newStoredAtBtn.Image = global::Inventory_Manage.Properties.Resources.compstui_64006_fotor_202404200838;
            this.newStoredAtBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newStoredAtBtn.Name = "newStoredAtBtn";
            this.newStoredAtBtn.Size = new System.Drawing.Size(23, 22);
            this.newStoredAtBtn.Text = "toolStripButton4";
            this.newStoredAtBtn.ToolTipText = "Create new";
            this.newStoredAtBtn.Click += new System.EventHandler(this.newStoredAtBtn_Click);
            // 
            // modifyStoredAtBtn
            // 
            this.modifyStoredAtBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modifyStoredAtBtn.Enabled = false;
            this.modifyStoredAtBtn.Image = global::Inventory_Manage.Properties.Resources.e7990ccb_46ab_42b3_ac4a_e62a1335cf3d_0;
            this.modifyStoredAtBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifyStoredAtBtn.Name = "modifyStoredAtBtn";
            this.modifyStoredAtBtn.Size = new System.Drawing.Size(23, 22);
            this.modifyStoredAtBtn.Text = "toolStripButton1";
            this.modifyStoredAtBtn.ToolTipText = "Modify";
            this.modifyStoredAtBtn.Click += new System.EventHandler(this.modifyStoredAtBtn_Click);
            // 
            // removeStoreAtBtn
            // 
            this.removeStoreAtBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeStoreAtBtn.Enabled = false;
            this.removeStoreAtBtn.Image = global::Inventory_Manage.Properties.Resources.compstui_64005_fotor_2024042001017;
            this.removeStoreAtBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeStoreAtBtn.Name = "removeStoreAtBtn";
            this.removeStoreAtBtn.Size = new System.Drawing.Size(23, 22);
            this.removeStoreAtBtn.Text = "toolStripButton2";
            this.removeStoreAtBtn.ToolTipText = "Remove";
            this.removeStoreAtBtn.Click += new System.EventHandler(this.removeStoreAtBtn_Click);
            // 
            // selectCategoryBtn
            // 
            this.selectCategoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectCategoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectCategoryBtn.Image")));
            this.selectCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectCategoryBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 4);
            this.selectCategoryBtn.Name = "selectCategoryBtn";
            this.selectCategoryBtn.Size = new System.Drawing.Size(60, 20);
            this.selectCategoryBtn.Tag = "category";
            this.selectCategoryBtn.Text = "Select...";
            this.selectCategoryBtn.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // newCategoryBtn
            // 
            this.newCategoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newCategoryBtn.Image = global::Inventory_Manage.Properties.Resources.compstui_64006_fotor_202404200838;
            this.newCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newCategoryBtn.Name = "newCategoryBtn";
            this.newCategoryBtn.Size = new System.Drawing.Size(23, 22);
            this.newCategoryBtn.Text = "toolStripButton3";
            this.newCategoryBtn.ToolTipText = "Create new";
            this.newCategoryBtn.Click += new System.EventHandler(this.newCategoryBtn_Click);
            // 
            // modifyCategoryBtn
            // 
            this.modifyCategoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modifyCategoryBtn.Enabled = false;
            this.modifyCategoryBtn.Image = global::Inventory_Manage.Properties.Resources.e7990ccb_46ab_42b3_ac4a_e62a1335cf3d_0;
            this.modifyCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifyCategoryBtn.Name = "modifyCategoryBtn";
            this.modifyCategoryBtn.Size = new System.Drawing.Size(23, 22);
            this.modifyCategoryBtn.Text = "toolStripButton2";
            this.modifyCategoryBtn.ToolTipText = "Modify";
            this.modifyCategoryBtn.Click += new System.EventHandler(this.modifyCategoryBtn_Click);
            // 
            // removeCategoryBtn
            // 
            this.removeCategoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeCategoryBtn.Enabled = false;
            this.removeCategoryBtn.Image = global::Inventory_Manage.Properties.Resources.compstui_64005_fotor_2024042001017;
            this.removeCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeCategoryBtn.Name = "removeCategoryBtn";
            this.removeCategoryBtn.Size = new System.Drawing.Size(23, 22);
            this.removeCategoryBtn.Text = "toolStripButton1";
            this.removeCategoryBtn.ToolTipText = "Remove";
            this.removeCategoryBtn.Click += new System.EventHandler(this.removeCategoryBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 262);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infoBtn
            // 
            this.infoBtn.Image = global::Inventory_Manage.Properties.Resources.dabc12b4_3a6a_4be6_82ec_a279246c0ea8_0;
            this.infoBtn.Location = new System.Drawing.Point(274, 235);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(28, 23);
            this.infoBtn.TabIndex = 17;
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // addItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 260);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.notesTxtBox);
            this.Controls.Add(this.noteslbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.storedAtMenuStrip);
            this.Controls.Add(this.categoryToolStrip);
            this.Controls.Add(this.qtyTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addItemFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "addItemFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addItemFrm_FormClosing);
            this.Load += new System.EventHandler(this.addItemFrm_Load);
            this.categoryToolStrip.ResumeLayout(false);
            this.categoryToolStrip.PerformLayout();
            this.storedAtMenuStrip.ResumeLayout(false);
            this.storedAtMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox nameTxtBox;
        public System.Windows.Forms.TextBox qtyTxtBox;
        public System.Windows.Forms.ToolStrip categoryToolStrip;
        public System.Windows.Forms.ToolStrip storedAtMenuStrip;
        private System.Windows.Forms.ToolStripButton newCategoryBtn;
        private System.Windows.Forms.ToolStripButton newStoredAtBtn;
        public System.Windows.Forms.ToolStripDropDownButton selectStoredAtBtn;
        public System.Windows.Forms.ToolStripDropDownButton selectCategoryBtn;
        public System.Windows.Forms.ToolStripButton modifyCategoryBtn;
        public System.Windows.Forms.ToolStripButton modifyStoredAtBtn;
        public System.Windows.Forms.ToolStripButton removeCategoryBtn;
        public System.Windows.Forms.ToolStripButton removeStoreAtBtn;
        private System.Windows.Forms.Label noteslbl;
        public System.Windows.Forms.TextBox notesTxtBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button infoBtn;
    }
}