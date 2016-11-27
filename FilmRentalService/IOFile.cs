using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmRentalService
{
    class IOFile
    {
        List<Rental> nArray = new List<Rental>();
        List<Rental> deleter = new List<Rental>();

        public void WriteToFile()
        {
            if (nArray.Count == 0)
            {

                String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
                // nArray = new List<Rental>();
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

                nArray =  DeleteFromList( nArray, deleter);


                var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
                var wfile = new System.IO.StreamWriter(path);
                writer.Serialize(wfile, nArray);
                wfile.Close();

                //  nArray = null;
            }
            else
            {
                nArray = DeleteFromList(nArray, deleter);
                String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
                var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
                var wfile = new System.IO.StreamWriter(path);
                writer.Serialize(wfile, nArray);
                wfile.Close();

                // nArray = null;

            }


            //  MessageBox.Show("All was written to file!");
        }

        //delete from nArray deleted items
        private List<Rental> DeleteFromList(List<Rental> rental, List<Rental> del)
        {
            if (del.Count != 0)
            {
                for (int i = 0; i < rental.Count; i++)
                {
                    for (int j = 0; j < deleter.Count; j++)
                    {
                        if (rental[i].film.Name.IndexOf(del[j].film.Name, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            rental[i] = null;
                        }
                    }
                }               
            }

            return rental;
        }

        public void WriteFilmToFile(string name, string genre, int year, string rentDate, int price, string clientID)
        {
            foreach (Rental ren in nArray)
            {
                if (ren.film.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) < 0) //case insensitive
                {
                    String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
                    //nArray = new List<Rental>();
                    // Rental[] nArray2 = new Rental[4];
                    nArray.Add(new Rental(name, genre, year, rentDate, price, clientID));
                    MessageBox.Show("The film was added successfully!");
                }
                else
                {
                    MessageBox.Show("Film is already in list");
                }
            }
        }

        public string ReadFromFile()
        {
           // WriteToFile();
            String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
            List<Rental> nArray = new List<Rental>();
            System.Xml.Serialization.XmlSerializer reader =
                   new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            nArray = (List<Rental>)reader.Deserialize(file);
            file.Close();
            StringBuilder build = new StringBuilder();
            string s;
            foreach (Rental ren in nArray)
            {
                build.AppendLine(ren.ToString());
            }
            s = build.ToString();
            return s;
        }

        public int CountGenreFromFile(string genre)
        {
           // WriteToFile();
            String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
            List<Rental> nArray = new List<Rental>();
            System.Xml.Serialization.XmlSerializer reader =
                   new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            nArray = (List<Rental>)reader.Deserialize(file);
            file.Close();
            int count = 0;
            foreach (Rental ren in nArray)
            {
                if (ren.film.Genre.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0) //case insensitive
                {
                    count++;
                }
            }
            return count;
        }

        public bool DeleteFilm(string name)
        {
            if (GetFilmByName(name))
            {
                String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
               
                System.Xml.Serialization.XmlSerializer reader =
                       new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                nArray = (List<Rental>)reader.Deserialize(file);

                file.Close();
                for (int i = 0; i < nArray.Count; i++)
                {
                    if (nArray[i].film.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) //case insensitive
                    {
                        //nArray[i] = null;
                        //deleter.Add(nArray[i]);//add to deleted list
                        nArray.Remove(nArray[i]);
                       // String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
                        var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
                        var wfile = new System.IO.StreamWriter(path);
                        writer.Serialize(wfile, nArray);
                        wfile.Close();
                        return true;
                    }
                }
            } return false;
        }

        public bool GetFilmByName(string filmName)
        {
           // WriteToFile();
            String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
            nArray = new List<Rental>();
            System.Xml.Serialization.XmlSerializer reader =
                   new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            nArray = (List<Rental>)reader.Deserialize(file);
            file.Close();
            nArray = DeleteFromList(nArray, deleter);
            foreach (Rental ren in nArray)
            {
                if (ren.film.Name.IndexOf(filmName, StringComparison.OrdinalIgnoreCase) >= 0) //case insensitive
                {
                    return true;
                }

            }
            return false;
        }
        public int GetFilmPrice(string filmName)
        {
           // WriteToFile();
            String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
            List<Rental> nArray = new List<Rental>();
            System.Xml.Serialization.XmlSerializer reader =
                   new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            nArray = (List<Rental>)reader.Deserialize(file);
            file.Close();
            foreach (Rental ren in nArray)
            {
                if (ren.film.Name.IndexOf(filmName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return ren.pricePerday;
                }

            }
            return 0;
        }

        public string GetStatisticsPerDate(string date){
            
           // WriteToFile();
            String path = @"C:\Users\1\Documents\Visual Studio 2012\Projects\HelloWorldCsharp\FilmRentalService\bin\Debug\database2.xml";
            List<Rental> nArray = new List<Rental>();
            System.Xml.Serialization.XmlSerializer reader =
                   new System.Xml.Serialization.XmlSerializer(typeof(List<Rental>));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            nArray = (List<Rental>)reader.Deserialize(file);
            file.Close();
            StringBuilder build = new StringBuilder();
            string s;
            foreach (Rental ren in nArray)
            {
                if(ren.date>DateTime.Parse(date))
                {
                build.AppendLine(ren.ToString());
                }
            }
            s = build.ToString();
            return s;
       }
    }
}
