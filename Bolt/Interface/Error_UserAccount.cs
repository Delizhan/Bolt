﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolt.Interface
{
    public partial class Error_UserAccount : Form
    {
        public Error_UserAccount()
        {
            InitializeComponent();
        }

        private void button__ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
