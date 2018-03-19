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
    public partial class Exercise8 : Form
    {
        public Exercise8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            double? d = context.Movies.
                Where(x => x.MovieType == "Comedy").
                Average(x => x.RentalPrice);

            MessageBox.Show(d.ToString());
        }
    }
}
