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
    public partial class FilmNameFinder : Form
    {
        public FilmNameFinder()
        {
            InitializeComponent();
        }

        private void FilmNameFinder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IOFile counter = new IOFile();
            if (counter.GetFilmByName(textBox1.Text))
            {

                label1.Text = "We have " + textBox1.Text.ToUpperInvariant() + "  film";
            }
            else
            {
                label1.Text = "We do not have " + textBox1.Text.ToUpperInvariant() + "  film";
            }
        }
    }
}
