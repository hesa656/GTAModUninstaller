using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Mod_Uninstaller
{
    public partial class ListItem_custom : UserControl
    {
        public ListItem_custom()
        {
            InitializeComponent();
        }

        private string _title;
        private Color _color;
        private bool _wrongFile;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        [Category("Custom Props")]
        public bool wrongFile
        {
            get { return _wrongFile; }
            set { _wrongFile = value; }
        }
    }
}
