﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESNET_EF_Workshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            var qry = from x in context.Movies select x;

            List<Movies> cLst = qry.ToList<Movies>();
            dataGridView1.DataSource = cLst;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            List<Movies> cLst = context.Movies.ToList();

            dataGridView1.DataSource = cLst;
        }
    }
}
