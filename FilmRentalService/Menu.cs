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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFromFile view = new DisplayFromFile();
            view.Show();
        }

        private void fimmNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmNameFinder filmName = new FilmNameFinder();
            filmName.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Welcome to Matrix Cinema";
        }

        private void filmGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenreFinder view = new GenreFinder();
            view.Show();
           
        }

        private void filmrentalPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmPriceFinder finder = new FilmPriceFinder();
            finder.Show();
        }

        private void rentalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resources.FilmAdder adder = new Resources.FilmAdder();
            adder.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void filmNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmDelete destroyer = new FilmDelete();
            destroyer.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsPerDay statDisplay = new StatisticsPerDay();
            statDisplay.Show();
        }

        private void allRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFromFile displayer = new DisplayFromFile();
            displayer.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void writerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IOFile writer = new IOFile();
            writer.WriteToFile();

        }

       

        

        

       
    }
}
