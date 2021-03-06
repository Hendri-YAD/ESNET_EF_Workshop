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
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var q = from x in context.Movies
                    orderby x.MovieTitle
                    select x;
            List<Movies> clst = q.ToList<Movies>();
            dataGridView1.DataSource = clst;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            List<Movies> clst = context.Movies.
                OrderBy(x => x.MovieTitle).ToList();
            dataGridView1.DataSource = clst;
        }
    }
}
