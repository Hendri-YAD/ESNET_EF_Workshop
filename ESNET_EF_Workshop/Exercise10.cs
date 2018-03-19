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
    public partial class Exercise10 : Form
    {
        public Exercise10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            var q = from x in context.Movies
                    group x by x.MovieType into g
                    select new
                    {
                        MovieCategory = g.Key,
                        TotalStocks = g.Sum(x => x.TotalStock)
                    };

            dataGridView1.DataSource = q.ToList();

        }
    }
}
