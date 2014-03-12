namespace DÖMDBrackets
{
    partial class BracketView
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
            this.bracketBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bracketBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bracketBox
            // 
            this.bracketBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bracketBox.Location = new System.Drawing.Point(0, 0);
            this.bracketBox.Name = "bracketBox";
            this.bracketBox.Size = new System.Drawing.Size(284, 262);
            this.bracketBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bracketBox.TabIndex = 0;
            this.bracketBox.TabStop = false;
            // 
            // BracketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bracketBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BracketView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BracketView";
            ((System.ComponentModel.ISupportInitialize)(this.bracketBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox bracketBox;

    }
}