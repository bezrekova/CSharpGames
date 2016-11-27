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
    public partial class GenreFinder : Form
    {
        public GenreFinder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IOFile counter = new IOFile();
            label1.Text = "We have " + Convert.ToString(counter.CountGenreFromFile(textBox1.Text)) + "  films of genre " + textBox1.Text.ToLower();
              
        }

        private void GenreFinder_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
