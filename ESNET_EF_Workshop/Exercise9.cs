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
    public partial class Exercise9 : Form
    {
        public Exercise9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            var q = from x in context.Movies
                    where x.Rating == "R"
                    select new
                    {
                        x.VideoCode,
                        x.MovieTitle,
                        x.RentalPrice
                    };

            dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            dataGridView1.DataSource = context.Movies.
                Where(x => x.Rating == "R").
                Select(x => new { x.VideoCode, x.MovieTitle, x.RentalPrice }).ToList();
        }
    }
}
