using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTA
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string[] nationality;
        public int semester;
        public string[] languages;
        public string languageLevel;
        public bool approved;

        //student constructor
        public Student(string name, string surname, int age, string[] nationality, int semester, string[] languages, string languageLevel,bool approved)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.nationality = nationality;
            this.semester = semester;
            this.languages = languages;
            this.languageLevel = languageLevel;
            this.approved = approved;
        }  

    } 
}
