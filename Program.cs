using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDeal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Documents from C\WriteFile.txt";

            Student st = new Student("Stark", 2, "AD", 5, "Ukraine");
            Student s2 = new Student("Lannister", 1, "AF", 5, "France");
            Student s3 = new Student("Tyrell", 3, "AT", 2, "Marocco");
            Student s4 = new Student("Targaryen", 2, "DA", 5, "UK");
            Student s5 = new Student("Snow", 4, "JH", 5, "Norvey");
            Student s6 = new Student("Baretheon", 1, "RB", 5, "USA");

            //add all Students to list
            List<Student> listToWrite = new List<Student>();
            listToWrite.Add(st);
            listToWrite.Add(s2);
            listToWrite.Add(s3);
            listToWrite.Add(s4);
            listToWrite.Add(s5);
            listToWrite.Add(s6);
            Student.PrintList(listToWrite);

            //write to file
            try
            {
                //to clear file before write to it
                File.WriteAllText(path, String.Empty);

                using (StreamWriter writeT = new StreamWriter(path, true))//append ==true
                {
                    //write every Student from list to file
                    foreach (Student a in listToWrite)
                    {
                        a.WriteToFile(writeT);
                    }

                    Console.WriteLine("The info was written to File successfully");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file can't be read: ");
                Console.WriteLine(e.Message);
            }

            //read from file
            try
            {

                using (StreamReader reader = new StreamReader(path, true))
                {
                    //read all student from file to list
                    List<Student> list = Student.ReadFromFile(reader);
                    Console.WriteLine("Read list from file:");
                    Student.PrintList(list);

                    /*get and print  from list students, where year = 1 
                     * and country!="Ukraine" and avMark=5;
                    */
                    Student.GetForeignFreshmanNerd(list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file can't be written to: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();



        }
    }

    public class Student
    {
        private string surname;
        private int yearOfStudy;// //{ get; set; }
        private string studID;// { get; set; }
        private int averageMark;// { get; set; }
        private string country;// { get; set; }

        public Student(string sur, int year, string ID, int avMark, string countr)
        {
            this.surname = sur;
            this.yearOfStudy = year;
            this.studID = ID;
            this.averageMark = avMark;
            this.country = countr;
        }

        public void WriteToFile(StreamWriter writer)
        {


            writer.WriteLine(this.surname);
            writer.WriteLine(this.yearOfStudy);
            writer.WriteLine(this.studID);
            writer.WriteLine(this.averageMark);
            writer.WriteLine(this.country);
        }

        static public List<Student> ReadFromFile(StreamReader reader)
        {
            List<Student> list = new List<Student>();

            for (int i = 0; i < 6; i++)
            {
                string surname = reader.ReadLine();
                int yearOfStudy = Convert.ToInt32(reader.ReadLine());
                string studID = reader.ReadLine();
                int averageMark = Convert.ToInt32(reader.ReadLine());
                string country = reader.ReadLine();

                list.Add(new Student(surname, yearOfStudy, studID, averageMark, country));
            }

            return list;

        }

        public override string ToString()
        {
            return surname + " " + yearOfStudy + " " + studID +
                            " " + averageMark + " " + country + "\n\t";
        }

        static public void PrintList(List<Student> list)
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("{0,-15}{1,-10}{2,-9}{3,-10}{4,-13}\n", "Surname",
                "Year",
                "ID", "AvMark", "Country");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (Student a in list)
            {
                Console.WriteLine(String.Format("{0,-15}|{1,-8}|{2,-10}|{3,-10}|{4,-13}", a.surname,
                    a.yearOfStudy, a.studID, a.averageMark, a.country));
            }
            Console.WriteLine("--------------------------------------------------------------");
        }

        static public void GetForeignFreshmanNerd(List<Student> list)
        {
            Console.WriteLine("The foreign freshmen, whose averMark = 5:");
            foreach (Student a in list)
            {
                if ((a.yearOfStudy == 1) && (a.country != "Ukraine") && (a.averageMark == 5))
                {
                    Console.WriteLine(String.Format("{0,-15}|{1,-8}|{2,-10}|{3,-10}|{4,-13}", a.surname,
                    a.yearOfStudy, a.studID, a.averageMark, a.country));
                }

            }

        }
    }


}


