﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saleBt_Click(object sender, EventArgs e)
        {
            searchControl1.Visible = true;
            searchControl1.BringToFront();
            //location: 202, 100
            //SIze :599, 349
        }

        private void bookBt_Click(object sender, EventArgs e)
        {
            saleControl1.Visible = true;
            saleControl1.BringToFront();
        }

        private void dataBt_Click(object sender, EventArgs e)
        {
            databaseControl1.Visible = true;
            databaseControl1.BringToFront();
        }

        private void reportBt_Click(object sender, EventArgs e)
        {
            reportControl1.Visible = true;
            reportControl1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ruleChangeControl1.Visible = true;
            ruleChangeControl1.BringToFront();
        }
    }
}
