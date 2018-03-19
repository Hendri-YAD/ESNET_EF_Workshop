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
    public partial class Exercise4 : Form
    {
        public Exercise4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            var q = from x in context.Movies
                    where x.Rating == "R"
                    select x;

            List<Movies> clst = q.ToList<Movies>();
            dataGridView1.DataSource = clst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            List<Movies> clst = context.Movies.
                Where(x => x.Rating == "R").ToList();
            dataGridView1.DataSource = clst;
        }
    }
}
