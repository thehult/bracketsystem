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
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.panelOffline = new System.Windows.Forms.Panel();
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbScreens = new System.Windows.Forms.ComboBox();
            this.btnLoadBackup = new System.Windows.Forms.Button();
            this.btnJSONURL = new System.Windows.Forms.Button();
            this.btnLoadJSONFile = new System.Windows.Forms.Button();
            this.btnLoadTextFile = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelConfiguration.SuspendLayout();
            this.panelOffline.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Controls.Add(this.panelOffline);
            this.panelConfiguration.Controls.Add(this.label2);
            this.panelConfiguration.Controls.Add(this.cbScreens);
            this.panelConfiguration.Controls.Add(this.btnLoadBackup);
            this.panelConfiguration.Controls.Add(this.btnJSONURL);
            this.panelConfiguration.Controls.Add(this.btnLoadJSONFile);
            this.panelConfiguration.Controls.Add(this.btnLoadTextFile);
            this.panelConfiguration.Controls.Add(this.lblHeader);
            this.panelConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfiguration.Location = new System.Drawing.Point(0, 0);
            this.panelConfiguration.Margin = new System.Windows.Forms.Padding(0);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(1045, 692);
            this.panelConfiguration.TabIndex = 0;
            // 
            // panelOffline
            // 
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
            this.panelOffline.Location = new System.Drawing.Point(0, 62);
            this.panelOffline.Name = "panelOffline";
            this.panelOffline.Size = new System.Drawing.Size(1045, 630);
            this.panelOffline.TabIndex = 4;
            this.panelOffline.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(670, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 34);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioNoWinner
            // 
            this.radioNoWinner.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioNoWinner.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioNoWinner.Location = new System.Drawing.Point(307, 218);
            this.radioNoWinner.Name = "radioNoWinner";
            this.radioNoWinner.Size = new System.Drawing.Size(433, 24);
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
            this.radioTeam2.Location = new System.Drawing.Point(307, 188);
            this.radioTeam2.Name = "radioTeam2";
            this.radioTeam2.Size = new System.Drawing.Size(433, 24);
            this.radioTeam2.TabIndex = 6;
            this.radioTeam2.TabStop = true;
            this.radioTeam2.Text = "Lag 2";
            this.radioTeam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam2.UseVisualStyleBackColor = true;
            // 
            // radioTeam1
            // 
            this.radioTeam1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioTeam1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam1.Location = new System.Drawing.Point(307, 158);
            this.radioTeam1.Name = "radioTeam1";
            this.radioTeam1.Size = new System.Drawing.Size(433, 24);
            this.radioTeam1.TabIndex = 6;
            this.radioTeam1.TabStop = true;
            this.radioTeam1.Text = "Lag 1";
            this.radioTeam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioTeam1.UseVisualStyleBackColor = true;
            // 
            // lblTeam2
            // 
            this.lblTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.Location = new System.Drawing.Point(539, 101);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(494, 36);
            this.lblTeam2.TabIndex = 5;
            this.lblTeam2.Text = "Lag 2";
            // 
            // lblTeam1
            // 
            this.lblTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.Location = new System.Drawing.Point(12, 101);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(492, 33);
            this.lblTeam1.TabIndex = 4;
            this.lblTeam1.Text = "Lag 1";
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
            this.txtTeam.Location = new System.Drawing.Point(397, 29);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(267, 34);
            this.txtTeam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Screen";
            // 
            // cbScreens
            // 
            this.cbScreens.FormattingEnabled = true;
            this.cbScreens.Location = new System.Drawing.Point(397, 116);
            this.cbScreens.Name = "cbScreens";
            this.cbScreens.Size = new System.Drawing.Size(252, 24);
            this.cbScreens.TabIndex = 2;
            // 
            // btnLoadBackup
            // 
            this.btnLoadBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadBackup.Location = new System.Drawing.Point(397, 341);
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
            this.btnJSONURL.Location = new System.Drawing.Point(397, 294);
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
            this.btnLoadJSONFile.Location = new System.Drawing.Point(397, 247);
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
            this.btnLoadTextFile.Location = new System.Drawing.Point(397, 200);
            this.btnLoadTextFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTextFile.Name = "btnLoadTextFile";
            this.btnLoadTextFile.Size = new System.Drawing.Size(252, 39);
            this.btnLoadTextFile.TabIndex = 1;
            this.btnLoadTextFile.Text = "Load Teams From Text File";
            this.btnLoadTextFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFile.Click += new System.EventHandler(this.btnLoadTextFile_Click);
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.panelConfiguration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DÖMD Brackets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConfiguration.ResumeLayout(false);
            this.panelConfiguration.PerformLayout();
            this.panelOffline.ResumeLayout(false);
            this.panelOffline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfiguration;
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
    }
}

