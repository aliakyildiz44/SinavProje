﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavProjesi
{
    public partial class AdminScreen : Form
    {
        User admin;
        public AdminScreen()
        {
            InitializeComponent();
        }
        public AdminScreen(User admin)
        {
            this.admin= admin;
        }
    }
}