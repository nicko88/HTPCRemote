﻿namespace HTPCRemote.Forms
{
    partial class EditFileBrowser
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
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbFileBrowserRemote = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbShowFileBrowser = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFBMediaPlayer = new System.Windows.Forms.Button();
            this.lblFBMediaPlayerPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAPIHelp = new System.Windows.Forms.LinkLabel();
            this.tbYoutubeAPIKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYoutubePlayer = new System.Windows.Forms.LinkLabel();
            this.btnChooseYTMediaPlayer = new System.Windows.Forms.Button();
            this.cbYoutubeUseWebBrowser = new System.Windows.Forms.CheckBox();
            this.lblYTMediaPlayerPath = new System.Windows.Forms.Label();
            this.cbEnableYoutube = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbManualPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddManual = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPaths
            // 
            this.lbPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.ItemHeight = 20;
            this.lbPaths.Location = new System.Drawing.Point(13, 32);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(695, 224);
            this.lbPaths.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paths To Browse:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(466, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Path";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(566, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Path";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // cmbFileBrowserRemote
            // 
            this.cmbFileBrowserRemote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileBrowserRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFileBrowserRemote.FormattingEnabled = true;
            this.cmbFileBrowserRemote.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbFileBrowserRemote.Location = new System.Drawing.Point(408, 19);
            this.cmbFileBrowserRemote.Name = "cmbFileBrowserRemote";
            this.cmbFileBrowserRemote.Size = new System.Drawing.Size(52, 28);
            this.cmbFileBrowserRemote.TabIndex = 4;
            this.cmbFileBrowserRemote.SelectedIndexChanged += new System.EventHandler(this.cmbFileBrowserRemote_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Browser Remote:";
            // 
            // cbShowFileBrowser
            // 
            this.cbShowFileBrowser.AutoSize = true;
            this.cbShowFileBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowFileBrowser.Location = new System.Drawing.Point(6, 22);
            this.cbShowFileBrowser.Name = "cbShowFileBrowser";
            this.cbShowFileBrowser.Size = new System.Drawing.Size(211, 24);
            this.cbShowFileBrowser.TabIndex = 6;
            this.cbShowFileBrowser.Text = "Show File Browser Tab";
            this.cbShowFileBrowser.UseVisualStyleBackColor = true;
            this.cbShowFileBrowser.CheckedChanged += new System.EventHandler(this.cbShowFileBrowser_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "exe";
            this.openFileDialog.Filter = "Media Player|*.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Browser Media Player:";
            // 
            // btnChooseFBMediaPlayer
            // 
            this.btnChooseFBMediaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFBMediaPlayer.Location = new System.Drawing.Point(232, 85);
            this.btnChooseFBMediaPlayer.Name = "btnChooseFBMediaPlayer";
            this.btnChooseFBMediaPlayer.Size = new System.Drawing.Size(81, 28);
            this.btnChooseFBMediaPlayer.TabIndex = 8;
            this.btnChooseFBMediaPlayer.Text = "Choose";
            this.btnChooseFBMediaPlayer.UseVisualStyleBackColor = true;
            this.btnChooseFBMediaPlayer.Click += new System.EventHandler(this.btnChooseFBMediaPlayer_Click);
            // 
            // lblFBMediaPlayerPath
            // 
            this.lblFBMediaPlayerPath.AutoSize = true;
            this.lblFBMediaPlayerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBMediaPlayerPath.Location = new System.Drawing.Point(319, 87);
            this.lblFBMediaPlayerPath.Name = "lblFBMediaPlayerPath";
            this.lblFBMediaPlayerPath.Size = new System.Drawing.Size(155, 20);
            this.lblFBMediaPlayerPath.TabIndex = 9;
            this.lblFBMediaPlayerPath.Text = "Default Media Player";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddManual);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbManualPath);
            this.groupBox1.Controls.Add(this.btnChooseFBMediaPlayer);
            this.groupBox1.Controls.Add(this.cbShowFileBrowser);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.lblFBMediaPlayerPath);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFileBrowserRemote);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 120);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Browser Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAPIHelp);
            this.groupBox2.Controls.Add(this.tbYoutubeAPIKey);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblYoutubePlayer);
            this.groupBox2.Controls.Add(this.btnChooseYTMediaPlayer);
            this.groupBox2.Controls.Add(this.cbYoutubeUseWebBrowser);
            this.groupBox2.Controls.Add(this.lblYTMediaPlayerPath);
            this.groupBox2.Controls.Add(this.cbEnableYoutube);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 117);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YouTube Settings";
            // 
            // lblAPIHelp
            // 
            this.lblAPIHelp.AutoSize = true;
            this.lblAPIHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPIHelp.Location = new System.Drawing.Point(641, 89);
            this.lblAPIHelp.Name = "lblAPIHelp";
            this.lblAPIHelp.Size = new System.Drawing.Size(49, 16);
            this.lblAPIHelp.TabIndex = 16;
            this.lblAPIHelp.TabStop = true;
            this.lblAPIHelp.Text = "Help?";
            this.lblAPIHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAPIHelp_LinkClicked);
            // 
            // tbYoutubeAPIKey
            // 
            this.tbYoutubeAPIKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYoutubeAPIKey.Location = new System.Drawing.Point(166, 83);
            this.tbYoutubeAPIKey.Name = "tbYoutubeAPIKey";
            this.tbYoutubeAPIKey.Size = new System.Drawing.Size(469, 26);
            this.tbYoutubeAPIKey.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "YouTube API Key:";
            // 
            // lblYoutubePlayer
            // 
            this.lblYoutubePlayer.AutoSize = true;
            this.lblYoutubePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYoutubePlayer.Location = new System.Drawing.Point(504, 23);
            this.lblYoutubePlayer.Name = "lblYoutubePlayer";
            this.lblYoutubePlayer.Size = new System.Drawing.Size(191, 16);
            this.lblYoutubePlayer.TabIndex = 13;
            this.lblYoutubePlayer.TabStop = true;
            this.lblYoutubePlayer.Text = "Play YouTube in MPC/VLC";
            this.lblYoutubePlayer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblYoutubePlayer_LinkClicked);
            // 
            // btnChooseYTMediaPlayer
            // 
            this.btnChooseYTMediaPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseYTMediaPlayer.Location = new System.Drawing.Point(200, 49);
            this.btnChooseYTMediaPlayer.Name = "btnChooseYTMediaPlayer";
            this.btnChooseYTMediaPlayer.Size = new System.Drawing.Size(81, 28);
            this.btnChooseYTMediaPlayer.TabIndex = 11;
            this.btnChooseYTMediaPlayer.Text = "Choose";
            this.btnChooseYTMediaPlayer.UseVisualStyleBackColor = true;
            this.btnChooseYTMediaPlayer.Click += new System.EventHandler(this.btnChooseYTMediaPlayer_Click);
            // 
            // cbYoutubeUseWebBrowser
            // 
            this.cbYoutubeUseWebBrowser.AutoSize = true;
            this.cbYoutubeUseWebBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYoutubeUseWebBrowser.Location = new System.Drawing.Point(173, 19);
            this.cbYoutubeUseWebBrowser.Name = "cbYoutubeUseWebBrowser";
            this.cbYoutubeUseWebBrowser.Size = new System.Drawing.Size(334, 24);
            this.cbYoutubeUseWebBrowser.TabIndex = 11;
            this.cbYoutubeUseWebBrowser.Text = "Play YouTube In Default Web Browser";
            this.cbYoutubeUseWebBrowser.UseVisualStyleBackColor = true;
            this.cbYoutubeUseWebBrowser.CheckedChanged += new System.EventHandler(this.cbYoutubeUseWebBrowser_CheckedChanged);
            // 
            // lblYTMediaPlayerPath
            // 
            this.lblYTMediaPlayerPath.AutoSize = true;
            this.lblYTMediaPlayerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYTMediaPlayerPath.Location = new System.Drawing.Point(283, 53);
            this.lblYTMediaPlayerPath.Name = "lblYTMediaPlayerPath";
            this.lblYTMediaPlayerPath.Size = new System.Drawing.Size(160, 20);
            this.lblYTMediaPlayerPath.TabIndex = 12;
            this.lblYTMediaPlayerPath.Text = "Default Web Browser";
            // 
            // cbEnableYoutube
            // 
            this.cbEnableYoutube.AutoSize = true;
            this.cbEnableYoutube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnableYoutube.Location = new System.Drawing.Point(6, 19);
            this.cbEnableYoutube.Name = "cbEnableYoutube";
            this.cbEnableYoutube.Size = new System.Drawing.Size(161, 24);
            this.cbEnableYoutube.TabIndex = 10;
            this.cbEnableYoutube.Text = "Enable YouTube";
            this.cbEnableYoutube.UseVisualStyleBackColor = true;
            this.cbEnableYoutube.CheckedChanged += new System.EventHandler(this.cbEnableYoutube_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "YouTube Media Player:";
            // 
            // tbManualPath
            // 
            this.tbManualPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbManualPath.Location = new System.Drawing.Point(163, 53);
            this.tbManualPath.Name = "tbManualPath";
            this.tbManualPath.Size = new System.Drawing.Size(397, 26);
            this.tbManualPath.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Add Manual Path:";
            // 
            // btnAddManual
            // 
            this.btnAddManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManual.Location = new System.Drawing.Point(566, 53);
            this.btnAddManual.Name = "btnAddManual";
            this.btnAddManual.Size = new System.Drawing.Size(124, 28);
            this.btnAddManual.TabIndex = 19;
            this.btnAddManual.Text = "Add Manual";
            this.btnAddManual.UseVisualStyleBackColor = true;
            this.btnAddManual.Click += new System.EventHandler(this.btnAddManual_Click);
            // 
            // EditFileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbPaths);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFileBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Browser Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditFileBrowser_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbFileBrowserRemote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbShowFileBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFBMediaPlayer;
        private System.Windows.Forms.Label lblFBMediaPlayerPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChooseYTMediaPlayer;
        private System.Windows.Forms.CheckBox cbYoutubeUseWebBrowser;
        private System.Windows.Forms.Label lblYTMediaPlayerPath;
        private System.Windows.Forms.CheckBox cbEnableYoutube;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblYoutubePlayer;
        private System.Windows.Forms.TextBox tbYoutubeAPIKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblAPIHelp;
        private System.Windows.Forms.Button btnAddManual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbManualPath;
    }
}