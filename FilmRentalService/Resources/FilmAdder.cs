using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmRentalService.Resources
{
    public partial class FilmAdder : Form
    {
        public FilmAdder()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            IOFile counter = new IOFile();
            string filmName = textBox1.Text;
            string genre = textBox2.Text;
            int year = Convert.ToInt32(textBox3.Text);
            string date = textBox4.Text;
            int price = Convert.ToInt32(textBox5.Text);
            string id = textBox6.Text;
            counter.WriteFilmToFile(filmName, genre, year, date, price,id);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FilmAdder_Load(object sender, EventArgs e)
        {

        }
    }
}
