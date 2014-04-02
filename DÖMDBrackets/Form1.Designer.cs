namespace DÖMDBrackets
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOnline = new System.Windows.Forms.Panel();
            this.btnTeamListing = new System.Windows.Forms.Button();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSelectBGColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSponsFolder = new System.Windows.Forms.TextBox();
            this.btnSelectSponsFolder = new System.Windows.Forms.Button();
            this.txtBGPatternPath = new System.Windows.Forms.TextBox();
            this.btnSelectBGPattern = new System.Windows.Forms.Button();
            this.txtLogoPath = new System.Windows.Forms.TextBox();
            this.btnSelectLogo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbScreens = new System.Windows.Forms.ComboBox();
            this.btnLoadBackup = new System.Windows.Forms.Button();
            this.btnJSONURL = new System.Windows.Forms.Button();
            this.btnLoadJSONFile = new System.Windows.Forms.Button();
            this.btnLoadTextFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelOffline = new System.Windows.Forms.Panel();
            this.btnSaveMatch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioNoWinner = new System.Windows.Forms.RadioButton();
            this.radioTeam2 = new System.Windows.Forms.RadioButton();
            this.radioTeam1 = new System.Windows.Forms.RadioButton();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerView = new System.Windows.Forms.Timer(this.components);
            this.openLogoDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorBGDialog = new System.Windows.Forms.ColorDialog();
            this.folderSponsDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtJSONURL = new System.Windows.Forms.TextBox();
            this.nrUpdateInterval = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnToggleUpdates = new System.Windows.Forms.Button();
            this.timerUpdateInterval = new System.Windows.Forms.Timer(this.components);
            this.btnStartView = new System.Windows.Forms.Button();
            this.nrTeams = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelOnline.SuspendLayout();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelOffline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrUpdateInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnTeamListing);
            this.panelMain.Controls.Add(this.lblHeader);
            this.panelMain.Controls.Add(this.panelOnline);
            this.panelMain.Controls.Add(this.panelConfig);
            this.panelMain.Controls.Add(this.panelOffline);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1045, 692);
            this.panelMain.TabIndex = 0;
            // 
            // panelOnline
            // 
            this.panelOnline.Controls.Add(this.label13);
            this.panelOnline.Controls.Add(this.nrTeams);
            this.panelOnline.Controls.Add(this.btnStartView);
            this.panelOnline.Controls.Add(this.btnToggleUpdates);
            this.panelOnline.Controls.Add(this.label12);
            this.panelOnline.Controls.Add(this.label11);
            this.panelOnline.Controls.Add(this.label10);
            this.panelOnline.Controls.Add(this.nrUpdateInterval);
            this.panelOnline.Controls.Add(this.txtJSONURL);
            this.panelOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOnline.Location = new System.Drawing.Point(0, 0);
            this.panelOnline.Name = "panelOnline";
            this.panelOnline.Size = new System.Drawing.Size(1045, 692);
            this.panelOnline.TabIndex = 17;
            // 
            // btnTeamListing
            // 
            this.btnTeamListing.Location = new System.Drawing.Point(875, 21);
            this.btnTeamListing.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeamListing.Name = "btnTeamListing";
            this.btnTeamListing.Size = new System.Drawing.Size(155, 28);
            this.btnTeamListing.TabIndex = 9;
            this.btnTeamListing.Text = "Team Listing";
            this.btnTeamListing.UseVisualStyleBackColor = true;
            this.btnTeamListing.Click += new System.EventHandler(this.btnTeamListing_Click);
            // 
            // panelConfig
            // 
            this.panelConfig.Controls.Add(this.label9);
            this.panelConfig.Controls.Add(this.btnSelectBGColor);
            this.panelConfig.Controls.Add(this.label7);
            this.panelConfig.Controls.Add(this.label8);
            this.panelConfig.Controls.Add(this.label6);
            this.panelConfig.Controls.Add(this.txtSponsFolder);
            this.panelConfig.Controls.Add(this.btnSelectSponsFolder);
            this.panelConfig.Controls.Add(this.txtBGPatternPath);
            this.panelConfig.Controls.Add(this.btnSelectBGPattern);
            this.panelConfig.Controls.Add(this.txtLogoPath);
            this.panelConfig.Controls.Add(this.btnSelectLogo);
            this.panelConfig.Controls.Add(this.label2);
            this.panelConfig.Controls.Add(this.cbScreens);
            this.panelConfig.Controls.Add(this.btnLoadBackup);
            this.panelConfig.Controls.Add(this.btnJSONURL);
            this.panelConfig.Controls.Add(this.btnLoadJSONFile);
            this.panelConfig.Controls.Add(this.btnLoadTextFile);
            this.panelConfig.Controls.Add(this.label5);
            this.panelConfig.Controls.Add(this.label4);
            this.panelConfig.Controls.Add(this.numericUpDown1);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfig.Location = new System.Drawing.Point(0, 0);
            this.panelConfig.Margin = new System.Windows.Forms.Padding(4);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(1045, 692);
            this.panelConfig.TabIndex = 12;
            this.panelConfig.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Select Background Color";
            // 
            // btnSelectBGColor
            // 
            this.btnSelectBGColor.Location = new System.Drawing.Point(585, 180);
            this.btnSelectBGColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectBGColor.Name = "btnSelectBGColor";
            this.btnSelectBGColor.Size = new System.Drawing.Size(64, 28);
            this.btnSelectBGColor.TabIndex = 15;
            this.btnSelectBGColor.Text = "Colors";
            this.btnSelectBGColor.UseVisualStyleBackColor = true;
            this.btnSelectBGColor.Click += new System.EventHandler(this.btnSelectBGColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Select Sponsor Logo Folder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select Background Pattern";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select Event Logo";
            // 
            // txtSponsFolder
            // 
            this.txtSponsFolder.Location = new System.Drawing.Point(397, 341);
            this.txtSponsFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtSponsFolder.Name = "txtSponsFolder";
            this.txtSponsFolder.ReadOnly = true;
            this.txtSponsFolder.Size = new System.Drawing.Size(211, 22);
            this.txtSponsFolder.TabIndex = 13;
            // 
            // btnSelectSponsFolder
            // 
            this.btnSelectSponsFolder.Location = new System.Drawing.Point(617, 338);
            this.btnSelectSponsFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectSponsFolder.Name = "btnSelectSponsFolder";
            this.btnSelectSponsFolder.Size = new System.Drawing.Size(32, 28);
            this.btnSelectSponsFolder.TabIndex = 12;
            this.btnSelectSponsFolder.Text = "...";
            this.btnSelectSponsFolder.UseVisualStyleBackColor = true;
            this.btnSelectSponsFolder.Click += new System.EventHandler(this.btnSelectSponsFolder_Click);
            // 
            // txtBGPatternPath
            // 
            this.txtBGPatternPath.Location = new System.Drawing.Point(397, 239);
            this.txtBGPatternPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtBGPatternPath.Name = "txtBGPatternPath";
            this.txtBGPatternPath.ReadOnly = true;
            this.txtBGPatternPath.Size = new System.Drawing.Size(211, 22);
            this.txtBGPatternPath.TabIndex = 13;
            // 
            // btnSelectBGPattern
            // 
            this.btnSelectBGPattern.Location = new System.Drawing.Point(617, 236);
            this.btnSelectBGPattern.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectBGPattern.Name = "btnSelectBGPattern";
            this.btnSelectBGPattern.Size = new System.Drawing.Size(32, 28);
            this.btnSelectBGPattern.TabIndex = 12;
            this.btnSelectBGPattern.Text = "...";
            this.btnSelectBGPattern.UseVisualStyleBackColor = true;
            this.btnSelectBGPattern.Click += new System.EventHandler(this.btnSelectBGPattern_Click);
            // 
            // txtLogoPath
            // 
            this.txtLogoPath.Location = new System.Drawing.Point(397, 287);
            this.txtLogoPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogoPath.Name = "txtLogoPath";
            this.txtLogoPath.ReadOnly = true;
            this.txtLogoPath.Size = new System.Drawing.Size(211, 22);
            this.txtLogoPath.TabIndex = 13;
            // 
            // btnSelectLogo
            // 
            this.btnSelectLogo.Location = new System.Drawing.Point(617, 284);
            this.btnSelectLogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectLogo.Name = "btnSelectLogo";
            this.btnSelectLogo.Size = new System.Drawing.Size(32, 28);
            this.btnSelectLogo.TabIndex = 12;
            this.btnSelectLogo.Text = "...";
            this.btnSelectLogo.UseVisualStyleBackColor = true;
            this.btnSelectLogo.Click += new System.EventHandler(this.btnSelectLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Screen";
            // 
            // cbScreens
            // 
            this.cbScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreens.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbScreens.FormattingEnabled = true;
            this.cbScreens.Location = new System.Drawing.Point(397, 42);
            this.cbScreens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbScreens.Name = "cbScreens";
            this.cbScreens.Size = new System.Drawing.Size(251, 24);
            this.cbScreens.TabIndex = 2;
            // 
            // btnLoadBackup
            // 
            this.btnLoadBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadBackup.Location = new System.Drawing.Point(397, 582);
            this.btnLoadBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadBackup.Name = "btnLoadBackup";
            this.btnLoadBackup.Size = new System.Drawing.Size(252, 39);
            this.btnLoadBackup.TabIndex = 1;
            this.btnLoadBackup.Text = "Load Teams From Backup";
            this.btnLoadBackup.UseVisualStyleBackColor = true;
            this.btnLoadBackup.Click += new System.EventHandler(this.btnLoadBackup_Click);
            // 
            // btnJSONURL
            // 
            this.btnJSONURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJSONURL.Location = new System.Drawing.Point(397, 536);
            this.btnJSONURL.Margin = new System.Windows.Forms.Padding(4);
            this.btnJSONURL.Name = "btnJSONURL";
            this.btnJSONURL.Size = new System.Drawing.Size(252, 39);
            this.btnJSONURL.TabIndex = 1;
            this.btnJSONURL.Text = "Load Teams From JSON URL";
            this.btnJSONURL.UseVisualStyleBackColor = true;
            this.btnJSONURL.Click += new System.EventHandler(this.btnJSONURL_Click);
            // 
            // btnLoadJSONFile
            // 
            this.btnLoadJSONFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadJSONFile.Location = new System.Drawing.Point(397, 489);
            this.btnLoadJSONFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadJSONFile.Name = "btnLoadJSONFile";
            this.btnLoadJSONFile.Size = new System.Drawing.Size(252, 39);
            this.btnLoadJSONFile.TabIndex = 1;
            this.btnLoadJSONFile.Text = "Load Teams From JSON File";
            this.btnLoadJSONFile.UseVisualStyleBackColor = true;
            this.btnLoadJSONFile.Click += new System.EventHandler(this.btnLoadJSONFile_Click);
            // 
            // btnLoadTextFile
            // 
            this.btnLoadTextFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadTextFile.Location = new System.Drawing.Point(397, 442);
            this.btnLoadTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTextFile.Name = "btnLoadTextFile";
            this.btnLoadTextFile.Size = new System.Drawing.Size(252, 39);
            this.btnLoadTextFile.TabIndex = 1;
            this.btnLoadTextFile.Text = "Load Teams From Text File";
            this.btnLoadTextFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFile.Click += new System.EventHandler(this.btnLoadTextFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Change View every:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(397, 95);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1045, 62);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Configuration";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelOffline
            // 
            this.panelOffline.Controls.Add(this.btnSaveMatch);
            this.panelOffline.Controls.Add(this.btnSearch);
            this.panelOffline.Controls.Add(this.radioNoWinner);
            this.panelOffline.Controls.Add(this.radioTeam2);
            this.panelOffline.Controls.Add(this.radioTeam1);
            this.panelOffline.Controls.Add(this.lblTeam2);
            this.panelOffline.Controls.Add(this.lblTeam1);
            this.panelOffline.Controls.Add(this.label3);
            this.panelOffline.Controls.Add(this.lblMatch);
            this.panelOffline.Controls.Add(this.label1);
            this.panelOffline.Controls.Add(this.txtTeam);
            this.panelOffline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOffline.Location = new System.Drawing.Point(0, 0);
            this.panelOffline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOffline.Name = "panelOffline";
            this.panelOffline.Size = new System.Drawing.Size(1045, 692);
            this.panelOffline.TabIndex = 4;
            this.panelOffline.Visible = false;
            // 
            // btnSaveMatch
            // 
            this.btnSaveMatch.Enabled = false;
            this.btnSaveMatch.Location = new System.Drawing.Point(639, 289);
            this.btnSaveMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveMatch.Name = "btnSaveMatch";
            this.btnSaveMatch.Size = new System.Drawing.Size(100, 37);
            this.btnSaveMatch.TabIndex = 8;
            this.btnSaveMatch.Text = "Save";
            this.btnSaveMatch.UseVisualStyleBackColor = true;
            this.btnSaveMatch.Click += new System.EventHandler(this.btnSaveMatch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(669, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 34);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioNoWinner
            // 
            this.radioNoWinner.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioNoWinner.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNoWinner.Location = new System.Drawing.Point(307, 241);
            this.radioNoWinner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioNoWinner.Name = "radioNoWinner";
            this.radioNoWinner.Size = new System.Drawing.Size(433, 37);
            this.radioNoWinner.TabIndex = 6;
            this.radioNoWinner.TabStop = true;
            this.radioNoWinner.Text = "No Winner";
            this.radioNoWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNoWinner.UseVisualStyleBackColor = true;
            // 
            // radioTeam2
            // 
            this.radioTeam2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTeam2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam2.Location = new System.Drawing.Point(307, 199);
            this.radioTeam2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTeam2.Name = "radioTeam2";
            this.radioTeam2.Size = new System.Drawing.Size(433, 37);
            this.radioTeam2.TabIndex = 6;
            this.radioTeam2.TabStop = true;
            this.radioTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam2.UseVisualStyleBackColor = true;
            // 
            // radioTeam1
            // 
            this.radioTeam1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTeam1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam1.Location = new System.Drawing.Point(307, 158);
            this.radioTeam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTeam1.Name = "radioTeam1";
            this.radioTeam1.Size = new System.Drawing.Size(433, 37);
            this.radioTeam1.TabIndex = 6;
            this.radioTeam1.TabStop = true;
            this.radioTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam1.UseVisualStyleBackColor = true;
            // 
            // lblTeam2
            // 
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(539, 101);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(493, 36);
            this.lblTeam2.TabIndex = 5;
            // 
            // lblTeam1
            // 
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(12, 101);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(492, 33);
            this.lblTeam1.TabIndex = 4;
            this.lblTeam1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner:";
            // 
            // lblMatch
            // 
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(12, 101);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(1021, 33);
            this.lblMatch.TabIndex = 2;
            this.lblMatch.Text = "vs";
            this.lblMatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = ":Team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam.Location = new System.Drawing.Point(397, 30);
            this.txtTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(267, 34);
            this.txtTeam.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // timerView
            // 
            this.timerView.Tick += new System.EventHandler(this.timerView_Tick);
            // 
            // txtJSONURL
            // 
            this.txtJSONURL.Location = new System.Drawing.Point(397, 173);
            this.txtJSONURL.Name = "txtJSONURL";
            this.txtJSONURL.Size = new System.Drawing.Size(251, 22);
            this.txtJSONURL.TabIndex = 0;
            this.txtJSONURL.Text = "http://server.appative.com/apps/domd/results_combined.php";
            // 
            // nrUpdateInterval
            // 
            this.nrUpdateInterval.Location = new System.Drawing.Point(397, 218);
            this.nrUpdateInterval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nrUpdateInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrUpdateInterval.Name = "nrUpdateInterval";
            this.nrUpdateInterval.Size = new System.Drawing.Size(120, 22);
            this.nrUpdateInterval.TabIndex = 1;
            this.nrUpdateInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(404, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "JSON URL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Update Interval";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "seconds";
            // 
            // btnToggleUpdates
            // 
            this.btnToggleUpdates.Location = new System.Drawing.Point(468, 317);
            this.btnToggleUpdates.Name = "btnToggleUpdates";
            this.btnToggleUpdates.Size = new System.Drawing.Size(110, 32);
            this.btnToggleUpdates.TabIndex = 5;
            this.btnToggleUpdates.Text = "Start Timer";
            this.btnToggleUpdates.UseVisualStyleBackColor = true;
            this.btnToggleUpdates.Click += new System.EventHandler(this.btnToggleUpdates_Click);
            // 
            // timerUpdateInterval
            // 
            this.timerUpdateInterval.Interval = 30000;
            this.timerUpdateInterval.Tick += new System.EventHandler(this.timerUpdateInterval_Tick);
            // 
            // btnStartView
            // 
            this.btnStartView.Location = new System.Drawing.Point(468, 276);
            this.btnStartView.Name = "btnStartView";
            this.btnStartView.Size = new System.Drawing.Size(110, 32);
            this.btnStartView.TabIndex = 5;
            this.btnStartView.Text = "Start View";
            this.btnStartView.UseVisualStyleBackColor = true;
            this.btnStartView.Click += new System.EventHandler(this.btnStartView_Click);
            // 
            // nrTeams
            // 
            this.nrTeams.Location = new System.Drawing.Point(397, 125);
            this.nrTeams.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nrTeams.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nrTeams.Name = "nrTeams";
            this.nrTeams.Size = new System.Drawing.Size(120, 22);
            this.nrTeams.TabIndex = 6;
            this.nrTeams.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nrTeams.ValueChanged += new System.EventHandler(this.nrTeams_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Number of Teams";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DÖMD Brackets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelOnline.ResumeLayout(false);
            this.panelOnline.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelOffline.ResumeLayout(false);
            this.panelOffline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrUpdateInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnJSONURL;
        private System.Windows.Forms.Button btnLoadJSONFile;
        private System.Windows.Forms.Button btnLoadTextFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox cbScreens;
        private System.Windows.Forms.Button btnLoadBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioTeam1;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.RadioButton radioNoWinner;
        private System.Windows.Forms.RadioButton radioTeam2;
        public System.Windows.Forms.Panel panelOffline;
        private System.Windows.Forms.Button btnSaveMatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Timer timerView;
        private System.Windows.Forms.TextBox txtLogoPath;
        private System.Windows.Forms.Button btnSelectLogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSponsFolder;
        private System.Windows.Forms.Button btnSelectSponsFolder;
        private System.Windows.Forms.OpenFileDialog openLogoDialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelectBGColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBGPatternPath;
        private System.Windows.Forms.Button btnSelectBGPattern;
        private System.Windows.Forms.ColorDialog colorBGDialog;
        private System.Windows.Forms.FolderBrowserDialog folderSponsDialog;
        private System.Windows.Forms.Button btnTeamListing;
        private System.Windows.Forms.Panel panelOnline;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timerUpdateInterval;
        public System.Windows.Forms.NumericUpDown nrUpdateInterval;
        public System.Windows.Forms.TextBox txtJSONURL;
        public System.Windows.Forms.Button btnToggleUpdates;
        public System.Windows.Forms.Button btnStartView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nrTeams;
    }
}

