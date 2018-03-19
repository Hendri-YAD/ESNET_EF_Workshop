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
    public partial class Exercise5 : Form
    {
        public Exercise5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            var q = from x in context.Movies
                    where x.MovieType == "Sci-fi" &&
                    x.ProducerID == "Warner"
                    select x;
            List<Movies> clst = q.ToList<Movies>();
            dataGridView1.DataSource = clst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            List<Movies> clst = context.Movies.
                Where(x => x.MovieType == "Sci-fi" &&
                x.ProducerID == "Warner").ToList();

            dataGridView1.DataSource = clst;
        }
    }
}
