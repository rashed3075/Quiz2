﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void InsertClicked(object sender, EventArgs e)
        {
            new Insert().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AllBooks().Show();
        }
    }
}
