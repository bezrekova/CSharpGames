using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmRentalService
{
    [Serializable]
    public class Film
    {
        private int year;
        private string genre;
        private string name;

        public Film(string nameOfFilm, int yearOfProduction, string genreOfFilm)
        {
            name = nameOfFilm;
            genre = genreOfFilm;
            year = yearOfProduction;
        }

        public Film() { }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    [Serializable]
    //movie rental class
    public class Rental
    {
        public Film film { get; set; }
        public DateTime date { get; set; }
        public int pricePerday { get; set; }
        public string clientID { get; set; }
        //  FileStream stream;
        StreamWriter writer;


        public Rental()
        {
            film = new Film();
            date = new DateTime();
        }

        public Rental(string filmName, string filmG, int filmY, string rdate, int price, string ID)
        {
            film = new Film();
            date = new DateTime();
            date = DateTime.Parse(rdate);//(rdate, "d", null);d - shortform, null - current culture
            film.Genre = filmG;
            film.Name = filmName;
            film.Year = filmY;
            pricePerday = price;
            clientID = ID;
        }

        public void SetFilmName(string name) { film.Name = name; }

        public string GetFilmName() { return film.Name; }


        public override string ToString()
        {
            return film.Name + " " + "year=" + film.Year +
                " genre=" + film.Genre + " " + date + " " + "price=" + pricePerday +
                " " + "ID = " + clientID + "\n\t";
        }

        public static void PrintList(List<Rental> list)
        {
            foreach (Rental rent in list)
            {
                Console.WriteLine(rent.ToString());
            }

        }

        public virtual int GetDays(DateTime dd)
        {

            TimeSpan time = DateTime.Today.Subtract(dd);
            int days = (int)time.TotalDays;
            return days;
        }

        public virtual int GetPriceOnDate(int days, int pricePerDay)
        {
            int price = pricePerDay * days;
            return price;
        }
        //poliphorm input arg1 = DateTime
        public virtual int GetPriceOnDate(DateTime dd, int pricePerDay)
        {
            int price = pricePerDay * GetDays(dd);
            return price;
        }
        //Записать в файл Прокаты которые стоят на сегодняшний день более 100 гривен 
        //и фамилии должников (прокат более 2 недель)
        public virtual void FilmChooser(List<Rental> list)
        {
            List<Rental> badBoys = new List<Rental>();

            foreach (Rental rent in list)
            {

                int days = GetDays(rent.date);
                int price = GetPriceOnDate(days, rent.pricePerday);
                if (price > 100 && days > 14)
                {
                    badBoys.Add(rent);
                }
            }
            //write badrenters from list badBoys to file
            string path = @"D:\ІПЗ\1 курс 3 сем\Сучасні мови програмуванняC#\Лаби\surprise.txt";
            try
            {
                using (writer = new StreamWriter(path))
                {
                    foreach (Rental badrent in badBoys)
                    {

                        int days = GetDays(badrent.date);
                        writer.WriteLine(badrent.clientID);
                        writer.WriteLine("days of rent:{0}", days);
                    }
                }
                Console.WriteLine("BadBoys were written to file!!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }

}



