﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.Singleton
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             textBoxData.Text = UserSingleton.Instance.GetValue();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxData.Clear();
        }
    }
}
