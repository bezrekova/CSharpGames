using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FilmRentalService
{
    class NewClassss
    {

        static void Main(string[] args)
        {
            NewClassss classss = new NewClassss();
            classss.readFromFile();

            Console.Read();
        }         
            string readFromFile()
        {
            String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
            List<Rental> nArray = new List<Rental>();
            // Rental[] nArray2 = new Rental[4];
            nArray.Add(new Rental("Soap", "fantasy", 1994, "2016, 10, 1", 12, "Sokolov"));
            nArray.Add(new Rental("Twilight", "horror", 2010, "2.10.2016", 20, "Targarien"));
            nArray.Add(new Rental("New Moon", "horror", 2012, "2016, 10, 3", 21, "Lannister"));
            nArray.Add(new Rental("Eclipse", "fantasy", 2015, "2016, 10, 24", 8, "Snow"));
            nArray.Add(new Rental("Mullholland Drive", "thriller", 2001, "2016,09,12", 20, "Wats"));
            nArray.Add(new Rental("Sen to Chihiro no kamikakushi", "anime", 2001, "2016.08.10", 15, "Miadziaki"));
            nArray.Add(new Rental("Boyhood", "drama", 2014, "2016,10,21", 13, "Linkleiter"));
            nArray.Add(new Rental("Eternal Sunshine of the Spotless Mind", "melodrama", 2004, "2016,02,14", 12, "Gondri"));
            nArray.Add(new Rental("The Tree of Life ", "fantasy", 2010, "2016.10.02", 17, "Malik"));
            nArray.Add(new Rental("Ace Ventura: Pet Detective ", "comedy", 1993, "2016.10.05", 12, "Shediak"));
            nArray.Add(new Rental("Borat", "comedy", 2006, "2016,10,21", 15, "Charles"));
            nArray.Add(new Rental("Brokeback Mountain", "drama", 2005, "2016,10,22", 21, "Li"));
            nArray.Add(new Rental("Me and You and Everyone We Know", "drama", 2005, "2016,2,15", 22, "July"));
            nArray.Add(new Rental("Mean Girls", "comedy", 2004, "2016,10,2", 15, "Waters"));
            nArray.Add(new Rental("Shaun of the Dead", "horror", 2005, "2016.2.11", 12, "Right"));
            nArray.Add(new Rental("Million Dollar Baby", "drama", 2004, "2015,10,03", 14, "Eastwood"));
            nArray.Add(new Rental("Bad Santa", "drama", 2003, "2016.01.12", 18, "Tswigoff"));
            nArray.Add(new Rental("Pirates of the Caribbean", "adventure", 2004, "2016.09.05", 12, "Verbinski"));
            nArray.Add(new Rental("Spider-Man", "fantasy", 2003, "2016.10.15", 18, "Rami"));


            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
            var wfile = new System.IO.StreamWriter(path);
            writer.Serialize(wfile, nArray);
            wfile.Close();

            nArray = null;
           // MessageBox.Show("NULLLL");
            System.Xml.Serialization.XmlSerializer reader =
                   new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            nArray = (List<Rental>)reader.Deserialize(file);
            file.Close();
            StringBuilder build = new StringBuilder();
            string s;
            foreach (Rental ren in nArray)
            {

                s = ren.ToString();

                build.AppendLine(s);
            }
            s = build.ToString();
           
               Console.WriteLine(s);
                return s;
        }
        
        }
        
    }

