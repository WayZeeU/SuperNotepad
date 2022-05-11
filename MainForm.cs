using NotePad.Controls;
using NotePad.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class MainForm : Form
    {
        public RichTextBox CurrentRtb;
        public TextFile CurrentFile;
        public TabControl MainTabControl;
        public Session Session;

        public MainForm()
        {
            InitializeComponent();

            var menuStrip = new MainMenuStrip();

            MainTabControl = new MainTabControl();

            Session = new Session();
            

          
            
            

            Controls.AddRange(new Control[] { MainTabControl, menuStrip});
            
        }

       
    }
}
