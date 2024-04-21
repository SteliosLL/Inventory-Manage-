namespace Inventory_Manage
{
    partial class aboutFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moreOptionsBtn = new System.Windows.Forms.Button();
            this.classicNormalRadioBtn = new System.Windows.Forms.RadioButton();
            this.normalRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullClassicRadioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Manage 1.0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(220, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stelios Liakopoulos (Diesel Geezer) 2024";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 138);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/SteliosLL";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Inventory_Manage.Properties.Resources.banner15;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // moreOptionsBtn
            // 
            this.moreOptionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.moreOptionsBtn.Location = new System.Drawing.Point(9, 161);
            this.moreOptionsBtn.Name = "moreOptionsBtn";
            this.moreOptionsBtn.Size = new System.Drawing.Size(75, 23);
            this.moreOptionsBtn.TabIndex = 6;
            this.moreOptionsBtn.Text = "Options ▼";
            this.moreOptionsBtn.UseVisualStyleBackColor = true;
            this.moreOptionsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // classicNormalRadioBtn
            // 
            this.classicNormalRadioBtn.AutoSize = true;
            this.classicNormalRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.classicNormalRadioBtn.Location = new System.Drawing.Point(6, 37);
            this.classicNormalRadioBtn.Name = "classicNormalRadioBtn";
            this.classicNormalRadioBtn.Size = new System.Drawing.Size(106, 18);
            this.classicNormalRadioBtn.TabIndex = 7;
            this.classicNormalRadioBtn.TabStop = true;
            this.classicNormalRadioBtn.Text = "Classic + Nomal";
            this.classicNormalRadioBtn.UseVisualStyleBackColor = true;
            this.classicNormalRadioBtn.CheckedChanged += new System.EventHandler(this.classicNormalRadioBtn_CheckedChanged);
            // 
            // normalRadioBtn
            // 
            this.normalRadioBtn.AutoSize = true;
            this.normalRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.normalRadioBtn.Location = new System.Drawing.Point(6, 14);
            this.normalRadioBtn.Name = "normalRadioBtn";
            this.normalRadioBtn.Size = new System.Drawing.Size(132, 18);
            this.normalRadioBtn.TabIndex = 8;
            this.normalRadioBtn.TabStop = true;
            this.normalRadioBtn.Text = "Normal windows style";
            this.normalRadioBtn.UseVisualStyleBackColor = true;
            this.normalRadioBtn.CheckedChanged += new System.EventHandler(this.normalRadioBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fullClassicRadioBtn);
            this.groupBox1.Controls.Add(this.classicNormalRadioBtn);
            this.groupBox1.Controls.Add(this.normalRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(9, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 81);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visuals";
            // 
            // fullClassicRadioBtn
            // 
            this.fullClassicRadioBtn.AutoSize = true;
            this.fullClassicRadioBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fullClassicRadioBtn.Location = new System.Drawing.Point(6, 60);
            this.fullClassicRadioBtn.Name = "fullClassicRadioBtn";
            this.fullClassicRadioBtn.Size = new System.Drawing.Size(82, 18);
            this.fullClassicRadioBtn.TabIndex = 9;
            this.fullClassicRadioBtn.TabStop = true;
            this.fullClassicRadioBtn.Text = "Full classic";
            this.fullClassicRadioBtn.UseVisualStyleBackColor = true;
            this.fullClassicRadioBtn.CheckedChanged += new System.EventHandler(this.fullClassicRadioBtn_CheckedChanged);
            // 
            // aboutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.moreOptionsBtn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutFrm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.aboutFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button moreOptionsBtn;
        private System.Windows.Forms.RadioButton classicNormalRadioBtn;
        private System.Windows.Forms.RadioButton normalRadioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fullClassicRadioBtn;
    }
}