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
    public partial class BracketView : Form
    {
        public BracketView()
        {
            InitializeComponent();
            bracketBox.Image = BracketHandler.bracketImage;
        }
    }
}
