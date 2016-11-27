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
    public partial class FilmDelete : Form
    {
        public FilmDelete()
        {
            InitializeComponent();
        }

        private void FilmDelete_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IOFile counter = new IOFile();
            if (counter.DeleteFilm(textBox1.Text))
            {

                label1.Text = "Film " + textBox1.Text.ToUpperInvariant() + "  was deleted";
            }
            else
            {
                label1.Text = "We do not have such " + textBox1.Text.ToUpperInvariant() + "  film";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
