﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad.Controls
{
    public class MainTabControl : TabControl
    {
        private const string NAME = "MainTabControl";
        private TabControlContextMenuStrip _contextMenuStrip;
        public MainTabControl()
        {
            _contextMenuStrip = new TabControlContextMenuStrip();

            Name = NAME;

            ContextMenuStrip = _contextMenuStrip;
            Dock = DockStyle.Fill;
            

        }
    }
}
