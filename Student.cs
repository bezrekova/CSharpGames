using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class Student
    {
        private string surname;
        private short yearOfStudy;
        private string studID;
        private float averageMark;
        private string country;

        Student(string sur,short year,string ID,float avMark,string countr ) {
            this.surname = sur;
            this.yearOfStudy = year;
            this.studID = ID;
            this.averageMark = avMark;
            this.country = countr;
        }

        public static void operator>>(StreamWriter writeT,Student stud){
       string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
       using (writeT = new StreamWriter(mydocpath + @"\WriteFile.txt", true))
       {
           writeT.Write(stud.surname);
           writeT.Write(stud.yearOfStudy);
           writeT.Write(stud.studID);
           writeT.Write(stud.averageMark);
           writeT.Write(stud.country);
       }

        }
    }

