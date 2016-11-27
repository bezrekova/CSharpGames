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
    public partial class StatisticsPerDay : Form
    {
        public StatisticsPerDay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IOFile statistics = new IOFile();
            label1.Text =  statistics.GetStatisticsPerDate(textBox1.Text);

        }

        private void StatisticsPerDay_Load(object sender, EventArgs e)
        {
            
        }

       
    }
}
