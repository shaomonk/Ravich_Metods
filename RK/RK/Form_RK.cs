﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK
{
    public partial class Form_RK : Form
    {
        public Form_RK()
        {
            InitializeComponent();
        }

        private void вывестиБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void рассчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
            button6.Visible = true;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }
    }
}
