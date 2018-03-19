using System;
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
    public partial class Exercise3 : Form
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var q = from x in context.Movies
                    orderby x.MovieTitle descending
                    select x;
            List<Movies> clst = q.ToList<Movies>();
            dataGridView1.DataSource = clst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            List<Movies> clst = context.Movies.
                OrderByDescending(x => x.MovieTitle).ToList();
            dataGridView1.DataSource = clst;
        }
    }
}
