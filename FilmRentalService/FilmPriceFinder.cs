using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmRentalService
{
    public partial class FilmPriceFinder : Form
    {
        public FilmPriceFinder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IOFile counter = new IOFile();
            string price = Convert.ToString(counter.GetFilmPrice(textBox1.Text));
            if (price.Equals("0"))
            {

                label1.Text = "We do not have " + textBox1.Text + "  film";
            }
            else
            {
                label1.Text = "We  have " + textBox1.Text + "  film. Its price = " + price;
            }
        }

        private void FilmPriceFinder_Load(object sender, EventArgs e)
        {

        }
    }
}
