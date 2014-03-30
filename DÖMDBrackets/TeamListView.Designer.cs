namespace DÖMDBrackets
{
    partial class TeamListView
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
            this.tabRounds = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabRounds
            // 
            this.tabRounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRounds.Location = new System.Drawing.Point(0, 0);
            this.tabRounds.Name = "tabRounds";
            this.tabRounds.SelectedIndex = 0;
            this.tabRounds.Size = new System.Drawing.Size(326, 560);
            this.tabRounds.TabIndex = 0;
            // 
            // TeamListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 560);
            this.Controls.Add(this.tabRounds);
            this.Name = "TeamListView";
            this.Text = "Team Listing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamListView_FormClosing);
            this.Load += new System.EventHandler(this.TeamListView_Load);
            this.Shown += new System.EventHandler(this.TeamListView_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRounds;
    }
}