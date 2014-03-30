using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DÖMDBrackets
{
    public partial class TeamListView : Form
    {
        public TeamListView()
        {
            InitializeComponent();
        }

        private void TeamListView_Load(object sender, EventArgs e)
        {
            
        }

        private Color[] backColors = { Color.LightGray, Color.White };

        private void TeamListView_Shown(object sender, EventArgs e)
        {
            tabRounds.TabPages.Clear();
            for (int r = 0; r < BracketHandler.getNoRounds(); r++)
            {
                tabRounds.TabPages.Add("round" + r, "Round " + (r + 1).ToString());
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                lv.LabelEdit = true;
                lv.Location = new Point(0, 0);
                lv.View = View.Details;

                ColumnHeader header = new ColumnHeader();
                header.Text = "";
                header.Name = "col1";
                lv.Columns.Add(header);

                
                for (int m = 0; m < Math.Pow(2, BracketHandler.getNoRounds() - r - 1); m++)
                {
                    Match match = BracketHandler.matches[r, m];
                    if (match != null)
                    {
                        if (match.team1 != null)
                        {
                            lv.Items.Add(match.team1).BackColor = backColors[m % 2];
                            
                        }
                        if (match.team2 != null)
                        {
                            lv.Items.Add(match.team2).BackColor = backColors[m % 2];
                        }
                    }
                }
                lv.AfterLabelEdit += lv_AfterLabelEdit;
                tabRounds.TabPages["round" + r].Controls.Add(lv);
            }
        }

        void lv_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            
        }

        private void TeamListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
