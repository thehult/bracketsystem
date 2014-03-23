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
            this.panelMain.SuspendLayout();
            this.panelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelOffline.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelConfig);
            this.panelMain.Controls.Add(this.lblHeader);
            this.panelMain.Controls.Add(this.panelOffline);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(784, 562);
            this.panelMain.TabIndex = 0;
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
            this.panelConfig.Location = new System.Drawing.Point(0, 50);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(784, 512);
            this.panelConfig.TabIndex = 12;
            this.panelConfig.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Select Background Color";
            // 
            // btnSelectBGColor
            // 
            this.btnSelectBGColor.Location = new System.Drawing.Point(439, 146);
            this.btnSelectBGColor.Name = "btnSelectBGColor";
            this.btnSelectBGColor.Size = new System.Drawing.Size(48, 23);
            this.btnSelectBGColor.TabIndex = 15;
            this.btnSelectBGColor.Text = "Colors";
            this.btnSelectBGColor.UseVisualStyleBackColor = true;
            this.btnSelectBGColor.Click += new System.EventHandler(this.btnSelectBGColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Select Sponsor Logo Folder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select Background Pattern";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select Event Logo";
            // 
            // txtSponsFolder
            // 
            this.txtSponsFolder.Location = new System.Drawing.Point(298, 277);
            this.txtSponsFolder.Name = "txtSponsFolder";
            this.txtSponsFolder.ReadOnly = true;
            this.txtSponsFolder.Size = new System.Drawing.Size(159, 20);
            this.txtSponsFolder.TabIndex = 13;
            // 
            // btnSelectSponsFolder
            // 
            this.btnSelectSponsFolder.Location = new System.Drawing.Point(463, 275);
            this.btnSelectSponsFolder.Name = "btnSelectSponsFolder";
            this.btnSelectSponsFolder.Size = new System.Drawing.Size(24, 23);
            this.btnSelectSponsFolder.TabIndex = 12;
            this.btnSelectSponsFolder.Text = "...";
            this.btnSelectSponsFolder.UseVisualStyleBackColor = true;
            this.btnSelectSponsFolder.Click += new System.EventHandler(this.btnSelectSponsFolder_Click);
            // 
            // txtBGPatternPath
            // 
            this.txtBGPatternPath.Location = new System.Drawing.Point(298, 194);
            this.txtBGPatternPath.Name = "txtBGPatternPath";
            this.txtBGPatternPath.ReadOnly = true;
            this.txtBGPatternPath.Size = new System.Drawing.Size(159, 20);
            this.txtBGPatternPath.TabIndex = 13;
            // 
            // btnSelectBGPattern
            // 
            this.btnSelectBGPattern.Location = new System.Drawing.Point(463, 192);
            this.btnSelectBGPattern.Name = "btnSelectBGPattern";
            this.btnSelectBGPattern.Size = new System.Drawing.Size(24, 23);
            this.btnSelectBGPattern.TabIndex = 12;
            this.btnSelectBGPattern.Text = "...";
            this.btnSelectBGPattern.UseVisualStyleBackColor = true;
            this.btnSelectBGPattern.Click += new System.EventHandler(this.btnSelectBGPattern_Click);
            // 
            // txtLogoPath
            // 
            this.txtLogoPath.Location = new System.Drawing.Point(298, 233);
            this.txtLogoPath.Name = "txtLogoPath";
            this.txtLogoPath.ReadOnly = true;
            this.txtLogoPath.Size = new System.Drawing.Size(159, 20);
            this.txtLogoPath.TabIndex = 13;
            // 
            // btnSelectLogo
            // 
            this.btnSelectLogo.Location = new System.Drawing.Point(463, 231);
            this.btnSelectLogo.Name = "btnSelectLogo";
            this.btnSelectLogo.Size = new System.Drawing.Size(24, 23);
            this.btnSelectLogo.TabIndex = 12;
            this.btnSelectLogo.Text = "...";
            this.btnSelectLogo.UseVisualStyleBackColor = true;
            this.btnSelectLogo.Click += new System.EventHandler(this.btnSelectLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Screen";
            // 
            // cbScreens
            // 
            this.cbScreens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreens.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbScreens.FormattingEnabled = true;
            this.cbScreens.Location = new System.Drawing.Point(298, 34);
            this.cbScreens.Margin = new System.Windows.Forms.Padding(2);
            this.cbScreens.Name = "cbScreens";
            this.cbScreens.Size = new System.Drawing.Size(189, 21);
            this.cbScreens.TabIndex = 2;
            // 
            // btnLoadBackup
            // 
            this.btnLoadBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadBackup.Location = new System.Drawing.Point(298, 448);
            this.btnLoadBackup.Name = "btnLoadBackup";
            this.btnLoadBackup.Size = new System.Drawing.Size(189, 32);
            this.btnLoadBackup.TabIndex = 1;
            this.btnLoadBackup.Text = "Load Teams From Backup";
            this.btnLoadBackup.UseVisualStyleBackColor = true;
            this.btnLoadBackup.Click += new System.EventHandler(this.btnLoadBackup_Click);
            // 
            // btnJSONURL
            // 
            this.btnJSONURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJSONURL.Location = new System.Drawing.Point(298, 410);
            this.btnJSONURL.Name = "btnJSONURL";
            this.btnJSONURL.Size = new System.Drawing.Size(189, 32);
            this.btnJSONURL.TabIndex = 1;
            this.btnJSONURL.Text = "Load Teams From JSON URL";
            this.btnJSONURL.UseVisualStyleBackColor = true;
            this.btnJSONURL.Click += new System.EventHandler(this.btnJSONURL_Click);
            // 
            // btnLoadJSONFile
            // 
            this.btnLoadJSONFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadJSONFile.Location = new System.Drawing.Point(298, 372);
            this.btnLoadJSONFile.Name = "btnLoadJSONFile";
            this.btnLoadJSONFile.Size = new System.Drawing.Size(189, 32);
            this.btnLoadJSONFile.TabIndex = 1;
            this.btnLoadJSONFile.Text = "Load Teams From JSON File";
            this.btnLoadJSONFile.UseVisualStyleBackColor = true;
            this.btnLoadJSONFile.Click += new System.EventHandler(this.btnLoadJSONFile_Click);
            // 
            // btnLoadTextFile
            // 
            this.btnLoadTextFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadTextFile.Location = new System.Drawing.Point(298, 334);
            this.btnLoadTextFile.Name = "btnLoadTextFile";
            this.btnLoadTextFile.Size = new System.Drawing.Size(189, 32);
            this.btnLoadTextFile.TabIndex = 1;
            this.btnLoadTextFile.Text = "Load Teams From Text File";
            this.btnLoadTextFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFile.Click += new System.EventHandler(this.btnLoadTextFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Change View every:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
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
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(784, 50);
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
            this.panelOffline.Margin = new System.Windows.Forms.Padding(2);
            this.panelOffline.Name = "panelOffline";
            this.panelOffline.Size = new System.Drawing.Size(784, 562);
            this.panelOffline.TabIndex = 4;
            this.panelOffline.Visible = false;
            // 
            // btnSaveMatch
            // 
            this.btnSaveMatch.Enabled = false;
            this.btnSaveMatch.Location = new System.Drawing.Point(479, 235);
            this.btnSaveMatch.Name = "btnSaveMatch";
            this.btnSaveMatch.Size = new System.Drawing.Size(75, 30);
            this.btnSaveMatch.TabIndex = 8;
            this.btnSaveMatch.Text = "Save";
            this.btnSaveMatch.UseVisualStyleBackColor = true;
            this.btnSaveMatch.Click += new System.EventHandler(this.btnSaveMatch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(502, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 28);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioNoWinner
            // 
            this.radioNoWinner.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioNoWinner.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNoWinner.Location = new System.Drawing.Point(230, 196);
            this.radioNoWinner.Margin = new System.Windows.Forms.Padding(2);
            this.radioNoWinner.Name = "radioNoWinner";
            this.radioNoWinner.Size = new System.Drawing.Size(325, 30);
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
            this.radioTeam2.Location = new System.Drawing.Point(230, 162);
            this.radioTeam2.Margin = new System.Windows.Forms.Padding(2);
            this.radioTeam2.Name = "radioTeam2";
            this.radioTeam2.Size = new System.Drawing.Size(325, 30);
            this.radioTeam2.TabIndex = 6;
            this.radioTeam2.TabStop = true;
            this.radioTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam2.UseVisualStyleBackColor = true;
            // 
            // radioTeam1
            // 
            this.radioTeam1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTeam1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam1.Location = new System.Drawing.Point(230, 128);
            this.radioTeam1.Margin = new System.Windows.Forms.Padding(2);
            this.radioTeam1.Name = "radioTeam1";
            this.radioTeam1.Size = new System.Drawing.Size(325, 30);
            this.radioTeam1.TabIndex = 6;
            this.radioTeam1.TabStop = true;
            this.radioTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam1.UseVisualStyleBackColor = true;
            // 
            // lblTeam2
            // 
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(404, 82);
            this.lblTeam2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(370, 29);
            this.lblTeam2.TabIndex = 5;
            // 
            // lblTeam1
            // 
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(9, 82);
            this.lblTeam1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(369, 27);
            this.lblTeam1.TabIndex = 4;
            this.lblTeam1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Winner:";
            // 
            // lblMatch
            // 
            this.lblMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.Location = new System.Drawing.Point(9, 82);
            this.lblMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(766, 27);
            this.lblMatch.TabIndex = 2;
            this.lblMatch.Text = "vs";
            this.lblMatch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = ":Team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTeam
            // 
            this.txtTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam.Location = new System.Drawing.Point(298, 24);
            this.txtTeam.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(201, 29);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DÖMD Brackets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelOffline.ResumeLayout(false);
            this.panelOffline.PerformLayout();
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
    }
}

